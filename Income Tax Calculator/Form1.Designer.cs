namespace Income_Tax
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIncomeTBox = new System.Windows.Forms.TextBox();
            this.dependentsTBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goiOutputLabel = new System.Windows.Forms.Label();
            this.incomeTaxOutputLabel = new System.Windows.Forms.Label();
            this.maritalStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.marrieLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Dependents";
            // 
            // totalIncomeTBox
            // 
            this.totalIncomeTBox.Location = new System.Drawing.Point(239, 80);
            this.totalIncomeTBox.Name = "totalIncomeTBox";
            this.totalIncomeTBox.Size = new System.Drawing.Size(100, 20);
            this.totalIncomeTBox.TabIndex = 3;
            // 
            // dependentsTBox
            // 
            this.dependentsTBox.Location = new System.Drawing.Point(239, 122);
            this.dependentsTBox.Name = "dependentsTBox";
            this.dependentsTBox.Size = new System.Drawing.Size(60, 20);
            this.dependentsTBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gross Adjusted Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Income Tax";
            // 
            // goiOutputLabel
            // 
            this.goiOutputLabel.AutoSize = true;
            this.goiOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goiOutputLabel.Location = new System.Drawing.Point(236, 212);
            this.goiOutputLabel.Name = "goiOutputLabel";
            this.goiOutputLabel.Size = new System.Drawing.Size(47, 15);
            this.goiOutputLabel.TabIndex = 8;
            this.goiOutputLabel.Text = "label6";
            // 
            // incomeTaxOutputLabel
            // 
            this.incomeTaxOutputLabel.AutoSize = true;
            this.incomeTaxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTaxOutputLabel.Location = new System.Drawing.Point(236, 261);
            this.incomeTaxOutputLabel.Name = "incomeTaxOutputLabel";
            this.incomeTaxOutputLabel.Size = new System.Drawing.Size(47, 15);
            this.incomeTaxOutputLabel.TabIndex = 9;
            this.incomeTaxOutputLabel.Text = "label7";
            // 
            // maritalStatusCheckBox
            // 
            this.maritalStatusCheckBox.AutoSize = true;
            this.maritalStatusCheckBox.Location = new System.Drawing.Point(28, 43);
            this.maritalStatusCheckBox.Name = "maritalStatusCheckBox";
            this.maritalStatusCheckBox.Size = new System.Drawing.Size(102, 17);
            this.maritalStatusCheckBox.TabIndex = 10;
            this.maritalStatusCheckBox.Text = "Check if married";
            this.maritalStatusCheckBox.UseVisualStyleBackColor = true;
            this.maritalStatusCheckBox.CheckedChanged += new System.EventHandler(this.maritalStatusCheckBox_CheckedChanged);
            // 
            // marrieLabel
            // 
            this.marrieLabel.AutoSize = true;
            this.marrieLabel.Location = new System.Drawing.Point(221, 64);
            this.marrieLabel.Name = "marrieLabel";
            this.marrieLabel.Size = new System.Drawing.Size(134, 13);
            this.marrieLabel.TabIndex = 11;
            this.marrieLabel.Text = "Enter total couple\'s income";
            this.marrieLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(128, 309);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.marrieLabel);
            this.Controls.Add(this.maritalStatusCheckBox);
            this.Controls.Add(this.incomeTaxOutputLabel);
            this.Controls.Add(this.goiOutputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dependentsTBox);
            this.Controls.Add(this.totalIncomeTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalIncomeTBox;
        private System.Windows.Forms.TextBox dependentsTBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label goiOutputLabel;
        private System.Windows.Forms.Label incomeTaxOutputLabel;
        private System.Windows.Forms.CheckBox maritalStatusCheckBox;
        private System.Windows.Forms.Label marrieLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

