using System;
using System.Collections.Generic;
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

		public static List<int> GetChildProcesses()
		{
			List<int> lst = new List<int>();

			using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ParentProcessID=" + Commandline.Id + " AND Caption != 'conhost.exe'"))
			{
				ManagementObjectCollection managementObjectCollection = searcher.Get();
				foreach (ManagementObject managementObject in managementObjectCollection)
				{
					lst.Add(Convert.ToInt32(managementObject["ProcessID"]));
				}
			}

			return lst;
		}

		public static void KillChildProcesses()
		{
			foreach (int pid in GetChildProcesses())
			{
				Debug.WriteLine($"Killing {pid})");
				Process.GetProcessById(pid).Kill();
			}
		}

		public static void KillChildProcessesAsync()
		{
			Task.Run(() => { KillChildProcesses(); });
		}

		public static void KillChildProcessesWithShell()
		{
			HelperClass.Execute("adb kill-server");
			string input = "taskkill /F ";

			foreach (int pid in GetChildProcesses())
			{
				input += $"/PID {pid} ";
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

			Debug.WriteLine("Executing: cmd /c " + input);

			cmd.Start();
		}

		public static void KillAllAdbProcessesWithShell()
		{
			string input = "taskkill /F ";

			foreach (Process process in Process.GetProcessesByName("adb"))
			{
				input += $"/PID {process.Id} ";
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

			Debug.WriteLine("Executing: cmd /c " + input);

			cmd.Start();

		}

		public static void Execute(string command)
		{
			Commandline.StandardInput.WriteLine(command);
		}

		public static string GetOutput(string fileName, string arguments)
		{
			Process cmd = new Process();

			ProcessStartInfo startInfo = new ProcessStartInfo()
			{
				FileName = fileName,
				Arguments = arguments,
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

		public static void StopWithShell()
		{
			KillChildProcessesWithShell();
			Commandline.Kill();
		}
	}
}
