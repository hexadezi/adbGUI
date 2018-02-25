using System;
using System.Collections.Generic;

namespace adbGUI.Methods
{
    public class AdbDeviceList : EventArgs
    {
        public List<string> GetDevicesList { set; get; }

        public string GetDevicesRaw { set; get; }
    }
}