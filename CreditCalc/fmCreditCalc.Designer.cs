namespace CreditCalc
{
    partial class fmCreditCalc
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numudPeriod = new System.Windows.Forms.NumericUpDown();
            this.madCreditConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbPeriod = new System.Windows.Forms.Label();
            this.tboxCreditRate = new System.Windows.Forms.TextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.tboxCreditAmt = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.cboxMode = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madCreditConfigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(131, 133);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numudPeriod);
            this.panel1.Controls.Add(this.lbPeriod);
            this.panel1.Controls.Add(this.tboxCreditRate);
            this.panel1.Controls.Add(this.lbRate);
            this.panel1.Controls.Add(this.tboxCreditAmt);
            this.panel1.Controls.Add(this.lbAmount);
            this.panel1.Controls.Add(this.cboxMode);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 121);
            this.panel1.TabIndex = 2;
            // 
            // numudPeriod
            // 
            this.numudPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.madCreditConfigBindingSource, "Period", true));
            this.numudPeriod.Location = new System.Drawing.Point(231, 88);
            this.numudPeriod.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numudPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudPeriod.Name = "numudPeriod";
            this.numudPeriod.Size = new System.Drawing.Size(43, 20);
            this.numudPeriod.TabIndex = 7;
            this.numudPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numudPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // madCreditConfigBindingSource
            // 
            this.madCreditConfigBindingSource.DataSource = typeof(CreditCalc.MadCreditConfig);
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(6, 90);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(113, 13);
            this.lbPeriod.TabIndex = 6;
            this.lbPeriod.Text = "Credit Period (months):";
            // 
            // tboxCreditRate
            // 
            this.tboxCreditRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.madCreditConfigBindingSource, "Percent", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tboxCreditRate.Location = new System.Drawing.Point(188, 62);
            this.tboxCreditRate.Name = "tboxCreditRate";
            this.tboxCreditRate.Size = new System.Drawing.Size(86, 20);
            this.tboxCreditRate.TabIndex = 5;
            this.tboxCreditRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(6, 65);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(90, 13);
            this.lbRate.TabIndex = 4;
            this.lbRate.Text = "Percent Rate (%):";
            // 
            // tboxCreditAmt
            // 
            this.tboxCreditAmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.madCreditConfigBindingSource, "CreditAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tboxCreditAmt.Location = new System.Drawing.Point(188, 36);
            this.tboxCreditAmt.Name = "tboxCreditAmt";
            this.tboxCreditAmt.Size = new System.Drawing.Size(86, 20);
            this.tboxCreditAmt.TabIndex = 3;
            this.tboxCreditAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(6, 39);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(76, 13);
            this.lbAmount.TabIndex = 2;
            this.lbAmount.Text = "Credit Amount:";
            // 
            // cboxMode
            // 
            this.cboxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMode.FormattingEnabled = true;
            this.cboxMode.Items.AddRange(new object[] {
            "<Select...>",
            "Annual payment",
            "Differentiated payment"});
            this.cboxMode.Location = new System.Drawing.Point(149, 9);
            this.cboxMode.Name = "cboxMode";
            this.cboxMode.Size = new System.Drawing.Size(125, 21);
            this.cboxMode.TabIndex = 1;
            this.cboxMode.SelectedIndexChanged += new System.EventHandler(this.cboxMode_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(6, 12);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(84, 13);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Calculator Type:";
            // 
            // fmCreditCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmCreditCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreditCalc Settings";
            this.Load += new System.EventHandler(this.fmCreditCalc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madCreditConfigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxMode;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.BindingSource madCreditConfigBindingSource;
        private System.Windows.Forms.NumericUpDown numudPeriod;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.TextBox tboxCreditRate;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.TextBox tboxCreditAmt;
    }
}