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
    public partial class Bill_Entry_Screen : Form
    {
        private static Bill_Entry_Screen BillEntryScreen;
        public static int NumberOfGuests = 0;
        public static int QualityValue = 0;
        private decimal TipRate { get; set; }

        public static decimal TipValue = 0;

        public static Bill_Entry_Screen GetBillEntryScreenAccess()
        {
            return (BillEntryScreen == null) ? BillEntryScreen = new Bill_Entry_Screen() : BillEntryScreen;
        }

        private Bill_Entry_Screen()
        {
            InitializeComponent();
        }

        private void BillEntryScreen_Activated(object sender, EventArgs e)
        {
            SetBillDefaults();
            CalculateTipRate();
            CalculateTip();
            CalculatePerPersonTip();
            CalculateTotal();
        }

        private void QualityOfService_Scroll(object sender, EventArgs e)
        {
            QualityBarValue.Text = QualityOfService.Value.ToString();
            QualityValue = QualityOfService.Value;
            ControlChange(sender, e);
        }

        private void TailorTip_Click(object sender, EventArgs e)
        {
            NumberOfGuests = (int)NumberOfGuestsValue.Value;
            TipTailoringScreen.GetTipTailorScreenAccess().Show();
            this.Hide();
        }

        private void Configure_Click(object sender, EventArgs e)
        {
            ConfigurationScreen.GetConfigScreenAccess().Show();
            this.Hide();

        }

        private void ControlChange(object sender, EventArgs e)
        {
            CalculateTip();
            CalculateTipRate();
            CalculatePerPersonTip();
            CalculateTotal();
        }

        private void SetBillDefaults()
        {

            if (!ConfigurationScreen.ShowTax)
            {
                lblTax.Font = new Font(lblTax.Font, FontStyle.Strikeout);
                TaxValue.Enabled = false;
            }
            else
            {
                lblTax.Font = new Font(lblTax.Font, FontStyle.Bold);
                TaxValue.Enabled = true;
            }

            if (!ConfigurationScreen.ShowDeductions)
            {
                lblBillDeductions.Font = new Font(lblBillDeductions.Font, FontStyle.Strikeout);
                BillDeductionsValue.Enabled = false;
            }
            else
            {
                lblBillDeductions.Font = new Font(lblBillDeductions.Font, FontStyle.Bold);
                BillDeductionsValue.Enabled = true;
            }
        }

        private void CalculateTotal()
        {
            decimal TotalBillValue = BillTotalValue.Value;

            if (BillDeductionsValue.Enabled) { TotalBillValue += BillDeductionsValue.Value; }
            if (TaxValue.Enabled) { TotalBillValue += TaxValue.Value; }

            SetTotalBillAndTipValue(TotalBillValue + TipValue);

        }

        private void SetTotalBillAndTipValue(decimal total)
        {
            TotalBillAndTipValue.Text = total.ToString();
        }

        private void CalculateTipRate()
        {
            switch (QualityOfService.Value)
            {
                case 1:
                    TipRate = Math.Round(ConfigurationScreen.MinTip, 2);
                    TipRateValue.Text = TipRate.ToString();
                    break;
                case 2:
                    TipRate = Math.Round(Math.Max(ConfigurationScreen.MaxTip * 0.25M, ConfigurationScreen.MinTip), 2);
                    TipRateValue.Text = TipRate.ToString();
                    break;
                case 3:
                    TipRate = Math.Round(Math.Max(ConfigurationScreen.MaxTip * 0.5M, ConfigurationScreen.MinTip), 2);
                    TipRateValue.Text = TipRate.ToString(); ;
                    break;
                case 4:
                    TipRate = Math.Round(Math.Max(ConfigurationScreen.MaxTip * 0.75M, ConfigurationScreen.MinTip), 2);
                    TipRateValue.Text = TipRate.ToString(); ;
                    break;
                case 5:
                    TipRate = Math.Round(ConfigurationScreen.MaxTip, 2);
                    TipRateValue.Text = TipRate.ToString(); ;
                    break;
                default:

                    break;
            }
        }

        private void CalculateTip()
        {
            if (TipTailoringScreen.TipperRows != null && TipTailoringScreen.TipperRows.Count == 1)
            {
                TipValue = BillTotalValue.Value * (TipRate * 0.01M);
            }
            else
            {
                TipValue = BillTotalValue.Value * (TipRate * 0.01M);
            }

            TotalTipValue.Text = Math.Round(TipValue, 2).ToString();
        }

        private void CalculatePerPersonTip()
        {
            NumberOfGuests = (int)NumberOfGuestsValue.Value;
            PerPersonTipValue.Text = Math.Round((TipValue / NumberOfGuests), 2).ToString();

        }
    }
}
