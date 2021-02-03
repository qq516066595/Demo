using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    public class PlcTubeVar
    {
        public  PlcModels.TubeErr stTubeAlm;
        public  PlcModels.TubeErr stTubeWarn;
        public  PlcModels.TubeErr stTubeCaution;
        public  bool gbHMI_OpenDoor;
        public  bool gbHMI_CloseDoor;
        public  bool gbHMI_BoatIn;
        public  bool gbHMI_BoatOut;
        public  string[] gsVersion = new string[32];//软件版本号
        public  bool gbLicense_OK;//注册ok标志位
        public  Int32 giSN;//PLC序列号
        public  Int32 giLicense_Code;//PLC注册码
        public  bool gbHMI_Tube_Disable;
        public  bool gbHMI_Recipe_Start;
        public  bool gbHMI_Recipe_Hold;
        public  bool gbHMI_Recipe_Finish;
        public  bool gbHMI_Recipe_Abort;
        public  UInt16 gnHMI_Hold_Time;
        
        public  PlcModels.RecipePara[] stRecipePara = new PlcModels.RecipePara[46];
        public  PlcModels.RecipeCtrl stCurrentRecipeCtrl;
        public  Int16 giRecipe_ID;
        public  Int16 giTubeRunCount;
        public  bool gbProcess_Busy;
        public  UInt16 gnProcessTotalTime;
        public  UInt16 gnProcessWorkingTime;
        public  UInt16 gnProcessRemainTime;
        public  PlcModels.OP_MODE OP_Mode;//系统模式枚举
        public  PlcModels.OP_Cmd OP_Cmd;//系统模式操作
        public  PlcModels.BoatInfo stTube_BoatInfo;//舟信息

        public  bool gbProcess_InitStart;
        public  bool gbProcess_InitDone;
        public  bool gbBoatPush_InitStart;
        public  bool gbBoatPush_InitDone;
        public  bool gbBoatPush_Unlock;

        public  bool gbTubeDoor_Close;
        public  float grBoatOut_TouchPos;
        public  PlcModels.BoatPushAxisParaEx AxisParaEx;
        public  PlcModels.SV_Ctrl BoatPush_SV_Ctrl;//推舟轴控制结构体
        public  PlcModels.SV_Para BoatPush_SV_Para;//推舟轴参数结构体
        public  PlcModels.YV_Ctrl CloseDoor_YV_Ctrl;
        public  PlcModels.YV_Ctrl PushpullDoor_YV_Ctrl;
        public  PlcModels.Comm_from_Tube stComm_from_Tube;
        public  PlcModels.Comm_to_Tube stComm_to_Tube;
        public  float grHMI_TempSV;
        public  float grHMI_TempRump;
        public  bool gbHMI_Temp_Enable;
        public  float grTubeTail_Temp;
        public  PlcModels.TempZone[] stTempZone = new PlcModels.TempZone[8];
        public  PlcModels.HeatModelPara stTempPara;
        public  float grTube_ActPressure;
        public  float grActLeakRate;
        public  bool gbHMI_LeakCheck;
        public  PlcModels.Pump_Para stPump_Para;
        public  PlcModels.Pump_Ctrl stPump_Ctrl;
        
        public  bool gbValve_Unlock;
        public  PlcModels.MFC_Para[] stMFC_Para = new PlcModels.MFC_Para[12];
        public  PlcModels.MFC_Value[] stMFC_Value = new PlcModels.MFC_Value[12];
        public  PlcModels.Valve_Ctrl[] stValve_Ctrl = new PlcModels.Valve_Ctrl[24];
        public  float grButterFly_ActPos;

    }
}
