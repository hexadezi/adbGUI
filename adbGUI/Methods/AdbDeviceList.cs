// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace adbGUI.Methods
{
    using System;
    using System.Collections.Generic;

    public class AdbDeviceList : EventArgs
    {
        public List<string> GetDevicesList { set; get; }

        public string GetDevicesRaw { set; get; }
    }
}