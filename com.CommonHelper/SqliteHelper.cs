namespace System.Data.SQLite
{
    using log4net;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    public class SqliteHelper
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string pwd = "PWD"; 
        private static string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\sqliteTest.db";
        private static string connString = string.Format("Data Source =\"{0}\"", path, pwd);
        private static SqliteHelper instance;

        public  string[] connectionStrings = {
            "Data Source=database/db_Sys.sqlite;Version=3;",
            "Data Source=database/db_T1.sqlite;Version=3;",
            "Data Source=database/db_T2.sqlite;Version=3;",
            "Data Source=database/db_T3.sqlite;Version=3;",
            "Data Source=database/db_T4.sqlite;Version=3;",
            "Data Source=database/db_T5.sqlite;Version=3;"};


        public static SqliteHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqliteHelper();
                }
                return instance;
            }
        }

        public void ExecuteSql(int tubeIndex, string sql)
        {
            try
            {
                using (SQLiteConnection c = new SQLiteConnection(connectionStrings[tubeIndex]))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
               
            }
            catch (Exception ex)
            {
                log.Error("执行ExecuteSql执行出现异常：" + ex);
                throw new Exception("执行EExecuteSql执行出现异常：", ex);
            }
        }



        #region 数据库封装

        /**//// <summary>
            /// 执行SQL语句,返回受影响的行数
            /// </summary>
            /// <param name="cmdText">需要被执行的SQL语句</param>
            /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(int tubeIndex, string sql)
        {
            return ExecuteNonQuery(connectionStrings[tubeIndex], sql);
        }


        /**//// <summary>
            /// 执行SQL语句,返回受影响的行数
            /// </summary>
            /// <param name="connString">连接字符串</param>
            /// <param name="cmdText">SQL语句</param>
            /// <param name="parameters">SQL的参数</param>
            /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string connString, string cmdText, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                return ExecuteNonQuery(conn, cmdText, parameters);
            }
        }
        /**//// <summary>
            /// 执行SQL语句,返回受影响的行数
            /// </summary>
            /// <param name="connection">数据库链接</param>
            /// <param name="cmdText">SQL语句</param>
            /// <param name="parameters">参数</param>
            /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(SQLiteConnection connection, string cmdText, params SQLiteParameter[] parameters)
        {
            try
            {
                int val = 0;
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    PrepareCommand(cmd, connection, null, cmdText, parameters);
                    val = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                return val;
            }
            catch (Exception ex)
            {
                log.Error("执行ExecuteNonQuery执行出现异常：" + ex);
                throw new Exception("执行ExecuteNonQuery执行出现异常：", ex);
            }

        }
        /**//// <summary>
            /// 执行查询,并返回结果集的第一行的第一列.其他所有的行和列被忽略.
            /// </summary>
            /// <param name="cmdText">SQL 语句</param>
            /// <returns>第一行的第一列的值</returns>
        public static object ExecuteScalar(string cmdText)
        {
            return ExecuteScalar(connString, cmdText);
        }
        /**//// <summary>
            /// 执行查询,并返回结果集的第一行的第一列.其他所有的行和列被忽略.
            /// </summary>
            /// <param name="connString">连接字符串</param>
            /// <param name="cmdText">SQL 语句</param>
            /// <returns>第一行的第一列的值</returns>
        public static object ExecuteScalar(string connString, string cmdText)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                return ExecuteScalar(conn, cmdText);
            }
        }
        /**//// <summary>
            /// 执行查询,并返回结果集的第一行的第一列.其他所有的行和列被忽略.
            /// </summary>
            /// <param name="connection">数据库链接</param>
            /// <param name="cmdText">SQL 语句</param>
            /// <returns>第一行的第一列的值</returns>
        public static object ExecuteScalar(SQLiteConnection connection, string cmdText)
        {
            try
            {
                object val;
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    PrepareCommand(cmd, connection, null, cmdText);
                    val = cmd.ExecuteScalar();
                }
                return val;
            }
            catch (Exception ex)
            {
                log.Error("执行ExecuteScalar执行出现异常：" + ex);
                throw new Exception("执行ExecuteScalar执行出现异常：", ex);
            }

        }
        /**//// <summary>
            /// 执行SQL语句,返回结果集的DataReader
            /// </summary>
            /// <param name="cmdText">SQL语句</param>
            /// <param name="parameters">参数</param>
            /// <returns>结果集的DataReader</returns>
        public static SQLiteDataReader ExecuteReader(string cmdText, params SQLiteParameter[] parameters)
        {
            return ExecuteReader(connString, cmdText, parameters);
        }
        /**//// <summary>
            /// 执行SQL语句,返回结果集的DataReader
            /// </summary>
            /// <param name="connString">连接字符串</param>
            /// <param name="cmdText">SQL语句</param>
            /// <param name="parameters">参数</param>
            /// <returns>结果集的DataReader</returns>
        public static SQLiteDataReader ExecuteReader(string connString, string cmdText, params SQLiteParameter[] parameters)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand();
            try
            {
                PrepareCommand(cmd, conn, null, cmdText, parameters);
                SQLiteDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch (Exception ex)
            {
                conn.Close();
                log.Error("执行ExecuteReader执行出现异常：" + ex);
                throw new Exception("执行ExecuteReader执行出现异常：", ex);
            }
        }
        /**//// <summary>
            /// 预处理Command对象,数据库链接,事务,需要执行的对象,参数等的初始化
            /// </summary>
            /// <param name="cmd">Command对象</param>
            /// <param name="conn">Connection对象</param>
            /// <param name="trans">Transcation对象</param>
            /// <param name="cmdText">SQL Text</param>
            /// <param name="parameters">参数实例</param>
        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, params SQLiteParameter[] parameters)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            if (null != parameters && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
        }

        #endregion




    }
}