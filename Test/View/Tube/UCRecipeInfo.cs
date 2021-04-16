using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test.View.Tube
{
    public partial class UCRecipeInfo : UserControl
    {
        public UCRecipeInfo()
        {
            InitializeComponent();

        }
        View.Common.CommonClass comm = new Common.CommonClass();

        private void UCRecipeInfo_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();

            lstCom.Add(new KeyValuePair<string, string>("0", "--"));
            lstCom.Add(new KeyValuePair<string, string>("1", "无舟"));
            lstCom.Add(new KeyValuePair<string, string>("2", "空舟"));
            lstCom.Add(new KeyValuePair<string, string>("3", "未工艺舟"));
            lstCom.Add(new KeyValuePair<string, string>("4", "已工艺舟"));
            lstCom.Add(new KeyValuePair<string, string>("5", "异常舟"));
            lstCom.Add(new KeyValuePair<string, string>("6", "实验舟"));
            lstCom.Add(new KeyValuePair<string, string>("7", "空桨饱和"));
            lstCom.Add(new KeyValuePair<string, string>("8", "饱和完成"));
            lstCom.Add(new KeyValuePair<string, string>("9", "正在工艺"));
            lstCom.Add(new KeyValuePair<string, string>("10", "待清洗舟"));
            this.ucBoatState.Source = lstCom;
            this.ucBoatState.SelectedIndex = 0;
            lblRecipeInfoTitle.Text = "工艺设置-管";
            comm.OnNumChanged += Identify1_OnIdentifyTimeChanged;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblRecipeInfoTitle.Text = "工艺设置-测试";
        }

        public void Identify1_OnIdentifyTimeChanged(object sender, EventArgs e)
        {
            lblRecipeInfoTitle.Text = "工艺设置-管" + (((View.Common.CommonClass)sender).Num + 1).ToString();
            //MessageBox.Show(((View.Common.CommonClass)sender).Num.ToString());
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            lblRecipeInfoTitle.Text = "工艺设置-管";
        }
    }
}
