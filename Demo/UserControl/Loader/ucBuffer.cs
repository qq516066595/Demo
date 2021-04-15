using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Demo.UserControl.Loader
{
    public partial class ucBuffer : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler BoatID;
        public event EventHandler BoatState;
        public ucBuffer()
        {
            InitializeComponent();
            DataInit();
        }

        public TextEdit TxtBoatID
        {
            get { return txtBoatID; }
            set { txtBoatID = value; }
        }
        public ComboBoxEdit CmbBoatState
        {
            get { return cmbBoatState; }
            set { cmbBoatState = value; }
        }
        public LabelControl LblFromTube
        {
            get { return lblFromTube; }
            set { lblFromTube = value; }
        }
        public LabelControl LblMode
        {
            get { return lblMode; }
            set { lblMode = value; }
        }
        public LabelControl LblCDTime
        {
            get { return lblCDTime; }
            set { lblCDTime = value; }
        }
        public LabelControl LblStorageTime
        {
            get { return lblStorageTime; }
            set { lblStorageTime = value; }
        }
        public LabelControl LblLight_L
        {
            get { return lblLight_L; }
            set { lblLight_L = value; }
        }
        public LabelControl LblLight_R
        {
            get { return lblLight_R; }
            set { lblLight_R = value; }
        }

        private void DataInit()
        {
  
            this.cmbBoatState.Properties.Items.Add("禁止");
            this.cmbBoatState.Properties.Items.Add("无舟");
            this.cmbBoatState.Properties.Items.Add("空舟");
            this.cmbBoatState.Properties.Items.Add("未工艺舟");
            this.cmbBoatState.Properties.Items.Add("已工艺舟");
            this.cmbBoatState.Properties.Items.Add("异常舟");
            //this.cmbBoatState.Properties.Items.Add("空桨饱和");
            //this.cmbBoatState.Properties.Items.Add("饱和完成");
            //this.cmbBoatState.Properties.Items.Add("正在工艺");
            this.cmbBoatState.Properties.Items.Add("实验舟");
            this.cmbBoatState.Properties.Items.Add("待清洗舟");
          
        }
        private void txtBoatID_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (BoatID != null)
                {
                    BoatID(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("舟号设置异常：" + ex.Message);
            }
            
        }

        private void cmbBoatState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (BoatState != null)
                {
                    BoatState(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("舟状态设置异常：" + ex.Message);
            }


        }

    }
}
