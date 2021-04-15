using com.DataBaseModels.Tube.@event;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseDAL
{
    public class TubeEventDbRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeEventDbRepository instance;

        private TubeEventDbRepository() { }

        public static TubeEventDbRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeEventDbRepository();
                }
                return instance;
            }
        }
        /// <summary>
        /// 查询炉管、机械手操作事件信息
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeEventViewModel> EventList(int tubeIndex, DateTime startDate, DateTime endDate)
        {
            List<TubeEventViewModel> tubeEventTOs = new List<TubeEventViewModel>();
            string sql = "select * from ActionEventInfo where alarmTime between '" + startDate + "' and '" + endDate + "' order by alarmTime desc";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[tubeIndex]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            TubeEventViewModel tubeEventTO = new TubeEventViewModel();
                            tubeEventTO.EventName = rdr["userName"].ToString();
                            tubeEventTO.EventDesc = rdr["description"].ToString();
                            tubeEventTO.EventTime = rdr["eventTime"].ToString();
                            tubeEventTOs.Add(tubeEventTO);
                        }
                    }
                }
            }

            return tubeEventTOs;
        }


        /// <summary>
        /// 查询机械手搬舟信息记录
        /// </summary>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeEventViewModel> LoaderEventList(DateTime startDate, DateTime endDate)
        {
            List<TubeEventViewModel> loaderEventTOs = new List<TubeEventViewModel>();
            string sql = "select * from LoaderRunInfo where alarmTime between '" + startDate + "' and '" + endDate + "' order by alarmTime desc";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[6]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            TubeEventViewModel loaderEventTO = new TubeEventViewModel();
                            loaderEventTO.EventName = rdr["userName"].ToString();
                            loaderEventTO.EventDesc = rdr["description"].ToString();
                            loaderEventTO.EventTime = rdr["eventTime"].ToString();
                            loaderEventTOs.Add(loaderEventTO);
                        }
                    }
                }
            }

            return loaderEventTOs;
        }
    }
}
