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

    public class DeviceList : EventArgs
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

    class DeviceWatcher
    {
        CmdProcess cmdProcess = new CmdProcess();

        public event DeviceChangedHandler DeviceChanged;

        public delegate void DeviceChangedHandler(DeviceWatcher sender, DeviceList e);

        private string devicesRawOld;

        private string devicesRawNew;

        Thread tr;

        private bool isAdbWatcher;

        /// <summary>
        /// True for adb or false for fastboot
        /// </summary>
        /// <param name="isAdbWatcher"></param>
        public DeviceWatcher(bool isAdbWatcher)
        {
            this.isAdbWatcher = isAdbWatcher;
        }

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
            if (isAdbWatcher)
            {
                while (true)
                {
                    if (DeviceChanged != null)
                    {
                        devicesRawNew = cmdProcess.StartProcessingInThread("tools\\adb devices -l", "");

                        if (devicesRawNew != devicesRawOld)
                        {
                            devicesRawOld = devicesRawNew;

                            DeviceList dl = new DeviceList()
                            {
                                GetDevicesRaw = devicesRawNew,
                                GetDevicesList = ParseDevicesL(devicesRawNew)

                            };

                            DeviceChanged(this, dl);
                        }
                    }
                    Thread.Sleep(1000);
                } 
            }
            else
            {
                while (true)
                {
                    if (DeviceChanged != null)
                    {
                        devicesRawNew = cmdProcess.StartProcessingReadToEnd("tools\\fastboot devices", "");

                        if (devicesRawNew != devicesRawOld)
                        {
                            devicesRawOld = devicesRawNew;

                            DeviceList dl = new DeviceList()
                            {
                                GetDevicesRaw = devicesRawNew,
                                // todo Fastboot output parsen
                                //GetDevicesList = ParseDevicesL(devicesRawNew)

                            };

                            DeviceChanged(this, dl);
                        }
                    }
                    Thread.Sleep(2500);
                }
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