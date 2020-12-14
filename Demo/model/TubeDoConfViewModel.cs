using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.model
{
   public  class TubeDoConfViewModel:ViewModel
    {
        private int mTubeIndex;

        private int mID;
        private string mDoName;
        private string mDoAliaName;
        private int mNameIndex;
        private bool mDoShow;

        public TubeDoConfViewModel(int id)
        {
            mID = id;
        }


        public int ID
        {
            get { return mID; }
            set
            {
                mID = value;
                Notify("ID");
            }
        }

        public int TubeIndex
        {
            get { return mTubeIndex; }
            set
            {
                mTubeIndex = value;
                Notify("TubeIndex");
            }
        }

        public int NameIndex
        {
            get { return mNameIndex; }
            set
            {
                mNameIndex = value;
                Notify("NameIndex");
            }
        }

        public string DoName
        {
            get { return mDoName; }
            set
            {
                mDoName = value;
                Notify("DoName");
            }
        }

        public string DoAliaName
        {
            get { return mDoAliaName; }
            set
            {
                mDoAliaName = value;
                Notify("DoAliaName");
            }
        }

        public bool DoShow
        {
            get { return mDoShow; }
            set
            {
                mDoShow = value;
                Notify("DoShow");
            }
        }
    }
}
