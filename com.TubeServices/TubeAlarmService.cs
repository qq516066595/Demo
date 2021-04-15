using com.CommonHelper;
using com.DataBaseDAL;
using com.DataBaseModels;
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
        #region <插入报警记录>
        /// <summary>
        /// 炉管报警记录
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="userName">用户名称</param>
        /// <param name="description">报警描述</param>
        public void TubeAlarmEvent(int tubeIndex, string userName, string description)
        {
            Properties config = new Properties("config/alarm.config");
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
        #endregion

        #region <查询报警记录>
        /// <summary>
        /// 查询炉管报警记录集合
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeAlarm> GetTubeAlarmList(int tubeIndex, DateTime startDate, DateTime endDate)
        {
            List<TubeAlarm> alarmTOs = TubeAlarmDbRepository.Instance.TubeAlarmList(tubeIndex, startDate, endDate);
            return alarmTOs;
        }
        /// <summary>
        /// 查询机械手报警记录
        /// </summary>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeAlarm> GetLoaderAlarmList(DateTime startDate, DateTime endDate)
        {
            List<TubeAlarm> alarmTOs = TubeAlarmDbRepository.Instance.LoaderAlarmList(startDate, endDate);
            return alarmTOs;
        }
        #endregion
    }
}
