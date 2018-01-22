namespace Oracle_Scripter
{
    partial class FrmOracleScripter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkTrigger = new MetroFramework.Controls.MetroCheckBox();
            this.chkProcedure = new MetroFramework.Controls.MetroCheckBox();
            this.chkFunction = new MetroFramework.Controls.MetroCheckBox();
            this.chkDbObjectList = new System.Windows.Forms.CheckedListBox();
            this.lblSavingPath = new MetroFramework.Controls.MetroLabel();
            this.txtSavingFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnTestConn = new MetroFramework.Controls.MetroButton();
            this.lblConnStr = new MetroFramework.Controls.MetroLabel();
            this.txtConnStr = new MetroFramework.Controls.MetroTextBox();
            this.lblObjList = new MetroFramework.Controls.MetroLabel();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytSavingPath = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytCheckBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytConn = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetObjects = new MetroFramework.Controls.MetroButton();
            this.tblLytFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilter = new MetroFramework.Controls.MetroLabel();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.btnClearFilter = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChosenTypes = new MetroFramework.Controls.MetroLabel();
            this.lblChosenObjTypes = new MetroFramework.Controls.MetroLabel();
            this.tblLytSelection = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelectAll = new MetroFramework.Controls.MetroCheckBox();
            this.lblSelectedItems = new MetroFramework.Controls.MetroLabel();
            this.lblSelectedItemsValue = new MetroFramework.Controls.MetroLabel();
            this.lblAllItems = new MetroFramework.Controls.MetroLabel();
            this.lblAllItemsValue = new MetroFramework.Controls.MetroLabel();
            this.tbCtrlMain = new MetroFramework.Controls.MetroTabControl();
            this.tbPgDb = new MetroFramework.Controls.MetroTabPage();
            this.tbPgErrorLog = new MetroFramework.Controls.MetroTabPage();
            this.txtErrorLog = new System.Windows.Forms.RichTextBox();
            this.tbPgLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.browserDestinationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tblLytMain.SuspendLayout();
            this.tblLytSavingPath.SuspendLayout();
            this.tblLytCheckBoxes.SuspendLayout();
            this.tblLytConn.SuspendLayout();
            this.tblLytFilter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLytSelection.SuspendLayout();
            this.tbCtrlMain.SuspendLayout();
            this.tbPgDb.SuspendLayout();
            this.tbPgErrorLog.SuspendLayout();
            this.tbPgLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkTrigger
            // 
            this.chkTrigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTrigger.AutoSize = true;
            this.chkTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkTrigger.Location = new System.Drawing.Point(10, 9);
            this.chkTrigger.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkTrigger.Name = "chkTrigger";
            this.chkTrigger.Size = new System.Drawing.Size(69, 15);
            this.chkTrigger.TabIndex = 0;
            this.chkTrigger.Tag = "TRIGGER";
            this.chkTrigger.Text = "TRIGGER";
            this.chkTrigger.UseVisualStyleBackColor = true;
            this.chkTrigger.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkProcedure
            // 
            this.chkProcedure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkProcedure.AutoSize = true;
            this.chkProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkProcedure.Location = new System.Drawing.Point(262, 9);
            this.chkProcedure.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkProcedure.Name = "chkProcedure";
            this.chkProcedure.Size = new System.Drawing.Size(89, 15);
            this.chkProcedure.TabIndex = 1;
            this.chkProcedure.Tag = "PROCEDURE";
            this.chkProcedure.Text = "PROCEDURE";
            this.chkProcedure.UseVisualStyleBackColor = true;
            this.chkProcedure.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkFunction
            // 
            this.chkFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFunction.AutoSize = true;
            this.chkFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkFunction.Location = new System.Drawing.Point(514, 9);
            this.chkFunction.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkFunction.Name = "chkFunction";
            this.chkFunction.Size = new System.Drawing.Size(82, 15);
            this.chkFunction.TabIndex = 2;
            this.chkFunction.Tag = "FUNCTION";
            this.chkFunction.Text = "FUNCTION";
            this.chkFunction.UseVisualStyleBackColor = true;
            this.chkFunction.CheckedChanged += new System.EventHandler(this.chkTypeChanged);
            // 
            // chkDbObjectList
            // 
            this.chkDbObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDbObjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkDbObjectList.FormattingEnabled = true;
            this.chkDbObjectList.Location = new System.Drawing.Point(3, 203);
            this.chkDbObjectList.Name = "chkDbObjectList";
            this.chkDbObjectList.Size = new System.Drawing.Size(1009, 358);
            this.chkDbObjectList.TabIndex = 3;
            this.chkDbObjectList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkDbObjectList_ItemCheck);
            // 
            // lblSavingPath
            // 
            this.lblSavingPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSavingPath.AutoSize = true;
            this.lblSavingPath.Location = new System.Drawing.Point(3, 10);
            this.lblSavingPath.Name = "lblSavingPath";
            this.lblSavingPath.Size = new System.Drawing.Size(83, 19);
            this.lblSavingPath.TabIndex = 5;
            this.lblSavingPath.Text = "Saving Path :";
            // 
            // txtSavingFolderPath
            // 
            this.txtSavingFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavingFolderPath.Location = new System.Drawing.Point(101, 8);
            this.txtSavingFolderPath.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtSavingFolderPath.Name = "txtSavingFolderPath";
            this.txtSavingFolderPath.ReadOnly = true;
            this.txtSavingFolderPath.Size = new System.Drawing.Size(807, 22);
            this.txtSavingFolderPath.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Location = new System.Drawing.Point(919, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 33);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(463, 616);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 32);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestConn.Location = new System.Drawing.Point(784, 4);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(89, 45);
            this.btnTestConn.TabIndex = 9;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // lblConnStr
            // 
            this.lblConnStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Location = new System.Drawing.Point(3, 17);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(113, 19);
            this.lblConnStr.TabIndex = 10;
            this.lblConnStr.Text = "Conection String :";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnStr.Location = new System.Drawing.Point(121, 16);
            this.txtConnStr.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(647, 22);
            this.txtConnStr.TabIndex = 11;
            // 
            // lblObjList
            // 
            this.lblObjList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjList.AutoSize = true;
            this.lblObjList.Location = new System.Drawing.Point(3, 5);
            this.lblObjList.Name = "lblObjList";
            this.lblObjList.Size = new System.Drawing.Size(77, 19);
            this.lblObjList.TabIndex = 12;
            this.lblObjList.Text = "Object List :";
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.chkDbObjectList, 0, 5);
            this.tblLytMain.Controls.Add(this.btnGenerate, 0, 7);
            this.tblLytMain.Controls.Add(this.tblLytSavingPath, 0, 6);
            this.tblLytMain.Controls.Add(this.tblLytCheckBoxes, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytConn, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytFilter, 0, 2);
            this.tblLytMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tblLytMain.Controls.Add(this.tblLytSelection, 0, 4);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(3, 3);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 8;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytMain.Size = new System.Drawing.Size(1015, 655);
            this.tblLytMain.TabIndex = 13;
            // 
            // tblLytSavingPath
            // 
            this.tblLytSavingPath.ColumnCount = 3;
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavingPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytSavingPath.Controls.Add(this.txtSavingFolderPath, 1, 0);
            this.tblLytSavingPath.Controls.Add(this.btnBrowse, 2, 0);
            this.tblLytSavingPath.Controls.Add(this.lblSavingPath, 0, 0);
            this.tblLytSavingPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSavingPath.Location = new System.Drawing.Point(3, 567);
            this.tblLytSavingPath.Name = "tblLytSavingPath";
            this.tblLytSavingPath.RowCount = 1;
            this.tblLytSavingPath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavingPath.Size = new System.Drawing.Size(1009, 39);
            this.tblLytSavingPath.TabIndex = 13;
            // 
            // tblLytCheckBoxes
            // 
            this.tblLytCheckBoxes.ColumnCount = 4;
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytCheckBoxes.Controls.Add(this.chkFunction, 2, 0);
            this.tblLytCheckBoxes.Controls.Add(this.chkProcedure, 1, 0);
            this.tblLytCheckBoxes.Controls.Add(this.chkTrigger, 0, 0);
            this.tblLytCheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytCheckBoxes.Location = new System.Drawing.Point(3, 63);
            this.tblLytCheckBoxes.Name = "tblLytCheckBoxes";
            this.tblLytCheckBoxes.RowCount = 1;
            this.tblLytCheckBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytCheckBoxes.Size = new System.Drawing.Size(1009, 34);
            this.tblLytCheckBoxes.TabIndex = 14;
            // 
            // tblLytConn
            // 
            this.tblLytConn.ColumnCount = 4;
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytConn.Controls.Add(this.lblConnStr, 0, 0);
            this.tblLytConn.Controls.Add(this.btnTestConn, 2, 0);
            this.tblLytConn.Controls.Add(this.txtConnStr, 1, 0);
            this.tblLytConn.Controls.Add(this.btnGetObjects, 3, 0);
            this.tblLytConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConn.Location = new System.Drawing.Point(3, 3);
            this.tblLytConn.Name = "tblLytConn";
            this.tblLytConn.RowCount = 1;
            this.tblLytConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConn.Size = new System.Drawing.Size(1009, 54);
            this.tblLytConn.TabIndex = 15;
            // 
            // btnGetObjects
            // 
            this.btnGetObjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetObjects.Location = new System.Drawing.Point(900, 4);
            this.btnGetObjects.Name = "btnGetObjects";
            this.btnGetObjects.Size = new System.Drawing.Size(97, 46);
            this.btnGetObjects.TabIndex = 12;
            this.btnGetObjects.Text = "Get Objects";
            this.btnGetObjects.Click += new System.EventHandler(this.btnGetObjects_Click);
            // 
            // tblLytFilter
            // 
            this.tblLytFilter.ColumnCount = 3;
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytFilter.Controls.Add(this.lblFilter, 0, 0);
            this.tblLytFilter.Controls.Add(this.txtFilter, 1, 0);
            this.tblLytFilter.Controls.Add(this.btnClearFilter, 2, 0);
            this.tblLytFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytFilter.Location = new System.Drawing.Point(3, 103);
            this.tblLytFilter.Name = "tblLytFilter";
            this.tblLytFilter.RowCount = 1;
            this.tblLytFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytFilter.Size = new System.Drawing.Size(1009, 29);
            this.tblLytFilter.TabIndex = 16;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(3, 5);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 19);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(101, 3);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(807, 23);
            this.txtFilter.TabIndex = 1;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(910, 1);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(98, 27);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblObjList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChosenTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblChosenObjTypes, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 29);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblChosenTypes
            // 
            this.lblChosenTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChosenTypes.AutoSize = true;
            this.lblChosenTypes.Location = new System.Drawing.Point(255, 5);
            this.lblChosenTypes.Name = "lblChosenTypes";
            this.lblChosenTypes.Size = new System.Drawing.Size(134, 19);
            this.lblChosenTypes.TabIndex = 13;
            this.lblChosenTypes.Text = "Chosen Object Types:";
            // 
            // lblChosenObjTypes
            // 
            this.lblChosenObjTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChosenObjTypes.AutoSize = true;
            this.lblChosenObjTypes.Location = new System.Drawing.Point(507, 14);
            this.lblChosenObjTypes.Name = "lblChosenObjTypes";
            this.lblChosenObjTypes.Size = new System.Drawing.Size(0, 0);
            this.lblChosenObjTypes.TabIndex = 14;
            // 
            // tblLytSelection
            // 
            this.tblLytSelection.ColumnCount = 5;
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytSelection.Controls.Add(this.chkSelectAll, 0, 0);
            this.tblLytSelection.Controls.Add(this.lblSelectedItems, 1, 0);
            this.tblLytSelection.Controls.Add(this.lblSelectedItemsValue, 2, 0);
            this.tblLytSelection.Controls.Add(this.lblAllItems, 3, 0);
            this.tblLytSelection.Controls.Add(this.lblAllItemsValue, 4, 0);
            this.tblLytSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSelection.Location = new System.Drawing.Point(3, 173);
            this.tblLytSelection.Name = "tblLytSelection";
            this.tblLytSelection.RowCount = 1;
            this.tblLytSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSelection.Size = new System.Drawing.Size(1009, 24);
            this.tblLytSelection.TabIndex = 19;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 4);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(71, 15);
            this.chkSelectAll.TabIndex = 17;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(299, 2);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(100, 19);
            this.lblSelectedItems.TabIndex = 18;
            this.lblSelectedItems.Text = "Selected Items :";
            // 
            // lblSelectedItemsValue
            // 
            this.lblSelectedItemsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectedItemsValue.AutoSize = true;
            this.lblSelectedItemsValue.Location = new System.Drawing.Point(405, 12);
            this.lblSelectedItemsValue.Name = "lblSelectedItemsValue";
            this.lblSelectedItemsValue.Size = new System.Drawing.Size(0, 0);
            this.lblSelectedItemsValue.TabIndex = 19;
            // 
            // lblAllItems
            // 
            this.lblAllItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAllItems.AutoSize = true;
            this.lblAllItems.Location = new System.Drawing.Point(735, 2);
            this.lblAllItems.Name = "lblAllItems";
            this.lblAllItems.Size = new System.Drawing.Size(66, 19);
            this.lblAllItems.TabIndex = 20;
            this.lblAllItems.Text = "All Items :";
            // 
            // lblAllItemsValue
            // 
            this.lblAllItemsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllItemsValue.AutoSize = true;
            this.lblAllItemsValue.Location = new System.Drawing.Point(807, 12);
            this.lblAllItemsValue.Name = "lblAllItemsValue";
            this.lblAllItemsValue.Size = new System.Drawing.Size(0, 0);
            this.lblAllItemsValue.TabIndex = 21;
            // 
            // tbCtrlMain
            // 
            this.tbCtrlMain.Controls.Add(this.tbPgDb);
            this.tbCtrlMain.Controls.Add(this.tbPgErrorLog);
            this.tbCtrlMain.Controls.Add(this.tbPgLog);
            this.tbCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlMain.Location = new System.Drawing.Point(20, 60);
            this.tbCtrlMain.Name = "tbCtrlMain";
            this.tbCtrlMain.SelectedIndex = 0;
            this.tbCtrlMain.Size = new System.Drawing.Size(1029, 700);
            this.tbCtrlMain.TabIndex = 14;
            // 
            // tbPgDb
            // 
            this.tbPgDb.Controls.Add(this.tblLytMain);
            this.tbPgDb.HorizontalScrollbarBarColor = true;
            this.tbPgDb.Location = new System.Drawing.Point(4, 35);
            this.tbPgDb.Name = "tbPgDb";
            this.tbPgDb.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDb.Size = new System.Drawing.Size(1021, 661);
            this.tbPgDb.TabIndex = 0;
            this.tbPgDb.Text = "Database";
            this.tbPgDb.UseVisualStyleBackColor = true;
            this.tbPgDb.VerticalScrollbarBarColor = true;
            // 
            // tbPgErrorLog
            // 
            this.tbPgErrorLog.Controls.Add(this.txtErrorLog);
            this.tbPgErrorLog.HorizontalScrollbarBarColor = true;
            this.tbPgErrorLog.Location = new System.Drawing.Point(4, 35);
            this.tbPgErrorLog.Name = "tbPgErrorLog";
            this.tbPgErrorLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgErrorLog.Size = new System.Drawing.Size(1021, 662);
            this.tbPgErrorLog.TabIndex = 1;
            this.tbPgErrorLog.Text = "ErrorLog";
            this.tbPgErrorLog.UseVisualStyleBackColor = true;
            this.tbPgErrorLog.VerticalScrollbarBarColor = true;
            // 
            // txtErrorLog
            // 
            this.txtErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorLog.Location = new System.Drawing.Point(3, 3);
            this.txtErrorLog.Name = "txtErrorLog";
            this.txtErrorLog.ReadOnly = true;
            this.txtErrorLog.Size = new System.Drawing.Size(1015, 656);
            this.txtErrorLog.TabIndex = 0;
            this.txtErrorLog.Text = "";
            // 
            // tbPgLog
            // 
            this.tbPgLog.Controls.Add(this.txtLog);
            this.tbPgLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbPgLog.Location = new System.Drawing.Point(4, 35);
            this.tbPgLog.Name = "tbPgLog";
            this.tbPgLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgLog.Size = new System.Drawing.Size(1021, 662);
            this.tbPgLog.TabIndex = 2;
            this.tbPgLog.Text = "Log";
            this.tbPgLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1015, 656);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // FrmOracleScripter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 780);
            this.Controls.Add(this.tbCtrlMain);
            this.Name = "FrmOracleScripter";
            this.Text = "Oracle Scripter";
            this.tblLytMain.ResumeLayout(false);
            this.tblLytSavingPath.ResumeLayout(false);
            this.tblLytSavingPath.PerformLayout();
            this.tblLytCheckBoxes.ResumeLayout(false);
            this.tblLytCheckBoxes.PerformLayout();
            this.tblLytConn.ResumeLayout(false);
            this.tblLytConn.PerformLayout();
            this.tblLytFilter.ResumeLayout(false);
            this.tblLytFilter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblLytSelection.ResumeLayout(false);
            this.tblLytSelection.PerformLayout();
            this.tbCtrlMain.ResumeLayout(false);
            this.tbPgDb.ResumeLayout(false);
            this.tbPgErrorLog.ResumeLayout(false);
            this.tbPgLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //MetroFramework.Controls.MetroLabel

        private MetroFramework.Controls.MetroCheckBox chkTrigger;
        private MetroFramework.Controls.MetroCheckBox chkProcedure;
        private MetroFramework.Controls.MetroCheckBox chkFunction;
        private System.Windows.Forms.CheckedListBox chkDbObjectList;
        private MetroFramework.Controls.MetroLabel lblSavingPath;
        private MetroFramework.Controls.MetroTextBox txtSavingFolderPath;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnTestConn;
        private MetroFramework.Controls.MetroLabel lblConnStr;
        private MetroFramework.Controls.MetroTextBox txtConnStr;
        private MetroFramework.Controls.MetroLabel lblObjList;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytSavingPath;
        private System.Windows.Forms.TableLayoutPanel tblLytCheckBoxes;
        private System.Windows.Forms.TableLayoutPanel tblLytConn;
        private MetroFramework.Controls.MetroTabControl tbCtrlMain;
        private MetroFramework.Controls.MetroTabPage tbPgDb;
        private MetroFramework.Controls.MetroTabPage tbPgErrorLog;

        //private System.Windows.Forms.TabControl tbCtrlMain;
        //private System.Windows.Forms.TabPage tbPgDb;
        //private System.Windows.Forms.TabPage tbPgErrorLog;

        private System.Windows.Forms.TableLayoutPanel tblLytFilter;
        private MetroFramework.Controls.MetroLabel lblFilter;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroButton btnClearFilter;
        private System.Windows.Forms.RichTextBox txtErrorLog;
        private MetroFramework.Controls.MetroCheckBox chkSelectAll;
        private System.Windows.Forms.TabPage tbPgLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private MetroFramework.Controls.MetroButton btnGetObjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblChosenTypes;
        private MetroFramework.Controls.MetroLabel lblChosenObjTypes;
        private System.Windows.Forms.TableLayoutPanel tblLytSelection;
        private MetroFramework.Controls.MetroLabel lblSelectedItems;
        private MetroFramework.Controls.MetroLabel lblSelectedItemsValue;
        private MetroFramework.Controls.MetroLabel lblAllItems;
        private MetroFramework.Controls.MetroLabel lblAllItemsValue;
        private System.Windows.Forms.FolderBrowserDialog browserDestinationDialog;
    }
}

