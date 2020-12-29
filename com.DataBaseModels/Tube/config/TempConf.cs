using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
   public class TempConf
    {
        private string mTempName;       //
        private string mAliaName;
        private int[] mPidValues;
        private int[] mPidEdits;
        private int[] mMaxValues;
        private int[] mMaxEdits;
        private bool mTempShow;


        public TempConf()
        {
            mPidValues = new int[6];
            mPidEdits = new int[6];
            mMaxValues = new int[2];
            mMaxEdits = new int[2];
        }

        public string TempName
        {
            get { return mTempName; }
            set { mTempName = value; }
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

        public int[] MaxValues
        {
            get { return mMaxValues; }
        }

        public int[] MaxEdits
        {
            get { return mMaxEdits; }
        }

        public bool TempShow
        {
            get { return mTempShow; }
            set { mTempShow = value; }
        }
    }
}
