namespace PayrollGUI
{
    partial class Payroll
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.federalLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.gpLabel = new System.Windows.Forms.Label();
            this.fwLabel = new System.Windows.Forms.Label();
            this.swLabel = new System.Windows.Forms.Label();
            this.npLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(131, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Payroll Form";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(226, 95);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.payRateTextBox.TabIndex = 1;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(226, 153);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTextBox.TabIndex = 2;
            // 
            // payRateLabel
            // 
            this.payRateLabel.AutoSize = true;
            this.payRateLabel.Location = new System.Drawing.Point(96, 101);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(51, 13);
            this.payRateLabel.TabIndex = 3;
            this.payRateLabel.Text = "Pay Rate";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(99, 153);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.hoursWorkedLabel.TabIndex = 4;
            this.hoursWorkedLabel.Text = "Hours Worked";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(78, 244);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(55, 13);
            this.grossPayLabel.TabIndex = 5;
            this.grossPayLabel.Text = "Gross Pay";
            // 
            // federalLabel
            // 
            this.federalLabel.AutoSize = true;
            this.federalLabel.Location = new System.Drawing.Point(78, 283);
            this.federalLabel.Name = "federalLabel";
            this.federalLabel.Size = new System.Drawing.Size(101, 13);
            this.federalLabel.TabIndex = 7;
            this.federalLabel.Text = "Federal Withholding";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(78, 322);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(91, 13);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State Withholding";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(156, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 28);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Location = new System.Drawing.Point(78, 365);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(45, 13);
            this.netPayLabel.TabIndex = 10;
            this.netPayLabel.Text = "Net Pay";
            
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.Location = new System.Drawing.Point(290, 243);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(25, 13);
            this.gpLabel.TabIndex = 11;
            this.gpLabel.Text = "------";
            // 
            // fwLabel
            // 
            this.fwLabel.AutoSize = true;
            this.fwLabel.Location = new System.Drawing.Point(289, 283);
            this.fwLabel.Name = "fwLabel";
            this.fwLabel.Size = new System.Drawing.Size(25, 13);
            this.fwLabel.TabIndex = 12;
            this.fwLabel.Text = "------";
            
            // 
            // swLabel
            // 
            this.swLabel.AutoSize = true;
            this.swLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swLabel.Location = new System.Drawing.Point(289, 321);
            this.swLabel.Name = "swLabel";
            this.swLabel.Size = new System.Drawing.Size(25, 13);
            this.swLabel.TabIndex = 13;
            this.swLabel.Text = "------";
            // 
            // npLabel
            // 
            this.npLabel.AutoSize = true;
            this.npLabel.Location = new System.Drawing.Point(290, 365);
            this.npLabel.Name = "npLabel";
            this.npLabel.Size = new System.Drawing.Size(25, 13);
            this.npLabel.TabIndex = 14;
            this.npLabel.Text = "------";
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 444);
            this.Controls.Add(this.npLabel);
            this.Controls.Add(this.swLabel);
            this.Controls.Add(this.fwLabel);
            this.Controls.Add(this.gpLabel);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.federalLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.payRateLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label payRateLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label federalLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.Label gpLabel;
        private System.Windows.Forms.Label fwLabel;
        private System.Windows.Forms.Label swLabel;
        private System.Windows.Forms.Label npLabel;
    }
}

