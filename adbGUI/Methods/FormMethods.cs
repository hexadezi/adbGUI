using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace adbGUI
{
    public class FormMethods : IDisposable
    {
        private MainForm frm;

        CmdProcess adb = new CmdProcess();

        public FormMethods(MainForm f)
        {
            //Pass the MainForm instance
            frm = f;
        }

        public void Dispose()
        {
            adb.Dispose();
        }

        public string SelectedDevice()
        {
            if (frm.tsc_ConnectedDevices.Items.Count == 0)
            {
                return "";
            }
            else
            {
                return frm.tsc_ConnectedDevices.SelectedItem.ToString();

            }
        }

        public void RefreshAdbSerialsInCombobox(List<string> devices)
        {
            frm.tsc_ConnectedDevices.Items.Clear();

            foreach (var item in devices)
            {
                frm.tsc_ConnectedDevices.Items.Add(item);
            }

            frm.tsc_ConnectedDevices.SelectedIndex = frm.tsc_ConnectedDevices.Items.Count - 1;

        }

        public void KillServer()
        {
            try
            {
                foreach (var pr in Process.GetProcessesByName("adb"))
                {
                    pr.Kill();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ShowMboxAborted()
        {
            MessageBox.Show("Processing aborted succesfully", "Abortion succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public bool AlwaysClearConsole()
        {
            if (frm.tsb_AlwaysClearConsole.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
