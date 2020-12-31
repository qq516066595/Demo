using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
  public  class EvConf
    {
        private string mEvName;         //电磁阀名称
        private string mEvAliaName;     //电磁阀别名
        private bool mEvShow;           //电池阀是否显示

        public EvConf() { }

        public string EvName
        {
            get { return mEvName; }
            set { mEvName = value; }
        }

        public string EvAliaName
        {
            get { return mEvAliaName; }
            set { mEvAliaName = value; }
        }

        public bool EvShow
        {
            get { return mEvShow; }
            set { mEvShow = value; }
        }
    }
}
