using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI
{
    class AdbOps
    {
        Process process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "tools\\adb",
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
                process.CancelOutputRead();
                process.CancelErrorRead();
            }
            catch { }
            finally
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

                process.StartInfo.Arguments = serial + command;

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.StartInfo.Arguments = null;

            }



        }

        public void StopProcessing()
        {
            try
            {
                process.Kill();
            }
            catch { }
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

            //t.Abort();

            return output;
        }

    }
}
