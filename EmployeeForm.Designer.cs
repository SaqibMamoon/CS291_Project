namespace CS291_Project
{
    partial class EmployeeForm
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
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.bookingLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(63, 39);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(183, 21);
            this.customerComboBox.TabIndex = 0;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(267, 37);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 1;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // bookingLabel
            // 
            this.bookingLabel.AutoSize = true;
            this.bookingLabel.Location = new System.Drawing.Point(60, 23);
            this.bookingLabel.Name = "bookingLabel";
            this.bookingLabel.Size = new System.Drawing.Size(86, 13);
            this.bookingLabel.TabIndex = 2;
            this.bookingLabel.Text = "Select customer:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(684, 37);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bookingLabel);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.customerComboBox);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label bookingLabel;
        private System.Windows.Forms.Button backButton;
    }
}