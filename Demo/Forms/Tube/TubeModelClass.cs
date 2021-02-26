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
        #region 工艺设置
        public string stCurrentRecipeName;
        public bool gbHMI_Tube_Disable;
        public bool gbHMI_Recipe_Start;
        public bool gbHMI_Recipe_Hold;
        public bool gbHMI_Recipe_Finish;
        public bool gbHMI_Recipe_Abort;
        public UInt16 gnHMI_Hold_Time;

        public RecipeCtrl stCurrentRecipeCtrl;
        public Int16 giRecipe_ID;
        public Int16 giTubeRunCount;
        public bool gbProcess_Busy;
        public UInt16 gnProcessTotalTime;
        public UInt16 gnProcessWorkingTime;
        public UInt16 gnProcessRemainTime;
        public OP_MODE OP_Mode;//系统模式枚举
        public BoatInfo stTube_BoatInfo;//舟信息

        public struct RecipeCtrl
        {
            public UInt16 eName;                   //步名称
            public float nDuration;                //步总时间
            public float nWorking_Time;            //步进行时间
            public float nRemain_Time;             //步剩余时间
            public bool bFinish;                   //当前步完成
        }

        public struct BoatInfo
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr, SizeConst = 10)]
            public string ID;                    //舟托编号  
            public BoatState eBoatState;         //舟状态
            public WaferMode eWaferMode;         //硅片状态
            public Int16 iFromTubeNum;           //来自哪个管
            public Int16 iToTubeNum;             //去往哪个管
            public bool bCoolingFinish;          //冷却完成标志位
            public UInt16 nStoreTime;            //存储时间
            public UInt16 nRemainCoolTime;       //剩余冷却时间
            public bool bAlarm;                   //工位报警

        }
        public enum BoatState
        {
            DISABLE,
            NO_BOAT,
            EMPTY_BOAT,
            UNPROCESS_BOAT,
            PROCESSED_BOAT,
            PROCESSING_BOAT,
            CLEAN_BOAT,
            ERR_BOAT,
            TEST_BOAT,
            BAKE_OAR,
            BAKE_FINISH
        }
        public enum WaferMode
        {
            IDLE_MODE,
            LOAD,
            UNLOAD,
            LOAD_UNLOAD

        }
        public enum OP_MODE
        {
            NO_MODE,
            MANUAL_MODE,
            AUTO_MODE,
            AUTO_RUN_MODE,
            HALT_MODE,
            EM_MODE

        }
        #endregion

        #region 轴参数
        public BoatPushAxisParaEx AxisParaEx;
        public SV_Ctrl BoatPush_SV_Ctrl;//推舟轴控制结构体
        public SV_Para BoatPush_SV_Para;//推舟轴参数结构体
        public YV_Ctrl CloseDoor_YV_Ctrl;
        public YV_Ctrl PushpullDoor_YV_Ctrl;
        public float grHand_X_RulerPos;//推舟X轴磁栅尺位置
        public float grHand_Z_RulerPos;//推舟Z轴磁栅尺位置
        public bool gbBoatPush_Unlock;//解除联锁
        public bool gbHMI_BoatIn = com.DataBaseModels.PlcVar.Tube[com.DataBaseModels.frmID.Unit].gbHMI_BoatIn;
        public bool gbHMI_BoatOut = com.DataBaseModels.PlcVar.Tube[com.DataBaseModels.frmID.Unit].gbHMI_BoatOut;
        public bool gbHMI_OpenDoor = com.DataBaseModels.PlcVar.Tube[com.DataBaseModels.frmID.Unit].gbHMI_OpenDoor;
        public bool gbHMI_CloseDoor = com.DataBaseModels.PlcVar.Tube[com.DataBaseModels.frmID.Unit].gbHMI_CloseDoor;
        public struct BoatPushAxisParaEx
        {
            public float rBoatOut_OffsetPos;       //出舟时，根据传感器定位舟
            public float rFollow_MaxOffsetPos;     //随动最大允许的偏移距离
            public float rBoatOut_AlmOffsetPos;    //出舟时有舟位与无舟位的最大偏差          
        }
        public struct SV_Ctrl
        {
            public bool bPowerOff;
            public bool bPowerStatus;
            public bool bStandStill;
            public bool bMinPos_Reached;
            public bool bMaxPos_Reached;
            public bool bHome_Excute;
            public bool bHome_Condition;
            public bool bJogF;
            public bool bJogB;

            public bool bJogF_Condition;
            public bool bJogB_Condition;
            public bool bReset_Execute;
            public bool bStop_Execute;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 30)]
            public bool[] bAbs_Execute;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 30)]
            public bool[] bAbs_Condition;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 30)]
            public bool[] bPos_Reached;
            public float rOverride;
            public float rActPos;
            public float rActSpeed;
            public float rAct_Torque;
            public bool P_SW;
            public bool N_SW;
            public bool O_SW;
            public bool bAlarm;
            public UInt16 nErrorCode;
            public UInt16 nECT_ErrorCode;
        }
        public struct SV_Para
        {
            public UInt16 nHomeType;
            public UInt32 ID;
            public bool bHome_OK;
            public double rScaling_Factor;
            public double rPosition_Bias;
            public float rJogSpeed;
            public float rAcc;
            public float rDec;
            public float rJerk;
            public float rMaxPos;
            public float rMinPos;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 30)]
            public float[] rAbs_Pos;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 30)]
            public float[] rAbs_Speed;
            public bool bEnableT_Protect;
            public float rMax_Torque;
            public float rMin_Torque;
        }
        public struct YV_Ctrl
        {
            public bool bHMI_Out;
            public bool bHMI_Back;
            public bool bAuto_Out;
            public bool bAuto_Back;
            public bool bOut_Condition;
            public bool bBack_Condition;
            public bool bOutPos_Reached;
            public bool bBackPos_Reached;
            public bool bDI_OutPos;
            public bool bDI_BackPos;
            public bool bDO_Out;
            public bool bDO_Back;
            public bool bAlarm;
            public Int16 nErrorCode;
        }
        #endregion

        #region 流量计参数
        public MFC_Para[] stMFC_Para = new MFC_Para[12];
        public struct MFC_Para
        {
            public float rWarnDiff_Persent;                  //设定值
            public float rAlmDiff_Persent;                  //实际值       
            public UInt16 nMaxRange;                        //错误编码 
            public bool bShield;
        }
        #endregion
    }
}
