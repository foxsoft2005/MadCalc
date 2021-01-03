namespace MadCalc
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.comboboxPreset = new System.Windows.Forms.ComboBox();
            this.lbPreset = new System.Windows.Forms.Label();
            this.lbExpression = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExprHelp = new System.Windows.Forms.Button();
            this.lbErrors = new System.Windows.Forms.Label();
            this.richboxErrors = new System.Windows.Forms.RichTextBox();
            this.btnPresetSetup = new System.Windows.Forms.Button();
            this.richboxResult = new System.Windows.Forms.RichTextBox();
            this.richboxExpr = new System.Windows.Forms.RichTextBox();
            this.btnExprAbout = new System.Windows.Forms.Button();
            this.gboxExprParam = new System.Windows.Forms.GroupBox();
            this.gboxExpr = new System.Windows.Forms.GroupBox();
            this.lbAllowed = new System.Windows.Forms.Label();
            this.lnkHistory = new System.Windows.Forms.LinkLabel();
            this.gboxExprParam.SuspendLayout();
            this.gboxExpr.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboboxPreset
            // 
            this.comboboxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPreset.FormattingEnabled = true;
            this.comboboxPreset.Location = new System.Drawing.Point(101, 12);
            this.comboboxPreset.Name = "comboboxPreset";
            this.comboboxPreset.Size = new System.Drawing.Size(177, 21);
            this.comboboxPreset.TabIndex = 0;
            this.comboboxPreset.SelectedIndexChanged += new System.EventHandler(this.comboboxPreset_SelectedIndexChanged);
            // 
            // lbPreset
            // 
            this.lbPreset.AutoSize = true;
            this.lbPreset.Location = new System.Drawing.Point(10, 15);
            this.lbPreset.Name = "lbPreset";
            this.lbPreset.Size = new System.Drawing.Size(84, 13);
            this.lbPreset.TabIndex = 1;
            this.lbPreset.Text = "MadCalc Plugin:";
            // 
            // lbExpression
            // 
            this.lbExpression.AutoSize = true;
            this.lbExpression.Location = new System.Drawing.Point(4, 16);
            this.lbExpression.Name = "lbExpression";
            this.lbExpression.Size = new System.Drawing.Size(81, 13);
            this.lbExpression.TabIndex = 2;
            this.lbExpression.Text = "Expression text:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(4, 101);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(66, 13);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "Result(s) list:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(91, 383);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExprHelp
            // 
            this.btnExprHelp.Location = new System.Drawing.Point(95, 18);
            this.btnExprHelp.Name = "btnExprHelp";
            this.btnExprHelp.Size = new System.Drawing.Size(75, 23);
            this.btnExprHelp.TabIndex = 8;
            this.btnExprHelp.Text = "Help";
            this.btnExprHelp.UseVisualStyleBackColor = true;
            this.btnExprHelp.Click += new System.EventHandler(this.btnExprHelp_Click);
            // 
            // lbErrors
            // 
            this.lbErrors.AutoSize = true;
            this.lbErrors.Location = new System.Drawing.Point(4, 186);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(58, 13);
            this.lbErrors.TabIndex = 9;
            this.lbErrors.Text = "Error(s) list:";
            // 
            // richboxErrors
            // 
            this.richboxErrors.Location = new System.Drawing.Point(7, 202);
            this.richboxErrors.Name = "richboxErrors";
            this.richboxErrors.ReadOnly = true;
            this.richboxErrors.Size = new System.Drawing.Size(250, 66);
            this.richboxErrors.TabIndex = 10;
            this.richboxErrors.Text = "";
            this.richboxErrors.WordWrap = false;
            // 
            // btnPresetSetup
            // 
            this.btnPresetSetup.Location = new System.Drawing.Point(14, 18);
            this.btnPresetSetup.Name = "btnPresetSetup";
            this.btnPresetSetup.Size = new System.Drawing.Size(75, 23);
            this.btnPresetSetup.TabIndex = 11;
            this.btnPresetSetup.Text = "Settings";
            this.btnPresetSetup.UseVisualStyleBackColor = true;
            this.btnPresetSetup.Click += new System.EventHandler(this.btnPresetSetup_Click);
            // 
            // richboxResult
            // 
            this.richboxResult.Location = new System.Drawing.Point(7, 117);
            this.richboxResult.Name = "richboxResult";
            this.richboxResult.ReadOnly = true;
            this.richboxResult.Size = new System.Drawing.Size(250, 66);
            this.richboxResult.TabIndex = 12;
            this.richboxResult.Text = "";
            this.richboxResult.WordWrap = false;
            // 
            // richboxExpr
            // 
            this.richboxExpr.Location = new System.Drawing.Point(7, 32);
            this.richboxExpr.Name = "richboxExpr";
            this.richboxExpr.Size = new System.Drawing.Size(250, 66);
            this.richboxExpr.TabIndex = 13;
            this.richboxExpr.Text = "";
            this.richboxExpr.WordWrap = false;
            this.richboxExpr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richboxExpr_KeyDown);
            // 
            // btnExprAbout
            // 
            this.btnExprAbout.Location = new System.Drawing.Point(176, 18);
            this.btnExprAbout.Name = "btnExprAbout";
            this.btnExprAbout.Size = new System.Drawing.Size(75, 23);
            this.btnExprAbout.TabIndex = 14;
            this.btnExprAbout.Text = "About";
            this.btnExprAbout.UseVisualStyleBackColor = true;
            this.btnExprAbout.Click += new System.EventHandler(this.btnExprAbout_Click);
            // 
            // gboxExprParam
            // 
            this.gboxExprParam.Controls.Add(this.btnPresetSetup);
            this.gboxExprParam.Controls.Add(this.btnExprAbout);
            this.gboxExprParam.Controls.Add(this.btnExprHelp);
            this.gboxExprParam.Location = new System.Drawing.Point(12, 39);
            this.gboxExprParam.Name = "gboxExprParam";
            this.gboxExprParam.Size = new System.Drawing.Size(265, 53);
            this.gboxExprParam.TabIndex = 15;
            this.gboxExprParam.TabStop = false;
            this.gboxExprParam.Text = "Plugin box";
            // 
            // gboxExpr
            // 
            this.gboxExpr.Controls.Add(this.lbAllowed);
            this.gboxExpr.Controls.Add(this.lnkHistory);
            this.gboxExpr.Controls.Add(this.lbExpression);
            this.gboxExpr.Controls.Add(this.richboxExpr);
            this.gboxExpr.Controls.Add(this.richboxErrors);
            this.gboxExpr.Controls.Add(this.richboxResult);
            this.gboxExpr.Controls.Add(this.lbErrors);
            this.gboxExpr.Controls.Add(this.lbResult);
            this.gboxExpr.Location = new System.Drawing.Point(13, 98);
            this.gboxExpr.Name = "gboxExpr";
            this.gboxExpr.Size = new System.Drawing.Size(265, 279);
            this.gboxExpr.TabIndex = 16;
            this.gboxExpr.TabStop = false;
            this.gboxExpr.Text = "Expression box";
            // 
            // lbAllowed
            // 
            this.lbAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllowed.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbAllowed.Location = new System.Drawing.Point(131, 16);
            this.lbAllowed.Name = "lbAllowed";
            this.lbAllowed.Size = new System.Drawing.Size(128, 13);
            this.lbAllowed.TabIndex = 15;
            this.lbAllowed.Text = "Empty expression allowed";
            this.lbAllowed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lnkHistory
            // 
            this.lnkHistory.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkHistory.AutoSize = true;
            this.lnkHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkHistory.Location = new System.Drawing.Point(182, 101);
            this.lnkHistory.Name = "lnkHistory";
            this.lnkHistory.Size = new System.Drawing.Size(75, 13);
            this.lnkHistory.TabIndex = 14;
            this.lnkHistory.TabStop = true;
            this.lnkHistory.Text = "Results history";
            this.lnkHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHistory_LinkClicked);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 413);
            this.Controls.Add(this.gboxExpr);
            this.Controls.Add(this.gboxExprParam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbPreset);
            this.Controls.Add(this.comboboxPreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.gboxExprParam.ResumeLayout(false);
            this.gboxExpr.ResumeLayout(false);
            this.gboxExpr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxPreset;
        private System.Windows.Forms.Label lbPreset;
        private System.Windows.Forms.Label lbExpression;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExprHelp;
        private System.Windows.Forms.Label lbErrors;
        private System.Windows.Forms.RichTextBox richboxErrors;
        private System.Windows.Forms.Button btnPresetSetup;
        private System.Windows.Forms.RichTextBox richboxResult;
        private System.Windows.Forms.RichTextBox richboxExpr;
        private System.Windows.Forms.Button btnExprAbout;
        private System.Windows.Forms.GroupBox gboxExprParam;
        private System.Windows.Forms.GroupBox gboxExpr;
        private System.Windows.Forms.LinkLabel lnkHistory;
        private System.Windows.Forms.Label lbAllowed;
    }
}

