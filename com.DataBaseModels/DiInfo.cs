using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
   public class DiInfo
    {
        private List<string> zDiNames;
        private List<bool> zDis;

        public DiInfo()
        {
            zDiNames = new List<string>();
            zDis = new List<bool>();
        }

        public List<string> DiNames
        {
            get { return zDiNames; }
        }

        public List<bool> Dis
        {
            get { return zDis; }
        }
    }
}
