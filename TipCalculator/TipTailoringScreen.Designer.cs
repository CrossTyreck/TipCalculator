namespace TipCalculator
{
    partial class TipTailoringScreen
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
            this.TipperName = new System.Windows.Forms.TextBox();
            this.TipperDollar = new System.Windows.Forms.Label();
            this.TipperTipValue = new System.Windows.Forms.Label();
            this.TipperAmount = new System.Windows.Forms.TrackBar();
            this.TipperPanel = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TipperAmount)).BeginInit();
            this.TipperPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipperName
            // 
            this.TipperName.Location = new System.Drawing.Point(3, 21);
            this.TipperName.Name = "TipperName";
            this.TipperName.Size = new System.Drawing.Size(100, 20);
            this.TipperName.TabIndex = 3;
            this.TipperName.Text = "You";
            // 
            // TipperDollar
            // 
            this.TipperDollar.AutoSize = true;
            this.TipperDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.TipperDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipperDollar.Location = new System.Drawing.Point(215, 21);
            this.TipperDollar.Name = "TipperDollar";
            this.TipperDollar.Size = new System.Drawing.Size(16, 16);
            this.TipperDollar.TabIndex = 20;
            this.TipperDollar.Text = "$";
            // 
            // TipperTipValue
            // 
            this.TipperTipValue.AutoSize = true;
            this.TipperTipValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.TipperTipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipperTipValue.Location = new System.Drawing.Point(229, 22);
            this.TipperTipValue.Name = "TipperTipValue";
            this.TipperTipValue.Size = new System.Drawing.Size(16, 16);
            this.TipperTipValue.TabIndex = 21;
            this.TipperTipValue.Text = "0";
            this.TipperTipValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipperAmount
            // 
            this.TipperAmount.BackColor = System.Drawing.Color.White;
            this.TipperAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipperAmount.Location = new System.Drawing.Point(107, 10);
            this.TipperAmount.Name = "TipperAmount";
            this.TipperAmount.Size = new System.Drawing.Size(104, 45);
            this.TipperAmount.TabIndex = 4;
            this.TipperAmount.Scroll += new System.EventHandler(this.TipperAmount_Scroll);
            // 
            // TipperPanel
            // 
            this.TipperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.TipperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipperPanel.Controls.Add(this.TipperName);
            this.TipperPanel.Controls.Add(this.TipperDollar);
            this.TipperPanel.Controls.Add(this.TipperAmount);
            this.TipperPanel.Controls.Add(this.TipperTipValue);
            this.TipperPanel.Location = new System.Drawing.Point(-1, 69);
            this.TipperPanel.Name = "TipperPanel";
            this.TipperPanel.Size = new System.Drawing.Size(300, 65);
            this.TipperPanel.TabIndex = 22;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.Header.Controls.Add(this.button1);
            this.Header.Location = new System.Drawing.Point(-1, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(286, 65);
            this.Header.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "<- RETURN";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackToBillEntryScreen_Click);
            // 
            // TipTailoringScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TipperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TipTailoringScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipTailoringScreen";
            this.Activated += new System.EventHandler(this.TipTailoringScreen_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.TipperAmount)).EndInit();
            this.TipperPanel.ResumeLayout(false);
            this.TipperPanel.PerformLayout();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TipperName;
        private System.Windows.Forms.TrackBar TipperAmount;
        private System.Windows.Forms.Label TipperDollar;
        private System.Windows.Forms.Label TipperTipValue;
        private System.Windows.Forms.Panel TipperPanel;
    }
}