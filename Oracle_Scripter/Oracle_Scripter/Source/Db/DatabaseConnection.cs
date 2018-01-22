using System;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;

namespace Oracle_Scripter.Source.Db
{
    internal class DatabaseConnection
    {
        private string connStr;

        public DatabaseConnection(string connstr)
        {
            this.connStr = connstr;
        }

        public string ConnectionString
        {
            get { return connStr ?? string.Empty; }
            set { connStr = value ?? string.Empty; }
        }

        public string ConnectionUser
        {
            get
            {

                OracleConnectionStringBuilder connStrBuilder = new OracleConnectionStringBuilder();
                connStrBuilder.ConnectionString = this.ConnectionString;
                return connStrBuilder.UserID;
            }
        }


        public bool Test()
        {
            bool result = false;

            try
            {
                using (OracleConnection dbConn = new OracleConnection(this.ConnectionString))
                {
                    dbConn.Open();
                    dbConn.Close();
                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public DataTable GetResultSet(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                using (OracleConnection dbConn = new OracleConnection(this.ConnectionString))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, dbConn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
    }
}