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
            TrackBarValue.Text = QualityOfService.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipTailoringScreen.GetTipTailorScreenAccess().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigurationScreen.GetConfigScreenAccess().Show();
            this.Hide();

        }
    }
}
