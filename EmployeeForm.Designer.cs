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
            this.components = new System.ComponentModel.Container();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.bookingLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.database1DataSet = new CS291_Project.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCarInformationButton = new System.Windows.Forms.Button();
            this.bookCustomerErrorLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(50, 60);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(183, 21);
            this.customerComboBox.TabIndex = 0;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(254, 58);
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
            this.bookingLabel.Location = new System.Drawing.Point(47, 44);
            this.bookingLabel.Name = "bookingLabel";
            this.bookingLabel.Size = new System.Drawing.Size(86, 13);
            this.bookingLabel.TabIndex = 2;
            this.bookingLabel.Text = "Select customer:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(280, 153);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // addCarInformationButton
            // 
            this.addCarInformationButton.Location = new System.Drawing.Point(50, 144);
            this.addCarInformationButton.Name = "addCarInformationButton";
            this.addCarInformationButton.Size = new System.Drawing.Size(192, 41);
            this.addCarInformationButton.TabIndex = 4;
            this.addCarInformationButton.Text = "Add Car/Car Type/Pricing Model";
            this.addCarInformationButton.UseVisualStyleBackColor = true;
            this.addCarInformationButton.Click += new System.EventHandler(this.addCarInformationButton_Click);
            // 
            // bookCustomerErrorLabel
            // 
            this.bookCustomerErrorLabel.AutoSize = true;
            this.bookCustomerErrorLabel.Location = new System.Drawing.Point(56, 93);
            this.bookCustomerErrorLabel.Name = "bookCustomerErrorLabel";
            this.bookCustomerErrorLabel.Size = new System.Drawing.Size(143, 13);
            this.bookCustomerErrorLabel.TabIndex = 5;
            this.bookCustomerErrorLabel.Text = "A customer must be selected";
            this.bookCustomerErrorLabel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 218);
            this.Controls.Add(this.bookCustomerErrorLabel);
            this.Controls.Add(this.addCarInformationButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bookingLabel);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.customerComboBox);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label bookingLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button addCarInformationButton;
        private System.Windows.Forms.Label bookCustomerErrorLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}