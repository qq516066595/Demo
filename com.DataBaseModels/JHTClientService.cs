using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using com.DataBaseModels;
using LaplaceCIP;
namespace com.DataBaseModels
{
    //机械手通讯交互层
    public class JHTClientService
    {
        private static JHTClientService instance;
        public static JHTClientService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JHTClientService();
                }
                return instance;
            }
        }

        private JHTClientService() {

            

        }

        public void GetInfor() { 
        }

        



    }
}
