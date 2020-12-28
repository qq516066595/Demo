using com.DataBaseDAL;
using com.FunctionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDAL
{
   public class UserService
    {
        private static UserService instance;

        private UserInfo zCurUserInfo;
        public UserInfo CurUserInfo
        {
            get { return zCurUserInfo; }
        }
       
        public static UserService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserService();
                }
                return instance;
            }
        }
     
        private UserService()
        {
            zCurUserInfo = new UserInfo();
            zCurUserInfo.UserName = "";
            zCurUserInfo.NickName = "游客";
            zCurUserInfo.UserRole = 0;
            zCurUserInfo.UserRoleSimple = 0;
            zCurUserInfo.Powerscri = 0; 
        }
       
        public bool Login(UserInfo user)
        {
            UserInfo userInfoVO = UserDbRepository.Instance.GetUserInfo(user.UserName, user.Password);
            if (userInfoVO.UserName == null)
            {
                CurUserInfo.UserName = "";
                CurUserInfo.NickName = "游客";
                CurUserInfo.UserRole = 0;
                CurUserInfo.UserRoleSimple = 0;
                CurUserInfo.Powerscri = 255;
                return false;
            }
            else
            {
                CurUserInfo.UserName = userInfoVO.UserName;
                CurUserInfo.NickName = userInfoVO.NickName;
                CurUserInfo.Password = userInfoVO.Password;
                CurUserInfo.UserRole = userInfoVO.UserRole;
                CurUserInfo.UserRoleSimple = userInfoVO.UserRoleSimple;
                CurUserInfo.Powerscri = userInfoVO.Powerscri;
                return true;
            }
        } 
        public void Logout()
        {
            CurUserInfo.UserName = "";
            CurUserInfo.NickName = "";
            CurUserInfo.UserRole = 0;
            CurUserInfo.UserRoleSimple = 1;
            CurUserInfo.Powerscri = 0; 
        }

        //用户是否存在
        public bool IsUserExist(string userName)
        {
            return UserDbRepository.Instance.IsUserExist(userName);
        }
        //设备
        public bool IsMaintAllowed()
        {
            return zCurUserInfo.UserRole == 1 || zCurUserInfo.UserRole == 2 || zCurUserInfo.UserRole == 4;
        }
        //工艺
        public bool IsRecipeAllowed()
        {
            return zCurUserInfo.UserRole == 1 || zCurUserInfo.UserRole == 3;
        }
        //生产
        public bool IsLoaderAllowed()
        {
            return zCurUserInfo.UserRole == 1 || zCurUserInfo.UserRole == 2 || zCurUserInfo.UserRole == 4;
        }
        //新增用户功能
        public void AddUserInfo(UserInfo userInfoVO)
        {
            UserDbRepository.Instance.AddUserInfo(userInfoVO.UserName, userInfoVO.Password, userInfoVO.NickName, userInfoVO.UserRole);
        }
        //删除用户
        public void DelUserInfo(string userName)
        {
            UserDbRepository.Instance.DelUserInfo(userName);
        }
        //获得用户列表
        public List<UserInfo> GetUserInfoList()
        {
            return UserDbRepository.Instance.GetUserInfoList();
        }
        //修改用户信息
        public void UpdateUserInfo(UserInfo userInfo)
        {
            CurUserInfo.UserName = userInfo.UserName;
            CurUserInfo.NickName = userInfo.NickName;
            CurUserInfo.UserRoleSimple = userInfo.UserRoleSimple;
            CurUserInfo.Password = userInfo.Password;
            CurUserInfo.Powerscri = userInfo.Powerscri;
            UserDbRepository.Instance.UpdateUserInfo(CurUserInfo.UserName, CurUserInfo.Password, CurUserInfo.NickName, CurUserInfo.UserRoleSimple, CurUserInfo.Powerscri);
        }












    }
}
