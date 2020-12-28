using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
   public class TubeDoComRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDoComRepository instance;

        private TubeDoComRepository() { }

        public static TubeDoComRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDoComRepository();
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
