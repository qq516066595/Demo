using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
    public class DoConf
    {
        private string mDoName;         //输出名称
        private string mDoAliaName;     //输出别名
        private bool mDoShow;           //输出显示

        public DoConf() { }

        public string DoName
        {
            get { return mDoName; }
            set { mDoName = value; }
        }

        public string DoAliaName
        {
            get { return mDoAliaName; }
            set { mDoAliaName = value; }
        }

        public bool DoShow
        {
            get { return mDoShow; }
            set { mDoShow = value; }
        }
    }
}
