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
        public struct TipperRow
        {
            public TextBox Box { get; set; }
            public TrackBar TBar { get; set; }
            public Label DollarLabel { get; set; }
            public Label TrackValueLabel { get; set; }
            public Panel AddedTipPanel { get; set; }

            public void SetupControls()
            {
                Box = new System.Windows.Forms.TextBox();
                TBar = new System.Windows.Forms.TrackBar();
                TBar.Cursor = System.Windows.Forms.Cursors.Hand;
                DollarLabel = new System.Windows.Forms.Label();
                TrackValueLabel = new System.Windows.Forms.Label();
                AddedTipPanel = new System.Windows.Forms.Panel();

                TrackValueLabel.Text = TBar.Value.ToString();

                TBar.Scroll += new System.EventHandler(TBar_Scroll);
            }

            public void TBar_Scroll(object sender, EventArgs e)
            {
                TrackValueLabel.Text = TBar.Value.ToString();
            }
        }
        public Queue<TipperRow> TipperRows { get; set; }
        private int TipperPanelCounter { get; set; }
        private const int TIPPER_HEIGHT = 65;
        private static TipTailoringScreen TipTailorScreen;
        public static TipTailoringScreen GetTipTailorScreenAccess()
        {
            return (TipTailorScreen == null) ? TipTailorScreen = new TipTailoringScreen() : TipTailorScreen;
        }
        private TipTailoringScreen()
        {
            TipperRows = new Queue<TipperRow>();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bill_Entry_Screen.GetBillEntryScreenAccess().Show();
            this.Hide();
        }
        private void TipTailoringScreen_Activated(object sender, EventArgs e)
        {
            SetupTipperRows();
        }
        public void SetupTipperRows()
        {
            for (TipperPanelCounter = 1; TipperPanelCounter <= Math.Min(Bill_Entry_Screen.NumberOfGuests, 5) - 1; )
            {
                CreateAnotherRow();
            }

            while(TipperRows.Count > Bill_Entry_Screen.NumberOfGuests -1)
            {
                RemoveRow(TipperRows.Dequeue());
            }
        }

        private void CreateAnotherRow()
        {
            TipperRow AddedRow = new TipperRow();

            AddedRow.SetupControls();

            AddedRow.Box.Location = new System.Drawing.Point(3, 21);
            AddedRow.Box.Size = new System.Drawing.Size(100, 20);
            AddedRow.Box.TabIndex = 3;

            AddedRow.TBar.BackColor = System.Drawing.Color.White;
            AddedRow.TBar.Location = new System.Drawing.Point(107, 10);
            AddedRow.TBar.Size = new System.Drawing.Size(104, 45);

            AddedRow.DollarLabel.AutoSize = true;
            AddedRow.DollarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            AddedRow.DollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddedRow.DollarLabel.Location = new System.Drawing.Point(215, 21);
            AddedRow.DollarLabel.Size = new System.Drawing.Size(16, 16);
            AddedRow.DollarLabel.Text = "$";

            AddedRow.TrackValueLabel.AutoSize = true;
            AddedRow.TrackValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            AddedRow.TrackValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddedRow.TrackValueLabel.Location = new System.Drawing.Point(229, 22);
            AddedRow.TrackValueLabel.Size = new System.Drawing.Size(52, 16);
            AddedRow.TrackValueLabel.TabIndex = 21;
            AddedRow.TrackValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            AddedRow.AddedTipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            AddedRow.AddedTipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AddedRow.AddedTipPanel.Controls.Add(AddedRow.Box);
            AddedRow.AddedTipPanel.Controls.Add(AddedRow.TBar);
            AddedRow.AddedTipPanel.Controls.Add(AddedRow.DollarLabel);
            AddedRow.AddedTipPanel.Controls.Add(AddedRow.TrackValueLabel);
            AddedRow.AddedTipPanel.Location = new Point(this.TipperPanel.Location.X, this.TipperPanel.Location.Y + (TIPPER_HEIGHT * TipperPanelCounter++));
            AddedRow.AddedTipPanel.Size = new System.Drawing.Size(286, 65);

            this.Controls.Add(AddedRow.AddedTipPanel);

            TipperRows.Enqueue(AddedRow);

        }

        private void RemoveRow(TipperRow rowToRemove)
        {
            rowToRemove.Box.Dispose();
            rowToRemove.TBar.Dispose();
            rowToRemove.DollarLabel.Dispose(); 
            rowToRemove.TrackValueLabel.Dispose();
            rowToRemove.AddedTipPanel.Dispose();
        }
        private void TipperAmount_Scroll(object sender, EventArgs e)
        {
            TipperTipValue.Text = TipperAmount.Value.ToString();
        }


    }
}
