using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    public class PlcJhtVar
    {
        
        public static bool gbBeepSheild;//蜂鸣屏蔽
        public static bool gbDoorSheild;//门禁屏蔽
        public static bool gbManual_Path_Start;//手动搬舟启动
        public static bool gbWSL_EWH_Exchange;//手动与自动化传舟
        public static bool gbConveyer_EWH_HasTask;//输送位正在传舟
        public static bool gbHand_InitStart;//机械手初始化启动
        public static bool gbHand_InitDone;//机械手初始化完成
        public static bool gbConveyer_InitStart;//输送机初始化启动
        public static bool gbConveyer_InitDone;//输送机初始化完成
        public static bool gbHand_HasTask;//机械手有搬舟任务
        public static bool gbHand_X_Unlock;//机械手X轴初级解除联锁
        public static bool gbHand_Z_Unlock;//机械手Z轴初级解除联锁
        public static bool gbHand_X_Unlock_1;//机械手X轴高级解除联锁
        public static bool gbHand_Z_Unlock_1;//机械手Z轴高级解除联锁
        public static bool gbConveyer_Unlock; //输送位解除联锁
        public static float grHand_Z_RulerPos;//机械手Z轴磁栅尺位置
        public static string[] gsVersion = new string[32];//软件版本号
        public static bool gbLicense_OK;//注册ok标志位
        public static Int32 giSN;//PLC序列号
        public static Int32 giLicense_Code;//PLC注册码
        public static Int16 giLayBoatPos;//取舟位置
        public static Int16 giTakeBoatPos;//放舟位置
        public static PlcModels.JhtErr stJhtAlm;//报警结构体
        public static PlcModels.JhtErr stJhtWarn;//警示结构体
        public static PlcModels.JhtErr stJhtCaution;//提示结构体
        public static PlcModels.WSL_and_EWH WSL_to_EWH;//主机到自动化的通讯
        public static PlcModels.WSL_and_EWH EWH_to_WSL;//自动化到主机的通讯
        public static PlcModels.HandAxisParaEx AxisParaEx;//轴扩展参数结构体
        public static PlcModels.OP_MODE OP_Mode;//系统模式枚举
        public static PlcModels.OP_Cmd OP_Cmd;//系统模式操作
        public static PlcModels.BoatList[] garrBoatList = new PlcModels.BoatList[20];//舟列表
        public static PlcModels.BoatInfo[] stBuffer_BoatInfo = new PlcModels.BoatInfo[6];//缓存位舟信息
        public static PlcModels.BoatInfo[] stTube_BoatInfo = new PlcModels.BoatInfo[5];//炉管舟信息
        public static PlcModels.BoatInfo stConveyer_BoatInfo;//输送位舟信息
        public static PlcModels.BoatInfo stHand_BoatInfo;//机械手舟信息
        public static PlcModels.StationPara[] stBufferPara = new PlcModels.StationPara[6];//缓存位参数
        public static PlcModels.StationPara[] stTubePara = new PlcModels.StationPara[5];//炉管位参数
        public static PlcModels.SV_Ctrl Hand_X_SV_Ctrl;//机械手X轴控制结构体
        public static PlcModels.SV_Para Hand_X_SV_Para;//机械手X轴参数结构体
        public static PlcModels.SV_Ctrl Hand_Z_SV_Ctrl;//机械手Z轴控制结构体
        public static PlcModels.SV_Para Hand_Z_SV_Para;//机械手Z轴参数结构体
        public static PlcModels.Comm_to_Tube[] stComm_to_Tube = new PlcModels.Comm_to_Tube[5];//到炉管的通讯
        public static PlcModels.Comm_from_Tube[] stComm_from_Tube = new PlcModels.Comm_from_Tube[5];//来自炉管的通讯
        public static PlcModels.DTSU666 stEnergyValue;//电能数据
    }
}
