using System;
namespace TipCalculator
{
    partial class ConfigurationScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MinTipPerc = new System.Windows.Forms.NumericUpDown();
            this.MaxTipPerc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TaxFalse = new System.Windows.Forms.RadioButton();
            this.TaxTrue = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DeductionFalse = new System.Windows.Forms.RadioButton();
            this.DeductionTrue = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTipPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTipPerc)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 123);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "The tip range is the percentage \r\nrange for selecting tips. \r\nDefault values are " +
    "provided but you \r\ncan adjust the range if you wish.";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.Header.Controls.Add(this.button1);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(286, 65);
            this.Header.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "<- RETURN";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackToBillEntry_Click);
            // 
            // MinTipPerc
            // 
            this.MinTipPerc.DecimalPlaces = 2;
            this.MinTipPerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MinTipPerc.Location = new System.Drawing.Point(206, 200);
            this.MinTipPerc.Name = "MinTipPerc";
            this.MinTipPerc.Size = new System.Drawing.Size(66, 20);
            this.MinTipPerc.TabIndex = 2;
            this.MinTipPerc.ValueChanged += new System.EventHandler(this.SetMinMax);
            // 
            // MaxTipPerc
            // 
            this.MaxTipPerc.DecimalPlaces = 2;
            this.MaxTipPerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MaxTipPerc.Location = new System.Drawing.Point(206, 226);
            this.MaxTipPerc.Name = "MaxTipPerc";
            this.MaxTipPerc.Size = new System.Drawing.Size(66, 20);
            this.MaxTipPerc.TabIndex = 3;
            this.MaxTipPerc.ValueChanged += new System.EventHandler(this.SetMinMax);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimum Tip Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximum Tip Percentage";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(13, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 123);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 85);
            this.label5.TabIndex = 0;
            this.label5.Text = "The Tip Base is the items of the bill \r\nused to determine the Tip amount. \r\nThe t" +
    "ip base consists of: Bill \r\ntotal, the tax, the items deducted \r\nfrom the bill (" +
    "discounts, refunds, ...) ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TaxFalse);
            this.panel5.Controls.Add(this.TaxTrue);
            this.panel5.Location = new System.Drawing.Point(160, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 30);
            this.panel5.TabIndex = 6;
            // 
            // TaxFalse
            // 
            this.TaxFalse.AutoSize = true;
            this.TaxFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxFalse.Location = new System.Drawing.Point(56, 7);
            this.TaxFalse.Name = "TaxFalse";
            this.TaxFalse.Size = new System.Drawing.Size(48, 17);
            this.TaxFalse.TabIndex = 1;
            this.TaxFalse.TabStop = true;
            this.TaxFalse.Text = "OFF";
            this.TaxFalse.UseVisualStyleBackColor = true;
            this.TaxFalse.CheckedChanged += new System.EventHandler(this.SetTaxDeductions);
            // 
            // TaxTrue
            // 
            this.TaxTrue.AutoSize = true;
            this.TaxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTrue.Location = new System.Drawing.Point(9, 7);
            this.TaxTrue.Name = "TaxTrue";
            this.TaxTrue.Size = new System.Drawing.Size(43, 17);
            this.TaxTrue.TabIndex = 0;
            this.TaxTrue.TabStop = true;
            this.TaxTrue.Text = "ON";
            this.TaxTrue.UseVisualStyleBackColor = true;
            this.TaxTrue.CheckedChanged += new System.EventHandler(this.SetTaxDeductions);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DeductionFalse);
            this.panel6.Controls.Add(this.DeductionTrue);
            this.panel6.Location = new System.Drawing.Point(160, 421);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 30);
            this.panel6.TabIndex = 7;
            // 
            // DeductionFalse
            // 
            this.DeductionFalse.AutoSize = true;
            this.DeductionFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionFalse.Location = new System.Drawing.Point(56, 7);
            this.DeductionFalse.Name = "DeductionFalse";
            this.DeductionFalse.Size = new System.Drawing.Size(48, 17);
            this.DeductionFalse.TabIndex = 2;
            this.DeductionFalse.TabStop = true;
            this.DeductionFalse.Text = "OFF";
            this.DeductionFalse.UseVisualStyleBackColor = true;
            this.DeductionFalse.CheckedChanged += new System.EventHandler(this.SetTaxDeductions);
            // 
            // DeductionTrue
            // 
            this.DeductionTrue.AutoSize = true;
            this.DeductionTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionTrue.Location = new System.Drawing.Point(9, 7);
            this.DeductionTrue.Name = "DeductionTrue";
            this.DeductionTrue.Size = new System.Drawing.Size(43, 17);
            this.DeductionTrue.TabIndex = 3;
            this.DeductionTrue.TabStop = true;
            this.DeductionTrue.Text = "ON";
            this.DeductionTrue.UseVisualStyleBackColor = true;
            this.DeductionTrue.CheckedChanged += new System.EventHandler(this.SetTaxDeductions);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Include Deductions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Include Tax";
            // 
            // ConfigurationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxTipPerc);
            this.Controls.Add(this.MinTipPerc);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.ConfigurationScreen_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinTipPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTipPerc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.NumericUpDown MinTipPerc;
        private System.Windows.Forms.NumericUpDown MaxTipPerc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton TaxTrue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton TaxFalse;
        private System.Windows.Forms.RadioButton DeductionFalse;
        private System.Windows.Forms.RadioButton DeductionTrue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

