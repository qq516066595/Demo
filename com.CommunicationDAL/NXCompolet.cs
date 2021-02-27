using OMRON.Compolet.CIPCompolet64;
using OMRON.Compolet.CIPCompoletProxyLib;
using OMRON.Compolet.Framework.Function.EventLogs;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;

namespace com.CommunicationDAL
{
    //欧姆龙CIP
    [ToolboxBitmap(typeof(NXCompolet), "NXCompolet.ico")]
   public    class NXCompolet  : Component
    {
        public enum RunModeTypes
        {
            Program,
            Run = 4
        }

        private INXCompoletProxy _proxy;

        private Guid _objectID = Guid.Empty;

        private bool _connected = false;

        private readonly object _syncObject = new object();

        private string _routePath = string.Empty;

        public ConnectionType _connectionType = ConnectionType.UCMM;

        private bool _useRoutePath = false;

        private string _peerAddress = string.Empty;

        private int _localPort = 2;

        private bool _dontFlagment = false;

        private long _receiveTimeLimit = 750L;

        private Encoding _plcEncoding = Encoding.UTF8;

        [Browsable(false)]
        public bool Active
        {
            get
            {
                object syncObject = this._syncObject;
                bool result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = false;
                    }
                    else
                    {
                        try
                        {
                            this._connected = this._proxy.GetActive(this._objectID);
                        }
                        catch
                        {
                            this._connected = false;
                        }
                        result = this._connected;
                    }
                }
                return result;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    bool flag = this._proxy != null && this._objectID != Guid.Empty;
                    if (flag)
                    {
                        bool flag2 = this._connected == value;
                        if (!flag2)
                        {
                            if (value)
                            {
                                this._proxy.SetConnectionType(this._objectID, (OMRON.Compolet.CIP.ConnectionType)this._connectionType);
                                this._proxy.SetUseRoutePath(this._objectID, this._useRoutePath);
                                bool useRoutePath = this._useRoutePath;
                                if (useRoutePath)
                                {
                                    this._proxy.SetRoutePath(this._objectID, this._routePath);
                                }
                                else
                                {
                                    this._proxy.SetPeerAddress(this._objectID, this._peerAddress);
                                    this._proxy.SetLocalPort(this._objectID, this._localPort);
                                }
                                this._proxy.SetDontFragment(this._objectID, this._dontFlagment);
                                this._proxy.SetPlcEncoding(this._objectID, this._plcEncoding);
                                this._proxy.SetReceiveTimeLimit(this._objectID, this._receiveTimeLimit);
                            }
                            this._proxy.SetActive(this._objectID, value);
                            this._connected = this._proxy.GetActive(this._objectID);
                        }
                    }
                }
            }
        }

        public long ReceiveTimeLimit
        {
            get
            {
                object syncObject = this._syncObject;
                long receiveTimeLimit;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        receiveTimeLimit = this._receiveTimeLimit;
                    }
                    else
                    {
                        receiveTimeLimit = this._proxy.GetReceiveTimeLimit(this._objectID);
                    }
                }
                return receiveTimeLimit;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._receiveTimeLimit = value;
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetReceiveTimeLimit(this._objectID, value);
                    }
                }
            }
        }

        public  ConnectionType ConnectionType
        {
            get
            {
                object syncObject = this._syncObject;
                  ConnectionType connectionType;
                lock (syncObject)
                {
                    connectionType = _connectionType;
                }
                return connectionType;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._connectionType = value;
                }
            }
        }

        public string PeerAddress
        {
            get
            {
                object syncObject = this._syncObject;
                string peerAddress;
                lock (syncObject)
                {
                    peerAddress = this._peerAddress;
                }
                return peerAddress;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._peerAddress = value;
                }
            }
        }

        public int LocalPort
        {
            get
            {
                object syncObject = this._syncObject;
                int localPort;
                lock (syncObject)
                {
                    localPort = this._localPort;
                }
                return localPort;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._localPort = value;
                }
            }
        }

        public bool UseRoutePath
        {
            get
            {
                object syncObject = this._syncObject;
                bool useRoutePath;
                lock (syncObject)
                {
                    useRoutePath = this._useRoutePath;
                }
                return useRoutePath;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._useRoutePath = value;
                }
            }
        }

        public string RoutePath
        {
            get
            {
                object syncObject = this._syncObject;
                string routePath;
                lock (syncObject)
                {
                    routePath = this._routePath;
                }
                return routePath;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._routePath = value;
                }
            }
        }

        public bool IsConnected
        {
            get
            {
                object syncObject = this._syncObject;
                bool result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = false;
                    }
                    else
                    {
                        result = this._proxy.GetIsConnected(this._objectID);
                    }
                }
                return result;
            }
        }

        public bool DontFragment
        {
            get
            {
                object syncObject = this._syncObject;
                bool result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = this._dontFlagment;
                    }
                    else
                    {
                        result = this._proxy.GetDontFragment(this._objectID);
                    }
                }
                return result;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._dontFlagment = value;
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetDontFragment(this._objectID, value);
                    }
                }
            }
        }

        public string TypeName
        {
            get
            {
                object syncObject = this._syncObject;
                string result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = null;
                    }
                    else
                    {
                        result = this._proxy.GetTypeName(this._objectID);
                    }
                }
                return result;
            }
        }

        [Browsable(false), ReadOnly(true)]
        public DateTime Clock
        {
            get
            {
                object syncObject = this._syncObject;
                DateTime result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = DateTime.MinValue;
                    }
                    else
                    {
                        result = this._proxy.GetClock(this._objectID);
                    }
                }
                return result;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetClock(this._objectID, value);
                    }
                }
            }
        }

        [Browsable(false), ReadOnly(true)]
        public string UnitName
        {
            get
            {
                object syncObject = this._syncObject;
                string result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = null;
                    }
                    else
                    {
                        result = this._proxy.GetUnitName(this._objectID);
                    }
                }
                return result;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetUnitName(this._objectID, value);
                    }
                }
            }
        }

        [Browsable(false), ReadOnly(true)]
        public NXCompolet.RunModeTypes RunMode
        {
            get
            {
                object syncObject = this._syncObject;
                NXCompolet.RunModeTypes result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = NXCompolet.RunModeTypes.Program;
                    }
                    else
                    {
                        result = (NXCompolet.RunModeTypes)this._proxy.GetRunMode(this._objectID);
                    }
                }
                return result;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetRunMode(this._objectID, (OMRON.Compolet.CIP.NXCompolet.RunModeTypes)value);
                    }
                }
            }
        }

        public short RunStatus
        {
            get
            {
                object syncObject = this._syncObject;
                short result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = -1;
                    }
                    else
                    {
                        result = this._proxy.GetRunStatus(this._objectID);
                    }
                }
                return result;
            }
        }

        [Browsable(false)]
        public string[] VariableNames
        {
            get
            {
                object syncObject = this._syncObject;
                string[] result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = null;
                    }
                    else
                    {
                        result = this._proxy.GetVariableNames(this._objectID);
                    }
                }
                return result;
            }
        }

        [Browsable(false)]
        public string[] SystemVariableNames
        {
            get
            {
                object syncObject = this._syncObject;
                string[] result;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        result = null;
                    }
                    else
                    {
                        result = this._proxy.GetSystemVariableNames(this._objectID);
                    }
                }
                return result;
            }
        }

        [Browsable(false), ReadOnly(true)]
        public Encoding PlcEncoding
        {
            get
            {
                object syncObject = this._syncObject;
                Encoding plcEncoding;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        plcEncoding = this._plcEncoding;
                    }
                    else
                    {
                        plcEncoding = this._proxy.GetPlcEncoding(this._objectID);
                    }
                }
                return plcEncoding;
            }
            set
            {
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    this._plcEncoding = value;
                    bool flag = this._proxy != null && this._connected;
                    if (flag)
                    {
                        this._proxy.SetPlcEncoding(this._objectID, value);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public NXCompolet()
        {
        }

        public NXCompolet(IContainer container)
        {
            try
            {
                StartUp.Initialize();
            }
            catch
            {
            }
            this._proxy = RemoteSurface.Instance.NXCompolet;
            this._objectID = this._proxy.CreateInstance();
            bool flag = container != null;
            if (flag)
            {
                container.Add(this);
            }
        }

        protected override void Dispose(bool disposing)
        {
            object syncObject = this._syncObject;
            lock (syncObject)
            {
                bool flag = this._proxy != null && this._objectID != Guid.Empty;
                if (flag)
                {
                    bool active = this._proxy.GetActive(this._objectID);
                    if (active)
                    {
                        this._proxy.SetActive(this._objectID, false);
                    }
                    this._connected = false;
                    this._proxy.Dispose(this._objectID);
                    this._proxy = null;
                    this._objectID = Guid.Empty;
                }
                base.Dispose(disposing);
            }
        }

        public object ReadVariable(string variableName)
        {
            object syncObject = this._syncObject;
            object result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ReadVariable(this._objectID, variableName);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public Hashtable ReadVariableMultiple(string[] variableNames)
        {
            object syncObject = this._syncObject;
            Hashtable result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ReadVariableMultiple(this._objectID, variableNames);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public void WriteVariable(string variableName, object writeData)
        {
            object syncObject = this._syncObject;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    this._proxy.WriteVariable(this._objectID, variableName, writeData);
                }
            }
        }

        public byte[] ReadRawData(string variableName)
        {
            object syncObject = this._syncObject;
            byte[] result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ReadRawData(this._objectID, variableName);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public Hashtable ReadRawDataMultiple(string[] variableNames)
        {
            object syncObject = this._syncObject;
            Hashtable result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ReadRawDataMultiple(this._objectID, variableNames);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public void WriteRawData(string variableName, byte[] writeData)
        {
            object syncObject = this._syncObject;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    this._proxy.WriteRawData(this._objectID, variableName, writeData);
                }
            }
        }

        public VariableInfo GetVariableInfo(string variableName)
        {
            object syncObject = this._syncObject;
            VariableInfo result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    VariableInfoProxy variableInfo = this._proxy.GetVariableInfo(this._objectID, variableName);
                    result = VariableInfo.FromProxy(variableInfo);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public byte[] ExecuteCIPService(byte serviceCode, int classId, int instanceId, int attributeId, byte[] requestData, long requestDataSize)
        {
            object syncObject = this._syncObject;
            byte[] result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ExecuteCIPService(this._objectID, serviceCode, classId, instanceId, attributeId, requestData, requestDataSize);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public byte[] ExecuteCIPService(byte serviceCode, int classId, long instanceId, int attributeId, byte[] requestData, long requestDataSize)
        {
            object syncObject = this._syncObject;
            byte[] result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ExecuteCIPService(this._objectID, serviceCode, classId, instanceId, attributeId, requestData, requestDataSize);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public byte[] ExecuteCIPService(byte serviceCode, string variableName, byte[] requestData, long requestDataSize)
        {
            object syncObject = this._syncObject;
            byte[] result;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    result = this._proxy.ExecuteCIPService(this._objectID, serviceCode, variableName, requestData, requestDataSize);
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public void Update()
        {
            object syncObject = this._syncObject;
            lock (syncObject)
            {
                bool flag = this._proxy != null;
                if (flag)
                {
                    this._proxy.Update(this._objectID);
                }
            }
        }

        public EventLogItemCollection GetEventLogs(EventCategory eventCategory)
        {
            string text = null;
            EventLogItemCollection result;
            try
            {
                text = Path.GetTempFileName();
                object syncObject = this._syncObject;
                lock (syncObject)
                {
                    bool flag = this._proxy == null || !this._connected;
                    if (flag)
                    {
                        throw new InvalidOperationException();
                    }
                    this._proxy.GetEventLogFile(this._objectID, eventCategory, text);
                }
                result = EventLogItemCollection.RestoreEventLogs(text);
            }
            finally
            {
                bool flag2 = text != null;
                if (flag2)
                {
                    try
                    {
                        File.Delete(text);
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }


    }
}
