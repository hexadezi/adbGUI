using System;
using System.IO;
using System.Windows.Forms;

namespace adbGUI
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists("tools\\adb.exe") && File.Exists("tools\\AdbWinApi.dll") && File.Exists("tools\\AdbWinUsbApi.dll"))
            {
                Application.Run(new MainForm());
            }
            else
            {

                MessageBox.Show("Missing files. Make soure adbGUI.exe, AdbWinApi.dll adn AdbWinUsbApi.dll are in the tools folder.", "Error - Missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();

            }
        }
    }
}
