namespace BedAndBreakfast
{
    partial class BreakfastOptionForm
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
            this.breakfastOptionLabel = new System.Windows.Forms.Label();
            this.contBreakfastButton = new System.Windows.Forms.RadioButton();
            this.fullBreakfastButton = new System.Windows.Forms.RadioButton();
            this.deluxeBreakfastButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakfastOptionLabel
            // 
            this.breakfastOptionLabel.AutoSize = true;
            this.breakfastOptionLabel.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastOptionLabel.Location = new System.Drawing.Point(52, 33);
            this.breakfastOptionLabel.Name = "breakfastOptionLabel";
            this.breakfastOptionLabel.Size = new System.Drawing.Size(180, 21);
            this.breakfastOptionLabel.TabIndex = 0;
            this.breakfastOptionLabel.Text = "Select your breakfast option";
            // 
            // contBreakfastButton
            // 
            this.contBreakfastButton.AutoSize = true;
            this.contBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contBreakfastButton.Location = new System.Drawing.Point(41, 73);
            this.contBreakfastButton.Name = "contBreakfastButton";
            this.contBreakfastButton.Size = new System.Drawing.Size(98, 25);
            this.contBreakfastButton.TabIndex = 1;
            this.contBreakfastButton.TabStop = true;
            this.contBreakfastButton.Text = "Continental";
            this.contBreakfastButton.UseVisualStyleBackColor = true;
            this.contBreakfastButton.CheckedChanged += new System.EventHandler(this.contBreakfastButton_CheckedChanged);
            // 
            // fullBreakfastButton
            // 
            this.fullBreakfastButton.AutoSize = true;
            this.fullBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBreakfastButton.Location = new System.Drawing.Point(41, 118);
            this.fullBreakfastButton.Name = "fullBreakfastButton";
            this.fullBreakfastButton.Size = new System.Drawing.Size(51, 25);
            this.fullBreakfastButton.TabIndex = 2;
            this.fullBreakfastButton.TabStop = true;
            this.fullBreakfastButton.Text = "Full";
            this.fullBreakfastButton.UseVisualStyleBackColor = true;
            this.fullBreakfastButton.CheckedChanged += new System.EventHandler(this.fullBreakfastButton_CheckedChanged);
            // 
            // deluxeBreakfastButton
            // 
            this.deluxeBreakfastButton.AutoSize = true;
            this.deluxeBreakfastButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxeBreakfastButton.Location = new System.Drawing.Point(41, 158);
            this.deluxeBreakfastButton.Name = "deluxeBreakfastButton";
            this.deluxeBreakfastButton.Size = new System.Drawing.Size(72, 25);
            this.deluxeBreakfastButton.TabIndex = 3;
            this.deluxeBreakfastButton.TabStop = true;
            this.deluxeBreakfastButton.Text = "Deluxe";
            this.deluxeBreakfastButton.UseVisualStyleBackColor = true;
            this.deluxeBreakfastButton.CheckedChanged += new System.EventHandler(this.deluxeBreakfastButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(170, 197);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 21);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deluxeBreakfastButton);
            this.Controls.Add(this.fullBreakfastButton);
            this.Controls.Add(this.contBreakfastButton);
            this.Controls.Add(this.breakfastOptionLabel);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label breakfastOptionLabel;
        private System.Windows.Forms.RadioButton contBreakfastButton;
        private System.Windows.Forms.RadioButton fullBreakfastButton;
        private System.Windows.Forms.RadioButton deluxeBreakfastButton;
        private System.Windows.Forms.Label priceLabel;
    }
}