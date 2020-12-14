using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.FunctionModels
{
    public class UserInfo
    {
        private string zUserName;        //用户名称
        private string zNickName;        //别名
        private string zPassword;        //密码
        private byte   zPowerscri;       //最高
        private int    zUserRole;        //角色
        private int    zUserRoleSimple;  //简单角色
        private bool   zUserEditAble;    //可编辑的角色

        public bool UserEditAble
        {
            get { return zUserEditAble; }
            set
            {
                zUserEditAble = value;
            }
        }

        public UserInfo()
        {
        }

        public string UserName
        {
            get { return zUserName; }
            set
            {
                zUserName = value;
            }
        }

        public string NickName
        {
            get { return zNickName; }
            set
            {
                zNickName = value;
            }
        }
        public string Password
        {
            get { return zPassword; }
            set
            {
                zPassword = value;
            }
        }
        public byte Powerscri
        {
            get { return zPowerscri; }
            set
            {
                zPowerscri = value;
            }
        }

        public int UserRoleSimple
        {
            get { return zUserRoleSimple; }
            set
            {
                zUserRoleSimple = value;
            }
        }

        public int UserRole
        {
            get { return zUserRole; }
            set
            {
                zUserRole = value;
            }
        }

    }
}
