using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationModels
{
    public static class PlcJhtNode
    {

        public static string[] AxisParaEx = new string[] {
            "AxisParaEx.rHand_X_FastV",
            "AxisParaEx.rHand_X_SlowV",
            "AxisParaEx.rHand_X_SlowAcc",
            "AxisParaEx.rHand_Z_Mid_FastV",
            "AxisParaEx.rHand_Z_Mid_SlowV",
            "AxisParaEx.rHand_Z_Side_SlowV",
            "AxisParaEx.rHand_Z_FastAcc",
            "AxisParaEx.rHand_Z_SlowAcc",
            "AxisParaEx.rConveyer_JogFastV",
            "AxisParaEx.rConveyer_JogSlowV",
            "AxisParaEx.rTakeTube_CheckOffsetPos",
            "AxisParaEx.rLayTube_CheckOffsetPos",
            "AxisParaEx.rTakeBuff_CheckOffsetPos",
            "AxisParaEx.rLayBuff_CheckOffsetPos ",
            "AxisParaEx.rRuler_Ratio",
            "AxisParaEx.rEnc_Ruler_MaxDiff"
        };

        
        
        
         




        public static string[] AlrmInfo = new string[]{
          
        };


        public static string[] Conveyer = new string[] {


        };

        public static string[] HandInfo = new string[] {


        };

        public static string[] stTube_BoatInfo = new string[] {
            "ID",
            "eBoatState",
            "eWaferMode",
            "iFromTubeNum",
            "iToTubeNum",
            "bCoolingFinish",
            "nStoreTime",
            "nRemainCoolTime",
            "bAlarm"
             
        };






    }
}
