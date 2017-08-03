namespace InterestCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intrCompAnnuallyLabel = new System.Windows.Forms.Label();
            this.intrCompMonthlyLabel = new System.Windows.Forms.Label();
            this.initialBalanceBox = new System.Windows.Forms.TextBox();
            this.annIntrBox = new System.Windows.Forms.TextBox();
            this.numOfYearsBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annual Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest Compounded Annually";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interest Compounded Monthly";
            // 
            // intrCompAnnuallyLabel
            // 
            this.intrCompAnnuallyLabel.AutoSize = true;
            this.intrCompAnnuallyLabel.Location = new System.Drawing.Point(197, 217);
            this.intrCompAnnuallyLabel.Name = "intrCompAnnuallyLabel";
            this.intrCompAnnuallyLabel.Size = new System.Drawing.Size(0, 13);
            this.intrCompAnnuallyLabel.TabIndex = 6;
            // 
            // intrCompMonthlyLabel
            // 
            this.intrCompMonthlyLabel.AutoSize = true;
            this.intrCompMonthlyLabel.Location = new System.Drawing.Point(197, 256);
            this.intrCompMonthlyLabel.Name = "intrCompMonthlyLabel";
            this.intrCompMonthlyLabel.Size = new System.Drawing.Size(0, 13);
            this.intrCompMonthlyLabel.TabIndex = 7;
            // 
            // initialBalanceBox
            // 
            this.initialBalanceBox.Location = new System.Drawing.Point(172, 48);
            this.initialBalanceBox.Name = "initialBalanceBox";
            this.initialBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.initialBalanceBox.TabIndex = 8;
            // 
            // annIntrBox
            // 
            this.annIntrBox.Location = new System.Drawing.Point(172, 93);
            this.annIntrBox.Name = "annIntrBox";
            this.annIntrBox.Size = new System.Drawing.Size(100, 20);
            this.annIntrBox.TabIndex = 9;
            // 
            // numOfYearsBox
            // 
            this.numOfYearsBox.Location = new System.Drawing.Point(172, 143);
            this.numOfYearsBox.Name = "numOfYearsBox";
            this.numOfYearsBox.Size = new System.Drawing.Size(100, 20);
            this.numOfYearsBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(55, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(177, 24);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Interest Calculator";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(73, 283);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 308);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numOfYearsBox);
            this.Controls.Add(this.annIntrBox);
            this.Controls.Add(this.initialBalanceBox);
            this.Controls.Add(this.intrCompMonthlyLabel);
            this.Controls.Add(this.intrCompAnnuallyLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label intrCompAnnuallyLabel;
        private System.Windows.Forms.Label intrCompMonthlyLabel;
        private System.Windows.Forms.TextBox initialBalanceBox;
        private System.Windows.Forms.TextBox annIntrBox;
        private System.Windows.Forms.TextBox numOfYearsBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

