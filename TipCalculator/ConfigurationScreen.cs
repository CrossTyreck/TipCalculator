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
        public static bool ShowTax = true;
        public static bool ShowDeductions = true;
        public static decimal MinTip = 0.00M;
        public static decimal MaxTip = 0.00M;

        public static ConfigurationScreen GetConfigScreenAccess()
        {
            return (ConfigScreen == null) ? ConfigScreen = new ConfigurationScreen() : ConfigScreen;
        }

        private ConfigurationScreen()
        {
            InitializeComponent();
            TaxTrue.Checked = true;
            DeductionTrue.Checked = true;
        }

        private void ConfigurationScreen_Activated(object sender, EventArgs e)
        {
            SetupTaxRanges();
        }

        private void BackToBillEntry_Click(object sender, EventArgs e)
        {
            Bill_Entry_Screen.GetBillEntryScreenAccess().Show();
            this.Hide();
        }

        private void SetupTaxRanges()
        {
            MinTip = MinTipPerc.Value;
            MaxTip = MaxTipPerc.Value;
        }

        private void SetMinMax(object sender, EventArgs e)
        {
            MaxTipPerc.Minimum = MinTipPerc.Value + 0.01M;
            MinTipPerc.Maximum = MaxTipPerc.Value - 0.01M;
            SetupTaxRanges();
        }

        private void SetTaxDeductions(object sender, EventArgs e)
        {
            ShowTax = TaxTrue.Checked;
            ShowDeductions = DeductionTrue.Checked;
        }
    }
}
