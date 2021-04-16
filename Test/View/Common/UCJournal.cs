using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.TubeServices;

namespace Test.View.Common
{
    public partial class UCJournal : UserControl
    {
        public UCJournal()
        {
            InitializeComponent();
        }

        private void UCJournal_Load(object sender, EventArgs e)
        {
            //dgvJournal.DataSource = com.TubeServices.TubeAlarmService.Instance.GetTubeAlarmList(com.DataBaseModels.frmID.Unit, dtStartTime.Value, dtEndTime.Value);
        }

        //public void dgvDataBings()
        //{
        //    dgvJournal.DataSource = com.TubeServices.TubeAlarmService.GetTubeAlarmList(com,dtStartTime,dtEndTime);
        //}
    }
}
