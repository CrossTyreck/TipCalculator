using System;
namespace TipCalculator
{
    partial class Bill_Entry_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfigureTipButton = new System.Windows.Forms.Button();
            this.TipTailorButton = new System.Windows.Forms.Button();
            this.NumberOfGuestsValue = new System.Windows.Forms.NumericUpDown();
            this.lblNumGuests = new System.Windows.Forms.Label();
            this.QualityOfService = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.BillTotalValue = new System.Windows.Forms.NumericUpDown();
            this.TaxValue = new System.Windows.Forms.NumericUpDown();
            this.BillDeductionsValue = new System.Windows.Forms.NumericUpDown();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblBillDeductions = new System.Windows.Forms.Label();
            this.lblTotalTip = new System.Windows.Forms.Label();
            this.lblPerPersonTip = new System.Windows.Forms.Label();
            this.lblTipRate = new System.Windows.Forms.Label();
            this.lblTotalBillAndTip = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.QualityBarValue = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalBillAndTipValue = new System.Windows.Forms.Label();
            this.PerPersonTipValue = new System.Windows.Forms.Label();
            this.TotalTipValue = new System.Windows.Forms.Label();
            this.TipRateValue = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfGuestsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityOfService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDeductionsValue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Location = new System.Drawing.Point(-1, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(286, 65);
            this.Header.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 0, 35, 10);
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIP SPLITTING\r\nCALCULATOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.ConfigureTipButton);
            this.panel1.Controls.Add(this.TipTailorButton);
            this.panel1.Location = new System.Drawing.Point(-1, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 45);
            this.panel1.TabIndex = 3;
            // 
            // ConfigureTipButton
            // 
            this.ConfigureTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigureTipButton.Location = new System.Drawing.Point(150, 6);
            this.ConfigureTipButton.Name = "ConfigureTipButton";
            this.ConfigureTipButton.Size = new System.Drawing.Size(125, 33);
            this.ConfigureTipButton.TabIndex = 3;
            this.ConfigureTipButton.Text = "Configure Tip";
            this.ConfigureTipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ConfigureTipButton.UseVisualStyleBackColor = true;
            this.ConfigureTipButton.Click += new System.EventHandler(this.Configure_Click);
            // 
            // TipTailorButton
            // 
            this.TipTailorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipTailorButton.Location = new System.Drawing.Point(9, 6);
            this.TipTailorButton.Name = "TipTailorButton";
            this.TipTailorButton.Size = new System.Drawing.Size(125, 33);
            this.TipTailorButton.TabIndex = 2;
            this.TipTailorButton.Text = "Tip Tailoring";
            this.TipTailorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TipTailorButton.UseVisualStyleBackColor = true;
            this.TipTailorButton.Click += new System.EventHandler(this.TailorTip_Click);
            // 
            // NumberOfGuestsValue
            // 
            this.NumberOfGuestsValue.Location = new System.Drawing.Point(146, 180);
            this.NumberOfGuestsValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberOfGuestsValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfGuestsValue.Name = "NumberOfGuestsValue";
            this.NumberOfGuestsValue.Size = new System.Drawing.Size(43, 20);
            this.NumberOfGuestsValue.TabIndex = 4;
            this.NumberOfGuestsValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumGuests
            // 
            this.lblNumGuests.AutoSize = true;
            this.lblNumGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuests.Location = new System.Drawing.Point(3, 180);
            this.lblNumGuests.Name = "lblNumGuests";
            this.lblNumGuests.Size = new System.Drawing.Size(139, 17);
            this.lblNumGuests.TabIndex = 5;
            this.lblNumGuests.Text = "Number of Guests";
            // 
            // QualityOfService
            // 
            this.QualityOfService.BackColor = System.Drawing.Color.White;
            this.QualityOfService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QualityOfService.Location = new System.Drawing.Point(3, 118);
            this.QualityOfService.Maximum = 5;
            this.QualityOfService.Minimum = 1;
            this.QualityOfService.Name = "QualityOfService";
            this.QualityOfService.Size = new System.Drawing.Size(189, 45);
            this.QualityOfService.TabIndex = 6;
            this.QualityOfService.Value = 1;
            this.QualityOfService.Scroll += new System.EventHandler(this.QualityOfService_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quality of Service";
            // 
            // BillTotalValue
            // 
            this.BillTotalValue.Location = new System.Drawing.Point(146, 7);
            this.BillTotalValue.Name = "BillTotalValue";
            this.BillTotalValue.Size = new System.Drawing.Size(43, 20);
            this.BillTotalValue.TabIndex = 8;
            this.BillTotalValue.ValueChanged += new System.EventHandler(this.ControlChange);
            // 
            // TaxValue
            // 
            this.TaxValue.Location = new System.Drawing.Point(146, 65);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(43, 20);
            this.TaxValue.TabIndex = 10;
            this.TaxValue.ValueChanged += new System.EventHandler(this.ControlChange);
            // 
            // BillDeductionsValue
            // 
            this.BillDeductionsValue.Location = new System.Drawing.Point(146, 36);
            this.BillDeductionsValue.Name = "BillDeductionsValue";
            this.BillDeductionsValue.Size = new System.Drawing.Size(43, 20);
            this.BillDeductionsValue.TabIndex = 12;
            this.BillDeductionsValue.ValueChanged += new System.EventHandler(this.ControlChange);
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(3, 7);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(72, 17);
            this.lblBillTotal.TabIndex = 9;
            this.lblBillTotal.Text = "Bill Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(3, 65);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 17);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "Tax";
            // 
            // lblBillDeductions
            // 
            this.lblBillDeductions.AutoSize = true;
            this.lblBillDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDeductions.Location = new System.Drawing.Point(3, 36);
            this.lblBillDeductions.Name = "lblBillDeductions";
            this.lblBillDeductions.Size = new System.Drawing.Size(116, 17);
            this.lblBillDeductions.TabIndex = 13;
            this.lblBillDeductions.Text = "Bill Deductions";
            // 
            // lblTotalTip
            // 
            this.lblTotalTip.AutoSize = true;
            this.lblTotalTip.BackColor = System.Drawing.Color.White;
            this.lblTotalTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTip.Location = new System.Drawing.Point(5, 37);
            this.lblTotalTip.Name = "lblTotalTip";
            this.lblTotalTip.Size = new System.Drawing.Size(73, 17);
            this.lblTotalTip.TabIndex = 16;
            this.lblTotalTip.Text = "Total Tip";
            // 
            // lblPerPersonTip
            // 
            this.lblPerPersonTip.AutoSize = true;
            this.lblPerPersonTip.BackColor = System.Drawing.Color.White;
            this.lblPerPersonTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerPersonTip.Location = new System.Drawing.Point(5, 68);
            this.lblPerPersonTip.Name = "lblPerPersonTip";
            this.lblPerPersonTip.Size = new System.Drawing.Size(117, 17);
            this.lblPerPersonTip.TabIndex = 15;
            this.lblPerPersonTip.Text = "Per Person Tip";
            // 
            // lblTipRate
            // 
            this.lblTipRate.AutoSize = true;
            this.lblTipRate.BackColor = System.Drawing.Color.White;
            this.lblTipRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipRate.Location = new System.Drawing.Point(5, 9);
            this.lblTipRate.Name = "lblTipRate";
            this.lblTipRate.Size = new System.Drawing.Size(70, 17);
            this.lblTipRate.TabIndex = 14;
            this.lblTipRate.Text = "Tip Rate";
            // 
            // lblTotalBillAndTip
            // 
            this.lblTotalBillAndTip.AutoSize = true;
            this.lblTotalBillAndTip.BackColor = System.Drawing.Color.White;
            this.lblTotalBillAndTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBillAndTip.Location = new System.Drawing.Point(5, 97);
            this.lblTotalBillAndTip.Name = "lblTotalBillAndTip";
            this.lblTotalBillAndTip.Size = new System.Drawing.Size(144, 17);
            this.lblTotalBillAndTip.TabIndex = 17;
            this.lblTotalBillAndTip.Text = "Total (Bill and Tip)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.QualityBarValue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.QualityOfService);
            this.panel3.Controls.Add(this.lblBillTotal);
            this.panel3.Controls.Add(this.BillTotalValue);
            this.panel3.Controls.Add(this.lblNumGuests);
            this.panel3.Controls.Add(this.NumberOfGuestsValue);
            this.panel3.Controls.Add(this.lblBillDeductions);
            this.panel3.Controls.Add(this.TaxValue);
            this.panel3.Controls.Add(this.BillDeductionsValue);
            this.panel3.Controls.Add(this.lblTax);
            this.panel3.Location = new System.Drawing.Point(42, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 215);
            this.panel3.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(130, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "$";
            // 
            // QualityBarValue
            // 
            this.QualityBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityBarValue.Location = new System.Drawing.Point(86, 143);
            this.QualityBarValue.Name = "QualityBarValue";
            this.QualityBarValue.Size = new System.Drawing.Size(24, 21);
            this.QualityBarValue.TabIndex = 14;
            this.QualityBarValue.Text = "1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.TotalBillAndTipValue);
            this.panel4.Controls.Add(this.PerPersonTipValue);
            this.panel4.Controls.Add(this.TotalTipValue);
            this.panel4.Controls.Add(this.TipRateValue);
            this.panel4.Controls.Add(this.lblTotalBillAndTip);
            this.panel4.Controls.Add(this.lblTotalTip);
            this.panel4.Controls.Add(this.lblTipRate);
            this.panel4.Controls.Add(this.lblPerPersonTip);
            this.panel4.Location = new System.Drawing.Point(12, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 134);
            this.panel4.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(218, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(160, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(160, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "$";
            // 
            // TotalBillAndTipValue
            // 
            this.TotalBillAndTipValue.AutoSize = true;
            this.TotalBillAndTipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillAndTipValue.Location = new System.Drawing.Point(177, 101);
            this.TotalBillAndTipValue.Name = "TotalBillAndTipValue";
            this.TotalBillAndTipValue.Size = new System.Drawing.Size(36, 16);
            this.TotalBillAndTipValue.TabIndex = 21;
            this.TotalBillAndTipValue.Text = "0.56";
            this.TotalBillAndTipValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PerPersonTipValue
            // 
            this.PerPersonTipValue.AutoSize = true;
            this.PerPersonTipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerPersonTipValue.Location = new System.Drawing.Point(177, 72);
            this.PerPersonTipValue.Name = "PerPersonTipValue";
            this.PerPersonTipValue.Size = new System.Drawing.Size(36, 16);
            this.PerPersonTipValue.TabIndex = 20;
            this.PerPersonTipValue.Text = "1.00";
            this.PerPersonTipValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTipValue
            // 
            this.TotalTipValue.AutoSize = true;
            this.TotalTipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTipValue.Location = new System.Drawing.Point(177, 41);
            this.TotalTipValue.Name = "TotalTipValue";
            this.TotalTipValue.Size = new System.Drawing.Size(52, 16);
            this.TotalTipValue.TabIndex = 19;
            this.TotalTipValue.Text = "120.00";
            this.TotalTipValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipRateValue
            // 
            this.TipRateValue.AutoSize = true;
            this.TipRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipRateValue.Location = new System.Drawing.Point(177, 13);
            this.TipRateValue.Name = "TipRateValue";
            this.TipRateValue.Size = new System.Drawing.Size(36, 16);
            this.TipRateValue.TabIndex = 18;
            this.TipRateValue.Text = "0.40";
            this.TipRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bill_Entry_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bill_Entry_Screen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.BillEntryScreen_Activated);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfGuestsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityOfService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDeductionsValue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfigureTipButton;
        private System.Windows.Forms.Button TipTailorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfGuestsValue;
        private System.Windows.Forms.Label lblNumGuests;
        private System.Windows.Forms.TrackBar QualityOfService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BillTotalValue;
        private System.Windows.Forms.NumericUpDown TaxValue;
        private System.Windows.Forms.NumericUpDown BillDeductionsValue;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblBillDeductions;
        private System.Windows.Forms.Label lblTotalTip;
        private System.Windows.Forms.Label lblPerPersonTip;
        private System.Windows.Forms.Label lblTipRate;
        private System.Windows.Forms.Label lblTotalBillAndTip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox QualityBarValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalBillAndTipValue;
        private System.Windows.Forms.Label PerPersonTipValue;
        private System.Windows.Forms.Label TotalTipValue;
        private System.Windows.Forms.Label TipRateValue;
    }
}