using com.CommonHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace com.DataBaseModels
{
    public class PlcModels
    {
        private static PlcModels instance;

        public static PlcModels Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlcModels();
                }
                return instance;
            }
        }

        private static string TableHead(int index)
        {
            string[] ss = new string[61];
            string a = "";
            ss[0] = "步名称";
            ss[1] = "条件使能";
            ss[2] = "步时间";

            ss[3] = "温区1";
            ss[4] = "温区2";
            ss[5] = "温区3";
            ss[6] = "温区4";
            ss[7] = "温区5";
            ss[8] = "温区6";
            ss[9] = "温区7";
            ss[10] = "温区8";
            ss[11] = "温度斜率";

            ss[12] = "压力(mTorr)";
            ss[13] = "漏率(/min)";

            ss[14] = "MFC1";
            ss[15] = "MFC2";
            ss[16] = "MFC3";
            ss[17] = "MFC4";
            ss[18] = "MFC5";
            ss[19] = "MFC6";
            ss[20] = "MFC7";
            ss[21] = "MFC8";
            ss[22] = "MFC9";
            ss[23] = "MFC10";
            ss[24] = "MFC11";
            ss[25] = "MFC12";
            ss[26] = "流量监控";
            ss[27] = "温度监控";
            ss[28] = "压力监控";
            for (int i = 29; i <= 61; i++)
            {
                ss[i] = "V" + Convert.ToString(i);
            }
            for (int i = 0; i <= 61; i++)
            {
                a = a + ss[i] + ",";
            }

            return a;

        }

        #region 炉管结构体定义
        //******************配方结构体************************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct RecipePara
        {

            public int eName;                //配方步名称
            public bool bCondition_Check;    //条件判断使能
            public UInt16 nDuration;         //工艺段总时间
            public UInt16 nTempZone1_SV;     //温度1设定温度
            public UInt16 nTempZone2_SV;     //温度2设定温度
            public UInt16 nTempZone3_SV;     //温度3设定温度
            public UInt16 nTempZone4_SV;     //温度4设定温度
            public UInt16 nTempZone5_SV;     //温度5设定温度
            public UInt16 nTempZone6_SV;     //温度6设定温度
            public UInt16 nTempZone7_SV;     //温度7设定温度
            public UInt16 nTempZone8_SV;     //温度7设定温度
            public bool bTempRump_Enable;    //斜率有效
            public float rSetPressure;      //炉管设定压力
            public float rLeakRateLimit;    //真空漏率

            public UInt16 nMFC1_SV;
            public UInt16 nMFC2_SV;
            public UInt16 nMFC3_SV;
            public UInt16 nMFC4_SV;
            public UInt16 nMFC5_SV;
            public UInt16 nMFC6_SV;
            public UInt16 nMFC7_SV;
            public UInt16 nMFC8_SV;
            public UInt16 nMFC9_SV;
            public UInt16 nMFC10_SV;
            public UInt16 nMFC11_SV;
            public UInt16 nMFC12_SV;


            public bool bTemp_Check;     //温度监控
            public bool bFlow_Check;     //流量监控
            public bool bPressure_Check; //压力监控 

            public UInt32 nOpen_Valve;//32位，每一位代表一个阀
            public int Loop_Counter;
            public int Loop_Start_Step;
        }
        //public static stRecipePara[] stRecipeArray = new stRecipePara[45];
        //****************当前工艺控制****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct RecipeCtrl
        {
            public UInt16 eName;                   //步名称
            public float nDuration;                //步总时间
            public float nWorking_Time;            //步进行时间
            public float nRemain_Time;             //步剩余时间
            public bool bFinish;                   //当前步完成
        }
        //******************温区结构体************************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct TempZone
        {
            public float rInternal_Temp;            //内偶温度
            public float rExternal_Temp;            //外偶温度
            public float rMV;                       //输出功率
            public float rTarget_Temp;              //目标温度
            public float rCurrent_SV;               //当前设定温度
            public float rRump;                     //斜率

        }
        //public stTempZone[] stTempZoneArray = new stTempZone[8];
        //****************推舟伺服扩展轴参数结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BoatPushAxisParaEx
        {
            public float rBoatOut_OffsetPos;       //出舟时，根据传感器定位舟
            public float rFollow_MaxOffsetPos;     //随动最大允许的偏移距离
            public float rBoatOut_AlmOffsetPos;    //出舟时有舟位与无舟位的最大偏差          
        }

        //炉管和机械手通讯
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Comm_from_Tube
        {
            public byte iHeartBeat;         //心跳位
            public bool bOar_atPickPos;    //桨在取放位置
            public bool bTakeBoatReq;      //炉管请求取舟
            public bool bLayBoatReq;       //炉管请求放舟

        }
        //机械手和炉管通讯
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Comm_to_Tube
        {
            public byte iHeartBeat;         //心跳位
            public bool bHand_atSafePos;    //机械手在安全位置
            public bool bTube_has_Task;     //炉管正在执行搬舟任务
            public bool bTakeBoat_Finish;   //机械手向炉管取舟完成
            public bool bLayBoat_Finish;    //机械手向炉管放舟完成
        }

        //报警结构体
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct TubeErr
        {
            public UInt32 nSys;
            public UInt32 nProcess;
            public UInt32 nBoatPush1;
            public UInt32 nBoatPush2;
            public UInt32 nHeat1;
            public UInt32 nHeat2;
            public UInt32 nVacumm1;
            public UInt32 nVacumm2;
            public UInt32 nGas1;
            public UInt32 nGas2;
            
        }
        

            #endregion ------------------------------炉管结构体定义---------------------------------------

        #region 机械手结构体定义
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
        public enum StationMode
        {
            COOL_BOAT,
            HEAT_BOAT
        }
        //****************舟信息结构体****************
        // [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BoatInfo
        {
            [MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]
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
        
        //[Serializable]
       // [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct StationPara
        {
            public UInt16 nSetCoolTime;      //设定冷却时间
            public StationMode eStationMode; //工位状态，冷舟，热舟
            public bool bSheild;            //工位屏蔽
           
        }
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BoatList
        {
            [MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]
            public string ID;
            public Int16 iToTubeNum;     //去往哪个管
            public bool bCleanFlag;

        }
        public struct mydemo
        {
            [MarshalAs(UnmanagedType.LPStr, SizeConst = 21)]
            public string str1;
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 20)]
            public byte[] by;
        }
        //****************机械手轴扩展参数结构体****************
        public struct HandAxisParaEx
        {
            public float rHand_X_FastV;//X轴快速设定速度
            public float rHand_X_SlowV;//X轴慢速设定速度
            public float rHand_X_FastAcc;//X轴快速设定加速度
            public float rHand_X_SlowAcc;//X轴慢速设定加速度

            public float rHand_Z_Mid_FastV;//夹爪在通道位，Z轴快速设定速度
            public float rHand_Z_Mid_SlowV;//夹爪在通道位，Z轴慢速设定速度
            public float rHand_Z_Side_SlowV;//X轴在侧边，Z轴运行速度
            public float rHand_Z_FastAcc;//Z轴快速设定加速度
            public float rHand_Z_SlowAcc;//Z轴慢速设定加速度

            public float rConveyer_JogFastV;//输送机快速点动速度
            public float rConveyer_JogSlowV;//输送机慢速点动速度

            public float rTakeTube_CheckOffsetPos;//从管取舟时，相对于下位的位置偏移
            public float rLayTube_CheckOffsetPos;//向管放舟时，相对于上位的位置偏移
            public float rTakeBuff_CheckOffsetPos;//从缓存取舟时，相对于下位的位置偏移
            public float rLayBuff_CheckOffsetPos;//向缓存放舟时，相对于上位的位置偏移

            public float rRuler_Ratio;//磁栅尺分辨率
            public float rEnc_Ruler_MaxDiff;//编码器与磁栅尺的最大偏差

        }
        public struct WSL_and_EWH
        {
            public byte nHeartBeat;
            [MarshalAs(UnmanagedType.LPStr, SizeConst = 10)]
            public string ID;
            public Int16 iFromTubeNum;          //来自哪个管
            public BoatState eBoatState;       //舟状态
            public WaferMode eWaferMode;      //硅片状态
            public bool bSend_Req;
            public bool bReceive_Req;
            public bool bBusy;
            public bool bPause;
            public bool bReceiveComplete;
        }

        //报警结构体
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct JhtErr
        {
            public UInt32 nSys;
            public UInt32 nHand1;
            public UInt32 nHand2;
            public UInt32 nHand3;
            public UInt32 nHand4;
            public UInt32 nHand5;
            public UInt32 nCommWithTube;
            public UInt32 nConveyer1;
            public UInt32 nConveyer2;
            public UInt32 nSafe;
            
        }
        #endregion ---------------------------机械手结构体定义--------------------------------------- 

        #region 库文件结构体定义
        public enum OP_MODE
        {
            NO_MODE,
            MANUAL_MODE,
            AUTO_MODE,
            AUTO_RUN_MODE,
            HALT_MODE,
            EM_MODE

        }
        //****************操作命令结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OP_Cmd
        {
            public bool bReset;                     //复位按钮
            public bool bStart;                     //启动按钮
            public bool bStop;                      //停止按钮
            public bool bSpare;                     //备用
            public bool bAutoSelect;                //自动按钮
            public bool bHalt;                      //暂停按钮
            public bool bEM_Stop;                   //急停按钮 
        }
        //****************数字量输入结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DI_Ctrl
        {
            public bool IN;                 //模块实际输入
            public bool Q;                  //换算后的实际值
        }
        //****************数字量参数结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DI_Para
        {
            public UInt16 OnDelay;             //滤波数量
            public UInt16 OffDelay;

        }
        //****************模拟量输入结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct AI_Ctrl
        {
            public Int16 IN;                 //模块实际输入
            public float Q;                  //换算后的实际值
        }
        //****************模拟量参数结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct AI_Para
        {
            public int FilterN;             //滤波数量

            public double rMinAct;          //最小实际值
            public double rMinOriginal;     //最小分辨率
            public double rMaxAct;          //最大实际值
            public double rMaxOriginal;     //最大分辨率 
        }

        //****************伺服控制结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
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
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public bool[] bAbs_Execute;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public bool[] bAbs_Condition;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
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
        //****************伺服参数结构体****************
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
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
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public float[] rAbs_Pos;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public float[] rAbs_Speed;
            public bool bEnableT_Protect;
            public float rMax_Torque;
            public float rMin_Torque;
        }
        //温控模块通讯参数结构体
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct HeatModelPara
        {
            public UInt16 nBreakPV;     //断线显示值，切断输出
            public UInt16 nAlmPV;       //超温报警值,切断输出
            public UInt16 nKp;          //比例系数
            public UInt16 nKi;          //积分系数
            public UInt16 nKd;          //微分系数                  
            public UInt16 nWarnDiff;    //警示偏差值
            public UInt16 nAlmDiff;     //报警偏差值
            public bool bShield;        //当前通道屏蔽
        }

        //stMFC_Ctrl[] stMFC = new stMFC_Ctrl[12];
        //TempPara_Mini8[] stTempPara_Mini = new TempPara_Mini8[8];
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MFC_Value
        {
            public UInt16 SV;                //设定值
            public UInt16 PV;                //实际值       
            public UInt16 ErrorCode;            //错误编码 
        }
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MFC_Para
        {
            public float rWarnDiff_Persent;                //设定值
            public float rAlmDiff_Persent;                //实际值       
            public UInt16 nMaxRange;            //错误编码 
            public bool bShield;
        }
        //真空泵控制结构体
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Pump_Ctrl
        {
            public float rSetPressure;     //真空泵设定压力
            public float rActPressure;     //真空泵实际压力
            public float rSetSpeed;        //真空泵设定抽速
            public float rActSpeed;        //真空泵实际抽速
            public bool bStartPump;         //1：停止2启动  
            public UInt16 nStatusAlarm;        //故障代码

            public bool bCheckDiff_Enable;  //使能检测差值
        }
        //真空泵参数结构体
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Pump_Para
        {
            public float rWarnDiff_Persent;
            public float rAlmDiff_Persent;
            public float rCheckValue;
            public UInt16 nCheckTime;
        }

        //正泰电表
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DTSU666
        {
            public UInt32 nPt;
            public UInt32 nPa;
            public UInt32 nPb;
            public UInt32 nPc;
            public UInt32 nEnergyFw;
        }
        #endregion ---------------------------库文件结构体定义---------------------------------------


    }
}
