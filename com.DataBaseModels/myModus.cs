using com.CommonHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    public class MyModus
    {

        #region 操作命令
        //操作命令结构体
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

        //系统模式：0 未联机，1 手动模式，2 待机模式，3 运行模式，4 暂停模式，5 故障模式
        public int OP_Mode;
        #endregion

        #region 配方
        private static string TableHead(int index)
        {
            string[] ss = new string[39];
            string a = "";
            ss[0] = "配方步名称";
            ss[1] = "条件判断使能";
            ss[2] = "工艺段总时间";

            ss[3] = "温度1设定温度";
            ss[4] = "温度2设定温度";
            ss[5] = "温度3设定温度";
            ss[6] = "温度4设定温度";
            ss[7] = "温度5设定温度";
            ss[8] = "温度6设定温度";

            ss[9] = "温度7设定温度";
            ss[10] = "斜率有效";
            ss[11] = "炉管设定压力";
            ss[12] = "真空漏率";
            ss[13] = "源的压力1";
            ss[14] = "源的压力2";

            ss[15] = "MFC1";
            ss[16] = "MFC2";
            ss[17] = "MFC3";
            ss[18] = "MFC4";
            ss[19] = "MFC5";
            ss[20] = "MFC6";
            ss[21] = "MFC7";
            ss[22] = "MFC8";
            ss[23] = "MFC9";
            ss[24] = "MFC10";
            ss[25] = "MFC11";
            ss[26] = "MFC12";
            ss[27] = "流量监控";
            ss[28] = "温度监控";
            ss[29] = "压力监控";

            for (int i = 0; i <= 26; i++)
            {
                a = a + ss[i] + ",";
            }

            return a;

        }

        public static sStRecipePara[] stRecipeArrary = new sStRecipePara[5];

        public struct sStRecipePara
        {

            public int ename;      //配方步名称
            public bool bCondition_Che;     //条件判断使能
            public DateTime nDuration;     //工艺段总时间
            public int rTempZone1_SV;     //温度1设定温度
            public int rTempZone2_SV;     //温度2设定温度
            public int rTempZone3_SV;     //温度3设定温度
            public int rTempZone4_SV;     //温度4设定温度
            public int rTempZone5_SV;     //温度5设定温度
            public int rTempZone6_SV;     //温度6设定温度
            public int rTempZone7_SV;     //温度7设定温度
            public bool bTempRump_Enab;     //斜率有效
            public int rTube_SetPress;     //炉管设定压力
            public bool rLeakRateLimit;     //真空漏率
            public int rSource1_Press;     //源的压力1
            public int rSource2_Press;     //源的压力2
            public double rMFC1_FlowRate;
            public double rMFC2_FlowRate;
            public double rMFC3_FlowRate;
            public double rMFC4_FlowRate;
            public double rMFC5_FlowRate;
            public double rMFC6_FlowRate;
            public double rMFC7_FlowRate;
            public double rMFC8_FlowRate;
            public double rMFC9_FlowRate;
            public double rMFC10_FlowRat;
            public double rMFC11_FlowRat;
            public double rMFC12_FlowRat;
            public bool bOpen_Valve_1;
            public bool bOpen_Valve_2;
            public bool bOpen_Valve_3;
            public bool bOpen_Valve_4;
            public bool bOpen_Valve_5;
            public bool bOpen_Valve_6;
            public bool bOpen_Valve_7;
            public bool bOpen_Valve_8;
            public bool bOpen_Valve_9;
            public bool bOpen_Valve_10;
            public bool bOpen_Valve_11;
            public bool bOpen_Valve_12;
            public bool bOpen_Valve_13;
            public bool bOpen_Valve_14;
            public bool bOpen_Valve_15;
            public bool bOpen_Valve_16;
            public bool bOpen_Valve_17;
            public bool bOpen_Valve_18;
            public bool bOpen_Valve_19;
            public bool bOpen_Valve_20;
            public bool bOpen_Valve_21;
            public bool bOpen_Valve_22;
            public bool bOpen_Valve_23;
            public bool bOpen_Valve_24;
            public bool bTemp_Check;     //温度监控
            public bool bFlow_Check;     //流量监控
            public bool bPressure_Check;    //压力监控 
        }

        public string defaultRecipeName;
        #endregion

        #region 温区
        public StTempZone[] StTempZoneArray = new StTempZone[8];
        public struct StTempZone
        {
            public float rInternal_Temp;            //内偶温度
            public float rExternal_Temp;            //外偶温度
            public float rMV;                       //输出功率
            public float rSet_Temp;                 //设定温度
            public float rCal_Rump;                 //计算所得温度斜率
            public bool bRun;                        //启动加热
            public bool bTempRump_Enable;            //斜坡升温有效
            public float rRunStep_T;
        }


        public float[] grTemp_SPArray = new float[8];//过渡值

        public static float grHMI_TempSV;//设定温度

        public static float grHMI_TempRump;//设定斜率

        public static bool gbHMI_Temp_Enable;//温度使能？

        public static bool DI_HeatSwitch;//加热吸合器

        public float grCooling_PV1;//水冷温度1
        public float grCooling_PV2;//水冷温度2

        #endregion

        #region 气路
        //ddss
        stMFC_Ctrl[] stMFCC = new stMFC_Ctrl[12];
        public struct stMFC_Ctrl
        {
            public bool bReset;              //复位
            public bool bExcute;             //触发
            public bool bCheckDiff_Enable;   //使能检测差值
            public bool bRun_Condition;      //动作条件
            public ushort SV;                //设定值
            public ushort PV;                //实际值
            public float nAddress;          //地址
            public bool bWarn;               //流量偏差警示，完成当前工艺后停止
            public bool bAlarm;              //总报警输出
            public int ErrorCode;            //错误编码 
        }
        stMFC_Para[] stMFCP = new stMFC_Para[12];
        public struct stMFC_Para
        {
            public float rWarnDiff_Persent;
            public float rAlmDiff_Persent;
            public uint nMaxRange;
            public bool bShield;
        }

        stValve_Ctrl[] stValveC = new stValve_Ctrl[24];
        public struct stValve_Ctrl
        {
            public bool bHMI_Trigger;
            public bool bOpenCmd;
            public bool bOpen_Condition;
            public bool bClose_Condition;
            public bool bOpenFinish;
            public bool bCloseFinish;
            public bool bDO_Open;
            public bool bDO_Close;
            public bool bAlarm;
            public int nErrorCode;
        }

        public bool DI_TubePressure_Normal;//炉管常压检测
        public bool DI_TubePressure_Vacuum;//炉管真空检测
        #endregion

        #region 轴控

        //机械手X轴参数结构体
        public AxisParaEx axisParaEx = new AxisParaEx();
        public struct AxisParaEx
        {
            public float rBoatIn_SlowPos;          //进舟减速判断位
            public float rBoatIn_ClosePos;         //进舟关炉门判断位
            public float rBoatOut_OpenPos;         //出舟开炉门判断位
            public float rBoatOut_FastPos;         //出舟快速判断位
            public float rBoatOut_OffsetPos;       //出舟时，根据传感器定位舟
            public bool bAutoCalcEnable;          //使能自动计算力矩
            public float rFollow_StartT;           //随动启动力矩
            public float rFollow_StopT;            //随动停止力矩
            public float rFollow_MaxOffsetPos;     //随动最大允许的偏移距离
            public float rBoatOut_AlmOffsetPos;    //出舟时有舟位与无舟位的最大偏差
            public float rBoatPush_SV_MaxT;        //推舟轴最大力矩
        }
        public stTube_BoatInfo stTube_BoatInfos = new stTube_BoatInfo();
        //推舟机械手舟信息
        public struct stTube_BoatInfo
        {
            public string ID;               //舟托编号  
            public int eBoatState;       //舟状态
            public float rActStoreTime;    //实际存放时间
            public int iUseCount;        //使用次数
            public bool bAlarm;           //舟工位报警 
        }
        public Hand_X_SV_Ctrl hand_X_SV_Ctrl = new Hand_X_SV_Ctrl();
        public struct Hand_X_SV_Ctrl
        {
            public bool bHMI_PowerOff;
            public bool bAuto_PowerOff;
            public bool bHome_PowerOff;
            public bool bPowerStatus;
            public bool bStandStill;
            public bool bMinPos_Reached;
            public bool bMaxPos_Reached;
            public bool bHome_Excute;
            public bool bHome_Condition;
            public bool bHMI_JogF;
            public bool bHMI_JogB;
            public bool bAuto_JogF;
            public bool bAuto_JogB;
            public bool bJogF_Condition;
            public bool bJogB_Condition;
            public bool bReset_Execute;
            public bool bStop_Execute;
            public float rOverride;
            public float rActPos;
            public float rActSpeed;
            public float rAct_Torque;
            public float rLimit_Torque;
            public bool bP_OT;
            public bool bN_OT;
            public bool bHome_SW;
            public bool bAlarm;
            public uint nErrorCode;
        }
        public bool[] boatPush_SV_Ctrl_bAbs_Execute = new bool[32];
        public bool[] boatPush_SV_Ctrl_bAbs_Condition = new bool[32];
        public bool[] boatPush_SV_Ctrl_bPos_Reached = new bool[32];
        public bool gbHMI_BoatIn;//手动联动进舟
        public bool gbHMI_BoatOut;//手动联动出舟
        public float grRulerPos;//磁栅尺位置
        public bool gbBoatPush_Unlock; //轴解除联锁
        public bool gbValve_Unlock; //阀解除联锁
        #endregion

        #region 气缸
        public bool gbHMI_OpenDoor;
        public bool gbHMI_CloseDoor;
        public Struct_YV_Ctrl PushpullDoor_YV_Ctrl = new Struct_YV_Ctrl();//炉门推拉气缸控制结构体
        public Struct_YV_Ctrl CloseDoor_YV_Ctrl = new Struct_YV_Ctrl();//炉门关闭气缸控制结构体
        public struct Struct_YV_Ctrl
        {
            public bool bHMI_Out;
            public bool bHMI_Back;
            public bool bAuto_Out;
            public bool bAuto_Back;
            public bool bOut_Condition;
            public bool bBack_Condition;
            public bool bOutPos_Reached;
            public bool bDI_OutPos;
            public bool bDI_BackPos;
            public bool bDO_Out;
            public bool bDO_Back;
            public bool bAlarm;
            public bool nErrorCode;
        }
        public Struct_YV_Para CloseDoor_YV_Para = new Struct_YV_Para();//炉门关闭气缸参数结构体
        public Struct_YV_Para PushpullDoor_YV_Para = new Struct_YV_Para();//炉门推拉气缸参数结构体

        public struct Struct_YV_Para
        {
            public uint nOut_ReachTime;
            public uint nBack_ReachTime;
            public uint nOut_AlmTime;
            public uint nBack_AlmTime;
            public bool bDefaultPos;
            public bool bControlType;
            public bool bOut_has_SW;
            public bool bBack_has_SW;
            public bool bMonDisable;
        }
        #endregion

        #region 工艺信息
        public stCurrentRecipeCtrl stcurrentRecipeCtrl = new stCurrentRecipeCtrl();
        //当前工艺控制
        public struct stCurrentRecipeCtrl
        {
            public bool bFinish;
            public bool bAlarm;
            public uint nWorking_Time;            //步运行时间
            public uint nRemain_Time;             //步剩余时间
            public int eName;                       //步名称
            public uint nDuration;                //步总时间
        }

        public bool gbProcess_Busy;                 //工艺忙信号

        public int giRecipe_ID;                     //步号

        public uint gnProcessRemainTime;            //工艺剩余时间
        public uint gnProcessTotalTime;             //工艺总时间
        public uint gnProcessWorkingTime;           //工艺运行时间

        public string sCurrentRecipeName;           //炉管当前工艺名称

        public bool gbHMI_Recipe_Start;             //开始
        public bool gbHMI_Recipe_Hold;              //保持
        public bool gbHMI_Recipe_Abort;             //中止
        public bool gbHMI_Recipe_Finish;            //结束
        public uint gnHMI_Hold_Time;                //保持时间

        public bool gbTube_Disable;                 //锁管
        #endregion

        #region 真空
        //读真空泵数据结构体
        public struct stPump_Read
        {
            public float rActPressure;     //读真空泵数据结构体
            public float rActSpeed;        //抽速-0-100Hz
            public int nStatusAlarm;        //0：正常1：故障
            public bool bStartPump;         //1：停止2启动
            public float rSetPressure;     //读真空泵压力
            public bool bSetFunMode;        //2:真空模式1:速度模式
            public float rSetSpeed;        //0-100Hz
            public bool bCheckDiff_Enable;  //使能检测差值
        }
        //写真空泵数据结构体
        public struct stPump_Write
        {
            public ushort rActPressure;     //写真空泵数据结构体
            public ushort rActSpeed;        //读抽速度0-100Hz
            public int nStatusAlarm;        //0:正常1:故障
            public bool bStartPump;         //1：停止2：启动
            public ushort rSetPressure;     //写真空泵数据压力
            public bool bSetFunMode;        //2：真空模式1：速度模式
            public ushort rSetSpeed;        //设定抽速
            public bool bCheckDiff_Enable;  //使能检测差值  
        }

        public bool gbHMI_LeakCheck;//一键检漏
        public float grActLeakRate;//漏率

        public Struct_FXL_HWCs_Ctrl stHWCs_Ctrl = new Struct_FXL_HWCs_Ctrl();
        public struct Struct_FXL_HWCs_Ctrl
        {
            public float rActTemperature;
            public float rSetTempReturn;
            public float rSetTemperature;
            public uint nWeightStatus_1;
            public uint nWeightStatus_2;
            public uint nWeightStatus_3;
            public uint nWeightStatus_4;
            public uint nWeightStatus_5;
            public uint nWeightStatus_6;
            public uint nTempState;
            public uint nCompressorState;
            public uint nGasState;
            public uint nRunningState;
            public uint nLevel_1;
            public uint nLevel_2;
            public uint nLevel_3;
            public uint nLevel_4;
            public uint nLevel_5;
            public uint nLevel_6;
            public uint GasConcentration;
        }
        public int giSource_Counter;//源瓶使用次数
        public float Comm_rHCSPV;//恒温槽监控温度
        #endregion

        #region IO
        //炉管和机械手通讯
        public struct stComm_from_Tube
        {
            public int iHeartBeat;         //心跳位
            public bool bOar_atPickPos;    //桨在取放位置
            public bool bTakeBoatReq;      //炉管请求取舟
            public bool bLayBoatReq;       //炉管请求放舟
            public bool bAckTakeFinish;    //炉管接收到机械手取舟完成信号
            public bool bAckLayFinish;     //炉管接收到机械手放舟完成信号
            public bool bDisable;          //炉管的桨有报警
        }
        //机械手和炉管通讯
        public struct stComm_to_Tube
        {
            public int iHeartBeat;         //心跳位
            public bool bHand_atSafePos;    //机械手在安全位置
            public bool bTube_has_Task;     //炉管正在执行搬舟任务
            public bool bAckTakeReq;        //机械手收到炉管请求取舟的信号
            public bool bAckLayReq;         //机械手收到炉管请求放舟的信号
            public bool bTakeBoat_Finish;   //机械手向炉管取舟完成
            public bool bLayBoat_Finish;    //机械手向炉管放舟完成
        }
        stTempPara_Mini8[] stTempPara_Mini = new stTempPara_Mini8[8];
        #endregion

        #region 温控系统参数
        //mini8通讯
        public struct stTempPara_Mini8
        {
            public ushort nBreakPV;     //断线显示值，切断输出
            public ushort nAlmPV;       //超温报警值,切断输出
            public ushort nKp;          //比例系数
            public ushort nKi;          //积分系数
            public ushort nKd;          //微分系数
            public ushort nPID_Zone1;   //PID编号的区间
            public ushort nPID_Zone2;   //PID编号的区间
            public ushort nPID_Zone3;   //PID编号的区间
            public ushort nPID_Num;     //正在使用的PID组
            public ushort nUpRamp;      //温度上升斜坡时间
            public ushort nDownRamp;    //温度下降斜坡时间
            public ushort nWarnDiff;    //警示偏差值
            public ushort nAlmDiff;     //报警偏差值
            public bool bShield;        //当前通道屏蔽
        }

        //山武需要预留


        #endregion

        #region 真空系统参数
        //真空规控制结构体
        public struct stVG1_Ctrl
        {
            public float IN;                 //模块实际输入
            public float Q;                  //换算后的实际值
            public float bAlarm;             //报警标志位
            public float nErrorCode;         //报警代码
        }
        //真空规参数结构体
        public struct stVG1_Para
        {
            public int FilterN;             //滤波数量
            public int PeakN;               //毛刺监控数量
            public float rMinAct;          //输入最下肢对应的实际值
            public float rMinOriginal;     //原始值最小值
            public float rMaxAct;          //输入最大值对对应的实际值
            public float rMaxOriginal;     //原始值最大值 
        }
        #endregion
    }
}
