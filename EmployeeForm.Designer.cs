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
            this.addCarInformationButton = new System.Windows.Forms.Button();
            this.bookCustomerErrorLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dropOffErrorLabel = new System.Windows.Forms.Label();
            this.selectRentalLabel = new System.Windows.Forms.Label();
            this.dropOffButton = new System.Windows.Forms.Button();
            this.rentalComboBox = new System.Windows.Forms.ComboBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.selectBranchLabel = new System.Windows.Forms.Label();
            this.database1DataSet = new CS291_Project.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(50, 55);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(236, 21);
            this.customerComboBox.TabIndex = 1;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(348, 57);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // bookingLabel
            // 
            this.bookingLabel.AutoSize = true;
            this.bookingLabel.Location = new System.Drawing.Point(47, 39);
            this.bookingLabel.Name = "bookingLabel";
            this.bookingLabel.Size = new System.Drawing.Size(86, 13);
            this.bookingLabel.TabIndex = 0;
            this.bookingLabel.Text = "Select customer:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(307, 252);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addCarInformationButton
            // 
            this.addCarInformationButton.Location = new System.Drawing.Point(77, 243);
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
            this.bookCustomerErrorLabel.Location = new System.Drawing.Point(56, 88);
            this.bookCustomerErrorLabel.Name = "bookCustomerErrorLabel";
            this.bookCustomerErrorLabel.Size = new System.Drawing.Size(143, 13);
            this.bookCustomerErrorLabel.TabIndex = 3;
            this.bookCustomerErrorLabel.Text = "A customer must be selected";
            this.bookCustomerErrorLabel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dropOffErrorLabel
            // 
            this.dropOffErrorLabel.AutoSize = true;
            this.dropOffErrorLabel.Location = new System.Drawing.Point(307, 187);
            this.dropOffErrorLabel.Name = "dropOffErrorLabel";
            this.dropOffErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.dropOffErrorLabel.TabIndex = 9;
            // 
            // selectRentalLabel
            // 
            this.selectRentalLabel.AutoSize = true;
            this.selectRentalLabel.Location = new System.Drawing.Point(47, 123);
            this.selectRentalLabel.Name = "selectRentalLabel";
            this.selectRentalLabel.Size = new System.Drawing.Size(69, 13);
            this.selectRentalLabel.TabIndex = 6;
            this.selectRentalLabel.Text = "Select rental:";
            // 
            // dropOffButton
            // 
            this.dropOffButton.Location = new System.Drawing.Point(348, 141);
            this.dropOffButton.Name = "dropOffButton";
            this.dropOffButton.Size = new System.Drawing.Size(75, 23);
            this.dropOffButton.TabIndex = 8;
            this.dropOffButton.Text = "Drop off";
            this.dropOffButton.UseVisualStyleBackColor = true;
            this.dropOffButton.Click += new System.EventHandler(this.dropOffButton_Click);
            // 
            // rentalComboBox
            // 
            this.rentalComboBox.FormattingEnabled = true;
            this.rentalComboBox.Location = new System.Drawing.Point(50, 139);
            this.rentalComboBox.Name = "rentalComboBox";
            this.rentalComboBox.Size = new System.Drawing.Size(236, 21);
            this.rentalComboBox.TabIndex = 7;
            // 
            // branchComboBox
            // 
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(50, 179);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(236, 21);
            this.branchComboBox.TabIndex = 10;
            // 
            // selectBranchLabel
            // 
            this.selectBranchLabel.AutoSize = true;
            this.selectBranchLabel.Location = new System.Drawing.Point(47, 163);
            this.selectBranchLabel.Name = "selectBranchLabel";
            this.selectBranchLabel.Size = new System.Drawing.Size(148, 13);
            this.selectBranchLabel.TabIndex = 11;
            this.selectBranchLabel.Text = "Select a branch to drop off at:";
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 296);
            this.Controls.Add(this.selectBranchLabel);
            this.Controls.Add(this.branchComboBox);
            this.Controls.Add(this.dropOffErrorLabel);
            this.Controls.Add(this.selectRentalLabel);
            this.Controls.Add(this.dropOffButton);
            this.Controls.Add(this.rentalComboBox);
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
        private System.Windows.Forms.Label dropOffErrorLabel;
        private System.Windows.Forms.Label selectRentalLabel;
        private System.Windows.Forms.Button dropOffButton;
        private System.Windows.Forms.ComboBox rentalComboBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label selectBranchLabel;
    }
}