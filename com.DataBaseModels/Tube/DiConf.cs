using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.setting
{
   public class DiConf
    {
        private int zID;
        private string zDiName;
        private int zNameIndex;
        private string zDiAliaName;
        private bool zDiValue;

        private bool zDiEdit;
        private bool zDiShow;

        public DiConf() { }

        public int ID
        {
            get { return zID; }
            set { zID = value; }
        }

        public string DiName
        {
            get { return zDiName; }
            set { zDiName = value; }
        }

        public int NameIndex
        {
            get { return zNameIndex; }
            set { zNameIndex = value; }
        }

        public string DiAliaName
        {
            get { return zDiAliaName; }
            set { zDiAliaName = value; }
        }

        public bool DiValue
        {
            get { return zDiValue; }
            set { zDiValue = value; }
        }

        public bool DiEdit
        {
            get { return zDiEdit; }
            set { zDiEdit = value; }
        }

        public bool DiShow
        {
            get { return zDiShow; }
            set { zDiShow = value; }
        }
    }
}
