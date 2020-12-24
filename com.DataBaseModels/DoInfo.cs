using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
   public class DoInfo
    {
        private List<string> zDoNames;
        private List<bool> zDos;

        public DoInfo()
        {
            zDoNames = new List<string>();
            zDos = new List<bool>();
        }

        public List<string> DoNames
        {
            get { return zDoNames; }
        }

        public List<bool> Dos
        {
            get { return zDos; }
        }
    }
}
