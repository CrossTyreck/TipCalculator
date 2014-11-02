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

        private void QualityOfService_Scroll(object sender, EventArgs e)
        {
            int num = 0;
            QualityBarValue.Text = QualityOfService.Value.ToString();
            //Ensures value corresponds to text displayed. In case of error parsing default back to QualityOfService bar value.
            QualityValue = (int.TryParse(QualityBarValue.Text, out num) ? num : QualityOfService.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberOfGuests = (int)NumberOfGuestsValue.Value;
            TipTailoringScreen.GetTipTailorScreenAccess().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigurationScreen.GetConfigScreenAccess().Show();
            this.Hide();

        }

        private void ControlChange(object sender, EventArgs e)
        {
            int num = 0;
            TotalBillAndTipValue.Text = (BillTotalValue.Value + BillDeductionsValue.Value + TaxValue.Value + (int.TryParse(TotalTipValue.Text, out num) ? num : BillTotalValue.Value * (1 + (int.TryParse(TipRateValue.Text, out num) ? num : 0)))).ToString();
        }
    }
}
