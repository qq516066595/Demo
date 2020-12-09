using OMRON.Compolet.CIPCompolet64;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.CIPServer
{
    public class CIPDriver: NXCompolet
    {
        // private CIPDriver instance;


        List<string> ips = new List<string>();
        public static System.ComponentModel.IContainer components = new System.ComponentModel.Container();
        public OMRON.Compolet.CIPCompolet64.NXCompolet nxCompolet1 = new OMRON.Compolet.CIPCompolet64.NXCompolet(components);

        private Thread zConnectThread;
        private bool zUpdateCom;
        private bool zHoldingUpdateCom;


        public CIPDriver() { }




        public CIPDriver(string ips, bool active)
        {
            this.nxCompolet1.Active = true;
            this.nxCompolet1.PeerAddress = ips;
            //bool isConnect = this.nxCompolet1.IsConnected;
            //string ok = isConnect.ToString();
            this.nxCompolet1.Active = active;


        }

        public void StartComServer()
        {
            zConnectThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                }
            });
            zUpdateCom = true;
            zHoldingUpdateCom = false;
            zConnectThread.IsBackground = true;
            zConnectThread.Priority = ThreadPriority.Normal;
            zConnectThread.Start();

        }


        public void StopComServer()
        {
            zUpdateCom = false;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void BackOff()
        {
            if (this.nxCompolet1 != null && this.nxCompolet1.IsConnected)
            {
                this.nxCompolet1.Active = false;
            }
        }
        /// <summary>
        /// 重新连接
        /// </summary>
        public void Reconnect()
        {
            if (this.nxCompolet1 != null && this.nxCompolet1.IsConnected == false)
            {
                this.nxCompolet1.Active = true;
            }
        }
        /// <summary>
        /// 判断类型
        /// </summary>
        /// <param name="varName">获取类型的名称</param>
        /// <returns></returns>
        public string GetVariableInfo(string varName)
        {
            VariableInfo tempInfo = this.nxCompolet1.GetVariableInfo(varName);

            return string.Format("是否是数组：{0}，类型：{1}", tempInfo.IsArray, tempInfo.Type.ToString()); ;
        }
        /// <summary>
        /// 读取简单
        /// </summary>
        /// <param name="VarName">读取简单数据</param>
        /// <returns></returns>
        public string VariableMultiple(string VarName)
        {
            string[] variableList = new string[1];
            variableList[0] = VarName;
            Hashtable retValue = this.nxCompolet1.ReadVariableMultiple(variableList);
            object val = retValue[VarName];
            return Convert.ToString(val);
        }
        /// <summary>
        /// 读取复杂
        /// </summary>
        /// <param name="VarName">读取复杂类型的名称</param>
        /// <returns></returns>
        public string ReadVariableMultiple(string VarName)
        {
            string result = null;
            string[] variableList = new string[1];
            variableList[0] = VarName;
            Hashtable retValue = this.nxCompolet1.ReadVariableMultiple(variableList);
            byte[] data = retValue[VarName] as byte[];
            if (data != null || data.Length < 0)
            {
                result = BitConverter.ToString(data, 0, data.Length).Replace("-", " ");
            }
            return result;
        }
        /// <summary>
        /// 写入设备
        /// </summary>
        /// <param name="VarName">写入的变量名称</param>
        public void WiteVariable(string VarName)
        {
            this.nxCompolet1.WriteVariable(VarName, VarName);

        }

    }
}
