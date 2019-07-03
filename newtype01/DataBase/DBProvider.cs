using System.Data;
using System.Data.SqlClient;

namespace NewType.Seeker.DataBase
{
    /// <summary>
    /// 構造体:DBアクセス関連
    /// </summary>
    public class DBProvider
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBProvider()
        {
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
        }

        /// <summary>
        /// SQLデータアダプター
        /// </summary>
        public SqlDataAdapter adapter;

        /// <summary>
        /// SQLデータセット
        /// </summary>
        public DataSet dataSet;

        /// <summary>
        /// SQLコネクション
        /// </summary>
        public SqlConnection sqlConnection { get; set; }

        /// <summary>
        /// 接続文字列
        /// </summary>
        public SqlConnectionStringBuilder connectionString { get; set; }

        /// <summary>
        /// 接続フラグ
        /// </summary>
        public bool conFlg { get; set; }

        /// <summary>
        /// トランザクションフラグ
        /// </summary>
        public bool transFlag { get; set; } 

        /// <summary>
        /// リトライフラグ
        /// </summary>
        public bool retryFlag { get; set; } 

        /// <summary>
        /// 処理レコード件数
        /// </summary>
        public long recCount { get; set; }

        /// <summary>
        /// 初期化処理
        /// </summary>
        public void Clear()
        {
            transFlag = false;
            retryFlag = false;
            recCount = 0;
            sqlConnection = null;
            conFlg = false;
            adapter.Dispose();
            dataSet.Dispose();
        }
    }
}
