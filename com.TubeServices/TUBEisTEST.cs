using com.CommunicationDAL;
using OMRON.Compolet.CIPCompolet64;
using System;using System.Collections;
using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;


namespace com.TubeServices{    public class TUBEisTEST : Form    {        private System.ComponentModel.IContainer components;
        private Button button1; 
        private CommunicationDAL.NXCompolet nxCompolet1;
        private CommunicationDAL.NXCompolet nxCompolet2;
        private CommunicationDAL.NXCompolet nxCompolet3;
        private CommunicationDAL.NXCompolet nxCompolet4;
        private CommunicationDAL.NXCompolet nxCompolet5;
        private CommunicationDAL.NXCompolet nxCompolet6;        protected override void Dispose(bool disposing)        {            if (disposing)            {                if (components != null)                {                    components.Dispose();                }            }            this.nxCompolet1.Active = false;            base.Dispose(disposing);        }
        private void InitializeComponent()        {
            this.components = new System.ComponentModel.Container();
            this.nxCompolet1 = new com.CommunicationDAL.NXCompolet(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nxCompolet1
            // 
            //this.nxCompolet1.Active = false;
            //this.nxCompolet1.ConnectionType = OMRON.Compolet.CIPCompolet64.ConnectionType.UCMM;
            //this.nxCompolet1.DontFragment = false;
            //this.nxCompolet1.LocalPort = 2;
            //this.nxCompolet1.PeerAddress = "";
            //this.nxCompolet1.ReceiveTimeLimit = ((long)(750));
            //this.nxCompolet1.RoutePath = "";
            //this.nxCompolet1.UseRoutePath = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TUBEisTEST
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "TUBEisTEST";
            this.ResumeLayout(false);

        }
        public TUBEisTEST()        {
            InitializeComponent();             

        }        public bool[] iscContinue(int index)
        {
            bool result = false;            bool[] results = new bool[5];            switch (index)
            {
                case 1:
                    this.nxCompolet1.PeerAddress = "192.168.50.10";
                    this.nxCompolet2.Active = true;
                    results[0] = this.nxCompolet1.IsConnected;
                    break; 
                case 2:
                    this.nxCompolet1.PeerAddress = "192.168.50.20";
                    this.nxCompolet1.Active = true;
                    results[1] = this.nxCompolet2.IsConnected;
                    break;
                case 3:
                    this.nxCompolet1.PeerAddress = "192.168.50.30";
                    this.nxCompolet1.Active = true;
                    results[2] = this.nxCompolet3.IsConnected;
                    break;
                case 4:
                    this.nxCompolet1.PeerAddress = "192.168.50.40";
                    this.nxCompolet1.Active = true;
                    results[3] = this.nxCompolet4.IsConnected;
                    break;
                case 5:
                    this.nxCompolet1.PeerAddress = "192.168.50.50";
                    this.nxCompolet1.Active = true;
                    results[4] = this.nxCompolet5.IsConnected;
                    break;
                case 6:
                    this.nxCompolet1.PeerAddress = "192.168.50.100";
                    this.nxCompolet1.Active = true;
                    results[5] = this.nxCompolet6.IsConnected;
                    break;
                default:
                    break;
                   
            }

            return results;        }     
        private void button1_Click(object sender, EventArgs e)
        {
             
        }
        //读取标签
        public string    GetVariableInfo(int index,string varName) {
            string[] variableList = new string[1];
            variableList[0] = varName;
            Hashtable retValue = this.nxCompolet1.ReadVariableMultiple(variableList);
            object val = retValue[varName];
           return  Convert.ToString(val);

        }







    }}