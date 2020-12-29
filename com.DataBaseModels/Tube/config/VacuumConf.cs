using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
   public class VacuumConf
    {
        private string mVacuumName;     //名称
        private string mAliaName;       //别名
        private int[] mPidValues;       //值
        private int[] mPidEdits;        //可否编辑
        private int mMaxValue;          //最大值
        private int mMaxEdit;           //最大值编辑
        private bool mVacuumShow;       //显示


        public VacuumConf()
        {
            mPidValues = new int[3];
            mPidEdits = new int[3];
        }

        public string VacuumName
        {
            get { return mVacuumName; }
            set { mVacuumName = value; }
        }

        public string AliaName
        {
            get { return mAliaName; }
            set { mAliaName = value; }
        }

        public int[] PidValues
        {
            get { return mPidValues; }
        }

        public int[] PidEdits
        {
            get { return mPidEdits; }
        }

        public int MaxValue
        {
            get { return mMaxValue; }
            set { mMaxValue = value; }
        }

        public bool VacuumShow
        {
            get { return mVacuumShow; }
            set { mVacuumShow = value; }
        }
    }
}
