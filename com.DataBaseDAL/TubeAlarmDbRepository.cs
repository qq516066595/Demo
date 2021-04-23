using com.CommonHelper;
using com.DataBaseModels;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace com.DataBaseDAL
{
   public class TubeAlarmDbRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeAlarmDbRepository instance;
        private String myConnectionString = "Server=localhost;Database=RPBXT;Uid=root;Pwd=root;";

        private TubeAlarmDbRepository() { }

        public static TubeAlarmDbRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeAlarmDbRepository();
                }
                return instance;
            }
        }

        public List<TubeAlarm> GetAlarmList(int tubeIndex)
        {
             Properties config = new Properties("config/alarm.config");
             Properties configDi = new Properties("config/confT" + tubeIndex + ".properties");
            List<TubeAlarm> alarmTOs = new List<TubeAlarm>();
            string sql = "SELECT * FROM Tube_Alarm Where Tube_ID = 'Tube" + tubeIndex + "' ORDER BY Record_Timestamp DESC";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {

                connection.Open();
                MySqlDataReader myReader = null;
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    TubeAlarm alarmTO = new TubeAlarm();
                    int alrmNum = myReader.GetInt32("Alarm_Name");
                    string alarmDescription = config.get("Alarm_" + alrmNum);
                    if (alrmNum >= 2 && alrmNum <= 9)
                    {
                        alarmDescription.Replace("{1}", configDi.get("Gas" + (alrmNum - 1) + "AliaName"));
                    }
                    else if (alrmNum >= 10 && alrmNum <= 11)
                    {
                        alarmDescription.Replace("{1}", configDi.get("Ana" + (alrmNum - 9) + "AliaName"));
                    }
                    if (alrmNum >= 33 && alrmNum <= 64)
                    {
                        alarmDescription += ", Digital Input " + (alrmNum - 32) + ":" + configDi.get("Di" + (alrmNum - 32) + "AliaName");
                    }
                    alarmTO.AlarmName = myReader.GetString("Alarm_Name");
                    string alarmStatus = myReader.GetString("Alarm_Desc");
                    string q = alarmStatus == "On" ? "开始" : "结束";
                    alarmTO.AlarmDesc = "状态:" + q + ",  信息:" + alarmDescription;
                    alarmTO.AlarmTime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", myReader.GetDateTime("Record_Timestamp"));
                    alarmTOs.Add(alarmTO);

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();

                }
            }

            return alarmTOs;
        }

        public List<TubeAlarm> GetLoaderAlarmList(int loaderIndex)
        {
            List<TubeAlarm> tubeAlarm = new List<TubeAlarm>();
            return tubeAlarm;
        }

        /// <summary>
        /// 炉管报警信息查询
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeAlarm> TubeAlarmList (int tubeIndex,DateTime startDate,DateTime endDate)
        {
            List<TubeAlarm> tubeAlarmTOs = new List<TubeAlarm>();
            string sql = "select * from TubeAlarmInfo where alarmTime between '" + startDate.ToString("yyyy-MM-dd HH:MM:ss") + "' and '" + endDate.ToString("yyyy-MM-dd HH:MM:ss") + "' order by alarmTime desc";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[tubeIndex]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            TubeAlarm tubeAlarmTO = new TubeAlarm();
                            tubeAlarmTO.UserName = rdr["userName"].ToString();
                            tubeAlarmTO.AlarmDesc = rdr["description"].ToString();
                            tubeAlarmTO.AlarmTime = rdr["alarmTime"].ToString();
                            tubeAlarmTOs.Add(tubeAlarmTO);
                        }
                    }
                }
            }

            return tubeAlarmTOs;
        }
        /// <summary>
        /// 机械手报警信息查询
        /// </summary>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeAlarm> LoaderAlarmList( DateTime startDate, DateTime endDate)
        {
            List<TubeAlarm> loaderAlarmTOs = new List<TubeAlarm>();
            string sql = "select * from LoaderAlarmInfo where alarmTime between '" + startDate + "' and '" + endDate + "' order by alarmTime desc";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[6]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            TubeAlarm loaderAlarmTO = new TubeAlarm();
                            loaderAlarmTO.UserName = rdr["userName"].ToString();
                            loaderAlarmTO.AlarmDesc = rdr["description"].ToString();
                            loaderAlarmTO.AlarmTime = rdr["alarmTime"].ToString();
                            loaderAlarmTOs.Add(loaderAlarmTO);
                        }
                    }
                }
            }

            return loaderAlarmTOs;
        }
    }
}
