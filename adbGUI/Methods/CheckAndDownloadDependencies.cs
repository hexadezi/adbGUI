// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Methods
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Net;
    using System.Threading;
    using System.Windows.Forms;

    public static class CheckAndDownloadDependencies
    {
        private static readonly string DownloadToTempPath = Path.GetTempPath() + "platform-tools-latest-windows.zip";

        private static readonly string[] StrFiles =
            {"adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll", "fastboot.exe", "libwinpthread-1.dll"};

        private delegate void ExtractionCompletedHandler();

        private static event ExtractionCompletedHandler ExtractionCompleted;

        private static bool CheckIfFilesExist => StrFiles?.All(File.Exists) == true;

        public static void Start()
        {
            if (CheckIfFilesExist) return;
            var dialogResult =
                MessageBox.Show(
                    @"Enviroment Variables not set and files missing. Should all dependencies be downloaded and extracted?",
                    @"Error: Missing Files", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    try
                    {
                        DownloadFiles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case DialogResult.No:
                    Environment.Exit(0);
                    break;

                case DialogResult.None:
                    break;

                case DialogResult.OK:
                    break;

                case DialogResult.Cancel:
                    break;

                case DialogResult.Abort:
                    break;

                case DialogResult.Retry:
                    break;

                case DialogResult.Ignore:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void DependenciesChecker_ExtractionCompleted()
        {
            var extractedFilesPath = Path.GetTempPath() + "platform-tools";

            foreach (var item in StrFiles)
            {
                try
                {
                    File.Copy(extractedFilesPath + "\\" + item, item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ExtractionCompleted -= DependenciesChecker_ExtractionCompleted;

            MessageBox.Show(@"Files downloaded, decompressed and moved successfully", @"Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static void DownloadFiles()
        {
            ExtractionCompleted += DependenciesChecker_ExtractionCompleted;
            using (var wc = new WebClient())
            {
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                _ = wc.DownloadFileTaskAsync(
                    new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip"),
                    DownloadToTempPath);
            }
        }

        private static void ExtractFiles()
        {
            if (Directory.Exists(Path.GetTempPath() + "platform-tools"))
                Directory.Delete(Path.GetTempPath() + "platform-tools", true);

            ZipFile.ExtractToDirectory(DownloadToTempPath, Path.GetTempPath());

            ExtractionCompleted?.Invoke();
        }

        private static void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) => new Thread(ExtractFiles).Start();
    }
}