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
            CalculateTotal();
            CalculateTip();
        }

        private void QualityOfService_Scroll(object sender, EventArgs e)
        {
            int num = 0;
            QualityBarValue.Text = QualityOfService.Value.ToString();
            //Ensures value corresponds to text displayed. In case of error parsing default back to QualityOfService bar value.
            QualityValue = (int.TryParse(QualityBarValue.Text, out num) ? num : QualityOfService.Value);
            CalculateTip();
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

            SetTotalBillAndTipValue(TotalBillValue);
            
        }

        private void SetTotalBillAndTipValue(decimal total)
        {
            TotalBillAndTipValue.Text = total.ToString();
        }

        private void CalculateTip()
        {
            switch(QualityOfService.Value)
            {
                case 1:
                    TipRateValue.Text = Math.Round(ConfigurationScreen.MinTip, 2).ToString();
                    break;
                case 2:
                    TipRateValue.Text = (Math.Round(ConfigurationScreen.MaxTip * 0.25M, 2)).ToString();
                    break;
                case 3:
                    TipRateValue.Text = (Math.Round(ConfigurationScreen.MaxTip * 0.50M, 2)).ToString();;
                    break;
                case 4:
                    TipRateValue.Text = (Math.Round(ConfigurationScreen.MaxTip * 0.75M, 2)).ToString();;
                    break;
                case 5:
                    TipRateValue.Text = Math.Round(ConfigurationScreen.MaxTip, 2).ToString();;
                    break;
                default:
                    
                   break;

            }
        }
    }
}
