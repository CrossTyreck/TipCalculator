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
        //    MaxTipPerc.Minimum = 0M;
        //    MinTipPerc.Minimum = 0M;
        //    MaxTipPerc.Maximum = 100M;
        //    MinTipPerc.Maximum = 99.99M;

        //    switch (Bill_Entry_Screen.QualityValue)
        //    {
        //        case 1:
        //            MinTipPerc.Value = 0.00M;
        //            break;
        //        case 2:
        //            MinTipPerc.Value = 5.00M;
        //            break;
        //        case 3:
        //            MinTipPerc.Value = 10.00M;
        //            break;
        //        case 4:
        //            MinTipPerc.Value = 15.00M;
        //            break;
        //        case 5:
        //            MinTipPerc.Value = 20.00M;
        //            break;
        //        default:
        //            MinTipPerc.Value = 0.00M;
        //            break;
        //    }

        //    MaxTipPerc.Minimum = MinTipPerc.Value + 0.01M;

        //    switch (Bill_Entry_Screen.QualityValue)
        //    {
        //        case 1:
        //            MaxTipPerc.Value = 5.00M;
        //            break;
        //        case 2:
        //            MaxTipPerc.Value = 10.00M;
        //            break;
        //        case 3:
        //            MaxTipPerc.Value = 20.00M;
        //            break;
        //        case 4:
        //            MaxTipPerc.Value = 30.00M;
        //            break;
        //        case 5:
        //            MaxTipPerc.Value = 40.00M;
        //            break;
        //        default:
        //            MaxTipPerc.Value = 0.00M;
        //            break;
        //    }

        //    MinTipPerc.Maximum = MaxTipPerc.Value - 0.01M;

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
