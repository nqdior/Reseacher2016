﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

/// <summary>
/// Spos共通関数
/// </summary>
namespace NewType.Seeker.DataBase
{
    /// <summary>
    /// SqlServer共通クラス
    /// </summary>
    public class CommonSqlServer
    {
        #region 1. 宣言
        /// <summary>
        /// DB情報構造体
        /// </summary>
        private DBProvider DBinfo;

        /// <summary>
        /// DB(SQLSV)の情報構造体：trn 
        /// </summary>
        private SqlTransaction trn = null;

        /// <summary>
        /// DB(SQLSV)の情報構造体：cmd 
        /// </summary>
        public SqlCommand cmd = new SqlCommand();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CommonSqlServer(DBProvider DBinfo)
        {
            this.DBinfo = DBinfo;
        }
        #endregion

        #region 2. SQLServerへの接続

        /// <summary>
        /// SQLServerへの接続
        /// </summary>
        /// <param name="strCon">接続文字列</param>
        /// <param name="isMsgShow">メッセージ表示フラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        /// <returns>成功／失敗</returns>
        public bool ConnectToSQLServer(string strCon, bool isMsgShow = false,
                                                        bool isErrSkip = false, bool isRetryFlag = false, int maxRetryTimes = 0)
        {
            for (int retryTimes = 0; retryTimes <= maxRetryTimes; retryTimes++)
                try
                {
                    DBinfo.connectionString = new SqlConnectionStringBuilder(strCon);
                    DBinfo.sqlConnection = new SqlConnection();

                    DBinfo.sqlConnection.ConnectionString = strCon;
                    DBinfo.sqlConnection.Open();

                    // 各パラメータのセット 
                    DBinfo.transFlag = false;
                    DBinfo.conFlg = true;

                    return true;
                }

                catch (SqlException ex)
                {
                    DBinfo.conFlg = false;
                    HandleError(ex, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return false; }
                }

                catch (Exception e)
                {
                    DBinfo.conFlg = false;
                    HandleError(e, isMsgShow);

                    if (!isRetryFlag) { return false; }
                }

            return false;
        }

        #endregion

        #region 3. SQLServerを操作

        /// <summary>
        /// 列挙体：SELECT実行結果
        /// </summary>
        public enum GetData
        {
            Success = 0,
            Nothing = 1,
            Fail = 2,
        }

        /// <summary>
        /// SQLコマンドを実行する
        /// </summary>
        /// <param name="strSql">実行するSQLコマンド</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="isMsgShow">メッセージ表示フラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        /// <returns>データ有り／データなし／取得失敗</returns>
        public GetData GetDataFromSQLServer(string strSql, string tableName = "", bool isMsgShow = false,
                                                                  bool isErrSkip = false, bool isRetryFlag = false, int maxRetryTimes = 0)
        {
            for (int retryTimes = 0; retryTimes <= maxRetryTimes; retryTimes++)
                try
                {
                    cmd.Connection = DBinfo.sqlConnection;
                    cmd.CommandText = strSql;

                    if (DBinfo.transFlag) { cmd.Transaction = trn; }

                    // Selectコマンドを設定
                    DBinfo.adapter.SelectCommand = cmd;

                    if (!string.IsNullOrEmpty(tableName))
                    {
                        DBinfo.adapter.Fill(DBinfo.dataSet, tableName);
                        DBinfo.recCount = DBinfo.dataSet.Tables[tableName].Rows.Count;
                        DBinfo.adapter.FillSchema(DBinfo.dataSet, System.Data.SchemaType.Mapped, tableName);
                    }
                    else
                    {
                        DBinfo.adapter.Fill(DBinfo.dataSet);
                        DBinfo.recCount = DBinfo.dataSet.Tables[0].Rows.Count;
                    }
                    cmd.Dispose();

                    // データの存在確認
                    if (DBinfo.recCount > 0)
                    {
                        return GetData.Success;
                    }
                    else
                    {
                        return GetData.Nothing;
                    }
                }
                catch (SqlException ex)
                {
                    cmd.Dispose();
                    HandleError(ex, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return GetData.Fail; }
                }
                catch (Exception e)
                {
                    cmd.Dispose();
                    HandleError(e, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return GetData.Fail; }
                }

            return GetData.Fail;
        }

