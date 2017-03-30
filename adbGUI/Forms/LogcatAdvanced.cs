using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class LogcatAdvanced : Form
    {
        CmdProcess adb;
        FormMethods formMethods;

        public LogcatAdvanced(CmdProcess adbFrm, FormMethods formMethodsFrm)
        {
            InitializeComponent();

            adb = adbFrm;
            formMethods = formMethodsFrm;
        }
        // todo change Abort to Cancel
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

            adb.StartProcessing("adb logcat" + alternativeBuffers + outputFormat + quitAfterNumberOfLines + recentNumberOfLines + specifiedTime + regEx + bypassRegEx + pidFilter, formMethods.SelectedDevice());

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
            adb.StopProcessing();
        }

        private void Btn_LogcatAdvancedNewBufferSize_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("adb logcat -g", formMethods.SelectedDevice());
        }

        private void Btn_LogcatAdvancedSetBufferSize_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_LogcatAdvancedBufferSize.Text))
            {
                adb.StartProcessing("adb logcat -G " + txt_LogcatAdvancedBufferSize.Text, formMethods.SelectedDevice());
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

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text))
            {
                regEx = " -e " + txt_LogcatAdvancedRegularExpressions.Text;
            }

            return regEx;
        }

        private string GetQuitAfterNumberOfLines()
        {
            string countNumber = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedQuitAfterNumberLines.Text))
            {
                countNumber = " -m " + txt_LogcatAdvancedQuitAfterNumberLines.Text;
            }

            return countNumber;
        }

        private string GetBypassRegEx()
        {
            string bypassRegEx = "";

            if (cbo_LogcatAdvancedBypassRegEx.Checked && !String.IsNullOrEmpty(txt_LogcatAdvancedRegularExpressions.Text))
            {
                bypassRegEx = " --print";
            }

            return bypassRegEx;
        }

        private string GetPidFilter()
        {
            string pidFilter = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedPidFilter.Text))
            {
                pidFilter = " --pid=" + txt_LogcatAdvancedPidFilter.Text;
            }

            return pidFilter;

        }

        private string GetRecentNumberOfLines()
        {
            string recentNumberOfLines = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedRecentNumberOfLines.Text))
            {
                recentNumberOfLines = " -T " + txt_LogcatAdvancedRecentNumberOfLines.Text;
            }

            return recentNumberOfLines;
        }

        private string GetSpecifiedTime()
        {
            string specifiedTime = "";

            if (!String.IsNullOrEmpty(txt_LogcatAdvancedSpecifiedTime.Text))
            {
                specifiedTime = " -T \"" + txt_LogcatAdvancedSpecifiedTime.Text + "\"";
            }

            return specifiedTime;
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
    }
}
