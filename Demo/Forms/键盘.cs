using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.CommunicationDAL;

namespace Demo.Forms
{
    internal partial class 键盘 : Form
    {
        public 键盘()
        {
            InitializeComponent();
        }

        private void 键盘_Load(object sender, EventArgs e)
        {

        }

        private void SKB_14_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                int Index = (int)Conversion.Val(bt.Tag);

                Text1.Focus();

                if (Index >= 0 && Index <= 9)
                {
                    System.Windows.Forms.SendKeys.Send(Convert.ToString(Index));
                }
                //ORIGINAL LINE: Case 10
                else if (Index == 10)
                {
                    System.Windows.Forms.SendKeys.Send(".");
                }
                //ORIGINAL LINE: Case 12
                else if (Index == 12)
                {
                    System.Windows.Forms.SendKeys.Send("{BS}");
                }
                //ORIGINAL LINE: Case 14
                else if (Index == 14)
                {
                    CheckIt();
                }
                //ORIGINAL LINE: Case 15
                else if (Index == 15)
                {
                    MyModu.Gyedit = "cancel";
                    this.Close();
                }
                else if (Index == 20)
                {
                    System.Windows.Forms.SendKeys.Send("-");
                }

            }
            catch
            {
                goto eh;
            }
        eh:;
        }

        private void CheckIt()
        {
            
            double Value = 0;
            Value = Microsoft.VisualBasic.Conversion.Val(Text1.Text);
            if (Value > MyModu.MaxSet | Value < MyModu.MinSet)
            {
                MessageBox.Show("请将值设定在 " + MyModu.MinSet + " 和 " + MyModu.MaxSet + " 之间！", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyModu.Gyedit = Text1.Text;
            this.Close();
        }

        private void 键盘_Shown(object sender, EventArgs e)
        {
            Text1.Clear();
            MyModu.Gyedit = "cancel";
        }

       
    }
}
