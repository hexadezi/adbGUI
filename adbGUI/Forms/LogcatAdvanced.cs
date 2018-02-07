using System;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class LogcatAdvanced : Form, IDisposable
    {
        CmdProcess adb;
        CmdProcess altAdb = new CmdProcess();
        LogcatOutput lOut = new LogcatOutput();
        FormMethods formMethods;

        public LogcatAdvanced(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;

            altAdb.GetProcess.Start();
            altAdb.GetProcess.BeginOutputReadLine();
            altAdb.GetProcess.BeginErrorReadLine();

            altAdb.GetProcess.OutputDataReceived += GetProcess_OutputDataReceived;
            altAdb.GetProcess.ErrorDataReceived += GetProcess_OutputDataReceived;

            altAdb.CommandExecutionStarted += AltAdb_CommandExecutionStarted;
        }

     
        private void AltAdb_CommandExecutionStarted()
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                if (formMethods.AlwaysClearConsole())
                {
                    lOut.rtb_console.Clear();
                }
            });
        }

        private void Btn_LogcatAdvancedStart_Click(object sender, EventArgs e)
        {
            string alternativeBuffers = GetAlternativeBufferString();
            string regEx = GetRegularExpressionString();
            string quitAfterNumberOfLines = GetQuitAfterNumberOfLines();
            string bypassRegEx = GetBypassRegEx();
            string pidFilter = GetPidFilter();
            string recentNumberOfLines = GetRecentNumberOfLines();
            string specifiedTime = GetSpecifiedTime();
            string outputFormat = GetOutputFormat();
            string outputFilter = GetOutputFilter();


            if (cbo_LogcatAdvancedSeparateWindow.Checked)
            {
                lOut.Show();
                altAdb.StartProcessing("adb logcat" + outputFilter + alternativeBuffers + outputFormat + quitAfterNumberOfLines + recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter, formMethods.SelectedDevice());
            }
            else
            {
                adb.StartProcessing("adb logcat" + outputFilter + alternativeBuffers + outputFormat + quitAfterNumberOfLines + recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter, formMethods.SelectedDevice());
            }
        }

        private void GetProcess_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            try
            {
                BeginInvoke((MethodInvoker)delegate () { lOut.rtb_console.AppendText(e.Data + Environment.NewLine); });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Thread.Sleep(3);

        }

        private void Btn_LogcatAdvancedClearBuffers_Click(object sender, EventArgs e)
        {
            string alternativeBuffers = GetAlternativeBufferString();

            if (!String.IsNullOrEmpty(alternativeBuffers))
            {
                adb.StartProcessing("adb logcat" + alternativeBuffers + " -c", formMethods.SelectedDevice());
            }
        }

        private void Btn_LogcatAdvancedStop_Click(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedSeparateWindow.Checked)
            {
                altAdb.StopProcessing();
            }
            else
            {
                adb.StopProcessing();
            }

        }

        private void Btn_LogcatAdvancedNewBufferSize_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb logcat -g", formMethods.SelectedDevice());
        }

        private void Btn_LogcatAdvancedSetBufferSize_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_LogcatAdvancedBufferSize.Text))
            {
                adb.StartProcessing("adb logcat -G " + txt_LogcatAdvancedBufferSize.Text.Trim(), formMethods.SelectedDevice());
            }
        }

        private void Txt_LogcatAdvancedRecentNumberOfLines_KeyDown(object sender, KeyEventArgs e)
        {
            txt_LogcatAdvancedQuitAfterNumberLines.Clear();
        }

        private void Txt_LogcatAdvancedQuitAfterNumberLines_KeyDown(object sender, KeyEventArgs e)
        {
            txt_LogcatAdvancedRecentNumberOfLines.Clear();
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private string GetAlternativeBufferString()
        {
            string alternativeBuffers = "";

            if (cbo_LogcatAdvancedAlternativeBuffersAll.Checked)
            {
                alternativeBuffers += " -b all";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersDefault.Checked)
            {
                alternativeBuffers += " -b default";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersMain.Checked)
            {
                alternativeBuffers += " -b main";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersSystem.Checked)
            {
                alternativeBuffers += " -b system";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersCrash.Checked)
            {
                alternativeBuffers += " -b crash";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersRadio.Checked)
            {
                alternativeBuffers += " -b radio";
            }
            if (cbo_LogcatAdvancedAlternativeBuffersEvents.Checked)
            {
                alternativeBuffers += " -b events";
            }

            return alternativeBuffers;
        }

        private string GetRegularExpressionString()
        {
            string regEx = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim()))
            {
                if (txt_LogcatAdvancedRegularExpressions.Text.Contains("|"))
                {

                    regEx = " -e \"" + txt_LogcatAdvancedRegularExpressions.Text.Trim() + "\"";
                }
                else
                {
                    regEx = " -e " + txt_LogcatAdvancedRegularExpressions.Text.Trim();
                }
            }

            return regEx;
        }

        private string GetQuitAfterNumberOfLines()
        {
            string countNumber = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim()))
            {
                countNumber = " -m " + txt_LogcatAdvancedQuitAfterNumberLines.Text.Trim();
            }

            return countNumber;
        }

        private string GetBypassRegEx()
        {
            string bypassRegEx = "";

            if (cbo_LogcatAdvancedBypassRegEx.Checked && !String.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text.Trim()))
            {
                bypassRegEx = " --print";
            }

            return bypassRegEx;
        }

        private string GetPidFilter()
        {
            string pidFilter = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedPidFilter.Text.Trim()))
            {
                pidFilter = " --pid=" + txt_LogcatAdvancedPidFilter.Text.Trim();
            }

            return pidFilter;

        }

        private string GetRecentNumberOfLines()
        {
            string recentNumberOfLines = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedRecentNumberOfLines.Text.Trim()))
            {
                recentNumberOfLines = " -t " + txt_LogcatAdvancedRecentNumberOfLines.Text.Trim();
            }

            return recentNumberOfLines;
        }

        private string GetSpecifiedTime()
        {
            string specifiedTime = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedSpecifiedTime.Text.Trim()))
            {
                specifiedTime = " -T \"" + txt_LogcatAdvancedSpecifiedTime.Text.Trim() + "\"";
            }

            return specifiedTime;
        }

        private string GetOutputFilter()
        {
            string outputFilter = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedFilter.Text.Trim()))
            {
                outputFilter = " " + txt_LogcatAdvancedFilter.Text.Trim();
            }

            if (opt_LogcatAdvancedFilterVerbose.Checked)
            {
                outputFilter += " *:V";
            }

            else if (opt_LogcatAdvancedFilterDebug.Checked)
            {
                outputFilter += " *:D";
            }

            else if (opt_LogcatAdvancedFilterInfo.Checked)
            {
                outputFilter += " *:I";
            }

            else if (opt_LogcatAdvancedFilterWarning.Checked)
            {
                outputFilter += " *:W";
            }

            else if (opt_LogcatAdvancedFilterError.Checked)
            {
                outputFilter += " *:E";
            }

            else if (opt_LogcatAdvancedFilterFatal.Checked)
            {
                outputFilter += " *:F";
            }

            else if (opt_LogcatAdvancedFilterSilent.Checked)
            {
                outputFilter += " *:S";
            }

            return outputFilter;

        }

        private string GetOutputFormat()
        {
            if (opt_LogcatAdvancedOutputFormatThreadTime.Checked)
            {
                return " -v threadtime";
            }

            else if (opt_LogcatAdvancedOutputFormatLong.Checked)
            {
                return " -v long";
            }

            else if (opt_LogcatAdvancedOutputFormatTime.Checked)
            {
                return " -v time";
            }

            else if (opt_LogcatAdvancedOutputFormatRaw.Checked)
            {
                return " -v raw";
            }

            else if (opt_LogcatAdvancedOutputFormatTag.Checked)
            {
                return " -v tag";
            }

            else if (opt_LogcatAdvancedOutputFormatProcess.Checked)
            {
                return " -v process";
            }

            else if (opt_LogcatAdvancedOutputFormatBrief.Checked)
            {
                return " -v brief";
            }
            else
            {
                return "";
            }
        }

        private void Btn_LogcatAdvancedStatistics_Click(object sender, EventArgs e)
        {
            if (cbo_LogcatAdvancedSeparateWindow.Checked)
            {
                lOut.Show();

                altAdb.StartProcessing("adb logcat -S", formMethods.SelectedDevice());
            }
            else
            {
                adb.StartProcessing("adb logcat -S", formMethods.SelectedDevice());
            }
        }

        private void LogcatAdvanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            lOut.Close();
            lOut.Dispose();
            altAdb.GetProcess.Close();
        }

        public new void Dispose()
        {
            altAdb.Dispose();
        }
    }
}
