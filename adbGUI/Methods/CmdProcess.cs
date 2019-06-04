// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

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
        // Thanks to Vitaliy Fedorchenko
        private const int CtrlCEvent = 0;

        public CmdProcess() => GetProcess.EnableRaisingEvents = true;

        public delegate void ClearConsoleHandler();

        public delegate void CommandExecutionStartedHandler();

        public delegate void CommandExecutionStoppedHandler();

        // Delegate type to be used as the Handler Routine for SCCH
        private delegate bool ConsoleCtrlDelegate(uint ctrlType);

        public event ClearConsoleHandler ClearConsole;

        public event CommandExecutionStartedHandler CommandExecutionStarted;

        public event CommandExecutionStoppedHandler CommandExecutionStopped;

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

        public static string StartProcessingInThread(string command, string serialnumber)
        {
            if (command.StartsWith("adb"))
            {
                if (AdbDeviceWatcher.ConnectedAdbDevices > 0 || command.EndsWith("help") ||
                    command.EndsWith("version") || command.StartsWith("adb connect") ||
                    command.StartsWith("adb disconnect"))
                {
                    string output = "";

                    Thread t = new Thread(() => output = StartProcessingReadToEnd(command, serialnumber)) { IsBackground = true };

                    t.Start();

                    while (t.IsAlive)
                    {
                        Application.DoEvents();
                    }

                    return output;
                }
                else
                {
                    return null;
                }
            }

            {
                string output = "";

                Thread t = new Thread(() => output = StartProcessingReadToEnd(command, serialnumber)) { IsBackground = true };

                t.Start();

                while (t.IsAlive)
                {
                    Application.DoEvents();
                }

                return output;
            }
        }

        public void Dispose()
        {
            GetProcess?.Dispose();
            GC.SuppressFinalize(this);
        }

        public void StartProcessing(string command, string serialnumber)
        {
            if (command.StartsWith("adb"))
            {
                if (AdbDeviceWatcher.ConnectedAdbDevices > 0 || command.EndsWith("help")
                    || command.EndsWith("version") || command.StartsWith("adb connect")
                    || command.StartsWith("adb disconnect"))
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
            if (!AttachConsole((uint)GetProcess.Id))
            {
                return false;
            }

            SetConsoleCtrlHandler(null, true);
            try
            {
                if (!GenerateConsoleCtrlEvent(CtrlCEvent, 0))
                {
                    return false;
                }
            }
            finally
            {
                FreeConsole();
                CommandExecutionStopped?.Invoke();
            }

            return true;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

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

                if (command.StartsWith("logcat"))
                {
                    command = "exec-out " + command;
                }

                string serial = "";

                if (!string.IsNullOrEmpty(serialnumber))
                {
                    serial += "-s " + serialnumber + " ";
                }
                else
                {
                    serial = "";
                }

                return "adb " + serial + command;
            }

            if (!command.StartsWith("fastboot "))
            {
                return command;
            }

            {
                command = command.Remove(0, 9);

                return "fastboot " + command;
            }
        }

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate handlerRoutine, bool add);

        private static string StartProcessingReadToEnd(string command, string serialnumber)
        {
            Process process2 = new Process
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

            _ = process2.Start();

            return process2.StandardOutput.ReadToEnd();
        }
    }
}