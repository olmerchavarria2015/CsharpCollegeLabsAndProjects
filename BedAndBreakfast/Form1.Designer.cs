﻿namespace BedAndBreakfast
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
            this.belleAireCheckBox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckBox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Bailey\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check our rates";
            // 
            // belleAireCheckBox
            // 
            this.belleAireCheckBox.AutoSize = true;
            this.belleAireCheckBox.Location = new System.Drawing.Point(84, 118);
            this.belleAireCheckBox.Name = "belleAireCheckBox";
            this.belleAireCheckBox.Size = new System.Drawing.Size(93, 17);
            this.belleAireCheckBox.TabIndex = 2;
            this.belleAireCheckBox.Text = "Belleaire Suite";
            this.belleAireCheckBox.UseVisualStyleBackColor = true;
            this.belleAireCheckBox.CheckedChanged += new System.EventHandler(this.belleAireCheckBox_CheckedChanged);
            // 
            // lincolnCheckBox
            // 
            this.lincolnCheckBox.AutoSize = true;
            this.lincolnCheckBox.Location = new System.Drawing.Point(84, 142);
            this.lincolnCheckBox.Name = "lincolnCheckBox";
            this.lincolnCheckBox.Size = new System.Drawing.Size(91, 17);
            this.lincolnCheckBox.TabIndex = 3;
            this.lincolnCheckBox.Text = "Lincoln Room";
            this.lincolnCheckBox.UseVisualStyleBackColor = true;
            this.lincolnCheckBox.CheckedChanged += new System.EventHandler(this.lincolnCheckBox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(63, 175);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(154, 23);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.mealButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(292, 230);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.lincolnCheckBox);
            this.Controls.Add(this.belleAireCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bailey\'s Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox belleAireCheckBox;
        private System.Windows.Forms.CheckBox lincolnCheckBox;
        private System.Windows.Forms.Button mealButton;
    }
}

