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
using com.DataBaseModels;
/*
* namespace：Demo.Forms.Tube
* className：frmUnlockPwd
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-28 18:21:59
* Desc：解除联锁,目前为设置固定密码<123321>；如需设置可配置化则再完善
* 
* Remarks：权限控制待完善
*/
namespace Demo.Forms.Tube
{
    public partial class frmUnlockPwd : DevExpress.XtraEditors.XtraForm
    {
        PlcModels modus = new PlcModels();
        public frmUnlockPwd()
        {
            InitializeComponent();
        }
        public frmUnlockPwd(PlcModels mys)
        {
            
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text == "123321")
            {
                modus.gbBoatPush_Unlock = true;
                this.Close();
            }
            else
            {
                txtPwd.Text = "";
                picError.Visible = true;
            }
        }

        private void txtPwd_EditValueChanged(object sender, EventArgs e)
        {
            picError.Visible = false;
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}