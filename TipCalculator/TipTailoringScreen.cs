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
    public partial class TipTailoringScreen : Form
    {
        private static TipTailoringScreen TipTailorScreen;
        public static TipTailoringScreen GetTipTailorScreenAccess()
        {
            return (TipTailorScreen == null) ? TipTailorScreen = new TipTailoringScreen() : TipTailorScreen;
        }

        private TipTailoringScreen()
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
