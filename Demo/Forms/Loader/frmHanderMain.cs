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
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            bDoorEnable = !bDoorEnable;
            if (bDoorEnable)
            {
                picDoorEnable.Image = Image.FromFile(@"E:\工作\项目\02VS\资源\门禁管理红.png");
            }
            else
            {
                picDoorEnable.Image = Image.FromFile(@"E:\工作\项目\02VS\资源\门禁管理绿.png");
            }
            //pictureEdit1.Image = Image.FromFile(@"门禁管理红.png");
        }

        public bool bDoorEnable;
        private void picDoorEnable_EditValueChanged(object sender, EventArgs e)
        {

        }
        public bool bAuto_Manual;
        private void picAuto_Manual_Click(object sender, EventArgs e)
        {
            bAuto_Manual = !bAuto_Manual;
            if (bAuto_Manual)
            {
                picAuto_Manual.Image = Image.FromFile(@"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\双手自动红 (1).png");

            }
            else
            {
                picAuto_Manual.Image = Image.FromFile(@"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\双手自动绿.png");
            }
        }

        private void btnNegative_Limit_Click(object sender, EventArgs e)
        {

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {

        }

        bool bDropDown_Vertical = false;
       /* Button btn = new Button(bDropDown_Horizon, @"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\静音 红.png", @"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\静音.png", picAuto_Manual);
        */
        private void picDropDown_Vertical_Click(object sender, EventArgs e)
        {
            //  btn.Click();
            bDropDown_Vertical = !bDropDown_Vertical;
            if (bDropDown_Vertical)
            {
                pnlVertical_Control.Visible = true;
            }
            else
            {
                pnlVertical_Control.Visible = false;
            }
        }

        bool bDropDown_Horizon = false;
        private void picDropDown_Horizon_Click(object sender, EventArgs e)
        {
            bDropDown_Horizon = !bDropDown_Horizon;
            if (bDropDown_Horizon)
            {
                pnlHorizon_Control.Visible = true;
            }
            else
            {
                pnlHorizon_Control.Visible = false;
            }
        }

        public bool bDropDown_Horizon_T = false;
        private void picDropDown_L_Click(object sender, EventArgs e)
        {
            bDropDown_Horizon_T = !bDropDown_Horizon_T;
            if (bDropDown_Horizon_T)
            {
                pnlTransport_Control.Visible = true;
            }
            else
            {
                pnlTransport_Control.Visible = false;
            }
        }

        private void ucBoat11_Load(object sender, EventArgs e)
        {

        }

        private void ucBoat12_Load(object sender, EventArgs e)
        {

        }

        private void ucBoat7_Load(object sender, EventArgs e)
        {

        }

        private void ucBoat9_Load(object sender, EventArgs e)
        {

        }

        private void ucBoat8_Load(object sender, EventArgs e)
        {

        }

        private void ucBoat10_Load(object sender, EventArgs e)
        {

        }
    }
}