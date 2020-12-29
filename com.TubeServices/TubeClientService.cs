using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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







        private int mCurTubeIndex;
        private TubeClientService()
        {
            for (int j = 0; j < 32; ++j)
            {
                mDis.Add(false);
                mDos.Add(false);
                mEvs.Add(false);
            }
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
             
        }

        public List<bool> GetDis(int tubeIndex)
        {
            return mDis;
        }
        public List<bool> GetDos(int tubeIndex)
        {
            return mDos;
        }

        private void UpdateDate()
        {



        }



    }
}
