using MetroFramework.Forms;
using Oracle_Scripter.Source.Db;
using Oracle_Scripter.Source.Extensions;
using Oracle_Scripter.Source.ModelView;
using Oracle_Scripter.Source.QO;
using Oracle_Scripter.Source.Variables;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Oracle_Scripter
{
    public partial class FrmOracleScripter : MetroForm//Form
    {
        private DatabaseConnection Conn = null;

        private object writeLogLockObj = new object();
        private object writeExcLockObj = new object();

        private volatile string saveFolderPathName = string.Empty;

        private List<DbObject> dbObjList = new List<DbObject>();
        private List<DbObject> dbFilteredObjList = new List<DbObject>();

        private volatile bool _ischkSelectAllLock = false;

        private Thread thrdGetTables;

        private DataTable dtDbObjects = new DataTable();

        private volatile int unCheckedCount = 0;

        public FrmOracleScripter()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Conn = new DatabaseConnection(string.Empty);
        }

        private void TestConnection()
        {
            try
            {
                if (txtConnStr.Text.IsNullOrWhiteSpace())
                {
                    ShowMessage("Connection String can not be empty.");
                    return;
                }

                Conn.ConnectionString = txtConnStr.Text;// = new DatabaseConnection(txtConnStr.Text);
                bool testCheck = Conn.Test();
                string mess = string.Empty;
                mess = testCheck ? "Connection Success." : "Connection Failed.";

                ShowMessage(mess);
            }
            catch (Exception ex)
            {
                LogException(ex);
                ShowMessage("An Error occured check the log.");
            }
        }

        private void Browse()
        {
            try
            {
                browserDestinationDialog.Description = "Kaydedilecek klasör";
                DialogResult dialogRes = browserDestinationDialog.ShowDialog();

                if (dialogRes == DialogResult.OK)
                {
                    txtSavingFolderPath.Text = browserDestinationDialog.SelectedPath.Replace("\\", "/");
                    saveFolderPathName = txtSavingFolderPath.Text;
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
                ShowMessage("Error occured. Check the Error Log.");
            }
        }

        private void Generate()
        {
            try
            {
                if (txtSavingFolderPath.Text.IsNullOrWhiteSpace())
                {
                    ShowMessage("Save Path can not be empty.");
                    return;
                }

                if (chkDbObjectList.Items.Count < 1)
                {
                    ShowMessage("Db Object List can not be empty.");
                    return;
                }

                if (chkDbObjectList.CheckedItems.Count < 1)
                {
                    ShowMessage("Selected Db Object List can not be empty.");
                    return;
                }

                List<DbObject> dbObjTmpList = new List<DbObject>();
                DbObject obj;
                DbObject db_obj = new DbObject();
                string itemText;
                txtLog.Text = string.Empty;

                writeLog("Object filtering started.");
                if (chkDbObjectList.CheckedItems.Count == chkDbObjectList.Items.Count)
                {
                    dbObjTmpList = this.dbObjList;
                }
                else
                {
                    for (int counter = 0; counter < chkDbObjectList.CheckedItems.Count; counter++)
                    {
                        itemText = chkDbObjectList.GetItemText(chkDbObjectList.CheckedItems[counter]);
                        obj = dbObjList.AsQueryable().Where(dbo => dbo.ToString() == itemText).FirstOrDefault();

                        if (obj == null)
                            obj = new DbObject();

                        if (obj != db_obj)
                        {
                            dbObjTmpList.Add(obj);
                        }
                        else
                        {
                            writeLog(string.Format("Object has not found with name: {0}.", itemText));
                        }
                    }
                }

                writeLog("Object filtering completed.");
                writeLog("Data Script has been getting from Db.");

                string query = Crud.GetObjectListScriptBySchema();
                query = query.Replace(AppVariables.SchemaFormat, Conn.ConnectionUser);

                dtDbObjects = Conn.GetResultSet(query);

                writeLog("Data Script has been taken from Db.");

                string name;
                string typeName;
                for (int counter = 0; counter < dbObjTmpList.Count; counter++)
                {
                    name = dbObjTmpList[counter].NAME;
                    typeName = dbObjTmpList[counter].TYPENAME;
                    writeLog(string.Format("Script Creation: {0}/{1}", counter + 1, dbObjTmpList.Count));
                    this.CreateScriptOfObject(name, typeName);
                }

                writeLog("Script Creation has completed.");
                ShowMessage("Script Creation has completed.");
            }
            catch (Exception ex)
            {
                LogException(ex);
                ShowMessage("Error occured when script generation. Check the Error Log.");
            }
            finally
            {
                SetStatesOfSomeControls(true);
            }
        }

        private void SetStatesOfSomeControls(bool b)
        {
            txtConnStr.Enabled = b;
            txtFilter.Enabled = b;

            btnTestConn.Enabled = b;
            btnGetObjects.Enabled = b;
            btnClearFilter.Enabled = b;
            btnBrowse.Enabled = b;

            chkSelectAll.Enabled = b;
            chkTrigger.Enabled = b;
            chkProcedure.Enabled = b;
            chkFunction.Enabled = b;
            chkDbObjectList.Enabled = b;
        }

        private void ClearFilter()
        {
            txtFilter.ResetText();
        }

        private void GetObjects()
        {
            try
            {
                if (Conn.ConnectionString.IsNullOrWhiteSpace())
                {
                    ShowMessage("Connection String can not be empty.");
                    return;
                }

                List<string> tags = new List<string>();

                if (chkTrigger.Checked)
                    tags.Add(chkTrigger.Tag.ToStr());

                if (chkProcedure.Checked)
                    tags.Add(chkProcedure.Tag.ToStr());

                if (chkFunction.Checked)
                    tags.Add(chkFunction.Tag.ToStr());

                if (tags.Count == 0)
                {
                    ShowMessage("You should choose one option at least.");
                    return;
                }
                string usr = Conn.ConnectionUser;
                string s = AppVariables.ObjectTypeImplodeFormat;
                string str = s.Implode(tags.ToArray());

                s = Crud.GetBaseObjectListFormatBySchema();
                s = s.Replace(AppVariables.ObjectTypesFormat, str);
                s = s.Replace(AppVariables.SchemaFormat, usr);

                DataTable dt = Conn.GetResultSet(s);
                this.dbObjList = dt.ToList<DbObject>(false);
                this.dbFilteredObjList = this.dbObjList;

                LoadObjects();
            }
            catch (Exception ex)
            {
                LogException(ex);

                ShowMessage(ex.Message + Environment.NewLine + "Please Check the Error Log.");
            }
        }

        private void LoadObjects()
        {
            try
            {
                _ischkSelectAllLock = true;
                lblAllItemsValue.Text = "0";
                lblSelectedItemsValue.Text = "0";
                chkDbObjectList.Items.Clear();
                chkSelectAll.Checked = true;

                if (this.dbFilteredObjList.IsNullOrEmpty() == false)
                {
                    for (int counter = 0; counter < this.dbFilteredObjList.Count; counter++)
                    {
                        chkDbObjectList.Items.Add(this.dbFilteredObjList[counter].ToString(), true);
                    }

                    lblAllItemsValue.Text = this.dbFilteredObjList.Count.ToStr();
                    lblSelectedItemsValue.Text = this.dbFilteredObjList.Count.ToStr();
                    unCheckedCount = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _ischkSelectAllLock = false;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SetStatesOfSomeControls(false);
            Thread thrd = new Thread(new ThreadStart(this.Generate));
            thrd.Start();
        }

        private void LogException(Exception e)
        {
            //lock (writeExcLockObj)
            //{
            StringBuilder sB = new StringBuilder();

            sB.AppendLine(string.Format("Error Time: {0}", DateTime.Now.ToString(AppVariables.GeneralTimeFormat)));
            sB.AppendLine(string.Format("Error Message: {0}", e.Message));
            sB.AppendLine(string.Format("Error Stack Trace: {0}", e.StackTrace));
            sB.AppendLine(string.Format("********************************************************************"));

            txtErrorLog.Text = sB.ToString() + txtErrorLog.Text;
            //}
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void CreateScriptOfObject(string objectName, string typeName)
        {
            try
            {
                if (objectName.IsNullOrWhiteSpace())
                {
                    writeLog(string.Format("Any Text has not found for {0} with type {1}", objectName, typeName));
                    return;
                }

                if (dtDbObjects.IsNullOrEmpty())
                {
                    writeLog(string.Format("Any Text has not found for {0} with type {1}", objectName, typeName));
                    return;
                }

                DataRow[] rows = dtDbObjects.Select(string.Format("NAME = '{0}' AND TYPE='{1}'", objectName, typeName));

                /*
               string query = Crud.GetObjectScript();

               query = query.Replace(AppVariables.ObjectNameformat, objectName);

               DataTable dt = Conn.GetResultSet(query);

               if (dt.IsNullOrEmpty())
               {
                   writeLog(string.Format("Any Text has not found for {0} with type {1}", objectName, typeName));
                   return;
               }
               */

                if (rows == null || rows.Length == 0)
                {
                    writeLog(string.Format("Any Text has not found for {0} with type {1}", objectName, typeName));
                    return;
                }

                string fileFullName = getFileFullName(saveFolderPathName, objectName);
                int counter = 2;
                while (File.Exists(fileFullName))
                {
                    fileFullName = getFileFullName(saveFolderPathName, objectName + "_" + counter.ToString());
                    counter++;
                }

                FileMode fMode = File.Exists(fileFullName) ? FileMode.Append : FileMode.OpenOrCreate;

                using (StreamWriter outfile = new StreamWriter(new FileStream(fileFullName, fMode)) { AutoFlush = true })
                {
                    /*for (int rowCounter = 0; rowCounter < dt.Rows.Count; rowCounter++)
                    {
                        outfile.WriteLine(dt.Rows[rowCounter]["TEXT"].ToStr());
                    }
                    */
                    string s = string.Empty;
                    for (int rowCounter = 0; rowCounter < rows.Length; rowCounter++)
                    {
                        s = rows[rowCounter]["TEXT"].ToStr();
                        if (s.EndsWith("\r\n") || s.EndsWith("\n"))
                        {
                            outfile.Write(s);
                        }
                        else
                        {
                            outfile.WriteLine(s);
                        }
                    }
                }
                writeLog(string.Format("Script has been created {0} with type {1}.", objectName, typeName));
            }
            catch (Exception ex)
            {
                writeLog(string.Format("ERROR: Script has not been created {0} with type {1}. Please Check the Error Log.", objectName, typeName));
                LogException(ex);
            }
        }

        private string getFileFullName(string folderName, string fileName)
        {
            string s = folderName;

            if (!(s.EndsWith("/") || s.EndsWith("\\")))
            {
                s += "/";
            }

            s += fileName;
            s += ".sql";

            return s;
        }

        private void writeLog(string message)
        {
            //lock (writeLogLockObj)
            //{
            string s = string.Empty;
            s += string.Format("Log Time: {0}{1}", DateTime.Now.ToString(AppVariables.GeneralTimeFormat), Environment.NewLine);
            s += string.Format("Log Message: {0}{1}", message, Environment.NewLine);
            s += string.Format("********************************************************************{0}", Environment.NewLine);
            txtLog.Text = s + txtLog.Text;
            //}
        }

        private void btnGetObjects_Click(object sender, EventArgs e)
        {
            GetObjects();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ChkSelectAllChanged();
        }

        private void ChkSelectAllChanged()
        {
            if (!_ischkSelectAllLock)
            {
                if (chkDbObjectList.Items == null)
                    return;

                if (chkDbObjectList.Items.Count == 0)
                    return;

                for (int itemCounter = 0; itemCounter < chkDbObjectList.Items.Count; itemCounter++)
                {
                    chkDbObjectList.SetItemChecked(itemCounter, chkSelectAll.Checked);
                }

                lblSelectedItemsValue.Text = chkSelectAll.Checked ? dbFilteredObjList.Count.ToString() : "0";
            }
        }

        private void chkTypeChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }

        private void CheckChanged()
        {
            lblChosenObjTypes.Text = string.Empty;

            List<string> tags = new List<string>();

            if (chkTrigger.Checked)
                tags.Add(chkTrigger.Tag.ToStr());

            if (chkProcedure.Checked)
                tags.Add(chkProcedure.Tag.ToStr());

            if (chkFunction.Checked)
                tags.Add(chkFunction.Tag.ToStr());

            string s = ", ";
            lblChosenObjTypes.Text = s.Implode(tags.ToArray());
        }

        private void chkDbObjectList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_ischkSelectAllLock)
            {
                int counter = e.NewValue == CheckState.Checked ? -1 : 1;
                unCheckedCount += counter;

                lblSelectedItemsValue.Text = (dbFilteredObjList.Count - unCheckedCount).ToString();
            }
        }
    }
}