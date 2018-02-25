using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI.Methods
{
    public class CmdProcess : IDisposable
    {
        public delegate void ClearConsoleHandler();

        public delegate void CommandExecutionStartedHandler();

        public delegate void CommandExecutionStoppedHandler();

        // Thanks to Vitaliy Fedorchenko
        internal const int CtrlCEvent = 0;


        public CmdProcess()
        {
            GetProcess.EnableRaisingEvents = true;
        }

        public Process GetProcess { get; } = new Process
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
                StandardOutputEncoding = Encoding.GetEncoding(866),
                StandardErrorEncoding = Encoding.GetEncoding(866)
            }
        };

        public void Dispose()
        {
            GetProcess?.Dispose();
            GC.SuppressFinalize(this);
        }

        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate handlerRoutine, bool add);

        public event CommandExecutionStartedHandler CommandExecutionStarted;

        public event CommandExecutionStoppedHandler CommandExecutionStopped;


        public event ClearConsoleHandler ClearConsole;

        public void StartProcessing(string command, string serialnumber)
        {
            if (command.StartsWith("adb"))
            {
                if (AdbDeviceWatcher.GetConnectedAdbDevices() > 0 || command.EndsWith("help") ||
                    command.EndsWith("version") || command.StartsWith("adb connect") ||
                    command.StartsWith("adb disconnect"))
                {
                    StopProcessing();
                    Thread.Sleep(50);
                    CommandExecutionStarted?.Invoke();
                    GetProcess.StandardInput.WriteLine(CommandParser(command, serialnumber));
                }
                else
                {
                    MessageBox.Show(@"No device connected. Please connect a device for adb commands.",
                        @"Error - No Device Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (command.StartsWith("cls"))
            {
                ClearConsole?.Invoke();
            }

            else
            {
                StopProcessing();
                Thread.Sleep(50);
                CommandExecutionStarted?.Invoke();
                GetProcess.StandardInput.WriteLine(CommandParser(command, serialnumber));
            }
        }

        public bool StopProcessing()
        {
            if (!AttachConsole((uint) GetProcess.Id)) return false;
            SetConsoleCtrlHandler(null, true);
            try
            {
                if (!GenerateConsoleCtrlEvent(CtrlCEvent, 0)) return false;
            }
            finally
            {
                FreeConsole();
                CommandExecutionStopped?.Invoke();
            }

            return true;
        }

        public string StartProcessingInThread(string command, string serialnumber)
        {
            if (command.StartsWith("adb"))
                if (AdbDeviceWatcher.GetConnectedAdbDevices() > 0 || command.EndsWith("help") ||
                    command.EndsWith("version") || command.StartsWith("adb connect") ||
                    command.StartsWith("adb disconnect"))
                {
                    var output = "";

                    var t = new Thread(() => { output = StartProcessingReadToEnd(command, serialnumber); })
                    {
                        IsBackground = true
                    };

                    t.Start();

                    while (t.IsAlive) Application.DoEvents();

                    return output;
                }
                else
                {
                    return null;
                }

            {
                var output = "";

                var t = new Thread(() => { output = StartProcessingReadToEnd(command, serialnumber); })
                {
                    IsBackground = true
                };

                t.Start();

                while (t.IsAlive) Application.DoEvents();

                return output;
            }
        }

        private static string StartProcessingReadToEnd(string command, string serialnumber)
        {
            var process2 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/C " + CommandParser(command, serialnumber),
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true
                }
            };

            process2.Start();

            return process2.StandardOutput.ReadToEnd();
        }

        private static string CommandParser(string command, string serialnumber)
        {
            if (command.StartsWith("adb "))
            {
                command = command.Remove(0, 4);

                if (command.Contains("shell"))
                {
                    command = command.Remove(0, 5);
                    command = "exec-out" + command;
                }

                if (command.StartsWith("logcat")) command = "exec-out " + command;

                var serial = "";

                if (!string.IsNullOrEmpty(serialnumber))
                    serial += "-s " + serialnumber + " ";
                else
                    serial = "";

                var fullcommand = "adb " + serial + command;

                return fullcommand;
            }

            if (!command.StartsWith("fastboot ")) return command;
            {
                command = command.Remove(0, 9);

                var fullcommand = "fastboot " + command;

                return fullcommand;
            }
        }

        // Delegate type to be used as the Handler Routine for SCCH
        private delegate bool ConsoleCtrlDelegate(uint ctrlType);
    }
}