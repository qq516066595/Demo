using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.FunctionModels
{
    public class DoConf
    {
        private int zID;               
        private string zDoName;           
        private int zNameIndex;         
        private string zDoAliaName;     
        private bool zDoShow;           

        public DoConf() { }

        public int ID
        {
            get { return zID; }
            set { zID = value; }
        }

        public string DoName
        {
            get { return zDoName; }
            set { zDoName = value; }
        }

        public int NameIndex
        {
            get { return zNameIndex; }
            set { zNameIndex = value; }
        }

        public string DoAliaName
        {
            get { return zDoAliaName; }
            set { zDoAliaName = value; }
        }

        public bool DoShow
        {
            get { return zDoShow; }
            set { zDoShow = value; }
        }

    }
}
