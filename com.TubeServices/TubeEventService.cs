using com.DataBaseDAL;
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
        /// <summary>
        /// 炉管运行记录
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
        /// 机械手搬舟记录
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <param name="description">搬舟描述</param>
        public void LoaderRunAddEvent(int tubeIndex,string userName,string description)
        {
            string sql = "insert into LoaderRunInfo (userName,description) values ('"+ userName + "','" + description + "')";
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql);
        }
        /// <summary>
        /// 操作事件记录
        /// </summary>
        /// <param name="tubeIndex">炉管ID</param>
        /// <param name="userName">用户名称</param>
        /// <param name="description">操作描述</param>
        public void ActionEvent(int tubeIndex, string userName,string description)
        {
            string sql = "insert into  ActionEventInfo(userName,description) values ('"+ userName + "','"+ description + "')";
            SqliteHelper.Instance.ExecuteSql(tubeIndex, sql);

        }

    }
}
