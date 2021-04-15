using com.DataBaseDAL;
using com.DataBaseModels.Tube.@event;
using com.FunctionModels;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.TubeServices
{
    public class TubeEventService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static TubeEventService instance;

        private TubeEventService() { }

        public static TubeEventService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeEventService();
                }
                return instance;
            }
        }
        #region<插入运行、机械手搬舟、操作记录>
        /// <summary>
        /// 插入炉管运行记录
        /// </summary>
        /// <param name="userName">用户名称 </param>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="recipeName">配方名称</param>
        /// <param name="step">步号</param>
        /// <param name="stepName">步名称</param>
        public void TubeRunAddEvent(string userName,int tubeIndex, string recipeName,int step,string stepName,string description)
        {
            string sql = "insert into TubeRunInfo (userName,tubeIndex,recipeName,step,stepName) values ('" + userName + "'"+ tubeIndex + ",'"+ recipeName + "',"+ step + ",'"+ stepName + "','" + description + "')";//描述：阀等
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql); 
        }
        /// <summary>
        /// 插入机械手搬舟记录
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <param name="description">搬舟描述</param>
        public void LoaderRunAddEvent(int tubeIndex,string userName,string description)
        {
            string sql = "insert into LoaderRunInfo (userName,description) values ('"+ userName + "','" + description + "')";
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql);
        }
        /// <summary>
        /// 插入炉管、机械手操作事件记录
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="userName">用户名称</param>
        /// <param name="description">操作描述</param>
        public void ActionEvent(int tubeIndex, string userName,string description)
        {
            string sql = "insert into  ActionEventInfo(userName,description) values ('"+ userName + "','"+ description + "')";
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql);
        }
        #endregion

        //新增舟管理信息(插入)
        public void AddBoatList(string BoatID,int ToTubeNum,string TubeRecipe,bool CleanFlag)
        {
            string sql= "insert into  BoatList(BoatID,SurvivalDays,UseCount,UseDays,ToTubeNum,TubeRecipe,CleanFlag,SBoatUseDays) values('" + BoatID + "', '"+ 1 + "', '" + 0 + "', '" + 1 + "', '" + ToTubeNum + "', '" + TubeRecipe + "', '" + false + "', '" + 1 + "')";
            SqliteHelper.Instance.ExecuteSql(6, sql);
        }
        //保存、修改舟管理信息（修改）
        public void SaveBoatList(string sql)
        {
            SqliteHelper.Instance.ExecuteSql(6, sql);
        }



        #region<查询操作记录、机械手搬舟记录>
        /// <summary>
        /// 查询炉管、机械手操作记录
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeEventViewModel> GetEventList(int tubeIndex, DateTime startDate, DateTime endDate)
        {
            List<TubeEventViewModel> eventTOs = TubeEventDbRepository.Instance.EventList(tubeIndex, startDate, endDate);
            return eventTOs;
        }
        /// <summary>
        /// 查询搬舟记录
        /// </summary>
        /// <param name="startDate">查询起始时间</param>
        /// <param name="endDate">查询结束时间</param>
        /// <returns></returns>
        public List<TubeEventViewModel> GetLoaderEventList(DateTime startDate, DateTime endDate)
        {
            List<TubeEventViewModel> eventTOs = TubeEventDbRepository.Instance.LoaderEventList(startDate, endDate);
            return eventTOs;
        }
        #endregion
    }
}
