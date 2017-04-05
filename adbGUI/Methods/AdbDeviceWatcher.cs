using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace adbGUI.Methods
{
    public class AdbDeviceList : EventArgs
    {
        private List<string> devicesList;

        private string devicesRaw;

        public List<string> GetDevicesList
        {
            set
            {
                devicesList = value;
            }
            get
            {
                return this.devicesList;
            }
        }

        public string GetDevicesRaw
        {
            set
            {
                devicesRaw = value;
            }
            get
            {
                return devicesRaw;
            }
        }

    }

    public static class AdbDeviceWatcher
    {
        public static event DeviceChangedHandler DeviceChanged;

        public delegate void DeviceChangedHandler(AdbDeviceList e);

        private static string devicesRawOld;

        private static string devicesRawNew;

        private static int connectedDevices = 0;

        private static Thread tr;

        public static void StartDeviceWatcher()
        {

            tr = new Thread(Watcher)
            {
                IsBackground = true
            };

            tr.Start();

        }

        private static void Watcher()
        {
            while (true)
            {
                if (DeviceChanged != null)
                {
                    devicesRawNew = StartProcessingGetDevices("adb devices -l");

                    if (devicesRawNew != devicesRawOld)
                    {
                        devicesRawOld = devicesRawNew;

                        AdbDeviceList dl = new AdbDeviceList()
                        {
                            GetDevicesRaw = devicesRawNew,
                            GetDevicesList = ParseDevicesL(devicesRawNew)
                        };

                        connectedDevices = dl.GetDevicesList.Count;

                        DeviceChanged(dl);
                    }
                }
                Thread.Sleep(750);
            }
        }

        private static List<string> ParseDevicesL(string input)
        {
            List<string> listofserials = new List<string>();

            if (input.Length > 29)
            {
                using (StringReader s = new StringReader(input))
                {
                    string line;

                    while (s.Peek() != -1)
                    {
                        line = s.ReadLine();

                        if (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "" || line.StartsWith("*"))
                            continue;

                        if (line.IndexOf(' ') != -1)
                        {
                            listofserials.Add(line = line.Substring(0, line.IndexOf(' ')));
                        }
                    }
                    s.Close();

                }
            }

            return listofserials;
        }

        public static int GetConnectedAdbDevices() {
            return connectedDevices;
        }

        private static string StartProcessingGetDevices(string command)
        {
            Process process2 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/C " + command,
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

    }

}