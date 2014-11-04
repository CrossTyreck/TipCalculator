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
        private int OldNumOfGuests { get; set; }
        private int GuestDifference = 0;

        public static TipTailoringScreen GetTipTailorScreenAccess()
        {
            return (TipTailorScreen == null) ? TipTailorScreen = new TipTailoringScreen() : TipTailorScreen;
        }
        private TipTailoringScreen()
        {
            TipperRows = new Stack<TipperRow>();
            TipperPanelHeightCounter = 1;
            TipperPanelWidthCounter = 1;
            OldNumOfGuests = 1;
            InitializeComponent();

        }
        private void TipTailoringScreen_Activated(object sender, EventArgs e)
        {
            if (TipperRows.Count < 1)
            {
                TipperRows.Push(GetInitialTipperRow());
            }

            GuestDifference = Math.Abs(OldNumOfGuests - Bill_Entry_Screen.NumberOfGuests) == 0 ? 0 : OldNumOfGuests - Bill_Entry_Screen.NumberOfGuests;

            if (GuestDifference > 0)
                SetupTipperRows(ChangeType.Add);
            else if (GuestDifference < 0)
                SetupTipperRows(ChangeType.Remove);

            SetupIndividualTipMax();
        }

        //private int SetChangeType(int difference)
        //{
        //    if (difference < 0)
        //    {
        //        return difference * -1;
        //    }

        //    return difference;
        //}
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
                row.TBar.Value = 0;
                row.TrackValueLabel.Text = row.TBar.Value.ToString();
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
                        if (TipperRows.Count % 5 == 0)
                            this.Width = TIPPER_WIDTH * ++TipperPanelWidthCounter;
                        CreateAnotherRow();
                    }

                    break;
                case ChangeType.Remove:
                    while (TipperRows.Count > Bill_Entry_Screen.NumberOfGuests)
                    {
                        if (TipperRows.Count % 5 == 0)
                            this.Width = TIPPER_WIDTH * --TipperPanelWidthCounter;
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

            if (TipperPanelHeightCounter % 5 > 0)
            {
                this.Width = TIPPER_WIDTH * TipperPanelWidthCounter++;
            }

            AddedRow.AddedTipPanel.Location = new Point(this.TipperPanel.Location.X, this.TipperPanel.Location.Y + (TIPPER_HEIGHT * TipperPanelHeightCounter++));
            AddedRow.AddedTipPanel.Size = new System.Drawing.Size(TIPPER_WIDTH, TIPPER_HEIGHT);

            this.Controls.Add(AddedRow.AddedTipPanel);

            TipperRows.Push(AddedRow);

        }
        private void RemoveRow(TipperRow rowToRemove)
        {
            rowToRemove.Box.Dispose();
            rowToRemove.TBar.Dispose();
            rowToRemove.DollarLabel.Dispose();
            rowToRemove.TrackValueLabel.Dispose();
            rowToRemove.AddedTipPanel.Dispose();

            TipperPanelHeightCounter -= 1;
        }
        private void TipperAmount_Scroll(object sender, EventArgs e)
        {
            TipperTipValue.Text = TipperAmount.Value.ToString();
        }

    }
}
