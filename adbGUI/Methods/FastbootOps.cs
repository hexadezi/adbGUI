using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Methods
{
    class FastbootOps
    {
        public event CommandExecutionStartedHandler CommandExecutionStarted;
        public delegate void CommandExecutionStartedHandler();

        public event CommandExecutionStoppedHandler CommandExecutionStopped;
        public delegate void CommandExecutionStoppedHandler();

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

        public FastbootOps()
        {
            process.EnableRaisingEvents = true;
        }

        public Process GetProcess
        {
            get { return process; }
        }

        // Thanks to Vitaliy Fedorchenko
        internal const int CTRL_C_EVENT = 0;
        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);
        // Delegate type to be used as the Handler Routine for SCCH
        delegate Boolean ConsoleCtrlDelegate(uint CtrlType);
        public bool StopProcessing()
        {
            if (AttachConsole((uint)GetProcess.Id))
            {
                SetConsoleCtrlHandler(null, true);
                try
                {
                    if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                    {
                        return false;
                    }

                }
                finally
                {
                    FreeConsole();
                    CommandExecutionStopped();
                }
                return true;
            }

            return false;
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

            CommandExecutionStarted();

            process.StandardInput.WriteLine("tools\\fastboot " + serial + command);
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
                    FileName = @"tools\fastboot",
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
