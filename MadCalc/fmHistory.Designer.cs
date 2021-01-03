namespace MadCalc
{
    partial class fmHistory
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
            this.richHistory = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richHistory
            // 
            this.richHistory.Location = new System.Drawing.Point(5, 6);
            this.richHistory.Name = "richHistory";
            this.richHistory.ReadOnly = true;
            this.richHistory.Size = new System.Drawing.Size(295, 155);
            this.richHistory.TabIndex = 0;
            this.richHistory.Text = "";
            this.richHistory.WordWrap = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(225, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // fmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 195);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results history";
            this.Load += new System.EventHandler(this.fmHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richHistory;
        private System.Windows.Forms.Button btnClose;
    }
}