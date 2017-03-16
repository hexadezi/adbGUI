using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    public static class StandardIO
    {
        public static string AdbCMDBackground(string arg1, string arg2, string serialnumber = "")
        {
            string filename = "cmd.exe";

            var arguments = "/C " + arg1 + " tools\\adb " + serialnumber + " " + arg2;

            var startInfo = new ProcessStartInfo
            {
                Arguments = arguments,
                CreateNoWindow = true,
                FileName = filename,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            Process process = new Process { StartInfo = startInfo };

            process.Start();

            string s = process.StandardOutput.ReadToEnd();

            return s;
        }

        public static void AdbCMDBackgroundNoReturn(string arg1, string arg2, string serialnumber = "")
        {
            string filename = "cmd.exe";

            var arguments = "/C " + arg1 + " tools\\adb " + serialnumber + " " + arg2;

            var startInfo = new ProcessStartInfo
            {
                Arguments = arguments,
                CreateNoWindow = true,
                FileName = filename,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            Process process = new Process { StartInfo = startInfo };

            process.Start();
        }

        public static void AdbCMD(string arg1, string serialnumber = "")
        {
            const string filename = "cmd.exe";

            string arguments = "/C prompt $G & tools\\adb" + serialnumber + " " + arg1 + " & echo. & echo. & pause";

            var startInfo = new ProcessStartInfo
            {
                Arguments = arguments,
                FileName = filename,
                WindowStyle = ProcessWindowStyle.Normal
            };

            var process = new Process { StartInfo = startInfo };

            process.Start();
        }

        public static List<string> GetDevices()
        {
            List<string> listofserials = new List<string>();
            string adboutput = AdbCMDBackground("", "devices -l");

            if (adboutput.Length > 29)
            {
                using (StringReader s = new StringReader(adboutput))
                {
                    string line;

                    while (s.Peek() != -1)
                    {
                        line = s.ReadLine();

                        if (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "" || line.StartsWith("*"))
                            continue;

                        if (line.IndexOf(' ') != -1)
                        {
                            line = line.Substring(0, line.IndexOf(' '));
                            listofserials.Add(line);
                        }
                    }
                    s.Close();

                }
            }

            return listofserials;
        }

        public static void KillServer()
        {
            foreach (var pr in Process.GetProcessesByName("adb"))
            {
                pr.Kill();
            }
        }

        public static void NoDeviceConnected()
        {
            MessageBox.Show("No device connected. Please connect a device and select it.\t", "Error - No device connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}