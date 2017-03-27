using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Methods
{

    public class DeviceListAdb : EventArgs
    {
        private List<string> devices;
        public List<string> DeviceList
        {
            set
            {
                devices = value;
            }
            get
            {
                return this.devices;
            }
        }

        private string devicesRaw;
        public string DevicesRaw
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

    class DeviceWatcherAdb
    {
        AdbOps adb = new AdbOps();

        public event DeviceChangedHandler DeviceChanged;

        public delegate void DeviceChangedHandler(DeviceWatcherAdb sender, DeviceListAdb e);

        private string devicesRawOld;

        private string devicesRawNew;

        Thread tr;

        public void StartDeviceWatcher()
        {
            tr = new Thread(Watcher)
            {
                IsBackground = true
            };

            tr.Start();

        }

        private void Watcher()
        {
            while (true)
            {
                if (DeviceChanged != null)
                {
                    devicesRawNew = adb.StartProcessingReadToEnd("devices -l", "");

                    if (devicesRawNew != devicesRawOld)
                    {
                        devicesRawOld = devicesRawNew;

                        DeviceListAdb dl = new DeviceListAdb()
                        {
                            DevicesRaw = devicesRawNew,
                            DeviceList = ParseDevicesL(devicesRawNew)

                        };

                        DeviceChanged(this, dl);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        private List<string> ParseDevicesL(string input)
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
                            line = line.Substring(0, line.IndexOf(' '));
                            listofserials.Add(line);
                        }
                    }
                    s.Close();

                }
            }

            return listofserials;
        }

    }

}