﻿
using Demo.Forms.Loader;
using Demo.Forms.Template;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.DataBaseModels;
namespace Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmParent());
            //  Application.Run(new XtraForm1());
            
        }
    }
}

public sealed class Global
{
    public static byte TubeID;
    

}

public sealed class PlcVar
{
    public static PlcJhtVar Jht;
    public static PlcTubeVar[] Tube = new PlcTubeVar[5];

}


