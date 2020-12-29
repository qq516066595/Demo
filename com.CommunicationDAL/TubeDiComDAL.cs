using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
    //PLC交互
  public   class TubeDiComDAL
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDiComDAL instance;

        private TubeDiComDAL() { }

        public static TubeDiComDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDiComDAL();
                }
                return instance;
            }
        }

        public List<bool> GetDiConfValues(int tubeIndex)
        {
            return null;
        }

        public void PutDiConfValues(int tubeIndex, List<bool> diConfValues)
        {


        }


   }
}
