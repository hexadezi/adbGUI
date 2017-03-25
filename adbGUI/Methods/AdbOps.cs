using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    public class AdbOps
    {
        public event CommandExecutionStartedHandler CommandExecutionStarted;

        public delegate void CommandExecutionStartedHandler();

        Process process = new Process
        {

            StartInfo = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/K set prompt=INPUT -$G$S",
                UseShellExecute = false,
                CreateNoWindow = true,
                ErrorDialog = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
            }
        };

        public AdbOps()
        {
            process.EnableRaisingEvents = true;
        }
        public Process GetProcess
        {
            get { return process; }
        }

        public void StartProcessing(string @command, string @serialnumber)
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

            CommandExecutionStarted();

            process.StandardInput.WriteLine("tools\\adb " + serial + command);
        }


        public void StopProcessing()
        {
            process.CancelOutputRead();
            process.CancelErrorRead();

            process.Kill();

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

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
