using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class ScreenRecord : Form
    {
        private CmdProcess adb;
        private FormMethods formMethods;
        private int time;

        public ScreenRecord(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();
            adb = adbFrm;
            formMethods = formMethodsFrm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Trb_screenRecord_Scroll(object sender, EventArgs e)
        {
            lbl_screenRecordSeconds.Text = trb_screenRecordTimeLimit.Value.ToString();
        }

        private void Cbo_ScreenRecordCustomResolution_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_ScreenRecordCustomResolution.Checked)
            {
                txt_screenRecordResolution.Enabled = true;
            }
            else
            {
                txt_screenRecordResolution.Enabled = false;
            }
        }

        private void Btn_screenRecordStart_Click(object sender, EventArgs e)
        {
            string size = "";
            string rotate = "";
            string bitrate = "";
            string timelimit = "--time-limit " + trb_screenRecordTimeLimit.Value.ToString() + " ";

            time = trb_screenRecordTimeLimit.Value;

            if (cbo_ScreenRecordCustomResolution.Checked)
            {
                size = " --size " + txt_screenRecordResolution.Text + " ";
            }

            if (cbo_ScreenRecordRotate.Checked)
            {
                rotate = " --rotate ";
            }

            if (txt_ScreenRecordBitrate.Text != "")
            {
                bitrate = " --bit-rate " + txt_ScreenRecordBitrate.Text + " ";
            }


            saveFileDialog.FileName = "record";
            saveFileDialog.Filter = "Video File (*.mp4)|*.mp4";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string phoneDestination = "/sdcard/screenrecord.mp4";
                string localDestination = saveFileDialog.FileName;

                adb.StartProcessing("adb shell screenrecord --verbose" + size + bitrate + timelimit + rotate + phoneDestination, formMethods.SelectedDevice());
                timer.Enabled = true;
                adb.StartProcessing("adb pull " + phoneDestination + " " + localDestination + " && adb shell rm " + phoneDestination, formMethods.SelectedDevice());
            }


        }

        private void Btn_SreenRecordAbort_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btn_screenRecordStart.Text = "Start";
            adb.StopProcessing();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 1)
            {
                time--;
                btn_screenRecordStart.Text = "Start " + time;
            }
            else
            {
                timer.Enabled = false;
                btn_screenRecordStart.Text = "Start";
            }
        }

        private void ScreenRecord_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}