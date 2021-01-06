using System;
using System.Windows.Forms;

namespace com.CommunicationDAL
{
    internal static class Mymode
    {
        public static string LoginUser;
        public static int Level;

        public static string Gyedit;
        //public static short Number;

        public static DogIni Config = new DogIni(Application.StartupPath + "\\config.ini"); //配置所有公共参数
        public static DogIni GongyiIni = new DogIni(); //用来读取和保存工艺文件

        public static bool Quit;
        public static double MaxSet;
        public static double MinSet;
        public static string StartTime;
        public static string EndTime;

        public struct Run_Infor
        {
            public string RecName; //工艺名称
            public long Product_Num; //产品批号
            public long BoatIDCount;//舟使用次数
            public bool RunFlag;
            public bool ErrHandle;
            public int CurrentStep;
            public double[] WenduSv;
            public int ControlMode;
            public int TotalTime;
            public string[] StepTime;
            public string[] StepExp;
            public double[] Profile_PV;
            public double[] Spike_PV;
            public double[] GAS_PV;
            public int[] UDSpeed;
            public double UDPosition;
            public int[] HSpeed;
            public double HPosition;
            public string UDLimit;
            public string HLimit;
            public string DoorState;
            public string OverTemp;
            public string EMO;
            public string LowPressureState;
            public string BoatID;
            public string[] POnOff_SV;
            public string POnOff_PV;
            public int VATAngle;


            public void Initialize()
            {
                Spike_PV = new double[5];
                Profile_PV = new double[5];
                GAS_PV = new double[8];
                POnOff_SV = new string[31];
                WenduSv = new double[31];
                StepExp = new string[31];

                UDSpeed = new int[31];
                HSpeed = new int[31];
                StepTime = new string[31];

                UDLimit = "";
                HLimit = "";
                DoorState = "";
                OverTemp = "";
                EMO = "";
                LowPressureState = "";
                BoatID = "";
                POnOff_PV = "0/0";
            }

        }
        public static Run_Infor[] Infor = new Run_Infor[5];


        #region Form_
        
         public static  BeifuPlc[] PLC = new BeifuPlc[5];  
         public static MoonsCommLibHelper[] MoonsComm = new MoonsCommLibHelper[5];

        #endregion

        public static void LogHistory(string FileName, int Num, string Thing1) //history
        {

            //操作记录和报警记录()
            //历史数据()

            if (FileName.Length == 0)
            {
                return;
            }
            string sfile = Application.StartupPath + "\\历史数据\\" + Num.ToString();
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }
            sfile = sfile + "\\" + FileName;

            System.IO.FileStream n = null;
            System.IO.StreamWriter m = null;

            if (System.IO.File.Exists(sfile) == false)
            {
                n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
                m = new System.IO.StreamWriter(n, System.Text.Encoding.UTF8);
                m.WriteLine(TableHead(Num));
                m.Close();
            }

            n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            m = new System.IO.StreamWriter(n);
            m.WriteLine(Thing1);
            m.Close();
        }

        private static string TableHead(int index)
        {
            string[] ss = new string[39];
            string a = "";
            ss[0] = "时间";
            ss[1] = "工艺名称";
            ss[2] = "步号";

            ss[3] = "步时间";

            ss[4] = "内温5";
            ss[5] = "内温4";
            ss[6] = "内温3";
            ss[7] = "内温2";
            ss[8] = "内温1";

            ss[9] = "NH3";
            ss[10] = "SiH4";
            ss[11] = "N2";
            ss[12] = "压力";
            ss[13] = "蝶阀开度";
            ss[14] = "功率";
            ss[15] = "POnOff_SV";
            ss[16] = "POnOff_PV";
            ss[17] = "电流";
            ss[18] = "电压";
            ss[19] = "舟号";

            ss[20] = "外温5";
            ss[21] = "外温4";
            ss[22] = "外温3";
            ss[23] = "外温2";
            ss[24] = "外温1";




            for (int i = 0; i <= 24; i++)
            {
                a = a + ss[i] + ",";
            }

            return a;

        }

        public static void LogEvent(int Num, string Thing1, string Thing2) //操作记录
        {
            string sfile = null;

            //操作记录

            sfile = Application.StartupPath + "\\操作记录";
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }

            sfile = sfile + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            System.IO.FileStream n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            System.IO.StreamWriter m = new System.IO.StreamWriter(n, System.Text.Encoding.Default);
            string s = DateTime.Now.ToString() + "," + LoginUser + "," + "炉管-" + Num.ToString() + "," + Thing1 + "," + Thing2;
            m.WriteLine(s);
            m.Close();
        }


        public static void LogEventLift(string Thing1, string Thing2, string Thing3) //操作记录
        {
            string sfile = null;

            //操作记录

            sfile = Application.StartupPath + "\\操作记录";
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }

            sfile = sfile + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            System.IO.FileStream n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            System.IO.StreamWriter m = new System.IO.StreamWriter(n, System.Text.Encoding.Default);
            string s = DateTime.Now.ToString() + "," + LoginUser + "," + Thing1 + "," + Thing2 + "," + Thing3;
            m.WriteLine(s);
            m.Close();
        }

        public static void LogEventLift(string Thing1, string Thing2, string Thing3, string Thing4) //操作记录
        {
            string sfile = null;

            //操作记录

            sfile = Application.StartupPath + "\\操作记录";
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }

            sfile = sfile + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            System.IO.FileStream n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            System.IO.StreamWriter m = new System.IO.StreamWriter(n, System.Text.Encoding.Default);
            string s = DateTime.Now.ToString() + "," + LoginUser + "," + Thing1 + "," + Thing2 + "," + Thing3 + "," + Thing4;
            m.WriteLine(s);
            m.Close();
        }

        public static void LogAlarm(int Num, string Thing1, string Thing2) //报警记录
        {
            string sfile = null;

            //报警记录()

            sfile = Application.StartupPath + "\\报警记录";
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }

            sfile = sfile + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            System.IO.FileStream n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);

            System.IO.StreamWriter m = new System.IO.StreamWriter(n, System.Text.Encoding.Default);
            string s = DateTime.Now.ToString() + "," + LoginUser + "," + "炉管-" + Num.ToString() + "," + Thing1 + "," + Thing2;

            m.WriteLine(s);
            m.Close();
        }
         
        public static void LogHistorybyDate(string dt, string FileName, int Num, string Thing1) //history
        {


            //操作记录和报警记录()
            //历史数据()

            if (FileName.Length == 0)
            {
                return;
            }
            string sfile = Application.StartupPath + "\\历史数据\\" + Num.ToString() + "\\" + dt;
            if (System.IO.Directory.Exists(sfile) == false)
            {
                System.IO.Directory.CreateDirectory(sfile);
            }
            sfile = sfile + "\\" + FileName;

            System.IO.FileStream n = null;
            System.IO.StreamWriter m = null;

            if (System.IO.File.Exists(sfile) == false)
            {
                n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
                m = new System.IO.StreamWriter(n, System.Text.Encoding.UTF8);
                m.WriteLine(TableHead(Num));
                m.Close();
            }

            n = System.IO.File.Open(sfile, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            m = new System.IO.StreamWriter(n);
            m.WriteLine(Thing1);
            m.Close();
        }
    }
}
