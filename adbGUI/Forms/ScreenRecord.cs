// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Windows.Forms;

    public partial class ScreenRecord : Form
    {
        private readonly CmdProcess _adb;
        private readonly FormMethods _formMethods;
        private int _time;

        public ScreenRecord(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            _adb = adbFrm;
            _formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void Trb_screenRecord_Scroll(object sender, EventArgs e)
        {
            lbl_screenRecordSeconds.Text = trb_screenRecordTimeLimit.Value.ToString();
        }

        private void Cbo_ScreenRecordCustomResolution_CheckedChanged(object sender, EventArgs e)
        {
            txt_screenRecordResolution.Enabled = cbo_ScreenRecordCustomResolution.Checked;
        }

        private void Btn_screenRecordStart_Click(object sender, EventArgs e)
        {
            var size = "";
            var rotate = "";
            var bitrate = "";
            var timelimit = "--time-limit " + trb_screenRecordTimeLimit.Value + " ";

            _time = trb_screenRecordTimeLimit.Value;

            if (cbo_ScreenRecordCustomResolution.Checked) size = " --size " + txt_screenRecordResolution.Text + " ";

            if (cbo_ScreenRecordRotate.Checked) rotate = " --rotate ";

            if (txt_ScreenRecordBitrate.Text != "") bitrate = " --bit-rate " + txt_ScreenRecordBitrate.Text + " ";

            saveFileDialog.FileName = "record";
            saveFileDialog.Filter = @"Video File (*.mp4)|*.mp4";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            const string phoneDestination = "/sdcard/screenrecord.mp4";
            var localDestination = saveFileDialog.FileName;

            _adb.StartProcessing(
                "adb shell screenrecord --verbose" + size + bitrate + timelimit + rotate + phoneDestination,
                _formMethods.SelectedDevice());
            timer.Enabled = true;
            _adb.StartProcessing(
                "adb pull " + phoneDestination + " " + localDestination + " && adb shell rm " + phoneDestination,
                _formMethods.SelectedDevice());
        }

        private void Btn_SreenRecordAbort_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btn_screenRecordStart.Text = @"Start";
            _adb.StopProcessing();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_time > 1)
            {
                _time--;
                btn_screenRecordStart.Text = @"Start " + _time;
            }
            else
            {
                timer.Enabled = false;
                btn_screenRecordStart.Text = @"Start";
            }
        }
    }
}