// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using adbGUI.Forms;

namespace adbGUI.Methods
{
    public class FormMethods : IDisposable
    {
        private readonly CmdProcess _adb = new CmdProcess();
        private readonly MainForm _frm;

        public FormMethods(MainForm f)
        {
            //Pass the MainForm instance
            _frm = f;
        }

        public void Dispose()
        {
            _adb?.Dispose();
            GC.SuppressFinalize(this);
        }

        public string SelectedDevice()
        {
            return _frm.tsc_ConnectedDevices.Items.Count == 0 ? "" : _frm.tsc_ConnectedDevices.SelectedItem.ToString();
        }

        public void RefreshAdbSerialsInCombobox(List<string> devices)
        {
            _frm.tsc_ConnectedDevices.Items.Clear();

            foreach (var item in devices) _frm.tsc_ConnectedDevices.Items.Add(item);

            _frm.tsc_ConnectedDevices.SelectedIndex = _frm.tsc_ConnectedDevices.Items.Count - 1;
        }

        public static void KillServer()
        {
            try
            {
                foreach (var pr in Process.GetProcessesByName("adb")) pr.Kill();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static bool AlwaysClearConsole()
        {
            return true;
        }
    }
}