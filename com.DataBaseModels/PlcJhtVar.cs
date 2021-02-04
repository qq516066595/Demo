using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    public class PlcJhtVar
    {

        public  bool gbBeepSheild;//蜂鸣屏蔽
        public  bool gbDoorSheild;//门禁屏蔽
        public  bool gbManual_Path_Start;//手动搬舟启动
        public  bool gbWSL_EWH_Exchange;//手动与自动化传舟
        public  bool gbConveyer_EWH_HasTask;//输送位正在传舟
        public  bool gbHand_InitStart;//机械手初始化启动
        public  bool gbHand_InitDone;//机械手初始化完成
        public  bool gbConveyer_InitStart;//输送机初始化启动
        public  bool gbConveyer_InitDone;//输送机初始化完成
        public  bool gbHand_HasTask;//机械手有搬舟任务
        public  bool gbHand_X_Unlock;//机械手X轴初级解除联锁
        public  bool gbHand_Z_Unlock;//机械手Z轴初级解除联锁
        public  bool gbHand_X_Unlock_1;//机械手X轴高级解除联锁
        public  bool gbHand_Z_Unlock_1;//机械手Z轴高级解除联锁
        public  bool gbConveyer_Unlock; //输送位解除联锁
        public  float grHand_Z_RulerPos;//机械手Z轴磁栅尺位置
        public  string[] gsVersion = new string[32];//软件版本号
        public  bool gbLicense_OK;//注册ok标志位
        public  Int32 giSN;//PLC序列号
        public  Int32 giLicense_Code;//PLC注册码
        public  Int16 giLayBoatPos;//取舟位置
        public  Int16 giTakeBoatPos;//放舟位置
        public  PlcModels.JhtErr stJhtAlm;//报警结构体
        public  PlcModels.JhtErr stJhtWarn;//警示结构体
        public  PlcModels.JhtErr stJhtCaution;//提示结构体
        public  PlcModels.WSL_and_EWH WSL_to_EWH;//主机到自动化的通讯
        public  PlcModels.WSL_and_EWH EWH_to_WSL;//自动化到主机的通讯
        public  PlcModels.HandAxisParaEx AxisParaEx;//轴扩展参数结构体
        public  PlcModels.OP_MODE OP_Mode;//系统模式枚举
        public  PlcModels.OP_Cmd OP_Cmd;//系统模式操作
        public  PlcModels.BoatList[] garrBoatList = new PlcModels.BoatList[20];//舟列表
        public  PlcModels.BoatInfo[] stBuffer_BoatInfo = new PlcModels.BoatInfo[6];//缓存位舟信息
        public  PlcModels.BoatInfo[] stTube_BoatInfo = new PlcModels.BoatInfo[5];//炉管舟信息
        public  PlcModels.BoatInfo stConveyer_BoatInfo;//输送位舟信息
        public  PlcModels.BoatInfo stHand_BoatInfo;//机械手舟信息
        public  PlcModels.StationPara[] stBufferPara = new PlcModels.StationPara[6];//缓存位参数
        public  PlcModels.StationPara[] stTubePara = new PlcModels.StationPara[5];//炉管位参数
        public  PlcModels.SV_Ctrl Hand_X_SV_Ctrl;//机械手X轴控制结构体
        public  PlcModels.SV_Para Hand_X_SV_Para;//机械手X轴参数结构体
        public  PlcModels.SV_Ctrl Hand_Z_SV_Ctrl;//机械手Z轴控制结构体
        public  PlcModels.SV_Para Hand_Z_SV_Para;//机械手Z轴参数结构体
        public  PlcModels.Comm_to_Tube[] stComm_to_Tube = new PlcModels.Comm_to_Tube[5];//到炉管的通讯
        public  PlcModels.Comm_from_Tube[] stComm_from_Tube = new PlcModels.Comm_from_Tube[5];//来自炉管的通讯
        public  PlcModels.DTSU666 stEnergyValue;//电能数据
        public  PlcModels.FXL_HWCs_Ctrl stHWCs_Ctrl;
    }
}
