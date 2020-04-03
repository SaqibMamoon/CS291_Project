namespace CS291_Project
{
    partial class CustomerForm
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
			this.customerLabel = new System.Windows.Forms.Label();
			this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.pickupBranchComboBox = new System.Windows.Forms.ComboBox();
			this.dropoffBranchComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cartypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet1 = new CS291_Project.Database1DataSet1();
			this.car_typeTableAdapter = new CS291_Project.Database1DataSet1TableAdapters.car_typeTableAdapter();
			this.selectCarComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.billingCycleComboBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.bookButton = new System.Windows.Forms.Button();
			this.numCyclesInput = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.endDateLabel = new System.Windows.Forms.Label();
			this.totalCostLabel = new System.Windows.Forms.Label();
			this.carTextInfo = new System.Windows.Forms.TextBox();
			this.database1DataSet2 = new CS291_Project.Database1DataSet();
			((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCyclesInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(36, 9);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(123, 13);
			this.customerLabel.TabIndex = 0;
			this.customerLabel.Text = "Booking for customer: X ";
			// 
			// fromDateTimePicker
			// 
			this.fromDateTimePicker.Location = new System.Drawing.Point(124, 46);
			this.fromDateTimePicker.Name = "fromDateTimePicker";
			this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fromDateTimePicker.TabIndex = 1;
			this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Start Date:";
			// 
			// pickupBranchComboBox
			// 
			this.pickupBranchComboBox.FormattingEnabled = true;
			this.pickupBranchComboBox.Location = new System.Drawing.Point(124, 73);
			this.pickupBranchComboBox.Name = "pickupBranchComboBox";
			this.pickupBranchComboBox.Size = new System.Drawing.Size(200, 21);
			this.pickupBranchComboBox.TabIndex = 6;
			this.pickupBranchComboBox.SelectedIndexChanged += new System.EventHandler(this.pickupBranchComboBox_SelectedIndexChanged);
			// 
			// dropoffBranchComboBox
			// 
			this.dropoffBranchComboBox.FormattingEnabled = true;
			this.dropoffBranchComboBox.Location = new System.Drawing.Point(487, 73);
			this.dropoffBranchComboBox.Name = "dropoffBranchComboBox";
			this.dropoffBranchComboBox.Size = new System.Drawing.Size(200, 21);
			this.dropoffBranchComboBox.TabIndex = 7;
			this.dropoffBranchComboBox.SelectedIndexChanged += new System.EventHandler(this.dropoffBranchComboBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Pick Up Branch:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(396, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Drop Off Branch:";
			// 
			// cartypeBindingSource
			// 
			this.cartypeBindingSource.DataMember = "car_type";
			this.cartypeBindingSource.DataSource = this.database1DataSet1BindingSource;
			// 
			// database1DataSet1BindingSource
			// 
			this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
			this.database1DataSet1BindingSource.Position = 0;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet1";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// car_typeTableAdapter
			// 
			this.car_typeTableAdapter.ClearBeforeFill = true;
			// 
			// selectCarComboBox
			// 
			this.selectCarComboBox.FormattingEnabled = true;
			this.selectCarComboBox.Location = new System.Drawing.Point(124, 122);
			this.selectCarComboBox.Name = "selectCarComboBox";
			this.selectCarComboBox.Size = new System.Drawing.Size(200, 21);
			this.selectCarComboBox.TabIndex = 12;
			this.selectCarComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCarComboBox_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Select Car:";
			// 
			// billingCycleComboBox
			// 
			this.billingCycleComboBox.FormattingEnabled = true;
			this.billingCycleComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
			this.billingCycleComboBox.Location = new System.Drawing.Point(124, 163);
			this.billingCycleComboBox.Name = "billingCycleComboBox";
			this.billingCycleComboBox.Size = new System.Drawing.Size(200, 21);
			this.billingCycleComboBox.TabIndex = 15;
			this.billingCycleComboBox.SelectedIndexChanged += new System.EventHandler(this.billingCycleComboBox_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(49, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Billing Cycle:";
			// 
			// bookButton
			// 
			this.bookButton.Location = new System.Drawing.Point(124, 281);
			this.bookButton.Name = "bookButton";
			this.bookButton.Size = new System.Drawing.Size(75, 23);
			this.bookButton.TabIndex = 17;
			this.bookButton.Text = "Book";
			this.bookButton.UseVisualStyleBackColor = true;
			this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
			// 
			// numCyclesInput
			// 
			this.numCyclesInput.Location = new System.Drawing.Point(124, 190);
			this.numCyclesInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCyclesInput.Name = "numCyclesInput";
			this.numCyclesInput.Size = new System.Drawing.Size(200, 20);
			this.numCyclesInput.TabIndex = 18;
			this.numCyclesInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCyclesInput.ValueChanged += new System.EventHandler(this.numCyclesInput_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "End Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(49, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Num Cycles:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(60, 255);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Total Cost:";
			// 
			// endDateLabel
			// 
			this.endDateLabel.AutoSize = true;
			this.endDateLabel.Location = new System.Drawing.Point(121, 229);
			this.endDateLabel.Name = "endDateLabel";
			this.endDateLabel.Size = new System.Drawing.Size(0, 13);
			this.endDateLabel.TabIndex = 22;
			// 
			// totalCostLabel
			// 
			this.totalCostLabel.AutoSize = true;
			this.totalCostLabel.Location = new System.Drawing.Point(124, 255);
			this.totalCostLabel.Name = "totalCostLabel";
			this.totalCostLabel.Size = new System.Drawing.Size(0, 13);
			this.totalCostLabel.TabIndex = 23;
			// 
			// carTextInfo
			// 
			this.carTextInfo.AcceptsReturn = true;
			this.carTextInfo.Location = new System.Drawing.Point(399, 122);
			this.carTextInfo.Multiline = true;
			this.carTextInfo.Name = "carTextInfo";
			this.carTextInfo.ReadOnly = true;
			this.carTextInfo.Size = new System.Drawing.Size(288, 182);
			this.carTextInfo.TabIndex = 24;
			// 
			// database1DataSet2
			// 
			this.database1DataSet2.DataSetName = "Database1DataSet";
			this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 346);
			this.Controls.Add(this.carTextInfo);
			this.Controls.Add(this.totalCostLabel);
			this.Controls.Add(this.endDateLabel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numCyclesInput);
			this.Controls.Add(this.bookButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.billingCycleComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.selectCarComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dropoffBranchComboBox);
			this.Controls.Add(this.pickupBranchComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.fromDateTimePicker);
			this.Controls.Add(this.customerLabel);
			this.Name = "CustomerForm";
			this.Text = "Booking";
			this.Load += new System.EventHandler(this.CustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCyclesInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox pickupBranchComboBox;
		private System.Windows.Forms.ComboBox dropoffBranchComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
		private Database1DataSet1 database1DataSet1;
		private System.Windows.Forms.BindingSource cartypeBindingSource;
		private Database1DataSet1TableAdapters.car_typeTableAdapter car_typeTableAdapter;
		private System.Windows.Forms.ComboBox selectCarComboBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox billingCycleComboBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bookButton;
		private System.Windows.Forms.NumericUpDown numCyclesInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label endDateLabel;
		private System.Windows.Forms.Label totalCostLabel;
		private System.Windows.Forms.TextBox carTextInfo;
		private Database1DataSet database1DataSet2;
	}
}