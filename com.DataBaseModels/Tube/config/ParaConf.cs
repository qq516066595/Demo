using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.config
{
  public class ParaConf
    {
        private string mParaName;       //参数名
        private double mParaValue;      //参数值
        private double mParaEdit;       //是否可编辑参数

        public ParaConf() { }

        public string ParaName
        {
            get { return mParaName; }
            set { mParaName = value; }
        }

        public double ParaValue
        {
            get { return mParaValue; }
            set { mParaValue = value; }
        }

        public double ParaEdit
        {
            get { return mParaEdit; }
            set { mParaEdit = value; }
        }
    }
}
