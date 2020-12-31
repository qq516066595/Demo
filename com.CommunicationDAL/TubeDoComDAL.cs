using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
   public class TubeDoComDAL
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDoComDAL instance;

        private TubeDoComDAL() { }

        public static TubeDoComDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDoComDAL();
                }
                return instance;
            }
        }

        public List<bool> GetDos(int tubeIndex)
        {

            return null;
        }

        public void PutDos(int tubeIndex, List<bool> dos)
        {
           
        }
    }
}
