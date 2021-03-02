using com.CommunicationDAL; 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMRON.Compolet.CIPCompolet64;

namespace com.TubeServices
{
    public class TUBEisTEST : Form
    {
        private System.ComponentModel.IContainer components;
   
        private CommunicationDAL.NXCompolet nxCompolet1;
        private CommunicationDAL.NXCompolet nxCompolet2;
        private CommunicationDAL.NXCompolet nxCompolet3;
        private CommunicationDAL.NXCompolet nxCompolet4;
        private CommunicationDAL.NXCompolet nxCompolet5;
        private CommunicationDAL.NXCompolet nxCompolet6;
        public string test;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            this.nxCompolet1.Active = false;
            this.nxCompolet2.Active = false;
            this.nxCompolet3.Active = false;
            this.nxCompolet4.Active = false;
            this.nxCompolet5.Active = false;
            this.nxCompolet6.Active = false;
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nxCompolet1 = new CommunicationDAL.NXCompolet(this.components);
            this.nxCompolet2 = new CommunicationDAL.NXCompolet(this.components);
            this.nxCompolet3 = new CommunicationDAL.NXCompolet(this.components);
            this.nxCompolet4 = new CommunicationDAL.NXCompolet(this.components);
            this.nxCompolet5 = new CommunicationDAL.NXCompolet(this.components);
            this.nxCompolet6 = new CommunicationDAL.NXCompolet(this.components);
            this.SuspendLayout();
            // 
            // TUBEisTEST
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TUBEisTEST";
            this.Load += new System.EventHandler(this.TUBEisTEST_Load);
            this.ResumeLayout(false);
           
        }



        public TUBEisTEST()
        {
            InitializeComponent(); 
            this.nxCompolet1.PeerAddress = "192.168.50.10";
            this.nxCompolet1.Active = true;
            this.nxCompolet2.PeerAddress = "192.168.50.20";
            this.nxCompolet2.Active = true;
            this.nxCompolet3.PeerAddress = "192.168.50.30";
            this.nxCompolet3.Active = true;
            this.nxCompolet4.PeerAddress = "192.168.50.40";
            this.nxCompolet4.Active = true;
            this.nxCompolet5.PeerAddress = "192.168.50.50";
            this.nxCompolet5.Active = true;
            this.nxCompolet6.PeerAddress = "192.168.50.100";
            this.nxCompolet6.Active = true;
        }

        public bool[] iscContinue(int index)
        {
            bool result = false;
            bool[] results = new bool[5];
            switch (index)
            {
                case 1:
                    this.nxCompolet1.PeerAddress = "192.168.50.10";
                    this.nxCompolet1.Active = true;
                    results[0] = this.nxCompolet1.IsConnected;
                    break; 
                case 2:
                    this.nxCompolet2.PeerAddress = "192.168.50.20";
                    this.nxCompolet2.Active = true;
                    results[1] = this.nxCompolet2.IsConnected;
                    break;
                case 3:
                    this.nxCompolet3.PeerAddress = "192.168.50.30";
                    this.nxCompolet3.Active = true;
                    results[2] = this.nxCompolet3.IsConnected;
                    break;
                case 4:
                    this.nxCompolet4.PeerAddress = "192.168.50.40";
                    this.nxCompolet4.Active = true;
                    results[3] = this.nxCompolet4.IsConnected;
                    break;
                case 5:
                    this.nxCompolet5.PeerAddress = "192.168.50.50";
                    this.nxCompolet5.Active = true;
                    results[4] = this.nxCompolet5.IsConnected;
                    break;
                case 6:
                    this.nxCompolet6.PeerAddress = "192.168.50.100";
                    this.nxCompolet6.Active = true;
                    results[5] = this.nxCompolet6.IsConnected;
                    break;
                default:
                    break;
                   
            }

            return results;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
             
        }
        /// <summary>
        /// 读标签
        /// </summary>
        /// <param name="index"></param>
        /// <param name="varName">  </param>
        /// <returns></returns>
        public string   GetVariableInfo(int index,string varName)
        {
            object val=null;
            try
            {
                string[] variableList = new string[1];
           
                if (index == 1)
                {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet1.ReadVariableMultiple(variableList);
                    val = retValue[varName];
                } else if (index ==2 ) {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet2.ReadVariableMultiple(variableList);
                    val = retValue[varName];
                } else if (index ==3 )
                {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet3.ReadVariableMultiple(variableList);
                    val = retValue[varName];
                } else if (index ==4 )
                {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet4.ReadVariableMultiple(variableList);
                    val = retValue[varName];

                } else if (index ==5 )
                {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet5.ReadVariableMultiple(variableList);
                    val = retValue[varName];

                } else if (index ==6)
                {
                    variableList[0] = varName;
                    Hashtable retValue = this.nxCompolet6.ReadVariableMultiple(variableList);
                    val = retValue[varName];

                }

                Array.Clear(variableList, 0, variableList.Length);



            }
            catch (Exception ex )
            {
                MessageBox.Show(string.Format("ReadVariableMultiple异常：{0}_{1}", varName, ex.Message.ToString()));
            }
             
           return  Convert.ToString(val);

        }
        /// <summary>
        /// 写标签
        /// </summary>
        /// <param name="index"></param>
        /// <param name="varName"></param>
        /// <param name="witeValue"></param>
        public void WiteVariable(int index ,string varName,string witeValue) {

            try
            {
                if (index == 1)
                {
                    this.nxCompolet1.WriteVariable(varName, witeValue);
                } else if (index == 2)
                {
                    this.nxCompolet2.WriteVariable(varName, witeValue);
                }
                else if (index == 3)
                {
                    this.nxCompolet3.WriteVariable(varName, witeValue);
                }
                else if (index == 4)
                {
                    this.nxCompolet4.WriteVariable(varName, witeValue);
                }
                else if (index == 5)
                {
                    this.nxCompolet5.WriteVariable(varName, witeValue);
                } else if (index == 6)
                {
                    this.nxCompolet6.WriteVariable(varName, witeValue);
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(string.Format("WriteVariable异常：{0}_{1}", witeValue, ex.Message.ToString()));
            } 
        }
        /// <summary>
        /// 读复杂标签
        /// </summary>
        /// <param name="index"></param>
        /// <param name="varName"></param>
        /// <returns></returns>
        public byte[] ReadVariable(int index,string varName) {

            string[] variableList = new string[1];
            variableList[0] = varName;
            Hashtable retVals = this.nxCompolet1.ReadVariableMultiple(variableList);
            byte[] data = retVals[varName] as byte[];
            if (data != null || data.Length < 0)
            {
                MessageBox.Show(string.Format("ReadVariableMultiple数据为空"));
                varName = BitConverter.ToString(data, 0, data.Length).Replace("-", " ");
            }
            return data;
        }

        private void TUBEisTEST_Load(object sender, EventArgs e)
        {

        }
    }
}
