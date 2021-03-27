using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
  public  class TubeAlarm  
    {
        private string zAlarmName;
        private string zAlarmDesc;
        private string zAlarmTime;
        private string zUserName;

        public TubeAlarm()
        {
        }
        public string UserName
        {
            get { return zUserName; }
            set { zUserName = value; }
        }

        public string AlarmName
        {
            get { return zAlarmName; }
            set { zAlarmName = value; }
        }

        public string AlarmDesc
        {
            get { return zAlarmDesc; }
            set { zAlarmDesc = value; }
        }

        public string AlarmTime
        {
            get { return zAlarmTime; }
            set { zAlarmTime = value; }
        }
    }
}
