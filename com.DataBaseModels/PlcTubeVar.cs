using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    public class PlcTubeVar
    {
        public static PlcModels.TubeErr stTubeAlm;
        public static PlcModels.TubeErr stTubeWarn;
        public static PlcModels.TubeErr stTubeCaution;
        public static bool gbHMI_OpenDoor;
        public static bool gbHMI_CloseDoor;
        public static bool gbHMI_BoatIn;
        public static bool gbHMI_BoatOut;
        public static string[] gsVersion = new string[32];//软件版本号
        public static bool gbLicense_OK;//注册ok标志位
        public static Int32 giSN;//PLC序列号
        public static Int32 giLicense_Code;//PLC注册码
        public static bool gbHMI_Tube_Disable;
        public static bool gbHMI_Recipe_Start;
        public static bool gbHMI_Recipe_Hold;
        public static bool gbHMI_Recipe_Finish;
        public static bool gbHMI_Recipe_Abort;
        public static UInt16 gnHMI_Hold_Time;
        
        public static PlcModels.RecipePara[] stRecipePara = new PlcModels.RecipePara[46];
        public static PlcModels.RecipeCtrl stCurrentRecipeCtrl;
        public static Int16 giRecipe_ID;
        public static Int16 giTubeRunCount;
        public static bool gbProcess_Busy;
        public static UInt16 gnProcessTotalTime;
        public static UInt16 gnProcessWorkingTime;
        public static UInt16 gnProcessRemainTime;
        public static PlcModels.OP_MODE OP_Mode;//系统模式枚举
        public static PlcModels.OP_Cmd OP_Cmd;//系统模式操作
        public static PlcModels.BoatInfo stTube_BoatInfo;//舟信息

        public static bool gbProcess_InitStart;
        public static bool gbProcess_InitDone;
        public static bool gbBoatPush_InitStart;
        public static bool gbBoatPush_InitDone;
        public static bool gbBoatPush_Unlock;

        public static bool gbTubeDoor_Close;
        public static float grBoatOut_TouchPos;
        public static PlcModels.BoatPushAxisParaEx AxisParaEx;
        public static PlcModels.SV_Ctrl BoatPush_SV_Ctrl;//推舟轴控制结构体
        public static PlcModels.SV_Para BoatPush_SV_Para;//推舟轴参数结构体
        public static PlcModels.YV_Ctrl CloseDoor_YV_Ctrl;
        public static PlcModels.YV_Ctrl PushpullDoor_YV_Ctrl;
        public static PlcModels.Comm_from_Tube stComm_from_Tube;
        public static PlcModels.Comm_to_Tube stComm_to_Tube;
        public static float grHMI_TempSV;
        public static float grHMI_TempRump;
        public static bool gbHMI_Temp_Enable;
        public static float grTubeTail_Temp;
        public static PlcModels.TempZone[] stTempZone = new PlcModels.TempZone[8];
        public static PlcModels.HeatModelPara stTempPara;
        public static float grTube_ActPressure;
        public static float grActLeakRate;
        public static bool gbHMI_LeakCheck;
        public static PlcModels.Pump_Para stPump_Para;
        public static PlcModels.Pump_Ctrl stPump_Ctrl;
        
        public static bool gbValve_Unlock;
        public PlcModels.MFC_Para[] stMFC_Para = new PlcModels.MFC_Para[12];
        public static PlcModels.MFC_Value[] stMFC_Value = new PlcModels.MFC_Value[12];
        public static PlcModels.Valve_Ctrl[] stValve_Ctrl = new PlcModels.Valve_Ctrl[24];
        public static float grButterFly_ActPos;

    }
}
