using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    class AdbOps
    {
        Process process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = null,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
            }
        };

        public Process GetProcess
        {
            get { return process; }
        }

        public void StartProcessing(string @command, string @serialnumber)
        {
            try
            {
                StopProcessing();
                while (!process.HasExited)
                {
                    Thread.Sleep(100);
                }
            }
            catch { }
            finally
            {

                string serial = "";

                if (!string.IsNullOrEmpty(serialnumber))
                {
                    serial += "-s " + serialnumber + " ";
                }
                else
                {
                    serial = "";
                }

                if (command.StartsWith("shell") || command.StartsWith("shell screencap"))
                {
                    command = command.Remove(0, 5);
                    command = "exec-out" + command;
                }
                if (command.StartsWith("logcat"))
                {
                    command = "exec-out " + command;
                }


                process.StartInfo.Arguments = "/C tools\\adb " + serial + command;

                process.EnableRaisingEvents = true;

                process.Start();

                process.BeginOutputReadLine();

                process.BeginErrorReadLine();

                process.StartInfo.Arguments = null;

            }
        }
        public void StopProcessing()
        {
            process.CancelOutputRead();

            process.CancelErrorRead();

            if (!process.HasExited)
            {
                process.Kill();
            }
        }

        public string StartProcessingReadToEnd(string @command, string @serialnumber)
        {

            string serial = "";

            if (!string.IsNullOrEmpty(serialnumber))
            {
                serial += " -s " + serialnumber + " ";
            }
            else
            {
                serial = "";
            }

            Process process2 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"tools\adb",
                    Arguments = serial + command,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                }
            };

            process2.Start();

            return process2.StandardOutput.ReadToEnd();

        }

        public string StartProcessingInThread(string @command, string @serialnumber)
        {
            string output = "";

            Thread t = new Thread(
                delegate ()
                {
                    output = StartProcessingReadToEnd(command, serialnumber);
                }
            );

            t.Start();

            while (t.IsAlive)
            {
                Application.DoEvents();
            }

            t.Abort();

            return output;
        }

    }
}
