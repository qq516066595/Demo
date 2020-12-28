using com.CommunicationDAL;
using com.FunctionModels;
using com.TubeServices;
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
        public List<bool> GetDos(int tubeIndex)
        {
            //List<bool> dos = TubeDoComRepository.Instance.GetDos(tubeIndex);
            List<bool> dos = TubeClientService.Instance.GetDos(tubeIndex);
            return dos;
        }

        public List<DoConf> GetDoConfInfos(int tubeIndex)
        {
            List<DoConf> doConfs = new List<DoConf>();
            List<DoConf> doInfoPOs = TubeDoFileRepository.Instance.GetDoConfInfos(tubeIndex);
            for (int i = 0; i < doInfoPOs.Count; ++i)
            {
                DoConf doConf = new DoConf();
                doConf.ID = doInfoPOs[i].ID;
                doConf.DoName = doInfoPOs[i].DoName;
                doConf.NameIndex = doInfoPOs[i].NameIndex;
                doConf.DoAliaName = doInfoPOs[i].DoAliaName;
                doConf.DoShow = doInfoPOs[i].DoShow;
                doConfs.Add(doConf);
            }
            return doConfs;
        }

        public void PutDos(int tubeIndex, List<bool> dos)
        {
            List<bool> tdos = new List<bool>();
            for (int i = 0; i < dos.Count; ++i)
            {
                tdos.Add(dos[i]);
            }
            TubeDoComRepository.Instance.PutDos(tubeIndex, tdos);
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
