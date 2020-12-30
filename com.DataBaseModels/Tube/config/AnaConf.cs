using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
    public class AnaConf
    {
        private string mAnaName;    //模拟量名称
        private string mAliaName;   //模拟量别名
        private string mAnaUnit;    //单位
        private int mAnaValue;      //值
        private int mAnaEdit;       //可否编辑
        private bool mAnaShow;      //是否显示

       
        public AnaConf() { }

        public string AnaName
        {
            get { return mAnaName; }
            set { mAnaName = value; }
        }

        public string AliaName
        {
            get { return mAliaName; }
            set { mAliaName = value; }
        }


        public string AnaUnit
        {
            get { return mAnaUnit; }
            set { mAnaUnit = value; }
        }

        public int AnaValue
        {
            get { return mAnaValue; }
            set { mAnaValue = value; }
        }

        public int AnaEdit
        {
            get { return mAnaEdit; }
            set { mAnaEdit = value; }
        }

        public bool AnaShow
        {
            get { return mAnaShow; }
            set { mAnaShow = value; }
        }
    }
}
