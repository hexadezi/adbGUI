using System;
using System.Windows.Forms;
using adbGUI.Forms;
using adbGUI.Methods;

namespace adbGUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                CheckAndDownloadDependencies.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}