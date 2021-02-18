using System;
using System.Threading;
using System.Windows.Forms;
using adbGUI.Methods;

namespace adbGUI.Forms
{
	public partial class ScreenRecord : ExtForm
	{
		private int _time;

		public ScreenRecord()
		{
			InitializeComponent();
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

		const string phoneDestination = "/sdcard/screenrecord.mp4";
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


			HelperClass.Execute(
				"adb exec-out screenrecord --verbose" + size + bitrate + timelimit + rotate + phoneDestination);

			timer.Enabled = true;


			saveFileDialog.FileName = "screenrecord_" + DateTime.Now.ToString(@"ddMMyyyy_HHmmss");
			saveFileDialog.Filter = @"Video File (*.mp4)|*.mp4";

			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
			string localDestination = saveFileDialog.FileName;

			// ADB has to sleep otherwise the file would be pulled too fast and be corrupted
			HelperClass.Execute("adb shell sleep 4 && adb pull " + phoneDestination + " " + localDestination + " && adb shell rm " + phoneDestination);
		}

		private void Btn_SreenRecordAbort_Click(object sender, EventArgs e)
		{
			timer.Enabled = false;
			btn_screenRecordStart.Text = @"Start";
			CLI.KillChildProcesses();
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

		private void Btn_PullVideo_Click(object sender, EventArgs e)
		{
			saveFileDialog.FileName = "screenrecord_" + DateTime.Now.ToString(@"ddMMyyyy_HHmmss");
			saveFileDialog.Filter = @"Video File (*.mp4)|*.mp4";

			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
			string localDestination = saveFileDialog.FileName;

			HelperClass.Execute("adb pull " + phoneDestination + " " + localDestination + " && adb shell rm " + phoneDestination);
		}
	}
}