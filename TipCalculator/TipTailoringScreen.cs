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
        public enum ChangeType
        {
            Add,
            Remove
        };

        public struct TipperRow
        {
            public TextBox Box { get; set; }
            public TrackBar TBar { get; set; }
            public Label DollarLabel { get; set; }
            public Label TrackValueLabel { get; set; }
            public Panel AddedTipPanel { get; set; }

            public TipperRow(TextBox box, TrackBar bar, Label dLabel, Label trackValue, Panel wrapper)
                : this()
            {
                Box = box;
                TBar = bar;
                DollarLabel = dLabel;
                TrackValueLabel = trackValue;
                AddedTipPanel = wrapper;
            }
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

        public static decimal TotalTip = 0;
        public static Stack<TipperRow> TipperRows { get; set; }
        private int TipperPanelHeightCounter { get; set; }
        private int TipperPanelWidthCounter { get; set; }
        private const int TIPPER_HEIGHT = 65;
        private const int TIPPER_WIDTH = 300;
        private static TipTailoringScreen TipTailorScreen;

        public static TipTailoringScreen GetTipTailorScreenAccess()
        {
            return (TipTailorScreen == null) ? TipTailorScreen = new TipTailoringScreen() : TipTailorScreen;
        }
        private TipTailoringScreen()
        {
            TipperRows = new Stack<TipperRow>();
            TipperPanelHeightCounter = 1;
            TipperPanelWidthCounter = 0;

            InitializeComponent();

        }
        private void TipTailoringScreen_Activated(object sender, EventArgs e)
        {
            if (TipperRows.Count < 1)
            {
                TipperRows.Push(GetInitialTipperRow());
            }

            if (TipperRows.Count < Bill_Entry_Screen.NumberOfGuests)
                SetupTipperRows(ChangeType.Add);
            else if (TipperRows.Count > Bill_Entry_Screen.NumberOfGuests)
                SetupTipperRows(ChangeType.Remove);

            this.Width = TIPPER_WIDTH * ((int)((TipperRows.Count-1) / 5) + 1);
            SetupIndividualTipMax();
        }

        private void SetupIndividualTipMax()
        {
            decimal MaxVal = Math.Round((Bill_Entry_Screen.TipValue / TipperRows.Count), 2);

            //Maximum being an int is going to give higher values for each persons allowed tip amount
            this.TipperAmount.Maximum = (int)Math.Ceiling(MaxVal);
            this.TipperAmount.Value = 0;
            this.TipperTipValue.Text = this.TipperAmount.Value.ToString();

            foreach (TipperRow row in TipperRows)
            {
                row.TBar.Maximum = (int)Math.Ceiling(MaxVal);
                row.TrackValueLabel.Text = row.TBar.Value > 0 ? row.TBar.Value.ToString() : "0";
            }

        }
        public void AddTipsUp()
        {
            TotalTip = 0;

            foreach (TipperRow row in TipperRows)
            {
                TotalTip += row.TBar.Value;
            }

        }
        private TipperRow GetInitialTipperRow()
        {
            TextBox box = new TextBox();
            box.Text = this.TipperName.Text;

            TrackBar bar = new TrackBar();
            bar.Value = this.TipperAmount.Value;

            Label dLabel = new Label();
            dLabel.Text = this.TipperDollar.Text;

            Label tipLabel = new Label();
            tipLabel.Text = this.TipperTipValue.Text;

            Panel wrapper = new Panel();

            TipperRow InitialRow = new TipperRow(box, bar, dLabel, tipLabel, wrapper);

            return InitialRow;
        }
        private void BackToBillEntryScreen_Click(object sender, EventArgs e)
        {
            Bill_Entry_Screen.GetBillEntryScreenAccess().Show();
            this.Hide();
        }
        public void SetupTipperRows(ChangeType change)
        {
            switch (change)
            {
                case ChangeType.Add:
                    while (TipperRows.Count < Math.Min(Bill_Entry_Screen.NumberOfGuests, 35))
                    {
                        CreateAnotherRow();
                    }

                    break;
                case ChangeType.Remove:
                    while (TipperRows.Count > Bill_Entry_Screen.NumberOfGuests)
                    {
                        RemoveRow(TipperRows.Pop());
                    }
                    break;
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

            TipperPanelHeightCounter = TipperPanelHeightCounter == 5 ? 0 : TipperPanelHeightCounter;
            AddedRow.AddedTipPanel.Location = new Point(-this.TipperPanel.Location.X + (TIPPER_WIDTH * (int)(TipperRows.Count/5)), this.TipperPanel.Location.Y + (TIPPER_HEIGHT * TipperPanelHeightCounter++));
            AddedRow.AddedTipPanel.Size = new System.Drawing.Size(TIPPER_WIDTH, TIPPER_HEIGHT);

            this.Controls.Add(AddedRow.AddedTipPanel);

            TipperRows.Push(AddedRow);

            this.Header.Width = this.Header.Width + (TIPPER_WIDTH * (int)(TipperRows.Count/5));
        }
        private void RemoveRow(TipperRow rowToRemove)
        {
            rowToRemove.Box.Dispose();
            rowToRemove.TBar.Dispose();
            rowToRemove.DollarLabel.Dispose();
            rowToRemove.TrackValueLabel.Dispose();
            rowToRemove.AddedTipPanel.Dispose();

            if (--TipperPanelHeightCounter == 0)
            {
                TipperPanelHeightCounter = 5;
            }
        }
        private void TipperAmount_Scroll(object sender, EventArgs e)
        {
            TipperTipValue.Text = TipperAmount.Value.ToString();
        }

    }
}
