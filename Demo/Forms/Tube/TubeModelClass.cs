using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* namespace：Demo.Forms.Tube
* className：TubeModelClass
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2021/2/3 11:28:52
* Desc：声明炉管所需变量，同时与model层变量绑定。
* 
* Remarks：
*/
namespace Demo.Forms.Tube
{
    public class TubeModelClass
    {
        private float[] tempIn;//内偶
        private float[] tempEx;//外偶
        private float[] tempMV;//功率输出
        private float[] tempSP;//过渡值
        private float[] tempSV;//设定值
        public float[] TempIn { get => tempIn; set => tempIn = value; }
        public float[] TempEx { get => tempEx; set => tempEx = value; }
        public float[] TempMV { get => tempMV; set => tempMV = value; }
        public float[] TempSP { get => tempSP; set => tempSP = value; }
        public float[] TempSV { get => tempSV; set => tempSV = value; }
       

        private float coolingPV1;//水冷1
        private float coolingPV2;//水冷2

        public float CoolingPV1 { get => coolingPV1; set => coolingPV1 = value; }
        public float CoolingPV2 { get => coolingPV2; set => coolingPV2 = value; }
    }
}
