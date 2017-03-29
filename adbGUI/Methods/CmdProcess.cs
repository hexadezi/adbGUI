using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI
{
    public class CmdProcess
    {
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
                StandardOutputEncoding = System.Text.Encoding.GetEncoding(437),
                StandardErrorEncoding = System.Text.Encoding.GetEncoding(437)
    }
        };

        public CmdProcess()
        {
            process.EnableRaisingEvents = true;
        }

        public Process GetProcess
        {
            get { return process; }
        }

        public void StartProcessing(string @command, string @serialnumber)
        {
            CommandExecutionStarted?.Invoke();

            process.StandardInput.WriteLine(CommandParser(command, serialnumber));
        }

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

        public string StartProcessingInThread(string @command, string @serialnumber)
        {
            string output = "";

            Thread t = new Thread(
                () =>
                {
                    output = StartProcessingReadToEnd(command, serialnumber);
                }
            )

            {
                IsBackground = true
            };

            t.Start();

            while (t.IsAlive)
            {
                Application.DoEvents();
            }

            return output;
        }

        // auf private stellen
        public string StartProcessingReadToEnd(string command, string serialnumber)
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
                    RedirectStandardInput = true,
                }
            };

            process2.Start();

            return process2.StandardOutput.ReadToEnd();

        }

        private string CommandParser(string @command, string @serialnumber)
        {
            if (command.StartsWith("adb "))
            {
                command = command.Remove(0, 4);

                if (command.StartsWith("shell") || command.StartsWith("shell screencap"))
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

                string fullcommand = "tools\\adb " + serial + command;

                return fullcommand;

            }
            else if (command.StartsWith("fastboot "))
            {
                command = command.Remove(0, 9);

                string fullcommand = "tools\\fastboot " + command;

                return fullcommand;
            }
            else
            {
                return command;
            }

        }
    }

    public static class CheckAndDownloadDependencies
    {

        private static string downloadToTempPath = Path.GetTempPath() + "platform-tools-latest-windows.zip";

        private static string[] strFiles = { "adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll", "fastboot.exe", "libwinpthread-1.dll" };


        public static void Start()
        {

            if (!CheckIfFilesExist())
            {
                DialogResult dialogResult = MessageBox.Show("Some files are missing. \nShould all dependencies be downloaded and extracted?", "Error: Missing Files", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {

                    ExtractionCompleted += DependenciesChecker_ExtractionCompleted;
                    WebClient wc = new WebClient();
                    wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                    wc.DownloadFileTaskAsync(new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip"), downloadToTempPath);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Environment.Exit(0);
                }

            }

        }

        private static bool CheckIfFilesExist()
        {
            foreach (var item in strFiles)
            {
                if (!File.Exists("tools\\" + item))
                {
                    return false;
                }
            }
            return true;
        }

        private static void Wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Thread tr = new Thread(new ThreadStart(ExtractFiles));
            tr.Start();
        }


        private static event ExtractionCompletedHandler ExtractionCompleted;
        private delegate void ExtractionCompletedHandler();
        private static void ExtractFiles()
        {
            if (Directory.Exists(Path.GetTempPath() + "platform-tools"))
            {
                Directory.Delete(Path.GetTempPath() + "platform-tools", true);
            }

            ZipFile.ExtractToDirectory(downloadToTempPath, Path.GetTempPath());

            ExtractionCompleted();
        }

        private static void DependenciesChecker_ExtractionCompleted()
        {
            string extractedFilesPath = Path.GetTempPath() + "platform-tools";

            Directory.CreateDirectory("tools");

            foreach (var item in strFiles)
            {
                try
                {
                    File.Copy(extractedFilesPath + "\\" + item, "tools\\" + item);
                }
                catch (Exception) { }

            }

            ExtractionCompleted -= DependenciesChecker_ExtractionCompleted;

            MessageBox.Show("Files downloaded, decompressed and moved successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }

}
