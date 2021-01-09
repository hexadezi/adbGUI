using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI.Methods
{
	public static class Dependencies
	{
		private static readonly string DownloadToTempPath = Path.GetTempPath() + "platform-tools-latest-windows.zip";

		private static readonly string[] StrFiles =
			{"adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll", "fastboot.exe", "libwinpthread-1.dll"};

		public static void Start()
		{
			if (CheckIfFilesExist()) return;
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

		private static bool CheckIfFilesExist()
		{
			return StrFiles != null && StrFiles.All(File.Exists);
		}

		private static void DownloadFiles()
		{
			ExtractionCompleted += DependenciesChecker_ExtractionCompleted;
			using (var wc = new WebClient())
			{
				wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
				wc.DownloadFileTaskAsync(
					new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip"),
					DownloadToTempPath);
			}
		}

		private static void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			var tr = new Thread(ExtractFiles);
			tr.Start();
		}

		private static event ExtractionCompletedHandler ExtractionCompleted;

		private static void ExtractFiles()
		{
			if (Directory.Exists(Path.GetTempPath() + "platform-tools"))
				Directory.Delete(Path.GetTempPath() + "platform-tools", true);

			ZipFile.ExtractToDirectory(DownloadToTempPath, Path.GetTempPath());

			ExtractionCompleted?.Invoke();
		}

		private static void DependenciesChecker_ExtractionCompleted()
		{
			var extractedFilesPath = Path.GetTempPath() + "platform-tools";

			foreach (var item in StrFiles)
				try
				{
					File.Copy(extractedFilesPath + "\\" + item, item);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			ExtractionCompleted -= DependenciesChecker_ExtractionCompleted;

			MessageBox.Show(@"Files downloaded, decompressed and moved successfully", @"Completed",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private delegate void ExtractionCompletedHandler();
	}
}