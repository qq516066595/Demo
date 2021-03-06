﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Demo.Forms.Tube;
using DevExpress.XtraTabbedMdi;
using com.DataBaseModels;
/*
* namespace：Demo.Forms.Template
* className：frmParent
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-10 09:47:01
* Desc：软件系统的父窗体搭建，分辨率1280*1024；打开父窗体加载所有子窗体画面；
* 
* Remarks：1、自适应问题需调整；2、总览窗体为默认打开画面功能待完善
*/
namespace Demo.Forms.Template
{
    public partial class frmParent : DevExpress.XtraEditors.XtraForm
    {
        public frmParent MRF;
        public frmParent()
        {
            InitializeComponent();
            MRF = this;
            MRF.IsMdiContainer = true;
            defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Black";//窗体默认皮肤 

            //设置tab子窗体不可关闭
            xtraTabbedMdiManager1.PageAdded += (s, ei) =>
            {
                ei.Page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            };
            xtraTabbedMdiManager1.MouseUp += XtraTabbedMdiManager1_MouseUp;
        }

        public int xtraTabIndex;//赋值一级菜单对象唯一值

        private void XtraTabbedMdiManager1_MouseUp(object sender, MouseEventArgs e)
        {
            //获取打开对象，加载打开数据
            XtraMdiTabPage curPage = (sender as XtraTabbedMdiManager).SelectedPage;
            if (curPage.Text == "  总  览  ")
            {
                xtraTabIndex = 0;
                
                //curPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            }
            else if (curPage.Text == " 第 一 组 ")
                frmID.Unit  = 1;
            else if (curPage.Text == " 第 二 组 ")
                frmID.Unit = 2;
            else if (curPage.Text == " 第 三 组 ")
                frmID.Unit = 3;
            else if (curPage.Text == " 第 四 组 ")
                frmID.Unit = 4;
            else if (curPage.Text == " 第 五 组 ")
                frmID.Unit = 5;
            else if (curPage.Text == " 机 械 手 ")
                frmID.Unit = 6;
        }

        /// <summary>
        /// 窗体布局，实现自定义，待调试修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmParent_Layout(object sender, LayoutEventArgs e)
        {
            //AutoSizeFormClass As = new AutoSizeFormClass();
            //As.controlAutoSize(this);
        }

        #region 系统性功能按钮
        /// <summary>
        /// 系统退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出系统？", "退出提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 关于页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAbout_Click(object sender, EventArgs e)
        {
            string filepath = System.IO.Directory.GetCurrentDirectory() + "\\" + "help.pdf";
            System.Diagnostics.Process.Start(filepath);
        }
        /// <summary>
        /// 权限设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picUserInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户管理及权限设置");
        }
        /// <summary>
        /// 登陆注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登陆注销");
        }
        #endregion

        #region 画面打开加载所有子窗体
        /// <summary>
        /// 将子窗体在父窗体中打开
        /// </summary>
        /// <param name="caption">打开tab页的名称</param>
        /// <param name="ViewType">窗体路径</param>
        /// <param name="groupNum">借用tag值进行传值，区分管和机械手：替换变量</param>
        public void ActivateOrAddForm(string caption, string ViewType, int groupNum)
        {
            foreach (Form subForm in MRF.MdiChildren)
            {
                if (subForm.Text == caption)
                {
                    subForm.Activate();
                    return;
                }
            }
            Form fm = (Form)Activator.CreateInstance(Type.GetType(ViewType));
            fm.MdiParent = MRF;
            fm.Text = caption;
            fm.Tag = groupNum;
            fm.Show();
        }

        /// <summary>
        /// 父窗体打开时，默认加载所有子窗体画面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmParent_Load(object sender, EventArgs e)
        {
            ActivateOrAddForm("  总  览  ", "Demo.Forms.frmHomePage", 0);
            ActivateOrAddForm(" 第 一 组 ", "Demo.Forms.Tube.frmTubeMain", 1);
            ActivateOrAddForm(" 第 二 组 ", "Demo.Forms.Tube.frmTubeMain", 2);
            ActivateOrAddForm(" 第 三 组 ", "Demo.Forms.Tube.frmTubeMain", 3);
            ActivateOrAddForm(" 第 四 组 ", "Demo.Forms.Tube.frmTubeMain", 4);
            ActivateOrAddForm(" 第 五 组 ", "Demo.Forms.Tube.frmTubeMain", 5);
            ActivateOrAddForm(" 机 械 手 ", "Demo.Forms.Loader.frmHanderMain", 6);
        }
        #endregion

        #region Dev换肤设置，可优化(已注释，商讨是否无需换肤后决定是否删除)
        /// <summary>
        /// 换肤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void lblSkinsOne_Click(object sender, EventArgs e)
        //{
        //    Skins("DevExpress Style"); 
        //    lblSkinsOne.BackColor = Color.LightBlue;
        //    lblSkinsTwo.BackColor = DefaultBackColor;
        //    lblSkinsThree.BackColor = DefaultBackColor; 
        //}
        //private void lblSkinsTwo_Click(object sender, EventArgs e)
        //{
        //    Skins("Caramel");
        //    lblSkinsTwo.BackColor = Color.LightBlue;
        //    lblSkinsOne.BackColor = DefaultBackColor;
        //    lblSkinsThree.BackColor = DefaultBackColor;
        //}
        //private void lblSkinsThree_Click(object sender, EventArgs e)
        //{
        //    Skins("Office 2007 Black");
        //    lblSkinsThree.BackColor = Color.LightBlue;
        //    lblSkinsOne.BackColor = DefaultBackColor;
        //    lblSkinsTwo.BackColor = DefaultBackColor;
        //}
        //private void Skins(string SkinName)
        //{
        //    defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
        //    defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
        //    defaultLookAndFeel1.LookAndFeel.SkinName = SkinName;
        //}
        #endregion

        private void cmbSelectSkip_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            defaultLookAndFeel1.LookAndFeel.SkinName = cmbSelectSkip.SelectedText;
        }
    }
}