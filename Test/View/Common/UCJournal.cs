using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.TubeServices;
using com.DataBaseModels;

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
        FrmMain frmMain = new FrmMain();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string nodeName = frmMain.tvMenu.SelectedNode.Text;
            if (nodeName == "日志" || nodeName == "事件")
            {
                if (frmID.Unit == 0)
                    dgvJournal.DataSource = com.TubeServices.TubeEventService.Instance.GetLoaderEventList(dtStartTime.Value, dtEndTime.Value);
                else
                    dgvJournal.DataSource = com.TubeServices.TubeEventService.Instance.GetEventList(frmID.Unit, dtStartTime.Value, dtEndTime.Value);
            }
            else if(nodeName == "报警")
            {
                if (frmID.Unit == 0)
                    dgvJournal.DataSource = com.TubeServices.TubeAlarmService.Instance.GetLoaderAlarmList(dtStartTime.Value, dtEndTime.Value);
                else
                    dgvJournal.DataSource = com.TubeServices.TubeAlarmService.Instance.GetTubeAlarmList(frmID.Unit, dtStartTime.Value, dtEndTime.Value);
            }
            else
            {
                MessageBox.Show("画面异常！");
            }

        }

    }
}
