using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
 public   class LoaderModus
    {

          

        //轴扩展参数结构体
        public struct AxisParaEx
        {
            public int rHand_X_FastV;
            public int rHand_X_SlowV;
            public int rHand_X_FastAcc;
            public int rHand_X_SlowAcc;
            public int rHand_Z_MidX_FastV;
            public int rHand_Z_MidX_SlowV;
            public int rHand_Z_SideX_SlowV;
            public int rHand_Z_FastAcc;
            public int rHand_Z_SlowAcc;
            public int rConveryer_AutoJogFastV;
            public int rConveryer_AutoJogSlowV;
            public int rTake_CheckOffsetPos;
            public int rLay_CheckOffsetPos;
            public int rRuler_Ratio;
            public int rEnc_Ruler_MaxDiff;
            public int rHand_X_SV_MaxT;
            public int rHand_Z_SV_MaxT;


        }
        //输送机参数结构体
        public struct Conveyer_SV_Para
        {
            public int nHomeType;
            public int ID;
            public int bHome_OK;
            public int rScaling_Factor;
            public int rPosition_Bias;
            public int rHome_Position;
            public int rHome_Speed;
            public int rHMI_JogSpeed;
            public int rAuto_JogSpeed;
            public int rAcc;
            public int rDec;
            public int rJerk;
            public int rMaxPos;
            public int rMinPos;
        }

        //舟使用次数1-20
        public static garrBoatList[] garrBoatArray = new garrBoatList[20];
        public struct garrBoatList
        {
          public int ID;
          public int iUseCount;
          public DateTime iFromTubeNum;
          public int iToTubeNum;
          public int bCleanFlag;
             
        }

       // 机械手X轴控制结构体
       public struct Hand_X_SV_Ctrl
        {
            public int bHMI_PowerOff;
            public int bAuto_PowerOff;
            public int bHome_PowerOff;
            public int bPowerStatus;
            public int bStandStill;
            public int bMinPos_Reached;
            public int bMaxPos_Reached;
            public int bHome_Excute;
            public int bHome_Condition;
            public int bHMI_JogF;
            public int bHMI_JogB;
            public int bAuto_JogF;
            public int bAuto_JogB;
            public int bJogF_Condition;
            public int bJogB_Condition;
            public int bReset_Execute;
            public int bStop_Execute;
            public int rOverride;
            public int rActPos;
            public int rActSpeed;
            public int rAct_Torque;
            public int rLimit_Torque;
            public int bP_OT;
            public int bN_OT;
            public int bHome_SW;
            public int bAlarm;
            public int nErrorCode;


        }


    }
}
