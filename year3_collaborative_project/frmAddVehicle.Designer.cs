namespace year3_collaborative_project
{
    partial class frmAddVehicle
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
            this.gboMakeChoice = new System.Windows.Forms.GroupBox();
            this.lblSelectedMake = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.btnMakeConfirm = new System.Windows.Forms.Button();
            this.txtAddNewMake = new System.Windows.Forms.TextBox();
            this.cboCarMakes = new System.Windows.Forms.ComboBox();
            this.chbNewMake = new System.Windows.Forms.CheckBox();
            this.chbExistingMake = new System.Windows.Forms.CheckBox();
            this.gboModelChoice = new System.Windows.Forms.GroupBox();
            this.lblNewModelSelection = new System.Windows.Forms.Label();
            this.lblNewModel = new System.Windows.Forms.Label();
            this.btnModelConfirm = new System.Windows.Forms.Button();
            this.txtAddCarModel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboAddDetails = new System.Windows.Forms.GroupBox();
            this.nudDoors = new System.Windows.Forms.NumericUpDown();
            this.cboDrivePick = new System.Windows.Forms.ComboBox();
            this.cboTransmissionPick = new System.Windows.Forms.ComboBox();
            this.cboFuelPick = new System.Windows.Forms.ComboBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmDetails = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtEmissions = new System.Windows.Forms.TextBox();
            this.lblEmissions = new System.Windows.Forms.Label();
            this.lblDriveType = new System.Windows.Forms.Label();
            this.txtMPG = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.txtModelPrice = new System.Windows.Forms.TextBox();
            this.lblModelPrice = new System.Windows.Forms.Label();
            this.gboCheckDetails = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommitChanges = new System.Windows.Forms.Button();
            this.lblConfirmYear = new System.Windows.Forms.Label();
            this.lblConfirmEmissions = new System.Windows.Forms.Label();
            this.lblConfirmDrive = new System.Windows.Forms.Label();
            this.lblConfirmMPG = new System.Windows.Forms.Label();
            this.lblConfirmTransmission = new System.Windows.Forms.Label();
            this.lblConfirmFuel = new System.Windows.Forms.Label();
            this.lblConfirmDoors = new System.Windows.Forms.Label();
            this.lblConfirmEngine = new System.Windows.Forms.Label();
            this.lblConfirmPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConfirmChanges = new System.Windows.Forms.Label();
            this.btnMenuReturn = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.gboMakeChoice.SuspendLayout();
            this.gboModelChoice.SuspendLayout();
            this.gboAddDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoors)).BeginInit();
            this.gboCheckDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Vehicle";
            // 
            // gboMakeChoice
            // 
            this.gboMakeChoice.Controls.Add(this.lblSelectedMake);
            this.gboMakeChoice.Controls.Add(this.lblSelection);
            this.gboMakeChoice.Controls.Add(this.btnMakeConfirm);
            this.gboMakeChoice.Controls.Add(this.txtAddNewMake);
            this.gboMakeChoice.Controls.Add(this.cboCarMakes);
            this.gboMakeChoice.Controls.Add(this.chbNewMake);
            this.gboMakeChoice.Controls.Add(this.chbExistingMake);
            this.gboMakeChoice.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboMakeChoice.Location = new System.Drawing.Point(42, 154);
            this.gboMakeChoice.Name = "gboMakeChoice";
            this.gboMakeChoice.Size = new System.Drawing.Size(200, 175);
            this.gboMakeChoice.TabIndex = 1;
            this.gboMakeChoice.TabStop = false;
            this.gboMakeChoice.Text = "Select Make";
            // 
            // lblSelectedMake
            // 
            this.lblSelectedMake.AutoSize = true;
            this.lblSelectedMake.Location = new System.Drawing.Point(7, 149);
            this.lblSelectedMake.Name = "lblSelectedMake";
            this.lblSelectedMake.Size = new System.Drawing.Size(50, 19);
            this.lblSelectedMake.TabIndex = 6;
            this.lblSelectedMake.Text = "Make";
            this.lblSelectedMake.Visible = false;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(7, 126);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(137, 19);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "You have chosen:";
            this.lblSelection.Visible = false;
            // 
            // btnMakeConfirm
            // 
            this.btnMakeConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnMakeConfirm.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnMakeConfirm.ForeColor = System.Drawing.Color.White;
            this.btnMakeConfirm.Location = new System.Drawing.Point(7, 96);
            this.btnMakeConfirm.Name = "btnMakeConfirm";
            this.btnMakeConfirm.Size = new System.Drawing.Size(94, 27);
            this.btnMakeConfirm.TabIndex = 4;
            this.btnMakeConfirm.Text = "Confirm Make";
            this.btnMakeConfirm.UseVisualStyleBackColor = false;
            this.btnMakeConfirm.Visible = false;
            this.btnMakeConfirm.Click += new System.EventHandler(this.btnMakeConfirm_Click);
            // 
            // txtAddNewMake
            // 
            this.txtAddNewMake.Location = new System.Drawing.Point(7, 68);
            this.txtAddNewMake.Name = "txtAddNewMake";
            this.txtAddNewMake.Size = new System.Drawing.Size(100, 26);
            this.txtAddNewMake.TabIndex = 3;
            this.txtAddNewMake.Visible = false;
            this.txtAddNewMake.TextChanged += new System.EventHandler(this.txtAddNewMake_TextChanged);
            // 
            // cboCarMakes
            // 
            this.cboCarMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarMakes.FormattingEnabled = true;
            this.cboCarMakes.Location = new System.Drawing.Point(7, 68);
            this.cboCarMakes.Name = "cboCarMakes";
            this.cboCarMakes.Size = new System.Drawing.Size(121, 27);
            this.cboCarMakes.TabIndex = 2;
            this.cboCarMakes.Visible = false;
            this.cboCarMakes.SelectedIndexChanged += new System.EventHandler(this.cboCarMakes_SelectedIndexChanged_1);
            // 
            // chbNewMake
            // 
            this.chbNewMake.AutoSize = true;
            this.chbNewMake.Location = new System.Drawing.Point(7, 44);
            this.chbNewMake.Name = "chbNewMake";
            this.chbNewMake.Size = new System.Drawing.Size(141, 23);
            this.chbNewMake.TabIndex = 1;
            this.chbNewMake.Text = "Add New Make";
            this.chbNewMake.UseVisualStyleBackColor = true;
            this.chbNewMake.CheckedChanged += new System.EventHandler(this.chbNewMake_CheckedChanged_1);
            // 
            // chbExistingMake
            // 
            this.chbExistingMake.AutoSize = true;
            this.chbExistingMake.Location = new System.Drawing.Point(7, 20);
            this.chbExistingMake.Name = "chbExistingMake";
            this.chbExistingMake.Size = new System.Drawing.Size(131, 23);
            this.chbExistingMake.TabIndex = 0;
            this.chbExistingMake.Text = "Existing Make";
            this.chbExistingMake.UseVisualStyleBackColor = true;
            this.chbExistingMake.CheckedChanged += new System.EventHandler(this.chbExistingMake_CheckedChanged_1);
            // 
            // gboModelChoice
            // 
            this.gboModelChoice.Controls.Add(this.lblNewModelSelection);
            this.gboModelChoice.Controls.Add(this.lblNewModel);
            this.gboModelChoice.Controls.Add(this.btnModelConfirm);
            this.gboModelChoice.Controls.Add(this.txtAddCarModel);
            this.gboModelChoice.Controls.Add(this.textBox1);
            this.gboModelChoice.Controls.Add(this.label2);
            this.gboModelChoice.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboModelChoice.Location = new System.Drawing.Point(42, 353);
            this.gboModelChoice.Name = "gboModelChoice";
            this.gboModelChoice.Size = new System.Drawing.Size(229, 171);
            this.gboModelChoice.TabIndex = 2;
            this.gboModelChoice.TabStop = false;
            this.gboModelChoice.Text = "Select Model";
            this.gboModelChoice.Visible = false;
            // 
            // lblNewModelSelection
            // 
            this.lblNewModelSelection.AutoSize = true;
            this.lblNewModelSelection.Location = new System.Drawing.Point(7, 149);
            this.lblNewModelSelection.Name = "lblNewModelSelection";
            this.lblNewModelSelection.Size = new System.Drawing.Size(55, 19);
            this.lblNewModelSelection.TabIndex = 5;
            this.lblNewModelSelection.Text = "Model";
            this.lblNewModelSelection.Visible = false;
            // 
            // lblNewModel
            // 
            this.lblNewModel.AutoSize = true;
            this.lblNewModel.Location = new System.Drawing.Point(7, 127);
            this.lblNewModel.Name = "lblNewModel";
            this.lblNewModel.Size = new System.Drawing.Size(211, 19);
            this.lblNewModel.TabIndex = 4;
            this.lblNewModel.Text = "You are adding new model:";
            this.lblNewModel.Visible = false;
            // 
            // btnModelConfirm
            // 
            this.btnModelConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnModelConfirm.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnModelConfirm.ForeColor = System.Drawing.Color.White;
            this.btnModelConfirm.Location = new System.Drawing.Point(11, 92);
            this.btnModelConfirm.Name = "btnModelConfirm";
            this.btnModelConfirm.Size = new System.Drawing.Size(94, 32);
            this.btnModelConfirm.TabIndex = 3;
            this.btnModelConfirm.Text = "Confirm";
            this.btnModelConfirm.UseVisualStyleBackColor = false;
            this.btnModelConfirm.Visible = false;
            this.btnModelConfirm.Click += new System.EventHandler(this.btnModelConfirm_Click);
            // 
            // txtAddCarModel
            // 
            this.txtAddCarModel.Location = new System.Drawing.Point(11, 60);
            this.txtAddCarModel.Name = "txtAddCarModel";
            this.txtAddCarModel.Size = new System.Drawing.Size(100, 26);
            this.txtAddCarModel.TabIndex = 2;
            this.txtAddCarModel.TextChanged += new System.EventHandler(this.txtAddCarModel_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Model Name";
            // 
            // gboAddDetails
            // 
            this.gboAddDetails.Controls.Add(this.nudDoors);
            this.gboAddDetails.Controls.Add(this.cboDrivePick);
            this.gboAddDetails.Controls.Add(this.cboTransmissionPick);
            this.gboAddDetails.Controls.Add(this.cboFuelPick);
            this.gboAddDetails.Controls.Add(this.dtpYear);
            this.gboAddDetails.Controls.Add(this.btnConfirmDetails);
            this.gboAddDetails.Controls.Add(this.lblYear);
            this.gboAddDetails.Controls.Add(this.txtEmissions);
            this.gboAddDetails.Controls.Add(this.lblEmissions);
            this.gboAddDetails.Controls.Add(this.lblDriveType);
            this.gboAddDetails.Controls.Add(this.txtMPG);
            this.gboAddDetails.Controls.Add(this.lblMPG);
            this.gboAddDetails.Controls.Add(this.lblTransmission);
            this.gboAddDetails.Controls.Add(this.lblFuel);
            this.gboAddDetails.Controls.Add(this.lblDoors);
            this.gboAddDetails.Controls.Add(this.txtEngineSize);
            this.gboAddDetails.Controls.Add(this.lblEngineSize);
            this.gboAddDetails.Controls.Add(this.txtModelPrice);
            this.gboAddDetails.Controls.Add(this.lblModelPrice);
            this.gboAddDetails.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboAddDetails.Location = new System.Drawing.Point(368, 154);
            this.gboAddDetails.Name = "gboAddDetails";
            this.gboAddDetails.Size = new System.Drawing.Size(263, 370);
            this.gboAddDetails.TabIndex = 3;
            this.gboAddDetails.TabStop = false;
            this.gboAddDetails.Text = "Add Model Details";
            this.gboAddDetails.Visible = false;
            // 
            // nudDoors
            // 
            this.nudDoors.Location = new System.Drawing.Point(157, 85);
            this.nudDoors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDoors.Name = "nudDoors";
            this.nudDoors.ReadOnly = true;
            this.nudDoors.Size = new System.Drawing.Size(101, 26);
            this.nudDoors.TabIndex = 21;
            // 
            // cboDrivePick
            // 
            this.cboDrivePick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivePick.FormattingEnabled = true;
            this.cboDrivePick.Items.AddRange(new object[] {
            "4 Wheel",
            "Rear Wheel",
            "Front Wheel"});
            this.cboDrivePick.Location = new System.Drawing.Point(157, 218);
            this.cboDrivePick.Name = "cboDrivePick";
            this.cboDrivePick.Size = new System.Drawing.Size(100, 27);
            this.cboDrivePick.TabIndex = 22;
            // 
            // cboTransmissionPick
            // 
            this.cboTransmissionPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransmissionPick.FormattingEnabled = true;
            this.cboTransmissionPick.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cboTransmissionPick.Location = new System.Drawing.Point(157, 150);
            this.cboTransmissionPick.Name = "cboTransmissionPick";
            this.cboTransmissionPick.Size = new System.Drawing.Size(100, 27);
            this.cboTransmissionPick.TabIndex = 21;
            // 
            // cboFuelPick
            // 
            this.cboFuelPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelPick.FormattingEnabled = true;
            this.cboFuelPick.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.cboFuelPick.Location = new System.Drawing.Point(157, 117);
            this.cboFuelPick.Name = "cboFuelPick";
            this.cboFuelPick.Size = new System.Drawing.Size(100, 27);
            this.cboFuelPick.TabIndex = 20;
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(157, 283);
            this.dtpYear.MaxDate = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(100, 26);
            this.dtpYear.TabIndex = 19;
            this.dtpYear.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // btnConfirmDetails
            // 
            this.btnConfirmDetails.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmDetails.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnConfirmDetails.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDetails.Location = new System.Drawing.Point(54, 323);
            this.btnConfirmDetails.Name = "btnConfirmDetails";
            this.btnConfirmDetails.Size = new System.Drawing.Size(104, 30);
            this.btnConfirmDetails.TabIndex = 18;
            this.btnConfirmDetails.Text = "Confirm Details";
            this.btnConfirmDetails.UseVisualStyleBackColor = false;
            this.btnConfirmDetails.Click += new System.EventHandler(this.btnConfirmDetails_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 289);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(84, 19);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year Built:";
            // 
            // txtEmissions
            // 
            this.txtEmissions.Location = new System.Drawing.Point(157, 249);
            this.txtEmissions.Name = "txtEmissions";
            this.txtEmissions.Size = new System.Drawing.Size(100, 26);
            this.txtEmissions.TabIndex = 15;
            // 
            // lblEmissions
            // 
            this.lblEmissions.AutoSize = true;
            this.lblEmissions.Location = new System.Drawing.Point(6, 251);
            this.lblEmissions.Name = "lblEmissions";
            this.lblEmissions.Size = new System.Drawing.Size(85, 19);
            this.lblEmissions.TabIndex = 14;
            this.lblEmissions.Text = "Emissions:";
            // 
            // lblDriveType
            // 
            this.lblDriveType.AutoSize = true;
            this.lblDriveType.Location = new System.Drawing.Point(7, 221);
            this.lblDriveType.Name = "lblDriveType";
            this.lblDriveType.Size = new System.Drawing.Size(96, 19);
            this.lblDriveType.TabIndex = 12;
            this.lblDriveType.Text = "Drive Type:";
            // 
            // txtMPG
            // 
            this.txtMPG.Location = new System.Drawing.Point(157, 183);
            this.txtMPG.Name = "txtMPG";
            this.txtMPG.Size = new System.Drawing.Size(100, 26);
            this.txtMPG.TabIndex = 11;
            // 
            // lblMPG
            // 
            this.lblMPG.AutoSize = true;
            this.lblMPG.Location = new System.Drawing.Point(7, 186);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(50, 19);
            this.lblMPG.TabIndex = 10;
            this.lblMPG.Text = "MPG:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(6, 153);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(109, 19);
            this.lblTransmission.TabIndex = 8;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(7, 120);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(86, 19);
            this.lblFuel.TabIndex = 6;
            this.lblFuel.Text = "Fuel Type:";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(6, 88);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(101, 19);
            this.lblDoors.TabIndex = 4;
            this.lblDoors.Text = "No of Doors:";
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(157, 55);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(100, 26);
            this.txtEngineSize.TabIndex = 3;
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(7, 58);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(98, 19);
            this.lblEngineSize.TabIndex = 2;
            this.lblEngineSize.Text = "Engine Size:";
            // 
            // txtModelPrice
            // 
            this.txtModelPrice.Location = new System.Drawing.Point(157, 25);
            this.txtModelPrice.Name = "txtModelPrice";
            this.txtModelPrice.Size = new System.Drawing.Size(100, 26);
            this.txtModelPrice.TabIndex = 1;
            // 
            // lblModelPrice
            // 
            this.lblModelPrice.AutoSize = true;
            this.lblModelPrice.Location = new System.Drawing.Point(6, 28);
            this.lblModelPrice.Name = "lblModelPrice";
            this.lblModelPrice.Size = new System.Drawing.Size(51, 19);
            this.lblModelPrice.TabIndex = 0;
            this.lblModelPrice.Text = "Price:";
            // 
            // gboCheckDetails
            // 
            this.gboCheckDetails.Controls.Add(this.btnCancel);
            this.gboCheckDetails.Controls.Add(this.btnCommitChanges);
            this.gboCheckDetails.Controls.Add(this.lblConfirmYear);
            this.gboCheckDetails.Controls.Add(this.lblConfirmEmissions);
            this.gboCheckDetails.Controls.Add(this.lblConfirmDrive);
            this.gboCheckDetails.Controls.Add(this.lblConfirmMPG);
            this.gboCheckDetails.Controls.Add(this.lblConfirmTransmission);
            this.gboCheckDetails.Controls.Add(this.lblConfirmFuel);
            this.gboCheckDetails.Controls.Add(this.lblConfirmDoors);
            this.gboCheckDetails.Controls.Add(this.lblConfirmEngine);
            this.gboCheckDetails.Controls.Add(this.lblConfirmPrice);
            this.gboCheckDetails.Controls.Add(this.label11);
            this.gboCheckDetails.Controls.Add(this.label10);
            this.gboCheckDetails.Controls.Add(this.label9);
            this.gboCheckDetails.Controls.Add(this.label8);
            this.gboCheckDetails.Controls.Add(this.label7);
            this.gboCheckDetails.Controls.Add(this.label6);
            this.gboCheckDetails.Controls.Add(this.label5);
            this.gboCheckDetails.Controls.Add(this.label4);
            this.gboCheckDetails.Controls.Add(this.label3);
            this.gboCheckDetails.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboCheckDetails.Location = new System.Drawing.Point(713, 154);
            this.gboCheckDetails.Name = "gboCheckDetails";
            this.gboCheckDetails.Size = new System.Drawing.Size(356, 370);
            this.gboCheckDetails.TabIndex = 4;
            this.gboCheckDetails.TabStop = false;
            this.gboCheckDetails.Text = "Confirm Details";
            this.gboCheckDetails.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(213, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 32);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel and Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommitChanges
            // 
            this.btnCommitChanges.BackColor = System.Drawing.Color.DarkGray;
            this.btnCommitChanges.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCommitChanges.ForeColor = System.Drawing.Color.White;
            this.btnCommitChanges.Location = new System.Drawing.Point(6, 324);
            this.btnCommitChanges.Name = "btnCommitChanges";
            this.btnCommitChanges.Size = new System.Drawing.Size(142, 32);
            this.btnCommitChanges.TabIndex = 27;
            this.btnCommitChanges.Text = "Add to Database";
            this.btnCommitChanges.UseVisualStyleBackColor = false;
            this.btnCommitChanges.Click += new System.EventHandler(this.btnCommitChanges_Click);
            // 
            // lblConfirmYear
            // 
            this.lblConfirmYear.AutoSize = true;
            this.lblConfirmYear.Location = new System.Drawing.Point(115, 287);
            this.lblConfirmYear.Name = "lblConfirmYear";
            this.lblConfirmYear.Size = new System.Drawing.Size(45, 19);
            this.lblConfirmYear.TabIndex = 26;
            this.lblConfirmYear.Text = "0000";
            // 
            // lblConfirmEmissions
            // 
            this.lblConfirmEmissions.AutoSize = true;
            this.lblConfirmEmissions.Location = new System.Drawing.Point(115, 251);
            this.lblConfirmEmissions.Name = "lblConfirmEmissions";
            this.lblConfirmEmissions.Size = new System.Drawing.Size(41, 19);
            this.lblConfirmEmissions.TabIndex = 25;
            this.lblConfirmEmissions.Text = "0.00";
            // 
            // lblConfirmDrive
            // 
            this.lblConfirmDrive.AutoSize = true;
            this.lblConfirmDrive.Location = new System.Drawing.Point(115, 220);
            this.lblConfirmDrive.Name = "lblConfirmDrive";
            this.lblConfirmDrive.Size = new System.Drawing.Size(50, 19);
            this.lblConfirmDrive.TabIndex = 24;
            this.lblConfirmDrive.Text = "Drive";
            // 
            // lblConfirmMPG
            // 
            this.lblConfirmMPG.AutoSize = true;
            this.lblConfirmMPG.Location = new System.Drawing.Point(115, 185);
            this.lblConfirmMPG.Name = "lblConfirmMPG";
            this.lblConfirmMPG.Size = new System.Drawing.Size(45, 19);
            this.lblConfirmMPG.TabIndex = 23;
            this.lblConfirmMPG.Text = "MPG";
            // 
            // lblConfirmTransmission
            // 
            this.lblConfirmTransmission.AutoSize = true;
            this.lblConfirmTransmission.Location = new System.Drawing.Point(115, 153);
            this.lblConfirmTransmission.Name = "lblConfirmTransmission";
            this.lblConfirmTransmission.Size = new System.Drawing.Size(104, 19);
            this.lblConfirmTransmission.TabIndex = 22;
            this.lblConfirmTransmission.Text = "Transmission";
            // 
            // lblConfirmFuel
            // 
            this.lblConfirmFuel.AutoSize = true;
            this.lblConfirmFuel.Location = new System.Drawing.Point(115, 125);
            this.lblConfirmFuel.Name = "lblConfirmFuel";
            this.lblConfirmFuel.Size = new System.Drawing.Size(40, 19);
            this.lblConfirmFuel.TabIndex = 21;
            this.lblConfirmFuel.Text = "Fuel";
            // 
            // lblConfirmDoors
            // 
            this.lblConfirmDoors.AutoSize = true;
            this.lblConfirmDoors.Location = new System.Drawing.Point(115, 87);
            this.lblConfirmDoors.Name = "lblConfirmDoors";
            this.lblConfirmDoors.Size = new System.Drawing.Size(18, 19);
            this.lblConfirmDoors.TabIndex = 20;
            this.lblConfirmDoors.Text = "0";
            // 
            // lblConfirmEngine
            // 
            this.lblConfirmEngine.AutoSize = true;
            this.lblConfirmEngine.Location = new System.Drawing.Point(115, 56);
            this.lblConfirmEngine.Name = "lblConfirmEngine";
            this.lblConfirmEngine.Size = new System.Drawing.Size(45, 19);
            this.lblConfirmEngine.TabIndex = 19;
            this.lblConfirmEngine.Text = "0000";
            // 
            // lblConfirmPrice
            // 
            this.lblConfirmPrice.AutoSize = true;
            this.lblConfirmPrice.Location = new System.Drawing.Point(115, 24);
            this.lblConfirmPrice.Name = "lblConfirmPrice";
            this.lblConfirmPrice.Size = new System.Drawing.Size(50, 19);
            this.lblConfirmPrice.TabIndex = 18;
            this.lblConfirmPrice.Text = "£0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Year Built:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Emissions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Drive Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "MPG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Transmission:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fuel Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "No of Doors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price:";
            // 
            // lblConfirmChanges
            // 
            this.lblConfirmChanges.AutoSize = true;
            this.lblConfirmChanges.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblConfirmChanges.Location = new System.Drawing.Point(153, 100);
            this.lblConfirmChanges.Name = "lblConfirmChanges";
            this.lblConfirmChanges.Size = new System.Drawing.Size(238, 19);
            this.lblConfirmChanges.TabIndex = 5;
            this.lblConfirmChanges.Text = "New Model Added to Database";
            this.lblConfirmChanges.Visible = false;
            // 
            // btnMenuReturn
            // 
            this.btnMenuReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenuReturn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnMenuReturn.ForeColor = System.Drawing.Color.White;
            this.btnMenuReturn.Location = new System.Drawing.Point(416, 90);
            this.btnMenuReturn.Name = "btnMenuReturn";
            this.btnMenuReturn.Size = new System.Drawing.Size(152, 34);
            this.btnMenuReturn.TabIndex = 19;
            this.btnMenuReturn.Text = "Return to Menu";
            this.btnMenuReturn.UseVisualStyleBackColor = false;
            this.btnMenuReturn.Click += new System.EventHandler(this.btnMenuReturn_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(590, 100);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(256, 51);
            this.lblAlert.TabIndex = 20;
            this.lblAlert.Text = "lblAlert";
            this.lblAlert.Visible = false;
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblConfirmChanges);
            this.Controls.Add(this.btnMenuReturn);
            this.Controls.Add(this.gboAddDetails);
            this.Controls.Add(this.gboModelChoice);
            this.Controls.Add(this.gboMakeChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboCheckDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddVehicle";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            this.gboMakeChoice.ResumeLayout(false);
            this.gboMakeChoice.PerformLayout();
            this.gboModelChoice.ResumeLayout(false);
            this.gboModelChoice.PerformLayout();
            this.gboAddDetails.ResumeLayout(false);
            this.gboAddDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoors)).EndInit();
            this.gboCheckDetails.ResumeLayout(false);
            this.gboCheckDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboMakeChoice;
        private System.Windows.Forms.Label lblSelectedMake;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnMakeConfirm;
        private System.Windows.Forms.TextBox txtAddNewMake;
        private System.Windows.Forms.ComboBox cboCarMakes;
        private System.Windows.Forms.CheckBox chbNewMake;
        private System.Windows.Forms.CheckBox chbExistingMake;
        private System.Windows.Forms.GroupBox gboModelChoice;
        private System.Windows.Forms.Label lblNewModelSelection;
        private System.Windows.Forms.Label lblNewModel;
        private System.Windows.Forms.Button btnModelConfirm;
        private System.Windows.Forms.TextBox txtAddCarModel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboAddDetails;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.TextBox txtModelPrice;
        private System.Windows.Forms.Label lblModelPrice;
        private System.Windows.Forms.Button btnConfirmDetails;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtEmissions;
        private System.Windows.Forms.Label lblEmissions;
        private System.Windows.Forms.Label lblDriveType;
        private System.Windows.Forms.TextBox txtMPG;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.GroupBox gboCheckDetails;
        private System.Windows.Forms.Label lblConfirmYear;
        private System.Windows.Forms.Label lblConfirmEmissions;
        private System.Windows.Forms.Label lblConfirmDrive;
        private System.Windows.Forms.Label lblConfirmMPG;
        private System.Windows.Forms.Label lblConfirmTransmission;
        private System.Windows.Forms.Label lblConfirmFuel;
        private System.Windows.Forms.Label lblConfirmDoors;
        private System.Windows.Forms.Label lblConfirmEngine;
        private System.Windows.Forms.Label lblConfirmPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommitChanges;
        private System.Windows.Forms.Label lblConfirmChanges;
        private System.Windows.Forms.Button btnMenuReturn;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.ComboBox cboFuelPick;
        private System.Windows.Forms.ComboBox cboTransmissionPick;
        private System.Windows.Forms.ComboBox cboDrivePick;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.NumericUpDown nudDoors;
    }
}