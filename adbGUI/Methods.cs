using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adbGUI
{
      class Methods
      {
            private static void StartServer()
            {
                  var psi = new ProcessStartInfo("tools\\adb", "start-server");
                  psi.WindowStyle = ProcessWindowStyle.Hidden;
                  Process.Start(psi);
            }
      }
}
