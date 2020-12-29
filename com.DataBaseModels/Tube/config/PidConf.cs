using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
   public class PidConf
    {
        private string mPidName;        //名称
        private int mPValue;            //值
        private int mPEdit;             //可否编辑
        private int mIValue;            
        private int mIEdit;
        private int mDValue;
        private int mDEdit;


        public PidConf() { }

        public string PidName
        {
            get { return mPidName; }
            set { mPidName = value; }
        }

        public int PValue
        {
            get { return mPValue; }
            set { mPValue = value; }
        }


        public int PEdit
        {
            get { return mPEdit; }
            set { mPEdit = value; }
        }

        public int IValue
        {
            get { return mIValue; }
            set { mIValue = value; }
        }

        public int IEdit
        {
            get { return mIEdit; }
            set { mIEdit = value; }
        }

        public int DValue
        {
            get { return mDValue; }
            set { mDValue = value; }
        }

        public int DEdit
        {
            get { return mDEdit; }
            set { mDEdit = value; }
        }
    }
}
