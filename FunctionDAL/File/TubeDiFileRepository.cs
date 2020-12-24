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
  public  class TubeDiFileRepository
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDiFileRepository instance;

        private TubeDiFileRepository() { }

        public static TubeDiFileRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDiFileRepository();
                }
                return instance;
            }
        }

        public List<DiConf> GetDiConfInfos(int tubeIndex)
        {
            List<DiConf> diConfVOs = new List<DiConf>();

            Properties config = new Properties("config/confT" + tubeIndex + ".properties");
            for (int i = 0; i < 32; ++i)
            {
                DiConf diConfVO = new DiConf();
                diConfVO.ID = (i + 1);
                diConfVO.DiName = config.get("Di" + (i + 1) + "DiName");
                diConfVO.DiAliaName = config.get("Di" + (i + 1) + "AliaName");
                short value;
                short.TryParse(config.get("Di" + (i + 1) + "NameIndex"), out value);
                diConfVO.NameIndex = value;
                bool critical;
                bool.TryParse(config.get("Di" + (i + 1) + "Critical"), out critical);
                diConfVO.DiValue = critical;
                bool show;
                bool.TryParse(config.get("Di" + (i + 1) + "Show"), out show);
                diConfVO.DiShow = show;
                diConfVOs.Add(diConfVO);
            }
            return diConfVOs;
        }

        public void PutDiConfInfo(int tubeIndex, List<DiConf> diInfoVOs)
        {
           Properties config = new Properties("config/confT" + tubeIndex + ".properties");
            if (diInfoVOs != null)
            {
                for (int i = 0; i < diInfoVOs.Count; ++i)
                {
                    config.set("Di" + (i + 1) + "DiName", diInfoVOs[i].DiName);
                    config.set("Di" + (i + 1) + "NameIndex", diInfoVOs[i].NameIndex);
                    config.set("Di" + (i + 1) + "AliaName", diInfoVOs[i].DiAliaName);
                    config.set("Di" + (i + 1) + "Critical", diInfoVOs[i].DiValue);
                    config.set("Di" + (i + 1) + "Show", diInfoVOs[i].DiShow);
                }
            }

            config.Save();
        }



    }
}
