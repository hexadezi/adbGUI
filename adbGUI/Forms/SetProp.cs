using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class SetProp : Form
    {
        private AdbOps adb;
        private FormMethods formMethods;

        public SetProp(AdbOps adbFrm, FormMethods fMethods)
        {
            adb = adbFrm;
            formMethods = fMethods;
            InitializeComponent();
        }

        private void Btn_setProp_Click(object sender, EventArgs e)
        {
            adb.StartProcessing("shell su root setprop " + txt_setPropKey.Text + " " + txt_setPropValue.Text, formMethods.SelectedDevice());
        }
    }
}