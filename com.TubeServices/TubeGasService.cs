using com.CommunicationDAL;
using com.DataBaseModels;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.TubeServices
{

   public class TubeGasService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static TubeGasService instance;

        private TubeGasService() { }

        public static TubeGasService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TubeGasService();
                }
                return instance;
            }
        }

        public void GetGasInfo(int tubeIndex)
        { 
            PlcModels.AxisParaEx sd = new PlcModels.AxisParaEx();
            sd.bAutoCalcEnable = false;
        }



    }
}
