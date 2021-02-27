using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using com.DataBaseModels;
using System.Threading;
using OMRON.Compolet.CIPCompolet64;
namespace com.CommunicationDAL
{
    public  class PlcOmronCip
    {
        private static System.Timers.Timer t1=new System.Timers.Timer();
        private OMRON.Compolet.CIPCompolet64.NXCompolet[] nxCompolet_Tube=new NXCompolet[6];
        private OMRON.Compolet.CIPCompolet64.NXCompolet nxCompolet_Jht=new NXCompolet();

        public PlcOmronCip()
        {
            
            for (int i = 1; i <= 5; i++)
                nxCompolet_Tube[i] = new NXCompolet();

            nxCompolet_Jht.PeerAddress = "192.168.50.100";
            nxCompolet_Tube[1].PeerAddress = "192.168.50.10";
            nxCompolet_Tube[2].PeerAddress = "192.168.50.20";
            nxCompolet_Tube[3].PeerAddress = "192.168.50.30";
            nxCompolet_Tube[4].PeerAddress = "192.168.50.40";
            nxCompolet_Tube[5].PeerAddress = "192.168.50.50";

            nxCompolet_Jht.ConnectionType = OMRON.Compolet.CIPCompolet64.ConnectionType.UCMM;
            nxCompolet_Jht.LocalPort = 2;
            nxCompolet_Jht.Active = true;

            for (int i = 1; i <= 5; i++)
            {
                nxCompolet_Tube[i].ConnectionType = OMRON.Compolet.CIPCompolet64.ConnectionType.UCMM;
                nxCompolet_Tube[i].LocalPort = 2;
                nxCompolet_Tube[i].Active = true;
            }

            t1.Interval = 1000;//时间间隔1s
            t1.Elapsed += new System.Timers.ElapsedEventHandler(RW_PLC);
            t1.AutoReset = true;
            t1.Enabled = true;
            t1.Start();

        }

        public  void RW_PLC(object source,System.Timers.ElapsedEventArgs e)
        {
            PlcVar.Jht.HmiConnected = nxCompolet_Jht.IsConnected;
            for (int i = 1; i <= 5; i++)
            {
                PlcVar.Tube[i].HmiConnected = nxCompolet_Tube[i].IsConnected;
            }
                
           
            
            
        }
       
    }

}
