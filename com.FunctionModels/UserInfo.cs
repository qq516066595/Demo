using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.FunctionModels
{
    public class UserInfo
    {
        private string zUserName;
        private string zNickName;
        private string zPassword;
        private byte zPowerscri;
        private int zUserRole;
        private int zUserRoleSimple;
        private bool zUserEditAble;

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
