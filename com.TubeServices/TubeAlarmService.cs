using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.TubeServices
{
   public class TubeAlarmService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static TubeAlarmService instance;

        private TubeAlarmService() { }

        public static TubeAlarmService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeAlarmService();
                }
                return instance;
            }
        }
        /// <summary>
        /// 炉管报警记录
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="userName">用户名称</param>
        /// <param name="description">报警描述</param>
        public void TubeAlarmEvent(int tubeIndex, string userName, string description)
        {
            string sql = "insert into  TubeAlarmInfo(userName,description) values ('" + userName + "','" + description + "')";//是否需要传进来报警索引值，在本地文件寻找报警描述（或正常传描述）。
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql);
        }
        /// <summary>
        /// 机械手报警记录
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <param name="description">报警描述</param>
        public void LoaderAlarmEvent(string userName, string description)
        {
            string sql = "insert into  LoaderAlarmInfo(userName,description) values ('" + userName + "','" + description + "')";
            SqliteHelper.Instance.ExecuteSql(6, sql);
        }
    }
}
