// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Methods
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;

    public static class AdbDeviceWatcher
    {
        public delegate void DeviceChangedHandler(AdbDeviceList e);

        private static string _devicesRawOld;

        private static string _devicesRawNew;

        private static int _connectedDevices;

        private static Thread _tr;
        public static event DeviceChangedHandler DeviceChanged;

        public static void StartDeviceWatcher()
        {
            _tr = new Thread(Watcher)
            {
                IsBackground = true
            };

            _tr.Start();
        }

        private static void Watcher()
        {
            while (true)
            {
                if (DeviceChanged != null)
                {
                    _devicesRawNew = StartProcessingGetDevices("adb devices -l");

                    if (_devicesRawNew != _devicesRawOld)
                    {
                        _devicesRawOld = _devicesRawNew;

                        var dl = new AdbDeviceList
                        {
                            GetDevicesRaw = _devicesRawNew,
                            GetDevicesList = ParseDevicesL(_devicesRawNew)
                        };

                        _connectedDevices = dl.GetDevicesList.Count;

                        DeviceChanged?.Invoke(dl);
                    }
                }

                Thread.Sleep(750);
            }

            // ReSharper disable once FunctionNeverReturns
        }

        private static List<string> ParseDevicesL(string input)
        {
            var listofserials = new List<string>();

            if (input.Length <= 29) return listofserials;
            using (var s = new StringReader(input))
            {
                while (s.Peek() != -1)
                {
                    var line = s.ReadLine();

                    if (line != null && (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "" ||
                                         line.StartsWith("*")))
                        continue;

                    if (line != null && line.IndexOf(' ') != -1)
                        listofserials.Add(line.Substring(0, line.IndexOf(' ')));
                }
            }

            return listofserials;
        }

        public static int GetConnectedAdbDevices()
        {
            return _connectedDevices;
        }

        private static string StartProcessingGetDevices(string command)
        {
            using (var process2 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/C " + command,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true
                }
            })
            {
                process2.Start();

                return process2.StandardOutput.ReadToEnd();
            }
        }
    }
}