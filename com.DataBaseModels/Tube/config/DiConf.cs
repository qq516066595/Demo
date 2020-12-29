using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
   public class DiConf
    {
        private string mDiName;         //输入名称
        private string mDiAliaName;     //输入别名
        private bool mDiValue;          //输入值
        private bool mDiEdit;           //可否编辑
        private bool mDiShow;           //是否显示
                                        
        public DiConf() { }

        public string DiName
        {
            get { return mDiName; }
            set { mDiName = value; }
        }

        public string DiAliaName
        {
            get { return mDiAliaName; }
            set { mDiAliaName = value; }
        }

        public bool DiValue
        {
            get { return mDiValue; }
            set { mDiValue = value; }
        }

        public bool DiEdit
        {
            get { return mDiEdit; }
            set { mDiEdit = value; }
        }

        public bool DiShow
        {
            get { return mDiShow; }
            set { mDiShow = value; }
        }
    }
}
