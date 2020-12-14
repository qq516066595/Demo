using com.FunctionModels;
using FunctionDAL.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.LoaderServices
{
    public class TubeDoService
    {
        private static TubeDoService instance;

        private TubeDoService() { }

        public static TubeDoService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDoService();
                }
                return instance;
            }
        }


        public void PutDoConfInfo(int tubeIndex, List<DoConf> doConfVOs)
        {
            List<DoConf> doConfPOs = new List<DoConf>();
            for (int i = 0; i < doConfVOs.Count; ++i)
            {
                DoConf doConfPO = new DoConf();
                doConfPO.DoName = doConfVOs[i].DoName;
                doConfPO.NameIndex = doConfVOs[i].NameIndex;
                doConfPO.DoAliaName = doConfVOs[i].DoAliaName;
                doConfPO.DoShow = doConfVOs[i].DoShow;
                doConfPOs.Add(doConfPO);
            }
            TubeDoFileRepository.Instance.PutDoConfInfo(tubeIndex, doConfPOs);
        }


    }
}
