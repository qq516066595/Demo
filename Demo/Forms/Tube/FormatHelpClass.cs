using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* namespace：Demo.Forms.Tube
* className：FormatHelpClass
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020/12/31 14:49:18
* Desc：存放所有需要数值转换的内容
* 
* Remarks：
*/
namespace Demo.Forms.Tube
{
    public class FormatHelpClass
    {


        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// 将时间秒转换为分钟
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string timeFormatIntToString(uint time)
        {
            try
            {
                string newTime = ((Int32)time / 60).ToString() + " Min " + ((Int32)time % 60).ToString() + " s";
                return newTime;
            }
            catch (Exception e)
            {
                log.Error("秒转分钟",e);
                return "";
            }
        }

        /// <summary>
        /// 扩散配方名称转换：数字转文字
        /// </summary>
        /// <param name="eName">下标值</param>
        /// <returns></returns>
        public static string KSrecipeNameFormatIntToString(int eName)
        {
            string stepName = "";
            switch (eName)
            {
                case 0:
                    stepName = "无";
                    break;
                case 1:
                    stepName = "开始";
                    break;
                case 2:
                    stepName = "进舟";
                    break;
                case 3:
                    stepName = "升温";
                    break;
                case 4:
                    stepName = "抽真空";
                    break;
                case 5:
                    stepName = "检漏";
                    break;
                case 6:
                    stepName = "恒温";
                    break;
                case 7:
                    stepName = "恒压";
                    break;
                case 8:
                    stepName = "预沉积";
                    break;
                case 9:
                    stepName = "沉积";
                    break;
                case 10:
                    stepName = "抽空";
                    break;
                case 11:
                    stepName = "降温";
                    break;
                case 12:
                    stepName = "破真空";
                    break;
                case 13:
                    stepName = "等待";
                    break;
                case 14:
                    stepName = "出舟";
                    break;
                case 15:
                    stepName = "清洗";
                    break;
                case 16:
                    stepName = "结束";
                    break;
                default:
                    stepName = "无";
                    break;
            }
            return stepName;
        }

        /// <summary>
        /// 扩散配方名称转换：文字转数字
        /// </summary>
        /// <param name="recipeName">步名称</param>
        /// <returns></returns>
        public static int recipeNameFormatStringToInt(string stepName)
        {
            int eName = 0;
            switch (stepName)
            {
                case "无":
                    eName = 0;
                    break;
                case "开始":
                    eName = 1;
                    break;
                case "进舟":
                    eName = 2;
                    break;
                case "升温":
                    eName = 3;
                    break;
                case "抽真空":
                    eName = 4;
                    break;
                case "检漏":
                    eName = 5;
                    break;
                case "恒温":
                    eName = 6;
                    break;
                case "恒压":
                    eName = 7;
                    break;
                case "预沉积":
                    eName = 8;
                    break;
                case "沉积":
                    eName = 9;
                    break;
                case "抽空":
                    eName = 10;
                    break;
                case "降温":
                    eName = 11;
                    break;
                case "破真空":
                    eName = 12;
                    break;
                case "等待":
                    eName = 13;
                    break;
                case "出舟":
                    eName = 14;
                    break;
                case "清洗":
                    eName = 15;
                    break;
                case "结束":
                    eName = 16;
                    break;
                default:
                    eName = 0;
                    break;
            }
            return eName;
        }

        /// <summary>
        /// PE配方名称转换:数字转文字
        /// </summary>
        /// <param name="eName"></param>
        /// <returns></returns>
        public static string PErecipeNameFormatIntToString(int eName)
        {
            string stepName = "";
            return stepName;
        }

        /// <summary>
        /// PE配方名称转换：文字转数字
        /// </summary>
        /// <param name="eName"></param>
        /// <returns></returns>
        public static int PErecipeNameFormatStringToInt(string stepName)
        {
            int eName = 0;
            return eName;
        }

        /// <summary>
        /// 舟状态名称转换：数字转文字
        /// </summary>
        /// <param name="iboatState"></param>
        /// <returns></returns>
        public static string boatStateFormatIntToString(int iboatState)
        {
            string sboatState = "";
            switch (iboatState)
            {
                case 0:
                    sboatState = " -- ";
                    break;
                case 1:
                    sboatState = "无舟";
                    break;
                case 2:
                    sboatState = "空舟";
                    break;
                case 3:
                    sboatState = "未工艺舟";
                    break;
                case 4:
                    sboatState = "已工艺舟";
                    break;
                case 5:
                    sboatState = "异常舟";
                    break;
                case 6:
                    sboatState = "实验舟";
                    break;
                case 7:
                    sboatState = "空桨饱和";
                    break;
                case 8:
                    sboatState = "饱和完成";
                    break;
                case 9:
                    sboatState = "正在工艺";
                    break;
                case 10:
                    sboatState = "待清洗舟";
                    break;
                default:
                    sboatState = " -- ";
                    break;
            }
            return sboatState;
        }

        /// <summary>
        /// 舟状态名称转换：文字转数字
        /// </summary>
        /// <param name="iboatState"></param>
        /// <returns></returns>
        public static int boatStateFormatStringToInt(string sboatState)
        {
            int iboatState = 0;
            switch (sboatState)
            {
                case " -- ":
                    iboatState = 0;
                    break;
                case "无舟":
                    iboatState = 1;
                    break;
                case "空舟":
                    iboatState = 2;
                    break;
                case "未工艺舟":
                    iboatState = 3;
                    break;
                case "已工艺舟":
                    iboatState = 4;
                    break;
                case "异常舟":
                    iboatState = 5;
                    break;
                case "实验舟":
                    iboatState = 6;
                    break;
                case "空桨饱和":
                    iboatState = 7;
                    break;
                case "饱和完成":
                    iboatState = 8;
                    break;
                case "正在工艺":
                    iboatState = 9;
                    break;
                case "待清洗舟":
                    iboatState = 10;
                    break;
                default:
                    iboatState = 0;
                    break;
            }
            return iboatState;
        }

        /// <summary>
        /// 系统操作模式转换
        /// </summary>
        /// <param name="imode"></param>
        /// <returns></returns>
        public static string imodeFormatIntToString(int imode)
        {
            string smode = "";
            switch (imode)
            {
                case 0:
                    smode = "未联机";
                    break;
                case 1:
                    smode = "手动模式";
                    break;
                case 2:
                    smode = "待机模式";
                    break;
                case 3:
                    smode = "运行模式";
                    break;
                case 4:
                    smode = "暂停模式";
                    break;
                case 5:
                    smode = "故障模式";
                    break;
                default:
                    break;
            }
            return smode;
        }
    }
}
