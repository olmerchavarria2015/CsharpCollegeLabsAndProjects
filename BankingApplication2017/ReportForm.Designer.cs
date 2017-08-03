namespace BankingApplication
{
    partial class ReportForm
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
            this.tittleLabel = new System.Windows.Forms.Label();
            this.reportOuputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(31, 13);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(144, 20);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Accounts Report";
            // 
            // reportOuputLabel
            // 
            this.reportOuputLabel.AutoSize = true;
            this.reportOuputLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.reportOuputLabel.Location = new System.Drawing.Point(35, 48);
            this.reportOuputLabel.Name = "reportOuputLabel";
            this.reportOuputLabel.Size = new System.Drawing.Size(0, 13);
            this.reportOuputLabel.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 522);
            this.Controls.Add(this.reportOuputLabel);
            this.Controls.Add(this.tittleLabel);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.Label reportOuputLabel;
    }
}