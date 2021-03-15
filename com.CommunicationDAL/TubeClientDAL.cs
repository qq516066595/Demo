using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
   public  class TubeClientDAL
    {
        public static TubeClientDAL instance;

        public TubeClientDAL() {


        }
        public static TubeClientDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeClientDAL();
                }
                return instance;

            }
          
        }
       



    }
}
