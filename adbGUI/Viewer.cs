





using System;
using System.IO;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class Viewer : Form
      {
            public Viewer()
            {
                  InitializeComponent();
            }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                  if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
                  Close();
                  return true;
            }

            private void button1_Click(object sender, System.EventArgs e)
            {
                  saveFileDialog1.Filter = " .txt|*.txt";
                  saveFileDialog1.FileName = Viewer.ActiveForm.Text;
                  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        File.WriteAllText(saveFileDialog1.FileName, txt_output.Text);
                  }
            }
      }
}
