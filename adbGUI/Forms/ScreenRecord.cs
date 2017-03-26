using System;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class ScreenRecord : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;
        private int time;

        public ScreenRecord(AdbOps adbFrm, FormMethods formMethodsFrm)
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

        private void Rab_screenRecordSaveLocal_CheckedChanged(object sender, EventArgs e)
        {
            rab_screenRecordSavePhone.Checked = !rab_screenRecordSaveLocal.Checked;
            txt_ScreenRecordDestination.Clear();
            lbl_ScreenRecordSlowVideo.Text = "Bug: Video will be slow";
        }

        private void Rab_screenRecordSavePhone_CheckedChanged(object sender, EventArgs e)
        {
            rab_screenRecordSaveLocal.Checked = !rab_screenRecordSavePhone.Checked;
            txt_ScreenRecordDestination.Text = "/sdcard/record.mp4";
            lbl_ScreenRecordSlowVideo.Text = "";
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

            if (rab_screenRecordSavePhone.Checked)
            {
                string destination = txt_ScreenRecordDestination.Text;
                adb.StartProcessing("shell screenrecord --verbose" + size + bitrate + timelimit + rotate + destination, formMethods.SelectedDevice());
                timer.Enabled = true;
            }
            else
            {
                string destination = "";

                saveFileDialog.FileName = "record";
                saveFileDialog.Filter = "Video File (*.mp4)|*.mp4";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    destination = saveFileDialog.FileName;
                    txt_ScreenRecordDestination.Text = destination;
                    adb.StartProcessing("shell screenrecord " + size + bitrate + timelimit + rotate + " --output-format=h264 - > " + destination, formMethods.SelectedDevice());
                    timer.Enabled = true;
                }
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