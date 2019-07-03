using System.Data;
using static NewType.Seeker.DataBase.CommonSqlServer;

namespace NewType.Seeker.DataBase
{
    public class SqlServerManager
    {
        public CommonSqlServer ComSqlServer { get; set; }
        public DBProvider DBinfo = new DBProvider();

        public SqlServerManager() { ComSqlServer = new CommonSqlServer(DBinfo); }

        public bool Connect(string connectionString, bool isMsg = true) { return ComSqlServer.ConnectToSQLServer(connectionString, isMsg); }

        public void DisConnect()
        {
            DBinfo.dataSet.Clear();
            ComSqlServer.DisconnectFromSQLServer();
        }

        private void RemoveData(string tableName) { if (DBinfo.dataSet.Tables.Contains(tableName)) DBinfo.dataSet.Tables.Remove(tableName); }

        public GetData GetData(string Sql, string tableName)
        {
            RemoveData(tableName);
            return ComSqlServer.GetDataFromSQLServer(Sql, tableName, true);
        }

        public DataTable GetTable(string tableName) { return DBinfo.dataSet.Tables[tableName]; }

        public bool Update(string tableName) { return ComSqlServer.ExecuteUpdatingToSQLServer(tableName, true); }
    }
}
