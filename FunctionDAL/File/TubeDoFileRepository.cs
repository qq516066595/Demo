using com.CommonHelper;
using com.FunctionModels;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDAL.File
{
    public class TubeDoFileRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDoFileRepository instance;

        private TubeDoFileRepository() { }

        public static TubeDoFileRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDoFileRepository();
                }
                return instance;
            }
        }

        public List<DoConf> GetDoConfInfos(int tubeIndex)
        {
            List<DoConf> doConfs = new List<DoConf>();

            Properties config = new Properties("config/confT" + tubeIndex + ".properties");
            for (int i = 0; i < 32; ++i)
            {
                DoConf doConf = new DoConf();
                doConf.ID = (i + 1);
                doConf.DoName = config.get("Do" + (i + 1) + "DoName");
                doConf.DoAliaName = config.get("Do" + (i + 1) + "AliaName");
                short value;
                short.TryParse(config.get("Do" + (i + 1) + "NameIndex"), out value);
                doConf.NameIndex = value;
                bool show;
                bool.TryParse(config.get("Do" + (i + 1) + "Show"), out show);
                doConf.DoShow = show;
                doConfs.Add(doConf);
            }
            return doConfs;
        }

        public void PutDoConfInfo(int tubeIndex, List<DoConf> doInfoVOs)
        {
           Properties config = new Properties("config/confT" + tubeIndex + ".properties");
            if (doInfoVOs != null)
            {
                for (int i = 0; i < doInfoVOs.Count; ++i)
                {
                    config.set("Do" + (i + 1) + "DoName", doInfoVOs[i].DoName);
                    config.set("Do" + (i + 1) + "NameIndex", doInfoVOs[i].NameIndex);
                    config.set("Do" + (i + 1) + "AliaName", doInfoVOs[i].DoAliaName);
                    config.set("Do" + (i + 1) + "Show", doInfoVOs[i].DoShow);
                }
            }

            config.Save();
        }












    }
}
