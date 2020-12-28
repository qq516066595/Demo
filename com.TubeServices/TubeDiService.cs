using com.CommunicationDAL;
using com.DataBaseModels.Tube.setting;
using com.FunctionModels;
using FunctionDAL.File;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.TubeServices
{
    public class TubeDiService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeDiService instance;

        private TubeDiService() { }

        public static TubeDiService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeDiService();
                }
                return instance;
            }
        }

        public List<bool> GetDis(int tubeIndex)
        {
            //List<bool> dis = TubeDiComRepository.Instance.GetDis(tubeIndex);
            List<bool> dis = TubeClientService.Instance.GetDis(tubeIndex);
            return dis;
        }


        public List<DiConf> GetDiConfInfos(int tubeIndex, bool com)
        {
            List<DiConf> diConfVOs = new List<DiConf>();
            List<DiConf> diInfoPOs = TubeDiFileRepository.Instance.GetDiConfInfos(tubeIndex);
            for (int i = 0; i < 32; ++i)
            {
                DiConf diConfVO = new DiConf();
                diConfVO.ID = diInfoPOs[i].ID;
                diConfVO.DiName = diInfoPOs[i].DiName;
                diConfVO.NameIndex = diInfoPOs[i].NameIndex;
                diConfVO.DiAliaName = diInfoPOs[i].DiAliaName;
                diConfVO.DiEdit = diInfoPOs[i].DiValue;
                diConfVO.DiShow = diInfoPOs[i].DiShow;

                diConfVOs.Add(diConfVO);
            }
             
            return diConfVOs;
        }

        public void PutDiConfInfo(int tubeIndex, List<DiConf> diConfVOs, bool serverUpdate = true)
        {
            List<DiConf> diConfPOs = new List<DiConf>();
            List<bool> diCOnfValues = new List<bool>();
            for (int i = 0; i < diConfVOs.Count; ++i)
            {
                DiConf diConfPO = new DiConf();
                diConfPO.DiName = diConfVOs[i].DiName;
                diConfPO.NameIndex = diConfVOs[i].NameIndex;
                diConfPO.DiAliaName = diConfVOs[i].DiAliaName;
                diConfPO.DiValue = diConfVOs[i].DiEdit;
                diCOnfValues.Add(diConfVOs[i].DiValue);
                diConfPO.DiShow = diConfVOs[i].DiShow;
                diConfPOs.Add(diConfPO);
            }
            TubeDiFileRepository.Instance.PutDiConfInfo(tubeIndex, diConfPOs);
            if (serverUpdate)
            {
                TubeDiComRepository.Instance.PutDiConfValues(tubeIndex, diCOnfValues);
            }

        }

        public void SynDiConfInfo(int tubeIndex)
        {
            List<DiConf> diConfVOs = GetDiConfInfos(tubeIndex, true);
            List<DiConf> diInfoPOs = TubeDiFileRepository.Instance.GetDiConfInfos(tubeIndex);
            for (int i = 0; i < diConfVOs.Count; ++i)
            {
                diInfoPOs[i].DiValue = diConfVOs[i].DiValue;
            }
            TubeDiFileRepository.Instance.PutDiConfInfo(tubeIndex, diInfoPOs);
        }
    }
}
