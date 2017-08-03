namespace BankingApplication
{
    partial class Form1
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
            this.subtittleLabel = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.amountTbox = new System.Windows.Forms.TextBox();
            this.accountIdLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.depositRbutton = new System.Windows.Forms.RadioButton();
            this.withdrawRbutton = new System.Windows.Forms.RadioButton();
            this.balanceRbutton = new System.Windows.Forms.RadioButton();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.checkingRButton = new System.Windows.Forms.RadioButton();
            this.savingsRButton = new System.Windows.Forms.RadioButton();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.seniorCheckBox = new System.Windows.Forms.CheckBox();
            this.endOfMonthButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(105, 24);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(199, 29);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "ITSE 2453 Bank";
            // 
            // subtittleLabel
            // 
            this.subtittleLabel.AutoSize = true;
            this.subtittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtittleLabel.Location = new System.Drawing.Point(145, 60);
            this.subtittleLabel.Name = "subtittleLabel";
            this.subtittleLabel.Size = new System.Drawing.Size(106, 24);
            this.subtittleLabel.TabIndex = 1;
            this.subtittleLabel.Text = "Dallas, TX";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(55, 97);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(100, 20);
            this.idTbox.TabIndex = 2;
            // 
            // amountTbox
            // 
            this.amountTbox.Location = new System.Drawing.Point(238, 97);
            this.amountTbox.Name = "amountTbox";
            this.amountTbox.Size = new System.Drawing.Size(107, 20);
            this.amountTbox.TabIndex = 3;
            // 
            // accountIdLabel
            // 
            this.accountIdLabel.AutoSize = true;
            this.accountIdLabel.Location = new System.Drawing.Point(57, 131);
            this.accountIdLabel.Name = "accountIdLabel";
            this.accountIdLabel.Size = new System.Drawing.Size(61, 13);
            this.accountIdLabel.TabIndex = 4;
            this.accountIdLabel.Text = "Account ID";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(235, 131);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount";
            // 
            // depositRbutton
            // 
            this.depositRbutton.AutoSize = true;
            this.depositRbutton.Location = new System.Drawing.Point(238, 159);
            this.depositRbutton.Name = "depositRbutton";
            this.depositRbutton.Size = new System.Drawing.Size(61, 17);
            this.depositRbutton.TabIndex = 6;
            this.depositRbutton.TabStop = true;
            this.depositRbutton.Text = "Deposit";
            this.depositRbutton.UseVisualStyleBackColor = true;
            // 
            // withdrawRbutton
            // 
            this.withdrawRbutton.AutoSize = true;
            this.withdrawRbutton.Location = new System.Drawing.Point(238, 195);
            this.withdrawRbutton.Name = "withdrawRbutton";
            this.withdrawRbutton.Size = new System.Drawing.Size(70, 17);
            this.withdrawRbutton.TabIndex = 7;
            this.withdrawRbutton.TabStop = true;
            this.withdrawRbutton.Text = "Withdraw";
            this.withdrawRbutton.UseVisualStyleBackColor = true;
            // 
            // balanceRbutton
            // 
            this.balanceRbutton.AutoSize = true;
            this.balanceRbutton.Location = new System.Drawing.Point(238, 230);
            this.balanceRbutton.Name = "balanceRbutton";
            this.balanceRbutton.Size = new System.Drawing.Size(64, 17);
            this.balanceRbutton.TabIndex = 8;
            this.balanceRbutton.TabStop = true;
            this.balanceRbutton.Text = "Balance";
            this.balanceRbutton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(60, 286);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(113, 23);
            this.createAccountButton.TabIndex = 9;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(229, 286);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.outputLabel.Location = new System.Drawing.Point(22, 382);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 11;
            // 
            // checkingRButton
            // 
            this.checkingRButton.AutoSize = true;
            this.checkingRButton.Location = new System.Drawing.Point(55, 159);
            this.checkingRButton.Name = "checkingRButton";
            this.checkingRButton.Size = new System.Drawing.Size(70, 17);
            this.checkingRButton.TabIndex = 12;
            this.checkingRButton.TabStop = true;
            this.checkingRButton.Text = "Checking";
            this.checkingRButton.UseVisualStyleBackColor = true;
            // 
            // savingsRButton
            // 
            this.savingsRButton.AutoSize = true;
            this.savingsRButton.Location = new System.Drawing.Point(55, 195);
            this.savingsRButton.Name = "savingsRButton";
            this.savingsRButton.Size = new System.Drawing.Size(63, 17);
            this.savingsRButton.TabIndex = 13;
            this.savingsRButton.TabStop = true;
            this.savingsRButton.Text = "Savings";
            this.savingsRButton.UseVisualStyleBackColor = true;
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(55, 230);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Size = new System.Drawing.Size(101, 17);
            this.studentCheckBox.TabIndex = 14;
            this.studentCheckBox.Text = "College Student";
            this.studentCheckBox.UseVisualStyleBackColor = true;
            // 
            // seniorCheckBox
            // 
            this.seniorCheckBox.AutoSize = true;
            this.seniorCheckBox.Location = new System.Drawing.Point(55, 259);
            this.seniorCheckBox.Name = "seniorCheckBox";
            this.seniorCheckBox.Size = new System.Drawing.Size(90, 17);
            this.seniorCheckBox.TabIndex = 15;
            this.seniorCheckBox.Text = "Senior Citizen";
            this.seniorCheckBox.UseVisualStyleBackColor = true;
            // 
            // endOfMonthButton
            // 
            this.endOfMonthButton.Location = new System.Drawing.Point(60, 328);
            this.endOfMonthButton.Name = "endOfMonthButton";
            this.endOfMonthButton.Size = new System.Drawing.Size(113, 23);
            this.endOfMonthButton.TabIndex = 16;
            this.endOfMonthButton.Text = "End of Month";
            this.endOfMonthButton.UseVisualStyleBackColor = true;
            this.endOfMonthButton.Click += new System.EventHandler(this.endOfMonthButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(229, 328);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 17;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.endOfMonthButton);
            this.Controls.Add(this.seniorCheckBox);
            this.Controls.Add(this.studentCheckBox);
            this.Controls.Add(this.savingsRButton);
            this.Controls.Add(this.checkingRButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.balanceRbutton);
            this.Controls.Add(this.withdrawRbutton);
            this.Controls.Add(this.depositRbutton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.accountIdLabel);
            this.Controls.Add(this.amountTbox);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.subtittleLabel);
            this.Controls.Add(this.tittleLabel);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.Label subtittleLabel;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.TextBox amountTbox;
        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.RadioButton depositRbutton;
        private System.Windows.Forms.RadioButton withdrawRbutton;
        private System.Windows.Forms.RadioButton balanceRbutton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RadioButton checkingRButton;
        private System.Windows.Forms.RadioButton savingsRButton;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.CheckBox seniorCheckBox;
        private System.Windows.Forms.Button endOfMonthButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label label1;
    }
}

