using com.CommonHelper;
using com.FunctionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDAL.File
{
  public  class TubeDoFileRepository
    {
        private static TubeDoFileRepository instance;

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
        public List<com.FunctionModels.DoConf> GetDoConfInfos(int tubeIndex)
        {
            List<DoConf> doConfVOs = new List<DoConf>();

            com.CommonHelper.Properties config = new com.CommonHelper.Properties("config/confT" + tubeIndex + ".properties");
            for (int i = 0; i < 32; ++i)
            {
                DoConf doConfVO = new DoConf();
                doConfVO.ID = (i + 1);
                doConfVO.DoName = config.get("Do" + (i + 1) + "DoName");
                doConfVO.DoAliaName = config.get("Do" + (i + 1) + "AliaName");
                short value;
                short.TryParse(config.get("Do" + (i + 1) + "NameIndex"), out value);
                doConfVO.NameIndex = value;
                bool show;
                bool.TryParse(config.get("Do" + (i + 1) + "Show"), out show);
                doConfVO.DoShow = show;
                doConfVOs.Add(doConfVO);
            }
            return doConfVOs;
        }

        public void PutDoConfInfo(int tubeIndex, List<DoConf> doInfoVOs)
        {
            com.CommonHelper.Properties config = new com.CommonHelper.Properties("config/confT" + tubeIndex + ".properties");
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
