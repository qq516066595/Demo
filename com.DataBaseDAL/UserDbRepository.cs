using com.DataBaseModels;
using com.FunctionModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseDAL
{
    public class UserDbRepository
    {
        private static UserDbRepository instance;
        private UserDbRepository() { }

        public static UserDbRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDbRepository();
                }
                return instance;
            }
        }

        public UserInfo GetUserInfo(string userName, string password)
        {
            UserInfo userInfoVO = new UserInfo();
            string sql = "select * from user where user_name = '" + userName + "' and password = '" + password + "'";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[0]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            userInfoVO.UserName = rdr["user_name"].ToString();
                            userInfoVO.NickName = rdr["nick_name"].ToString();
                            userInfoVO.Password = rdr["password"].ToString();

                            userInfoVO.UserRole = int.Parse(rdr["user_role"].ToString() == "" ? "-1" : rdr["user_role"].ToString());
                            string user_role_simple = rdr["user_role_simple"].ToString();
                            userInfoVO.UserRoleSimple = int.Parse(user_role_simple == "" ? "-1" : user_role_simple);
                            string powerscr = rdr["powerscr"].ToString();
                            userInfoVO.Powerscri = byte.Parse(powerscr == "" ? "0" : powerscr);
                            //userInfoVO.Powerscri = byte.Parse("-1");
                        }
                    }
                }
            }
            return userInfoVO;
        }


        public bool IsUserExist(string userName)
        {
            bool exist = false;
            string sql = "select * from user where user_name = '" + userName + "'";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[0]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            exist = true;
                            break;
                        }
                    }
                }
            }

            return exist;
        }

        public List<UserInfo> GetUserInfoList()
        {
            List<UserInfo> userInfoVOs = new List<UserInfo>();
            string sql = "select * from user ";
            using (SQLiteConnection c = new SQLiteConnection(SqliteHelper.Instance.connectionStrings[0]))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            UserInfo userInfoVO = new UserInfo();
                            userInfoVO.UserName = rdr["user_name"].ToString();
                            userInfoVO.NickName = rdr["nick_name"].ToString();
                            userInfoVO.Password = rdr["password"].ToString();

                            string user_role = rdr["user_role"].ToString();
                            userInfoVO.UserRole = int.Parse(user_role == "" ? "-1" : user_role);
                            string user_role_simple = rdr["user_role_simple"].ToString();
                            userInfoVO.UserRoleSimple = int.Parse(user_role_simple == "" ? "-1" : user_role_simple);
                            string powerscr = rdr["powerscr"].ToString();
                            userInfoVO.Powerscri = byte.Parse(powerscr == "" ? "0" : powerscr);
                            userInfoVOs.Add(userInfoVO);
                        }
                    }
                }
            }

            return userInfoVOs;
        }

        public void AddUserInfo(string userName, string password, string nickName, int userRole)
        {
            string sql = "insert into user(user_name, nick_name, password, user_role) values('" + userName + "', '" + nickName + "', '" + password + "', " + userRole + ")";
            SqliteHelper.Instance.ExecuteSql(0, sql);
        }

        public void DelUserInfo(string userName)
        {
            string sql = "delete from user where user_name = '" + userName + "'";
            SqliteHelper.Instance.ExecuteSql(0, sql);
        }

        public  void UpdateUserInfo(string userName, string password, string nickName, int userRoleSimple, byte ValueOfRight)
        {
         

            //string sql = "update user set nick_name = '" + nickName + "', password = '" + password + "', powerscr = '" + ValueOfRight.ToString() + "' where user_name='" + userName  + "'";
            string sql = "";
            if (password != "")
            {
                sql = string.Format("replace into user (user_name,nick_name,password,user_role_simple,powerscr) values ('{0}','{1}','{2}',{3},{4})", userName, nickName, password, userRoleSimple.ToString(), ValueOfRight.ToString());
            }
            else
            {
                sql = string.Format("replace into user (user_name,nick_name,user_role_simple,powerscr) values ('{0}','{1}',{2},{3})", userName, nickName, userRoleSimple.ToString(), ValueOfRight.ToString());
            }
            SqliteHelper.Instance.ExecuteSql(0, sql);
            


         






        }

 




    }
}
