using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL.TubeService
{
   public class TubeDiService
    {
        public static TubeDiService instance;
         
      public static  TubeDiService Instance() {
            if (instance==null)
            {
                instance = new TubeDiService();
            }
            return instance;

        }

    }
}
