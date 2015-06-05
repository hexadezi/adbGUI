using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI
{
      public class adbMethods
      {
            private MainForm _mainForm;

            public adbMethods(MainForm mainForm)
            {
                  _mainForm = mainForm;
            }

            //Start the adb server
            private static void StartServer()
            {
                  var psi = new ProcessStartInfo("tools\\adb", "start-server");
                  psi.WindowStyle = ProcessWindowStyle.Hidden;
                  Process.Start(psi);
            }

            //Kill the adb server
            public void KillServer()
            {
                  foreach (var pr in Process.GetProcessesByName("adb"))
                  {
                        pr.Kill();
                  }
            }

            //Text to viewer
            private void ToViewer(string value, string title, int x, int y, FormWindowState windowstate = FormWindowState.Normal)
            {
                  if (_mainForm.InvokeRequired)
                  {
                        _mainForm.Invoke(new Action<string, string, int, int, FormWindowState>(ToViewer), value, title, x, y,
                              windowstate);
                        return;
                  }


                  var v = new Viewer();

                  v.txt_output.TabIndex = 2;
                  v.txt_output.Text += value;
                  v.Text = title;
                  v.WindowState = windowstate;
                  v.Width = x;
                  v.Height = y;
                  v.Show();
            }

            //Get all the information and start a new thread in wich CallAdb() runs
            public void GetInformation(string a, string b, string titel, int width = 850, int height = 606, FormWindowState windowstate = FormWindowState.Normal)
            {
                  if (_mainForm.cbSerials.SelectedItem != null)
                  {
                        string serial = Serialno();
                        var thread = new Thread(delegate() { CallAdb(a, b, titel, width, height, windowstate, serial); });
                        thread.IsBackground = true;
                        thread.Start();
                        while (thread.IsAlive)
                        {
                              _mainForm.tabControl1.Enabled = false;
                              Application.DoEvents();
                              //Cursor = Cursors.AppStarting;
                        }
                        _mainForm.tabControl1.Enabled = true;
                        //Cursor = Cursors.Default;
                  }
                  else
                  {
                        NoDeviceConnected();
                  }

            }

            //Call this, when you check for connected devices and there is no device connected
            private void NoDeviceConnected()
            {
                  _mainForm.tabControl1.SelectTab(0);

                  MessageBox.Show("No device Connected. Please connect a device and select it.\t", "Error - No device found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Call hidden adb instance, gets the output and puts it in a string, redirects string to ToViewer
            private void CallAdb(string a, string b, string c, int x, int y, FormWindowState windowstate = FormWindowState.Normal, string serial = "")
            {
                  const string filename = "cmd.exe";
                  var arguments = "/C " + a + " tools\\adb " + serial + " " + b;

                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };

                  var process = new Process { StartInfo = startInfo };

                  process.Start();

                  var s = process.StandardOutput.ReadToEnd();

                  ToViewer(s, c, x, y, windowstate);

                  process.Dispose();
            }

            //Returns the selected serial number in the combobox with the -s argument
            private string Serialno()
            {
                  try
                  {
                        if (_mainForm.cbSerials.SelectedItem.ToString() == "")
                        {
                              return "";
                        }
                        else
                        {
                              return "-s " + _mainForm.cbSerials.SelectedItem.ToString().ToLower();
                        }
                  }
                  catch (Exception)
                  {
                        return "";
                  }

            }

            //Open adb with commandprompt
            public void callADB_w(string x)
            {
                  if (_mainForm.cbSerials.SelectedItem == null)
                  {
                        NoDeviceConnected();
                  }
                  else
                  {
                        const string filename = "cmd.exe";
                        var arguments = "/C prompt $g & tools\\adb " + Serialno() + " " + x + " & echo. & pause";
                        var startInfo = new ProcessStartInfo
                        {
                              FileName = filename,
                              WindowStyle = ProcessWindowStyle.Normal,
                              Arguments = arguments
                        };
                        var process = new Process { StartInfo = startInfo };
                        process.Start();
                  }
            }

            //Open adb without commandprompt
            public void callADB_wo(string x, string y)
            {
                  if (_mainForm.cbSerials.SelectedItem != null)
                  {
                        var filename = "cmd.exe";
                        var arguments = "/C " + x + " tools\\adb " + Serialno() + " " + y;
                        var startInfo = new ProcessStartInfo
                        {
                              FileName = filename,
                              Arguments = arguments,
                              WindowStyle = ProcessWindowStyle.Hidden
                        };

                        var process = new Process { StartInfo = startInfo };

                        process.Start();
                  }
                  else
                  {
                        NoDeviceConnected();
                  }
            }

            //Checks if server is running and updates application title
            public void IsRunning()
            {
                  var a = "adbGUI - Server running";
                  var b = "adbGUI - Server not running";

                        if (Process.GetProcessesByName("adb").Length > 0)
                        {
                              if (_mainForm.InvokeRequired)
                              {
                                    _mainForm.Invoke(new Action<string>(ServerOn), a);
                              }
                        }
                        else
                        {
                              if (_mainForm.InvokeRequired)
                              {
                                    _mainForm.Invoke(new Action<string>(ServerOff), b);
                              }
                        }
            }

            private void ServerOn(string s)
            {
                  _mainForm.Text = s;
            }

            private void ServerOff(string s)
            {
                  _mainForm.Text = s;
                  _mainForm.txt_devices.Text = string.Empty;
            }

            //Prints devices - l to the textbox
            public void DevicesToTxtBox()
            {
                  const string filename = "cmd.exe";
                  const string arguments = "/C tools\\adb devices -l";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };

                        if (Process.GetProcessesByName("adb").Length > 0)
                        {
                              process.Start();
                        }

                        else
                        {
                              StartServer();
                              Thread.Sleep(500);
                              process.Start();
                        }

                        string s2 = process.StandardOutput.ReadToEnd();

                        _mainForm.txt_devices.Invoke((MethodInvoker)(() => _mainForm.txt_devices.Text = s2.ToUpper()));

            }

            //Run devices command, extract the serialnumber and add to combobox
            public void SerialnumberToComboBox()
            {
                  _mainForm.cbSerials.Invoke((MethodInvoker)(() => _mainForm.cbSerials.Items.Clear()));

                  const string filename = "cmd.exe";
                  const string arguments = "/C tools\\adb devices";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                  };
                  var process = new Process { StartInfo = startInfo };
                  process.Start();
                  string s2 = process.StandardOutput.ReadToEnd();


                  if (s2.Length > 29)
                  {
                        using (StringReader s = new StringReader(s2))
                        {
                              string line;

                              while (s.Peek() != -1)
                              {
                                    line = s.ReadLine();

                                    if (line.StartsWith("List") || line.StartsWith("\r\n") || line.Trim() == "")
                                          continue;

                                    if (line.IndexOf('\t') != -1)
                                    {
                                          line = line.Substring(0, line.IndexOf('\t'));
                                          _mainForm.cbSerials.Invoke((MethodInvoker)(() => _mainForm.cbSerials.Items.Add(line.ToUpper())));
                                    }
                              }
                              s.Close();
                              s.Dispose();
                        }
                  }
                  try
                  {
                        _mainForm.cbSerials.Invoke((MethodInvoker)(() => _mainForm.cbSerials.SelectedIndex = _mainForm.cbSerials.Items.Count - 1));
                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show(ex.Message);
                  }

            }

            //Connect device to the ip in textbox
            public void ConnectWifi()
            {
                  string s;
                  s = _mainForm.@txt_ip.Text;
                  if (s == "")
                  {
                        MessageBox.Show("Please type in IP and port!", "Error");
                  }
                  else
                  {
                        var filename = "cmd.exe";
                        var arguments = "/C tools\\adb connect " + s;
                        var startInfo = new ProcessStartInfo
                        {
                              FileName = filename,
                              Arguments = arguments,
                              WindowStyle = ProcessWindowStyle.Hidden
                        };

                        var process = new Process { StartInfo = startInfo };

                        process.Start();
                  }
            }

            //Disconnect connected devices
            public void DisconnectWifi()
            {
                  var filename = "cmd.exe";
                  var arguments = "/C tools\\adb disconnect";
                  var startInfo = new ProcessStartInfo
                  {
                        FileName = filename,
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden
                  };

                  var process = new Process { StartInfo = startInfo };

                  process.Start();
            }
      }
}