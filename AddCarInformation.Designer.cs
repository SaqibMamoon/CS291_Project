namespace CS291_Project
{
    partial class AddCarInformation
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
            System.Windows.Forms.TabPage pricingModelTabPage;
            this.pricingModelErrorLabel = new System.Windows.Forms.Label();
            this.addPricingModelButton = new System.Windows.Forms.Button();
            this.pricingModelNameTextBox = new System.Windows.Forms.TextBox();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.monthlyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthlyPriceLabel = new System.Windows.Forms.Label();
            this.weeklyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weeklyPriceLabel = new System.Windows.Forms.Label();
            this.dailyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dailyPriceLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.carTabPage = new System.Windows.Forms.TabPage();
            this.carErrorLabel = new System.Windows.Forms.Label();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.carIDTextBox = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.carTypeTabPage = new System.Windows.Forms.TabPage();
            this.pricingModelFormatLabel = new System.Windows.Forms.Label();
            this.carTypeErrorLabel = new System.Windows.Forms.Label();
            this.seatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.doorsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pricingModelLabel = new System.Windows.Forms.Label();
            this.pricingModelComboBox = new System.Windows.Forms.ComboBox();
            this.manualCheckBox = new System.Windows.Forms.CheckBox();
            this.bluetoothCheckBox = new System.Windows.Forms.CheckBox();
            this.sunRoofCheckBox = new System.Windows.Forms.CheckBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.heatedSeatsCheckBox = new System.Windows.Forms.CheckBox();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.Colors = new System.Windows.Forms.Label();
            this.doorsLabel = new System.Windows.Forms.Label();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.carManufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.addCarTypeButton = new System.Windows.Forms.Button();
            this.fuelTypeCheckBox = new System.Windows.Forms.CheckBox();
            pricingModelTabPage = new System.Windows.Forms.TabPage();
            pricingModelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyNumericUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.carTabPage.SuspendLayout();
            this.carTypeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pricingModelTabPage
            // 
            pricingModelTabPage.Controls.Add(this.pricingModelErrorLabel);
            pricingModelTabPage.Controls.Add(this.addPricingModelButton);
            pricingModelTabPage.Controls.Add(this.pricingModelNameTextBox);
            pricingModelTabPage.Controls.Add(this.modelNameLabel);
            pricingModelTabPage.Controls.Add(this.monthlyNumericUpDown);
            pricingModelTabPage.Controls.Add(this.monthlyPriceLabel);
            pricingModelTabPage.Controls.Add(this.weeklyNumericUpDown);
            pricingModelTabPage.Controls.Add(this.weeklyPriceLabel);
            pricingModelTabPage.Controls.Add(this.dailyNumericUpDown);
            pricingModelTabPage.Controls.Add(this.dailyPriceLabel);
            pricingModelTabPage.Location = new System.Drawing.Point(4, 22);
            pricingModelTabPage.Name = "pricingModelTabPage";
            pricingModelTabPage.Padding = new System.Windows.Forms.Padding(3);
            pricingModelTabPage.Size = new System.Drawing.Size(408, 319);
            pricingModelTabPage.TabIndex = 1;
            pricingModelTabPage.Text = "Pricing Model";
            pricingModelTabPage.UseVisualStyleBackColor = true;
            // 
            // pricingModelErrorLabel
            // 
            this.pricingModelErrorLabel.AutoSize = true;
            this.pricingModelErrorLabel.Location = new System.Drawing.Point(161, 179);
            this.pricingModelErrorLabel.Name = "pricingModelErrorLabel";
            this.pricingModelErrorLabel.Size = new System.Drawing.Size(101, 13);
            this.pricingModelErrorLabel.TabIndex = 64;
            this.pricingModelErrorLabel.Text = "Enter a model name";
            this.pricingModelErrorLabel.Visible = false;
            // 
            // addPricingModelButton
            // 
            this.addPricingModelButton.Location = new System.Drawing.Point(173, 204);
            this.addPricingModelButton.Name = "addPricingModelButton";
            this.addPricingModelButton.Size = new System.Drawing.Size(75, 23);
            this.addPricingModelButton.TabIndex = 63;
            this.addPricingModelButton.Text = "Add";
            this.addPricingModelButton.UseVisualStyleBackColor = true;
            this.addPricingModelButton.Click += new System.EventHandler(this.addPricingModelButton_Click);
            // 
            // pricingModelNameTextBox
            // 
            this.pricingModelNameTextBox.Location = new System.Drawing.Point(173, 55);
            this.pricingModelNameTextBox.Name = "pricingModelNameTextBox";
            this.pricingModelNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricingModelNameTextBox.TabIndex = 62;
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Location = new System.Drawing.Point(94, 58);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(70, 13);
            this.modelNameLabel.TabIndex = 61;
            this.modelNameLabel.Text = "Model Name:";
            // 
            // monthlyNumericUpDown
            // 
            this.monthlyNumericUpDown.Location = new System.Drawing.Point(173, 133);
            this.monthlyNumericUpDown.Name = "monthlyNumericUpDown";
            this.monthlyNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.monthlyNumericUpDown.TabIndex = 60;
            // 
            // monthlyPriceLabel
            // 
            this.monthlyPriceLabel.AutoSize = true;
            this.monthlyPriceLabel.Location = new System.Drawing.Point(94, 135);
            this.monthlyPriceLabel.Name = "monthlyPriceLabel";
            this.monthlyPriceLabel.Size = new System.Drawing.Size(74, 13);
            this.monthlyPriceLabel.TabIndex = 59;
            this.monthlyPriceLabel.Text = "Monthly Price:";
            // 
            // weeklyNumericUpDown
            // 
            this.weeklyNumericUpDown.Location = new System.Drawing.Point(173, 107);
            this.weeklyNumericUpDown.Name = "weeklyNumericUpDown";
            this.weeklyNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.weeklyNumericUpDown.TabIndex = 58;
            // 
            // weeklyPriceLabel
            // 
            this.weeklyPriceLabel.AutoSize = true;
            this.weeklyPriceLabel.Location = new System.Drawing.Point(94, 109);
            this.weeklyPriceLabel.Name = "weeklyPriceLabel";
            this.weeklyPriceLabel.Size = new System.Drawing.Size(73, 13);
            this.weeklyPriceLabel.TabIndex = 57;
            this.weeklyPriceLabel.Text = "Weekly Price:";
            // 
            // dailyNumericUpDown
            // 
            this.dailyNumericUpDown.Location = new System.Drawing.Point(173, 81);
            this.dailyNumericUpDown.Name = "dailyNumericUpDown";
            this.dailyNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.dailyNumericUpDown.TabIndex = 56;
            // 
            // dailyPriceLabel
            // 
            this.dailyPriceLabel.AutoSize = true;
            this.dailyPriceLabel.Location = new System.Drawing.Point(94, 83);
            this.dailyPriceLabel.Name = "dailyPriceLabel";
            this.dailyPriceLabel.Size = new System.Drawing.Size(60, 13);
            this.dailyPriceLabel.TabIndex = 55;
            this.dailyPriceLabel.Text = "Daily Price:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.carTabPage);
            this.tabControl.Controls.Add(this.carTypeTabPage);
            this.tabControl.Controls.Add(pricingModelTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(416, 345);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // carTabPage
            // 
            this.carTabPage.Controls.Add(this.carErrorLabel);
            this.carTabPage.Controls.Add(this.carIDLabel);
            this.carTabPage.Controls.Add(this.carIDTextBox);
            this.carTabPage.Controls.Add(this.addCarButton);
            this.carTabPage.Controls.Add(this.carTypeComboBox);
            this.carTabPage.Controls.Add(this.carTypeLabel);
            this.carTabPage.Controls.Add(this.branchComboBox);
            this.carTabPage.Controls.Add(this.branchLabel);
            this.carTabPage.Location = new System.Drawing.Point(4, 22);
            this.carTabPage.Name = "carTabPage";
            this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carTabPage.Size = new System.Drawing.Size(408, 319);
            this.carTabPage.TabIndex = 2;
            this.carTabPage.Text = "Car";
            this.carTabPage.UseVisualStyleBackColor = true;
            // 
            // carErrorLabel
            // 
            this.carErrorLabel.AutoSize = true;
            this.carErrorLabel.Location = new System.Drawing.Point(117, 245);
            this.carErrorLabel.Name = "carErrorLabel";
            this.carErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.carErrorLabel.TabIndex = 40;
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Location = new System.Drawing.Point(114, 73);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(40, 13);
            this.carIDLabel.TabIndex = 39;
            this.carIDLabel.Text = "Car ID:";
            // 
            // carIDTextBox
            // 
            this.carIDTextBox.Location = new System.Drawing.Point(165, 70);
            this.carIDTextBox.Name = "carIDTextBox";
            this.carIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.carIDTextBox.TabIndex = 38;
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(165, 180);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(75, 23);
            this.addCarButton.TabIndex = 37;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Location = new System.Drawing.Point(165, 126);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.carTypeComboBox.TabIndex = 36;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(114, 129);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(49, 13);
            this.carTypeLabel.TabIndex = 35;
            this.carTypeLabel.Text = "Car type:";
            // 
            // branchComboBox
            // 
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(165, 99);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(121, 21);
            this.branchComboBox.TabIndex = 34;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Location = new System.Drawing.Point(114, 102);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(44, 13);
            this.branchLabel.TabIndex = 33;
            this.branchLabel.Text = "Branch:";
            // 
            // carTypeTabPage
            // 
            this.carTypeTabPage.Controls.Add(this.fuelTypeCheckBox);
            this.carTypeTabPage.Controls.Add(this.pricingModelFormatLabel);
            this.carTypeTabPage.Controls.Add(this.carTypeErrorLabel);
            this.carTypeTabPage.Controls.Add(this.seatsNumericUpDown);
            this.carTypeTabPage.Controls.Add(this.ageNumericUpDown);
            this.carTypeTabPage.Controls.Add(this.doorsNumericUpDown);
            this.carTypeTabPage.Controls.Add(this.pricingModelLabel);
            this.carTypeTabPage.Controls.Add(this.pricingModelComboBox);
            this.carTypeTabPage.Controls.Add(this.manualCheckBox);
            this.carTypeTabPage.Controls.Add(this.bluetoothCheckBox);
            this.carTypeTabPage.Controls.Add(this.sunRoofCheckBox);
            this.carTypeTabPage.Controls.Add(this.conditionTextBox);
            this.carTypeTabPage.Controls.Add(this.conditionLabel);
            this.carTypeTabPage.Controls.Add(this.ageLabel);
            this.carTypeTabPage.Controls.Add(this.heatedSeatsCheckBox);
            this.carTypeTabPage.Controls.Add(this.colorsTextBox);
            this.carTypeTabPage.Controls.Add(this.Colors);
            this.carTypeTabPage.Controls.Add(this.doorsLabel);
            this.carTypeTabPage.Controls.Add(this.seatsLabel);
            this.carTypeTabPage.Controls.Add(this.modelLabel);
            this.carTypeTabPage.Controls.Add(this.modelTextBox);
            this.carTypeTabPage.Controls.Add(this.carManufacturerLabel);
            this.carTypeTabPage.Controls.Add(this.manufacturerTextBox);
            this.carTypeTabPage.Controls.Add(this.addCarTypeButton);
            this.carTypeTabPage.Location = new System.Drawing.Point(4, 22);
            this.carTypeTabPage.Name = "carTypeTabPage";
            this.carTypeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carTypeTabPage.Size = new System.Drawing.Size(408, 319);
            this.carTypeTabPage.TabIndex = 0;
            this.carTypeTabPage.Text = "Car Type";
            this.carTypeTabPage.UseVisualStyleBackColor = true;
            // 
            // pricingModelFormatLabel
            // 
            this.pricingModelFormatLabel.AutoSize = true;
            this.pricingModelFormatLabel.Location = new System.Drawing.Point(123, 225);
            this.pricingModelFormatLabel.Name = "pricingModelFormatLabel";
            this.pricingModelFormatLabel.Size = new System.Drawing.Size(248, 13);
            this.pricingModelFormatLabel.TabIndex = 56;
            this.pricingModelFormatLabel.Text = "Pricing ID, Daily Price, Weekly Price, Monthly Price";
            // 
            // carTypeErrorLabel
            // 
            this.carTypeErrorLabel.AutoSize = true;
            this.carTypeErrorLabel.Location = new System.Drawing.Point(25, 249);
            this.carTypeErrorLabel.Name = "carTypeErrorLabel";
            this.carTypeErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.carTypeErrorLabel.TabIndex = 55;
            // 
            // seatsNumericUpDown
            // 
            this.seatsNumericUpDown.Location = new System.Drawing.Point(126, 72);
            this.seatsNumericUpDown.Name = "seatsNumericUpDown";
            this.seatsNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.seatsNumericUpDown.TabIndex = 54;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(126, 149);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ageNumericUpDown.TabIndex = 53;
            // 
            // doorsNumericUpDown
            // 
            this.doorsNumericUpDown.Location = new System.Drawing.Point(126, 98);
            this.doorsNumericUpDown.Name = "doorsNumericUpDown";
            this.doorsNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.doorsNumericUpDown.TabIndex = 52;
            // 
            // pricingModelLabel
            // 
            this.pricingModelLabel.AutoSize = true;
            this.pricingModelLabel.Location = new System.Drawing.Point(46, 204);
            this.pricingModelLabel.Name = "pricingModelLabel";
            this.pricingModelLabel.Size = new System.Drawing.Size(74, 13);
            this.pricingModelLabel.TabIndex = 51;
            this.pricingModelLabel.Text = "Pricing Model:";
            // 
            // pricingModelComboBox
            // 
            this.pricingModelComboBox.FormattingEnabled = true;
            this.pricingModelComboBox.Location = new System.Drawing.Point(126, 201);
            this.pricingModelComboBox.Name = "pricingModelComboBox";
            this.pricingModelComboBox.Size = new System.Drawing.Size(262, 21);
            this.pricingModelComboBox.TabIndex = 50;
            // 
            // manualCheckBox
            // 
            this.manualCheckBox.AutoSize = true;
            this.manualCheckBox.Location = new System.Drawing.Point(272, 104);
            this.manualCheckBox.Name = "manualCheckBox";
            this.manualCheckBox.Size = new System.Drawing.Size(61, 17);
            this.manualCheckBox.TabIndex = 49;
            this.manualCheckBox.Text = "Manual";
            this.manualCheckBox.UseVisualStyleBackColor = true;
            // 
            // bluetoothCheckBox
            // 
            this.bluetoothCheckBox.AutoSize = true;
            this.bluetoothCheckBox.Location = new System.Drawing.Point(272, 81);
            this.bluetoothCheckBox.Name = "bluetoothCheckBox";
            this.bluetoothCheckBox.Size = new System.Drawing.Size(71, 17);
            this.bluetoothCheckBox.TabIndex = 48;
            this.bluetoothCheckBox.Text = "Bluetooth";
            this.bluetoothCheckBox.UseVisualStyleBackColor = true;
            // 
            // sunRoofCheckBox
            // 
            this.sunRoofCheckBox.AutoSize = true;
            this.sunRoofCheckBox.Location = new System.Drawing.Point(272, 58);
            this.sunRoofCheckBox.Name = "sunRoofCheckBox";
            this.sunRoofCheckBox.Size = new System.Drawing.Size(71, 17);
            this.sunRoofCheckBox.TabIndex = 47;
            this.sunRoofCheckBox.Text = "Sun Roof";
            this.sunRoofCheckBox.UseVisualStyleBackColor = true;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(126, 175);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionTextBox.TabIndex = 44;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(47, 178);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(54, 13);
            this.conditionLabel.TabIndex = 43;
            this.conditionLabel.Text = "Condition:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(47, 152);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 41;
            this.ageLabel.Text = "Age:";
            // 
            // heatedSeatsCheckBox
            // 
            this.heatedSeatsCheckBox.AutoSize = true;
            this.heatedSeatsCheckBox.Location = new System.Drawing.Point(272, 35);
            this.heatedSeatsCheckBox.Name = "heatedSeatsCheckBox";
            this.heatedSeatsCheckBox.Size = new System.Drawing.Size(91, 17);
            this.heatedSeatsCheckBox.TabIndex = 40;
            this.heatedSeatsCheckBox.Text = "Heated Seats";
            this.heatedSeatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.Location = new System.Drawing.Point(126, 123);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorsTextBox.TabIndex = 39;
            // 
            // Colors
            // 
            this.Colors.AutoSize = true;
            this.Colors.Location = new System.Drawing.Point(47, 126);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(39, 13);
            this.Colors.TabIndex = 38;
            this.Colors.Text = "Colors:";
            // 
            // doorsLabel
            // 
            this.doorsLabel.AutoSize = true;
            this.doorsLabel.Location = new System.Drawing.Point(47, 100);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new System.Drawing.Size(38, 13);
            this.doorsLabel.TabIndex = 36;
            this.doorsLabel.Text = "Doors:";
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Location = new System.Drawing.Point(47, 74);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(37, 13);
            this.seatsLabel.TabIndex = 34;
            this.seatsLabel.Text = "Seats:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(47, 48);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 33;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(126, 45);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 32;
            // 
            // carManufacturerLabel
            // 
            this.carManufacturerLabel.AutoSize = true;
            this.carManufacturerLabel.Location = new System.Drawing.Point(47, 22);
            this.carManufacturerLabel.Name = "carManufacturerLabel";
            this.carManufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.carManufacturerLabel.TabIndex = 31;
            this.carManufacturerLabel.Text = "Manufacturer:";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(126, 19);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTextBox.TabIndex = 30;
            // 
            // addCarTypeButton
            // 
            this.addCarTypeButton.Location = new System.Drawing.Point(175, 280);
            this.addCarTypeButton.Name = "addCarTypeButton";
            this.addCarTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addCarTypeButton.TabIndex = 29;
            this.addCarTypeButton.Text = "Add";
            this.addCarTypeButton.UseVisualStyleBackColor = true;
            this.addCarTypeButton.Click += new System.EventHandler(this.addCarTypeButton_Click);
            // 
            // fuelTypeCheckBox
            // 
            this.fuelTypeCheckBox.AutoSize = true;
            this.fuelTypeCheckBox.Location = new System.Drawing.Point(272, 127);
            this.fuelTypeCheckBox.Name = "fuelTypeCheckBox";
            this.fuelTypeCheckBox.Size = new System.Drawing.Size(73, 17);
            this.fuelTypeCheckBox.TabIndex = 57;
            this.fuelTypeCheckBox.Text = "Fuel Type";
            this.fuelTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCarInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 370);
            this.Controls.Add(this.tabControl);
            this.Name = "AddCarInformation";
            this.Text = "Add car/car type/pricing model";
            pricingModelTabPage.ResumeLayout(false);
            pricingModelTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyNumericUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.carTabPage.ResumeLayout(false);
            this.carTabPage.PerformLayout();
            this.carTypeTabPage.ResumeLayout(false);
            this.carTypeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage carTabPage;
        private System.Windows.Forms.TabPage carTypeTabPage;
        private System.Windows.Forms.CheckBox manualCheckBox;
        private System.Windows.Forms.CheckBox bluetoothCheckBox;
        private System.Windows.Forms.CheckBox sunRoofCheckBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.CheckBox heatedSeatsCheckBox;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.Label Colors;
        private System.Windows.Forms.Label doorsLabel;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label carManufacturerLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Button addCarTypeButton;
        private System.Windows.Forms.Label pricingModelLabel;
        private System.Windows.Forms.ComboBox pricingModelComboBox;
        private System.Windows.Forms.NumericUpDown seatsNumericUpDown;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.NumericUpDown doorsNumericUpDown;
        private System.Windows.Forms.Button addPricingModelButton;
        private System.Windows.Forms.TextBox pricingModelNameTextBox;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.NumericUpDown monthlyNumericUpDown;
        private System.Windows.Forms.Label monthlyPriceLabel;
        private System.Windows.Forms.NumericUpDown weeklyNumericUpDown;
        private System.Windows.Forms.Label weeklyPriceLabel;
        private System.Windows.Forms.NumericUpDown dailyNumericUpDown;
        private System.Windows.Forms.Label dailyPriceLabel;
        private System.Windows.Forms.Label pricingModelErrorLabel;
        private System.Windows.Forms.Label carTypeErrorLabel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label carIDLabel;
        private System.Windows.Forms.TextBox carIDTextBox;
        private System.Windows.Forms.Label carErrorLabel;
        private System.Windows.Forms.Label pricingModelFormatLabel;
        private System.Windows.Forms.CheckBox fuelTypeCheckBox;
    }
}