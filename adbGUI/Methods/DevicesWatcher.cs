using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adbGUI.Methods
{
	static class DevicesWatcher
	{
		public static event EventHandler<List<string>> DevicesChanged;

		private static string oldOutput = "";

		private static readonly Thread thread;

		private static int refreshInterval;

		static DevicesWatcher()
		{
			thread = new Thread(new ThreadStart(Refresh));
		}

		public static void Refresh()
		{
			while (true)
			{
				string output = CLI.GetOutput("adb devices");

				if (output != oldOutput)
				{
					List<string> list = new List<string>();

					oldOutput = output;

					foreach (string str in output.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
					{
						if (str.StartsWith("List"))
						{
							continue;
						}

						list.Add(str.Substring(0, str.IndexOf("\t")));

						Debug.WriteLine("Device added: " + str.Substring(0, str.IndexOf("\t")));
					}

					DevicesChanged?.Invoke(null, list);
				}
				Thread.Sleep(refreshInterval);
			}
		}

		public static void Start(int interval = 2000)
		{
			refreshInterval = interval;
			thread.Start();
			Debug.WriteLine($"DeviceWatcher thread{thread.ManagedThreadId} started");
		}
	}

}
