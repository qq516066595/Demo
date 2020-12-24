using com.CommonHelper;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDAL.File
{
   public class TubeComFileRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeComFileRepository instance;

        private TubeComFileRepository() { }

        public static TubeComFileRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeComFileRepository();
                }
                return instance;
            }
        }

        public List<string> GetComAddr()
        {
            Properties config = new Properties("config/com.config");
            List<string> ips = new List<string>();
            ips.Add(config.get("TubeIP1"));
            ips.Add(config.get("TubeIP2"));
            ips.Add(config.get("TubeIP3"));
            ips.Add(config.get("TubeIP4"));
            ips.Add(config.get("TubeIP5"));
            return ips;
        }


        public void PutComAddr(List<string> ips)
        {
            Properties config = new Properties("config/com.config");
            config.set("TubeIP1", ips[0]);
            config.set("TubeIP2", ips[1]);
            config.set("TubeIP3", ips[3]);
            config.set("TubeIP4", ips[4]);
            config.set("TubeIP5", ips[5]); 
            config.Save();
        }

    }
}
