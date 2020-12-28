using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.@event
{
     public class TubeEventViewModel: ViewModel 
    {
        private int mTubeIndex;

        private int    zEventID;
        private string zEventUser;
        private string zEventName;
        private string zEventDesc;
        private string zEventTime;
        private string zEventDsid;//event外键

        public TubeEventViewModel()
        {

        }

        public int TubeIndex
        {
            get { return mTubeIndex; }
            set
            {
                mTubeIndex = value;
                Notify("TubeIndex");
                this.NotifyPropertyChanged(p => p.mTubeIndex);

            }
        }

        public int EventID
        {
            get { return zEventID; }
            set
            {
                zEventID = value;
                Notify("EventID");
                this.NotifyPropertyChanged(p => p.EventID);
            }
        }

        public string EventName
        {
            get { return zEventName; }
            set
            {
                zEventName = value;
                Notify("EventName");
                this.NotifyPropertyChanged(p => p.EventName);
            }
        }


        public string EventDesc
        {
            get { return zEventDesc; }
            set
            {
                zEventDesc = value;
                Notify("EventDesc");
                this.NotifyPropertyChanged(p => p.EventDesc);
            }
        }

        public string EventTime
        {
            get { return zEventTime; }
            set
            {
                zEventTime = value;
                Notify("EventTime");
                this.NotifyPropertyChanged(p => p.EventTime);
            }
        }
        public string EventUser
        {
            get { return zEventUser; }
            set
            {
                zEventUser = value;
                Notify("mEventUser");
                this.NotifyPropertyChanged(p => p.EventUser);
            }
        }


        public string EventDsid
        {
            get { return zEventDsid; }
            set
            {
                zEventDsid = value;
                Notify("mEventDsid");
                this.NotifyPropertyChanged(p => p.EventDsid);
            }
        }
    }
}
