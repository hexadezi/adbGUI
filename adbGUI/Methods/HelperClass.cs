using adbGUI.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace adbGUI.Methods
{
	public static class HelperClass
	{
		public static event EventHandler BeforeExecute;

		public static string SelectedDevice { get; set; } = "";

		public static bool AlwaysClearConsole { get; set; } = false;

		public static void Execute(string command, bool withSerial = true)
		{
			BeforeExecute?.Invoke(null, EventArgs.Empty);

			if (String.IsNullOrWhiteSpace(SelectedDevice) || withSerial == false)
			{
				CLI.Execute(command);
			}
			else if (command.StartsWith("adb ", StringComparison.CurrentCultureIgnoreCase))
			{
				string cmd = ReplaceFirstOccurrence(command, "adb ", "adb -s " + SelectedDevice + " ");
				CLI.Execute(cmd);
			}
			else
			{
				CLI.Execute(command);
			}
		}

		public static string ExecuteWithOutput(string command, bool withSerial = true)
		{
			if (String.IsNullOrWhiteSpace(SelectedDevice) || withSerial == false)
			{
				return CLI.GetOutput(command);
			}
			else
			{
				string cmd = command.Replace("adb ", "adb -s " + SelectedDevice + " ");
				return CLI.GetOutput(cmd);
			}
		}

		public static string ReplaceFirstOccurrence(string Source, string Find, string Replace)
		{
			// Thanks to Tim Trott
			// https://lonewolfonline.net/replace-first-occurrence-string/
			int Place = Source.IndexOf(Find);
			string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
			return result;
		}

	}
}