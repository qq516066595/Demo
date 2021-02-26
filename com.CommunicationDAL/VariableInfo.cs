using System;
using OMRON.Compolet.CIP;
using OMRON.Compolet.CIPCompoletProxyLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
   public class VariableInfo
    {
        public string Name;

        public VariableType Type;

        public bool IsArray;

        public byte Dimension;

        public long[] NumberOfElements;

        public VariableInfo[] StructMembers;

        public long[] StartArrayElements;

        public static VariableInfo FromProxy(VariableInfoProxy proxy)
        {
            VariableInfo variableInfo = new VariableInfo();
            variableInfo.Name = proxy.Name;
            variableInfo.Type = (VariableType)((byte)proxy.Type);
            variableInfo.IsArray = proxy.IsArray;
            variableInfo.Dimension = proxy.Dimension;
            bool flag = proxy.NumberOfElements != null;
            if (flag)
            {
                variableInfo.NumberOfElements = new long[proxy.NumberOfElements.Length];
                proxy.NumberOfElements.CopyTo(variableInfo.NumberOfElements, 0);
            }
            else
            {
                variableInfo.NumberOfElements = null;
            }
            bool flag2 = proxy.StructMembers != null;
            if (flag2)
            {
                variableInfo.StructMembers = new VariableInfo[proxy.StructMembers.Length];
                for (int i = 0; i < proxy.StructMembers.Length; i++)
                {
                    variableInfo.StructMembers[i] = VariableInfo.FromProxy(proxy.StructMembers[i]);
                }
            }
            else
            {
                variableInfo.StructMembers = null;
            }
            bool flag3 = proxy.StartArrayElements != null;
            if (flag3)
            {
                variableInfo.StartArrayElements = new long[proxy.StartArrayElements.Length];
                proxy.StartArrayElements.CopyTo(variableInfo.StartArrayElements, 0);
            }
            else
            {
                variableInfo.StartArrayElements = null;
            }
            return variableInfo;
        }
    }
}
