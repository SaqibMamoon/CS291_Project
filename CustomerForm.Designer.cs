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
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cartypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.doorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heatedSeatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sunroofDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.bluetoothDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.manualDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.fuelTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet1 = new CS291_Project.Database1DataSet1();
			this.car_typeTableAdapter = new CS291_Project.Database1DataSet1TableAdapters.car_typeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).BeginInit();
			this.fillByToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Booking for customer: X ";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(124, 46);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(487, 47);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "From Date:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(432, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "To Date:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(124, 73);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(487, 73);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(200, 21);
			this.comboBox2.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Pick Up Branch:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
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
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.doorsDataGridViewTextBoxColumn,
            this.colorsDataGridViewTextBoxColumn,
            this.heatedSeatDataGridViewCheckBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.sunroofDataGridViewCheckBoxColumn,
            this.bluetoothDataGridViewCheckBoxColumn,
            this.manualDataGridViewCheckBoxColumn,
            this.fuelTypeDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.cartypeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(39, 126);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(983, 316);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
			// 
			// cartypeBindingSource
			// 
			this.cartypeBindingSource.DataMember = "car_type";
			this.cartypeBindingSource.DataSource = this.database1DataSet1BindingSource;
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(1064, 25);
			this.fillByToolStrip.TabIndex = 11;
			this.fillByToolStrip.Text = "fillByToolStrip";
			// 
			// fillByToolStripButton
			// 
			this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillByToolStripButton.Name = "fillByToolStripButton";
			this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
			this.fillByToolStripButton.Text = "FillBy";
			this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			this.modelDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// manufacturerDataGridViewTextBoxColumn
			// 
			this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
			this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
			this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
			this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// seatsDataGridViewTextBoxColumn
			// 
			this.seatsDataGridViewTextBoxColumn.DataPropertyName = "seats";
			this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
			this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
			this.seatsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// doorsDataGridViewTextBoxColumn
			// 
			this.doorsDataGridViewTextBoxColumn.DataPropertyName = "doors";
			this.doorsDataGridViewTextBoxColumn.HeaderText = "Doors";
			this.doorsDataGridViewTextBoxColumn.Name = "doorsDataGridViewTextBoxColumn";
			this.doorsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// colorsDataGridViewTextBoxColumn
			// 
			this.colorsDataGridViewTextBoxColumn.DataPropertyName = "colors";
			this.colorsDataGridViewTextBoxColumn.HeaderText = "Colors";
			this.colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
			this.colorsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// heatedSeatDataGridViewCheckBoxColumn
			// 
			this.heatedSeatDataGridViewCheckBoxColumn.DataPropertyName = "heatedSeat";
			this.heatedSeatDataGridViewCheckBoxColumn.HeaderText = "Heated Seats";
			this.heatedSeatDataGridViewCheckBoxColumn.Name = "heatedSeatDataGridViewCheckBoxColumn";
			this.heatedSeatDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			this.ageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// conditionDataGridViewTextBoxColumn
			// 
			this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
			this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
			this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
			this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sunroofDataGridViewCheckBoxColumn
			// 
			this.sunroofDataGridViewCheckBoxColumn.DataPropertyName = "sun_roof";
			this.sunroofDataGridViewCheckBoxColumn.HeaderText = "Sun Roof";
			this.sunroofDataGridViewCheckBoxColumn.Name = "sunroofDataGridViewCheckBoxColumn";
			this.sunroofDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// bluetoothDataGridViewCheckBoxColumn
			// 
			this.bluetoothDataGridViewCheckBoxColumn.DataPropertyName = "bluetooth";
			this.bluetoothDataGridViewCheckBoxColumn.HeaderText = "Bluetooth";
			this.bluetoothDataGridViewCheckBoxColumn.Name = "bluetoothDataGridViewCheckBoxColumn";
			this.bluetoothDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// manualDataGridViewCheckBoxColumn
			// 
			this.manualDataGridViewCheckBoxColumn.DataPropertyName = "manual";
			this.manualDataGridViewCheckBoxColumn.HeaderText = "Manual";
			this.manualDataGridViewCheckBoxColumn.Name = "manualDataGridViewCheckBoxColumn";
			this.manualDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// fuelTypeDataGridViewCheckBoxColumn
			// 
			this.fuelTypeDataGridViewCheckBoxColumn.DataPropertyName = "fuelType";
			this.fuelTypeDataGridViewCheckBoxColumn.HeaderText = "Fuel Type";
			this.fuelTypeDataGridViewCheckBoxColumn.Name = "fuelTypeDataGridViewCheckBoxColumn";
			this.fuelTypeDataGridViewCheckBoxColumn.ReadOnly = true;
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
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 585);
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Name = "CustomerForm";
			this.Text = "Customer";
			this.Load += new System.EventHandler(this.CustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cartypeBindingSource)).EndInit();
			this.fillByToolStrip.ResumeLayout(false);
			this.fillByToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
		private Database1DataSet1 database1DataSet1;
		private System.Windows.Forms.BindingSource cartypeBindingSource;
		private Database1DataSet1TableAdapters.car_typeTableAdapter car_typeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn doorsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn heatedSeatDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn sunroofDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn bluetoothDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn manualDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn fuelTypeDataGridViewCheckBoxColumn;
		private System.Windows.Forms.ToolStrip fillByToolStrip;
		private System.Windows.Forms.ToolStripButton fillByToolStripButton;
	}
}