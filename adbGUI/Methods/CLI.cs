using System;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adbGUI.Methods
{
	public static class CLI
	{
		private static readonly int defaultCodePage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage;

		static CLI()
		{
			Commandline = new Process();

			ProcessStartInfo startInfo = new ProcessStartInfo()
			{
				FileName = "cmd",
				Arguments = "/K prompt $g ",
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				RedirectStandardInput = true,
				StandardOutputEncoding = Encoding.GetEncoding(defaultCodePage),
				StandardErrorEncoding = Encoding.GetEncoding(defaultCodePage)
			};

			Commandline.EnableRaisingEvents = true;

			Commandline.StartInfo = startInfo;

			Commandline.Start();
		}

		public static Process Commandline { get; set; } = new Process();

		public static void AbortChildProcesses()
		{
			using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ParentProcessID=" + Commandline.Id + " AND Caption != 'conhost.exe'"))
			{
				ManagementObjectCollection managementObjectCollection = searcher.Get();
				foreach (ManagementObject managementObject in managementObjectCollection)
				{
					int pid = Convert.ToInt32(managementObject["ProcessID"]);
					Debug.WriteLine($"Killing {managementObject["Caption"]}({managementObject["ProcessID"]})");
					Process.GetProcessById(pid).Kill();
				}
			}
		}

		public static void AbortChildProcessesAsync()
		{
			Task.Run(() => { AbortChildProcesses(); });
		}

		public static void AbortChildProcessesWithShell()
		{
			string input = "taskkill /F ";

			using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ParentProcessID=" + Commandline.Id + " AND Caption != 'conhost.exe'"))
			{
				ManagementObjectCollection managementObjectCollection = searcher.Get();

				foreach (ManagementObject managementObject in managementObjectCollection)
				{
					int pid = Convert.ToInt32(managementObject["ProcessID"]);
					input += $"/PID {pid} ";
				}
			}

			if (input == "taskkill /F ") return;

			Process cmd = new Process();

			ProcessStartInfo startInfo = new ProcessStartInfo()
			{
				FileName = "cmd",
				Arguments = "/c " + input,
				UseShellExecute = false,
				CreateNoWindow = true,
			};

			cmd.StartInfo = startInfo;

			Debug.WriteLine("Executing: cmd /c" + input);

			cmd.Start();
		}

		public static void Execute(string command)
		{
			Commandline.StandardInput.WriteLine(command);
		}

		public static string GetOutput(string command)
		{
			Process cmd = new Process();

			ProcessStartInfo startInfo = new ProcessStartInfo()
			{
				FileName = "cmd",
				Arguments = "/c " + command,
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				RedirectStandardInput = true,
				StandardOutputEncoding = Encoding.GetEncoding(defaultCodePage),
				StandardErrorEncoding = Encoding.GetEncoding(defaultCodePage)
			};

			cmd.EnableRaisingEvents = true;

			cmd.StartInfo = startInfo;

			cmd.Start();

			return cmd.StandardOutput.ReadToEnd();
		}

		internal static void Stop()
		{
			AbortChildProcesses();
			Commandline.Kill();
		}

		internal static void StopWithShell()
		{
			AbortChildProcessesWithShell();
			Commandline.Kill();
		}
	}
}