        /// <summary>
        /// SQLコマンドを実行する
        /// </summary>
        /// <param name="strSql">実行するSQLコマンド</param>
        /// <param name="isMsgShow">メッセージ表示フラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        /// <returns></returns>
        public bool ExecuteCommandToSQLServer(string strSql, bool isMsgShow = false,
                                                                      bool isErrSkip = false, bool isRetryFlag = false, int maxRetryTimes = 0)
        {
            for (int retryTimes = 0; retryTimes <= maxRetryTimes; retryTimes++)
                try
                {
                    // 変数の初期化
                    DBinfo.recCount = 0;

                    // 接続・文字列の設定
                    cmd.Connection = DBinfo.sqlConnection;
                    cmd.CommandText = strSql;

                    // トランザクションの確認
                    if (DBinfo.transFlag)
                    {
                        cmd.Transaction = trn;
                    }
                    else
                    {
                        if (!BeginTransaction(isMsgShow)) { return false; }
                        cmd.Transaction = trn;
                    }

                    // コマンドの実行
                    cmd.ExecuteNonQuery();
                    CommitTransaction(isMsgShow);

                    cmd.Dispose();
                    return true;
                }
                catch (SqlException ex)
                {
                    cmd.Dispose();

                    // トランザクションが開始されていれば、ロールバックする
                    if (DBinfo.transFlag)
                    {
                        RollBackTransaction(isMsgShow);
                    }

                    DBinfo.transFlag = false;
                    HandleError(ex, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return false; }
                }
                catch (Exception e)
                {
                    // トランザクションが開始されていれば、ロールバックする
                    if (DBinfo.transFlag)
                    {
                        RollBackTransaction(true);
                    }

                    DBinfo.adapter.Fill(DBinfo.dataSet);
                    DBinfo.transFlag = false;
                    HandleError(e, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return false; }
                    cmd.Dispose();
                }

            return false;
        }

        /// <summary>
        /// SQLServerへのアップデート実行
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="isMsgShow">メッセージ表示フラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        /// <returns></returns>
        public bool ExecuteUpdatingToSQLServer(string tableName = "", bool isMsgShow = false,
                                                                     bool isErrSkip = false, bool isRetryFlag = false, int maxRetryTimes = 0)
        {
            int result;
            SqlCommandBuilder builder;

            for (int retryTimes = 0; retryTimes <= maxRetryTimes; retryTimes++)
                try
                {
                    builder = new SqlCommandBuilder(DBinfo.adapter);

                    // トランザクションの確認
                    if (DBinfo.transFlag)
                    {
                        cmd.Transaction = trn;
                    }
                    else
                    {
                        if (!BeginTransaction(isMsgShow))
                        {
                            return false;
                        }
                        cmd.Transaction = trn;
                    }
                    DBinfo.adapter.SelectCommand.Transaction = trn;

                    // UPDATEコマンドを取得/実行
                    builder.GetUpdateCommand();
                    Application.DoEvents();

                    // データセットにデータを格納
                    if (tableName != "")
                    {
                        result = DBinfo.adapter.Update(DBinfo.dataSet.Tables[tableName]);
                    }
                    else
                    {
                        result = DBinfo.adapter.Update(DBinfo.dataSet.Tables[0]);
                    }

                    // トランザクションのコミット
                    CommitTransaction(isMsgShow);
                    cmd.Dispose();

                    return true;
                }
                catch (SqlException ex)
                {
                    // トランザクションが開始されていれば、ロールバックする
                    if (DBinfo.transFlag)
                    {
                        RollBackTransaction(isMsgShow);
                    }

                    DBinfo.transFlag = false;
                    HandleError(ex, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return false; }
                }

                catch (Exception e)
                {
                    // ロールバック
                    HandleError(e, isMsgShow, isErrSkip, isRetryFlag, maxRetryTimes, retryTimes);

                    if (!isRetryFlag) { return false; }
                }

            return false;
        }

        /// <summary>
        /// SQLServer接続の切断
        /// </summary>
        /// <param name="isMsgShow">メッセージフラグ</param>
        public void DisconnectFromSQLServer(bool isMsgShow = false)
        {
            try
            {
                if (DBinfo.sqlConnection != null)
                {
                    DBinfo.sqlConnection.Close();
                    SqlConnection.ClearPool(DBinfo.sqlConnection);
                    DBinfo.sqlConnection.Dispose();
                }
                DBinfo.sqlConnection = null;
            }

            catch (SqlException ex)
            {
                if (isMsgShow)
                {
                    MessageBox.Show(ex.HResult + Environment.NewLine + ex.Message);
                }
            }

            catch (Exception e)
            {
                if (isMsgShow)
                {
                    MessageBox.Show(e.HResult + Environment.NewLine + e.Message);
                }
            }
        }

