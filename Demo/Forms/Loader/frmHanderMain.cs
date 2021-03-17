using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Demo.Forms.Loader;

/*
* namespace：Demo.Forms
* className：frmHomePage
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-12 11:57:58
* Desc：机械手页面
* 
* Remarks：
*/
namespace Demo.Forms.Loader
{
    public partial class frmHanderMain : DevExpress.XtraEditors.XtraForm
    {
        public frmHanderMain()
        {
            InitializeComponent();

            //初始化轴参数
            pnlHorizon.Size = new Size(286, 120);
            pnlVertical.Size = new Size(286, 120);
            pnlTransport.Size = new Size(286, 120);
            pnlDoorLock.Size = new Size(286, 70);

            ucIO_Menu1.InputClick += InputClick;
            ucIO_Menu1.OutputClick += OutputClick;
            ucIO_Menu1.CommClick += CommClick;
            ucIO_Menu1.MenuEnter += MenuEnter;
            ucIO_Menu1.Size = new Size(42, 50);

            ucIO_Menu2.InputClick += InputClick;
            ucIO_Menu2.OutputClick += OutputClick;
            ucIO_Menu2.CommClick += CommClick;
            ucIO_Menu2.MenuEnter += MenuEnter;
            ucIO_Menu2.Size = new Size(42, 50);

            ucIO_Menu3.InputClick += InputClick;
            ucIO_Menu3.OutputClick += OutputClick;
            ucIO_Menu3.CommClick += CommClick;
            ucIO_Menu3.MenuEnter += MenuEnter;
            ucIO_Menu3.Size = new Size(42, 50);
            
        }


        #region 垂直轴收缩条
        bool bDropDown_Vertical = false; //定义变量
        /// <summary>

        private void picDropDown_Vertical_Click(object sender, EventArgs e) //定义下拉条点击事件
        {

            bDropDown_Vertical = !bDropDown_Vertical;
            pnlHorizon.Size = new Size(286, 120); //点击后复位其他下拉条
            pnlTransport.Size = new Size(286, 120);//点击后复位其他下拉条
            bDropDown_Horizon = bDropDown_Transport = false;//点击后复位其他下拉条
            if (bDropDown_Vertical)
            {

                pnlVertical.Size = new Size(286, 741);

            }
            else
            {
                pnlVertical.Size = new Size(286, 120);

            }
        }
        #endregion

        #region 水平轴收缩条
        bool bDropDown_Horizon = false; //定义变量
        private void picDropDown_Horizon_Click(object sender, EventArgs e) //定义下拉条点击事件
        {
            bDropDown_Horizon = !bDropDown_Horizon;
            pnlVertical.Size = new Size(286, 120); //点击后复位其他下拉条
            pnlTransport.Size = new Size(286, 120);//点击后复位其他下拉条
            bDropDown_Vertical = bDropDown_Transport = false;//点击后复位其他下拉条
            if (bDropDown_Horizon)
            {
                pnlHorizon.Size = new Size(286, 619);
            }
            else
            {
                pnlHorizon.Size = new Size(286, 120);
            }
        }
        #endregion

        #region 输送机收缩条
        bool bDropDown_Transport = false; //定义变量
        private void picDropDown_L_Click(object sender, EventArgs e) //定义下拉条点击事件
        {
            bDropDown_Transport = !bDropDown_Transport;
            pnlHorizon.Size = new Size(286, 120);//点击后复位其他下拉条
            pnlVertical.Size = new Size(286, 120);//点击后复位其他下拉条
            bDropDown_Vertical = bDropDown_Horizon = false;//点击后复位其他下拉条
            if (bDropDown_Transport)
            {
                pnlTransport.Size = new Size(286, 497);
            }
            else
            {
                pnlTransport.Size = new Size(286, 120);
            }
        }
        #endregion

        private void InputClick(object sender, EventArgs e)
        {

            tcIO.SelectedTabPage = tpInput;
            ucIO_Menu1.Size = new Size(42, 50);
            ucIO_Menu2.Size = new Size(42, 50);
            ucIO_Menu3.Size = new Size(42, 50);

        }

        private void OutputClick(object sender, EventArgs e)
        {
            tcIO.SelectedTabPage = tpOutput;
            ucIO_Menu1.Size = new Size(42, 50);
            ucIO_Menu2.Size = new Size(42, 50);
            ucIO_Menu3.Size = new Size(42, 50);
        }

        private void CommClick(object sender, EventArgs e)
        {
            tcIO.SelectedTabPage = tpCommunication;
            ucIO_Menu1.Size = new Size(42, 50);
            ucIO_Menu2.Size = new Size(42, 50);
            ucIO_Menu3.Size = new Size(42, 50);
        }

        private void MenuEnter(object sender, EventArgs e)
        {
            ucIO_Menu1.Size = new Size(139, 301);
            ucIO_Menu2.Size = new Size(139, 301);
            ucIO_Menu3.Size = new Size(139, 301);
        }

        private void ucIO_Menu_MouseLeave(object sender, EventArgs e)
        {
            ucIO_Menu1.Size = new Size(42, 50);
            ucIO_Menu2.Size = new Size(42, 50);
            ucIO_Menu3.Size = new Size(42, 50);
        }

        private void lblNameBuffer1_Main_Click(object sender, EventArgs e)
        {

        }

        private void ucBoat_Buffer1_Load(object sender, EventArgs e)
        {

        }

        private void ucBuffer1_Load(object sender, EventArgs e)
        {

        }
    }
}