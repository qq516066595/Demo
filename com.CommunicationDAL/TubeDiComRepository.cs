using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
    //PLC交互
  public   class TubeDiComRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDiComRepository instance;

        private TubeDiComRepository() { }

        public static TubeDiComRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDiComRepository();
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