        #endregion

        #region 4. トランザクション

        /// <summary>
        /// トランザクションの開始
        /// </summary>
        /// <param name="isMsgShow">メッセージフラグ</param>
        /// <returns></returns>
        private bool BeginTransaction(bool isMsgShow = false)
        {
            try
            {
                if (DBinfo.transFlag) { return true; }
                //トランザクションを開始する
                trn = DBinfo.sqlConnection.BeginTransaction();

                DBinfo.transFlag = true;
                return true;
            }
            catch (SqlException ex)
            {
                DBinfo.transFlag = false;
                HandleError(ex, isMsgShow);

                return false;
            }
            catch (Exception e)
            {
                DBinfo.transFlag = false;
                HandleError(e, isMsgShow);

                return false;
            }
        }

        /// <summary>
        /// トランザクションのコミット
        /// </summary>
        /// <param name="isMsgShow">メッセージフラグ</param>
        /// <returns></returns>
        private bool CommitTransaction(bool isMsgShow = false)
        {
            try
            {
                if (!DBinfo.transFlag)
                {
                    return true;
                }
                // トランザクションをコミットする
                trn.Commit();

                DBinfo.transFlag = false;
                return true;
            }
            catch (SqlException ex)
            {
                DBinfo.transFlag = false;
                HandleError(ex, isMsgShow);

                return false;
            }
            catch (Exception e)
            {
                DBinfo.transFlag = false;
                HandleError(e, isMsgShow);

                return false;
            }
        }

        /// <summary>
        /// トランザクションのロールバック
        /// </summary>
        /// <param name="isMsgShow">メッセージフラグ</param>
        /// <returns></returns>
        private bool RollBackTransaction(bool isMsgShow = false)
        {
            try
            {
                if (!DBinfo.transFlag)
                {
                    cmd.Dispose();
                    return true;
                }
                // トランザクションをロールバックする
                trn.Rollback();

                DBinfo.transFlag = false;
                return true;
            }
            catch (SqlException ex)
            {
                DBinfo.transFlag = false;
                HandleError(ex, isMsgShow);

                return false;
            }
            catch (Exception e)
            {
                DBinfo.transFlag = false;
                HandleError(e, isMsgShow);

                return false;
            }
        }

        #endregion

        #region ex. エラー処理

        /// <summary>
        /// SQLエラー処理を行う
        /// </summary>
        /// <param name="ex">エラーオブジェクト</param>
        /// <param name="isMsgShow">メッセージフラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="retryTimes">再試行回数</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        private void HandleError(Exception ex, bool isMsgShow = false, bool isErrSkip = false, 
                                            bool isRetryFlag = false, int retryTimes = 0, int maxRetryTimes = 0)
        {
            // リトライフラグを確認
            if (isRetryFlag == true && retryTimes != maxRetryTimes) { return; }

            // エラースキップを確認
            if (isErrSkip) { return; }

            // メッセージ表示モードの確認
            if (isMsgShow)
            {
                MessageBox.Show(ex.HResult + Environment.NewLine + ex.Message);
                return;
            }
        }

        /// <summary>
        /// SQLエラー処理を行う
        /// </summary>
        /// <param name="ex">SQLエラーオブジェクト</param>
        /// <param name="isMsgShow">メッセージフラグ</param>
        /// <param name="isErrSkip">エラースキップフラグ</param>
        /// <param name="isRetryFlag">リトライフラグ</param>
        /// <param name="retryTimes">再試行回数</param>
        /// <param name="maxRetryTimes">最大試行回数</param>
        private void HandleError(SqlException ex, bool isMsgShow = false, bool isErrSkip = false,
                                            bool isRetryFlag = false, int retryTimes = 0, int maxRetryTimes = 0)
        {
            // リトライフラグを確認
            if (isRetryFlag == true && retryTimes != maxRetryTimes) { return; }

            // エラースキップを確認
            if (isErrSkip) { return; }

            // メッセージ表示モードの確認
            if (isMsgShow)
            {
                MessageBox.Show(ex.HResult + Environment.NewLine + ex.Message);
                return;
            }
        }

        #endregion
    }

    public static class GetDataExt
    {
        // Gender に対する拡張メソッドの定義
        public static bool ToBoolean(this CommonSqlServer.GetData isGet)
        {
            bool[] value = { true, false, false };
            return value[(int)isGet];
        }
    }
}
