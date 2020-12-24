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


       



        bool bDropDown_Vertical = false;

        /* Button btn = new Button(bDropDown_Horizon, @"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\静音 红.png", @"E:\工作\项目\02VS\12.14\Demo\Demo\Resources\静音.png", picAuto_Manual);
         */
        private void picDropDown_Vertical_Click(object sender, EventArgs e)
        {
            //  btn.Click();
            bDropDown_Vertical = !bDropDown_Vertical;
            pnlHorizon.Size = new Size(248, 120);
            pnlTransport.Size = new Size(248, 120);
            bDropDown_Horizon = bDropDown_Transport = false;
            if (bDropDown_Vertical)
            {
                // pnlVertical.Size = new Size(248, 445);
                pnlVertical.Size = new Size(248, 575);
                //  pnlOther.Visible = false;
            }
            else
            {
                pnlVertical.Size = new Size(248, 120);
                // pnlOther.Visible = true;
            }
        }

        bool bDropDown_Horizon = false;
        private void picDropDown_Horizon_Click(object sender, EventArgs e)
        {
            bDropDown_Horizon = !bDropDown_Horizon;
            pnlVertical.Size = new Size(248, 120);
            pnlTransport.Size = new Size(248, 120);
            bDropDown_Vertical = bDropDown_Transport = false;
            if (bDropDown_Horizon)
            {
                // pnlHorizon.Size = new Size(248, 360);
                pnlHorizon.Size = new Size(248, 455);
                // pnlOther.Visible = false;

            }
            else
            {
                pnlHorizon.Size = new Size(248, 120);
                //  pnlOther.Visible = true;
            }
        }

        bool bDropDown_Transport = false;
        private void picDropDown_L_Click(object sender, EventArgs e)
        {
            bDropDown_Transport = !bDropDown_Transport;
            pnlHorizon.Size = new Size(248, 120);
            pnlVertical.Size = new Size(248, 120);
            bDropDown_Vertical = bDropDown_Horizon = false;
            if (bDropDown_Transport)
            {
                // pnlTransport.Size= new Size(248,190);
                pnlTransport.Size = new Size(248, 340);
                //  pnlOther.Visible = false;

            }
            else
            {
                pnlTransport.Size = new Size(248, 120);
                // pnlOther.Visible = true;
            }
        }


        private void xtraTabControl1_Enter(object sender, EventArgs e)
        {
            pnlHorizon.Size = new Size(248, 120);
            pnlVertical.Size = new Size(248, 120);
            pnlTransport.Size = new Size(248, 120);
            pnlDoorLock.Size = new Size(248, 70);
            pnlOther.Size = new Size(248, 110);
        }

    }
}