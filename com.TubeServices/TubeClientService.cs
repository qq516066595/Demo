using com.CommunicationModels;
using com.FunctionModels;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.TubeServices
{
    //炉管通讯交互层
   public class TubeClientService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeClientService instance;

        private List<bool> mDis = new List<bool>();
        private List<bool> mDos = new List<bool>();
        private List<bool> mEvs = new List<bool>();

        private List<string> tes =new List<string> ();


         

        private int mCurTubeIndex;
        private TubeClientService()
        {
            tes.Add("");

        }
        public static TubeClientService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeClientService();
                }
                return instance;
            }
        }

        public void SelectTube(int tubeIndex)
        {
            mCurTubeIndex = tubeIndex;
             UpdateData();
        }

        public List<bool> GetDis(int tubeIndex)
        {
            return mDis;
        }
        public List<bool> GetDos(int tubeIndex)
        {
            return mDos;
        }

        public List<string> GetAnaMeasValues(int tubeIndex)
        {
            return tes;//断点1
        }

        
        

        private Thread mUpdateDataThread;
        private bool mUpdateData;
        private bool mHoldUpdateData;
        public void StartUpdateDataServer()
        {
            mUpdateDataThread = new Thread(() =>
            {
                while (mUpdateData)
                {
                    if (!mHoldUpdateData)
                    {
                        try
                        {
                            new Thread(() =>
                            {
                                //log.Info("start update plc data");
                                UpdateData();
                                //log.Info("end update plc data");
                            }).Start();
                        }
                        catch (Exception e)
                        {
                            log.Error(e);
                        }
                    }
                    Thread.Sleep(1000);
                }
            });
            mUpdateData = true;
            mHoldUpdateData = false;
            mUpdateDataThread.IsBackground = true;
            mUpdateDataThread.Start();
        }
       LaplaceCIP.PlcOmronCip plcOmronCip = new LaplaceCIP.PlcOmronCip();
         
        private void UpdateData()
        { 
           // tes[0]= plcOmronCip.GetVariablInfo(6,PlcJhtNode.AxisParaEx[0]).ToString();

        }






        public void ResumeUpdateDataServer()
        {
            mHoldUpdateData = false;
        }

        public void PauseUpdateDataServer()
        {
            mHoldUpdateData = true;
        }

        public void StopUpdateDataServer()
        {
            mUpdateData = false;
        }


    }
}
