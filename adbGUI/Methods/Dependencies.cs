using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Methods
{
	public static class Dependencies
	{
		private static readonly string downloadedZipFile = Path.GetTempPath() + "platform-tools-latest-windows.zip";

		private static readonly string tmpPlatformPath = Path.Combine(Path.GetTempPath(), "platform-tools");

		private static readonly Uri downloadUri = new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip");

		private static readonly string[] StrFiles =
			{"adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll", "fastboot.exe", "libwinpthread-1.dll"};

		public static void Check()
		{
			SetEnvVariable();

			if (FilesExist()) return;

			var dialogResult =
				MessageBox.Show(
					@"Required files are missing. Download missing files?",
					@"Error: Missing Files",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Error);

			switch (dialogResult)
			{
				case DialogResult.Yes:
					DownloadFiles();
					ExtractFiles();
					MessageBox.Show(@"Files downloaded", @"Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				default:
					Environment.Exit(0);
					break;
			}
		}

		private static bool FilesExist()
		{
			foreach (var file in StrFiles)
			{
				if (!File.Exists(Path.Combine(tmpPlatformPath, file)))
				{
					return false;
				}
			}

			return true;
		}

		private static void DownloadFiles()
		{
			using (var wc = new WebClient())
			{
				wc.DownloadFile(downloadUri, downloadedZipFile);
			}
		}

		private static void ExtractFiles()
		{
			if (!Directory.Exists(tmpPlatformPath))
			{
				Directory.CreateDirectory(tmpPlatformPath);
			}

			using (ZipArchive archive = ZipFile.OpenRead(downloadedZipFile))
			{
				foreach (ZipArchiveEntry entry in archive.Entries)
				{
					if (StrFiles.Any(entry.Name.Contains))
					{
						entry.ExtractToFile(Path.Combine(Path.GetTempPath(), entry.FullName), true);
					}
				}
			}
		}

		private static void SetEnvVariable()
		{
			string oldValue = Environment.GetEnvironmentVariable("PATH");

			Environment.SetEnvironmentVariable("PATH", oldValue + ";" + tmpPlatformPath);
		}

		private static void ExtractionCompleted()
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
		}
	}
}