using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class ConfigurationScreen : Form
    {
        private static ConfigurationScreen ConfigScreen;
        public static ConfigurationScreen GetConfigScreenAccess()
        {
            return (ConfigScreen == null) ? ConfigScreen = new ConfigurationScreen() : ConfigScreen;
        }

        private ConfigurationScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill_Entry_Screen.GetBillEntryScreenAccess().Show();
            this.Hide();
        }
    }
}
