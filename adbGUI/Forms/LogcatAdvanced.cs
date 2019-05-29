// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Forms
{
    using Methods;
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;

    public partial class LogcatAdvanced : Form, IDisposable
    {
        private readonly CmdProcess _adb;
        private readonly CmdProcess _altAdb = new CmdProcess();
        private readonly FormMethods _formMethods;
        private readonly LogcatOutput _lOut = new LogcatOutput();

        public LogcatAdvanced(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            _adb = adbFrm;
            _formMethods = formMethodsFrm;

            _altAdb.GetProcess.Start();
            _altAdb.GetProcess.BeginOutputReadLine();
            _altAdb.GetProcess.BeginErrorReadLine();

            _altAdb.GetProcess.OutputDataReceived += GetProcess_OutputDataReceived;
            _altAdb.GetProcess.ErrorDataReceived += GetProcess_OutputDataReceived;

            _altAdb.CommandExecutionStarted += AltAdb_CommandExecutionStarted;
        }

        public new void Dispose()
        {
            _altAdb?.Dispose();
            _lOut?.Dispose();
            GC.SuppressFinalize(this);
        }

        private void AltAdb_CommandExecutionStarted()
        {
            BeginInvoke((MethodInvoker)delegate
           {
               if (FormMethods.AlwaysClearConsole()) _lOut.rtb_console.Clear();
           });
        }

        private void Btn_LogcatAdvancedClearBuffers_Click(object sender, EventArgs e)
        {
            var alternativeBuffers = GetAlternativeBufferString();

            if (!string.IsNullOrEmpty(alternativeBuffers))
                _adb.StartProcessing("adb logcat" + alternativeBuffers + " -c", _formMethods.SelectedDevice());
        }

        private void Btn_LogcatAdvancedNewBufferSize_Click(object sender, EventArgs e) => _adb.StartProcessing("adb logcat -g", _formMethods.SelectedDevice());

        private void Btn_LogcatAdvancedSetBufferSize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_LogcatAdvancedBufferSize.Text))
            {
                _adb.StartProcessing("adb logcat -G " + txt_LogcatAdvancedBufferSize.Text.Trim(),
                    _formMethods.SelectedDevice());
            }
        }

        private void Btn_LogcatAdvancedStart_Click(object sender, EventArgs e)
        {
            var alternativeBuffers = GetAlternativeBufferString();
            var regEx = GetRegularExpressionString();
            var quitAfterNumberOfLines = GetQuitAfterNumberOfLines();
            var bypassRegEx = GetBypassRegEx();
            var pidFilter = GetPidFilter();
            var recentNumberOfLines = GetRecentNumberOfLines();
            var specifiedTime = GetSpecifiedTime();
            var outputFormat = GetOutputFormat();
            var outputFilter = GetOutputFilter();

            if (cbo_LogcatAdvancedSeparateWindow.Checked)
            {
                _lOut.Show();
                _altAdb.StartProcessing(
                    "adb logcat" + outputFilter + alternativeBuffers + outputFormat + quitAfterNumberOfLines +
                    recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter,
                    _formMethods.SelectedDevice());
            }
            else
            {
                _adb.StartProcessing(
                    "adb logcat" + outputFilter + alternativeBuffers + outputFormat + quitAfterNumberOfLines +
                    recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter,
                    _formMethods.SelectedDevice());
            }
        }

        private void Btn_LogcatAdvancedStatistics_Click(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedSeparateWindow.Checked)
            {
                _lOut.Show();

                _altAdb.StartProcessing("adb logcat -S", _formMethods.SelectedDevice());
            }
            else
            {
                _adb.StartProcessing("adb logcat -S", _formMethods.SelectedDevice());
            }
        }

        private void Btn_LogcatAdvancedStop_Click(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedSeparateWindow.Checked)
                _altAdb.StopProcessing();
            else
                _adb.StopProcessing();
        }

        private void Cbo_LogcatAdvancedAlternativeBuffersAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedAlternativeBuffersAll.Checked)
            {
                cbo_LogcatAdvancedAlternativeBuffersDefault.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersMain.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersRadio.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersEvents.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Checked = false;

                cbo_LogcatAdvancedAlternativeBuffersDefault.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersRadio.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersEvents.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = false;
            }
            else
            {
                cbo_LogcatAdvancedAlternativeBuffersDefault.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersRadio.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersEvents.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = true;
            }
        }

        private void Cbo_LogcatAdvancedAlternativeBuffersDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedAlternativeBuffersDefault.Checked)
            {
                cbo_LogcatAdvancedAlternativeBuffersMain.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Checked = false;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Checked = false;

                cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = false;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = false;
            }
            else
            {
                cbo_LogcatAdvancedAlternativeBuffersMain.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersSystem.Enabled = true;
                cbo_LogcatAdvancedAlternativeBuffersCrash.Enabled = true;
            }
        }

        private string GetAlternativeBufferString()
        {
            var alternativeBuffers = "";

            if (cbo_LogcatAdvancedAlternativeBuffersAll.Checked) alternativeBuffers += " -b all";
            if (cbo_LogcatAdvancedAlternativeBuffersDefault.Checked) alternativeBuffers += " -b default";
            if (cbo_LogcatAdvancedAlternativeBuffersMain.Checked) alternativeBuffers += " -b main";
            if (cbo_LogcatAdvancedAlternativeBuffersSystem.Checked) alternativeBuffers += " -b system";
            if (cbo_LogcatAdvancedAlternativeBuffersCrash.Checked) alternativeBuffers += " -b crash";
            if (cbo_LogcatAdvancedAlternativeBuffersRadio.Checked) alternativeBuffers += " -b radio";
            if (cbo_LogcatAdvancedAlternativeBuffersEvents.Checked) alternativeBuffers += " -b events";

            return alternativeBuffers;
        }

        private string GetBypassRegEx()
        {
            var bypassRegEx = "";

            if (cbo_LogcatAdvancedBypassRegEx.Checked &&
                !string.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim())) bypassRegEx = " --print";

            return bypassRegEx;
        }

        private string GetOutputFilter()
        {
            var outputFilter = "";

            if (!string.IsNullOrEmpty(txt_LogcatAdvancedFilter.Text.Trim()))
                outputFilter = " " + txt_LogcatAdvancedFilter.Text.Trim();

            if (opt_LogcatAdvancedFilterVerbose.Checked)
                outputFilter += " *:V";
            else if (opt_LogcatAdvancedFilterDebug.Checked)
                outputFilter += " *:D";
            else if (opt_LogcatAdvancedFilterInfo.Checked)
                outputFilter += " *:I";
            else if (opt_LogcatAdvancedFilterWarning.Checked)
                outputFilter += " *:W";
            else if (opt_LogcatAdvancedFilterError.Checked)
                outputFilter += " *:E";
            else if (opt_LogcatAdvancedFilterFatal.Checked)
                outputFilter += " *:F";
            else if (opt_LogcatAdvancedFilterSilent.Checked) outputFilter += " *:S";

            return outputFilter;
        }

        private string GetOutputFormat()
        {
            if (opt_LogcatAdvancedOutputFormatThreadTime.Checked)
                return " -v threadtime";

            if (opt_LogcatAdvancedOutputFormatLong.Checked)
                return " -v long";

            if (opt_LogcatAdvancedOutputFormatTime.Checked)
                return " -v time";

            if (opt_LogcatAdvancedOutputFormatRaw.Checked)
                return " -v raw";

            if (opt_LogcatAdvancedOutputFormatTag.Checked)
                return " -v tag";

            if (opt_LogcatAdvancedOutputFormatProcess.Checked)
                return " -v process";

            return opt_LogcatAdvancedOutputFormatBrief.Checked ? " -v brief" : "";
        }

        private string GetPidFilter()
        {
            var pidFilter = "";

            if (!string.IsNullOrEmpty(txt_LogcatAdvancedPidFilter.Text.Trim()))
                pidFilter = " --pid=" + txt_LogcatAdvancedPidFilter.Text.Trim();

            return pidFilter;
        }

        private void GetProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                BeginInvoke((MethodInvoker)delegate { _lOut.rtb_console.AppendText(e.Data + Environment.NewLine); });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Thread.Sleep(3);
        }

        private string GetQuitAfterNumberOfLines()
        {
            var countNumber = "";

            if (!string.IsNullOrEmpty(txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim()))
                countNumber = " -m " + txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim();

            return countNumber;
        }

        private string GetRecentNumberOfLines()
        {
            var recentNumberOfLines = "";

            if (!string.IsNullOrEmpty(txt_LogcatAdvancedRecentNumberOfLines.Text.Trim()))
                recentNumberOfLines = " -t " + txt_LogcatAdvancedRecentNumberOfLines.Text.Trim();

            return recentNumberOfLines;
        }

        private string GetRegularExpressionString()
        {
            const string regEx = "";

            if (string.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim())) return regEx;
            return (txt_LogcatAdvancedRegularExpressions.Text.Contains("|")) ? " -e \"" + txt_LogcatAdvancedRegularExpressions.Text.Trim() + "\"" : " -e " + txt_LogcatAdvancedRegularExpressions.Text.Trim();
        }

        private string GetSpecifiedTime()
        {
            var specifiedTime = "";

            if (!string.IsNullOrEmpty(txt_LogcatAdvancedSpecifiedTime.Text.Trim()))
                specifiedTime = " -T \"" + txt_LogcatAdvancedSpecifiedTime.Text.Trim() + "\"";

            return specifiedTime;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(linkLabel1.Text);

        private void LogcatAdvanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            _lOut.Close();
            _altAdb.GetProcess.Close();
        }

        private void Txt_LogcatAdvancedQuitAfterNumberLines_KeyDown(object sender, KeyEventArgs e) => txt_LogcatAdvancedRecentNumberOfLines.Clear();

        private void Txt_LogcatAdvancedRecentNumberOfLines_KeyDown(object sender, KeyEventArgs e) => txt_LogcatAdvancedQuitAfterNumberLines.Clear();
    }
}