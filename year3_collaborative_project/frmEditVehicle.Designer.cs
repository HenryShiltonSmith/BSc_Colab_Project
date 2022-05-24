namespace year3_collaborative_project
{
    partial class frmEditVehicle
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
            this.gboSelectModel = new System.Windows.Forms.GroupBox();
            this.btnCarChoiceConfirm = new System.Windows.Forms.Button();
            this.cboCarModels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarMakes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboCurrentDetails = new System.Windows.Forms.GroupBox();
            this.nudEditDoors = new System.Windows.Forms.NumericUpDown();
            this.cboEditYear = new System.Windows.Forms.ComboBox();
            this.cboDrive = new System.Windows.Forms.ComboBox();
            this.cboTransmission = new System.Windows.Forms.ComboBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.btnConfirmCancel = new System.Windows.Forms.Button();
            this.lblConfirmCancel2 = new System.Windows.Forms.Label();
            this.lblConfirmCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmEdits = new System.Windows.Forms.Button();
            this.txtEditEmissions = new System.Windows.Forms.TextBox();
            this.txtEditMPG = new System.Windows.Forms.TextBox();
            this.txtEditEngine = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gboConfirmEdits = new System.Windows.Forms.GroupBox();
            this.btnCancelAndMenuReturn = new System.Windows.Forms.Button();
            this.lblConfirmCancel4 = new System.Windows.Forms.Label();
            this.lblConfirmCancel3 = new System.Windows.Forms.Label();
            this.btnCancelAndExit = new System.Windows.Forms.Button();
            this.btnConfirmAndUpdate = new System.Windows.Forms.Button();
            this.lblEditedYear = new System.Windows.Forms.Label();
            this.lblEditedEmissions = new System.Windows.Forms.Label();
            this.lblEditedDriveType = new System.Windows.Forms.Label();
            this.lblEditedMPG = new System.Windows.Forms.Label();
            this.lblEditedTransmission = new System.Windows.Forms.Label();
            this.lblEditedFuel = new System.Windows.Forms.Label();
            this.lblEditedDoors = new System.Windows.Forms.Label();
            this.lblEditedEngine = new System.Windows.Forms.Label();
            this.lblEditedPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblConfirmChanges = new System.Windows.Forms.Label();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gboSelectModel.SuspendLayout();
            this.gboCurrentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditDoors)).BeginInit();
            this.gboConfirmEdits.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Edit Form";
            // 
            // gboSelectModel
            // 
            this.gboSelectModel.Controls.Add(this.btnCarChoiceConfirm);
            this.gboSelectModel.Controls.Add(this.cboCarModels);
            this.gboSelectModel.Controls.Add(this.label3);
            this.gboSelectModel.Controls.Add(this.cboCarMakes);
            this.gboSelectModel.Controls.Add(this.label2);
            this.gboSelectModel.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboSelectModel.Location = new System.Drawing.Point(109, 158);
            this.gboSelectModel.Name = "gboSelectModel";
            this.gboSelectModel.Size = new System.Drawing.Size(262, 237);
            this.gboSelectModel.TabIndex = 1;
            this.gboSelectModel.TabStop = false;
            this.gboSelectModel.Text = "Select Make and Model to Edit";
            // 
            // btnCarChoiceConfirm
            // 
            this.btnCarChoiceConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnCarChoiceConfirm.ForeColor = System.Drawing.Color.White;
            this.btnCarChoiceConfirm.Location = new System.Drawing.Point(60, 120);
            this.btnCarChoiceConfirm.Name = "btnCarChoiceConfirm";
            this.btnCarChoiceConfirm.Size = new System.Drawing.Size(101, 39);
            this.btnCarChoiceConfirm.TabIndex = 4;
            this.btnCarChoiceConfirm.Text = "Confirm";
            this.btnCarChoiceConfirm.UseVisualStyleBackColor = false;
            this.btnCarChoiceConfirm.Visible = false;
            this.btnCarChoiceConfirm.Click += new System.EventHandler(this.btnCarChoiceConfirm_Click);
            // 
            // cboCarModels
            // 
            this.cboCarModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarModels.FormattingEnabled = true;
            this.cboCarModels.Location = new System.Drawing.Point(60, 84);
            this.cboCarModels.Name = "cboCarModels";
            this.cboCarModels.Size = new System.Drawing.Size(121, 27);
            this.cboCarModels.TabIndex = 3;
            this.cboCarModels.SelectedIndexChanged += new System.EventHandler(this.cboCarModels_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // cboCarMakes
            // 
            this.cboCarMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarMakes.FormattingEnabled = true;
            this.cboCarMakes.Location = new System.Drawing.Point(60, 29);
            this.cboCarMakes.Name = "cboCarMakes";
            this.cboCarMakes.Size = new System.Drawing.Size(121, 27);
            this.cboCarMakes.TabIndex = 1;
            this.cboCarMakes.SelectedIndexChanged += new System.EventHandler(this.cboCarMakes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Make:";
            // 
            // gboCurrentDetails
            // 
            this.gboCurrentDetails.Controls.Add(this.nudEditDoors);
            this.gboCurrentDetails.Controls.Add(this.cboEditYear);
            this.gboCurrentDetails.Controls.Add(this.cboDrive);
            this.gboCurrentDetails.Controls.Add(this.cboTransmission);
            this.gboCurrentDetails.Controls.Add(this.cboFuel);
            this.gboCurrentDetails.Controls.Add(this.btnConfirmCancel);
            this.gboCurrentDetails.Controls.Add(this.lblConfirmCancel2);
            this.gboCurrentDetails.Controls.Add(this.lblConfirmCancel);
            this.gboCurrentDetails.Controls.Add(this.btnCancel);
            this.gboCurrentDetails.Controls.Add(this.btnConfirmEdits);
            this.gboCurrentDetails.Controls.Add(this.txtEditEmissions);
            this.gboCurrentDetails.Controls.Add(this.txtEditMPG);
            this.gboCurrentDetails.Controls.Add(this.txtEditEngine);
            this.gboCurrentDetails.Controls.Add(this.label12);
            this.gboCurrentDetails.Controls.Add(this.label11);
            this.gboCurrentDetails.Controls.Add(this.label10);
            this.gboCurrentDetails.Controls.Add(this.label9);
            this.gboCurrentDetails.Controls.Add(this.label8);
            this.gboCurrentDetails.Controls.Add(this.label7);
            this.gboCurrentDetails.Controls.Add(this.label6);
            this.gboCurrentDetails.Controls.Add(this.label5);
            this.gboCurrentDetails.Controls.Add(this.txtEditPrice);
            this.gboCurrentDetails.Controls.Add(this.label4);
            this.gboCurrentDetails.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboCurrentDetails.Location = new System.Drawing.Point(398, 158);
            this.gboCurrentDetails.Name = "gboCurrentDetails";
            this.gboCurrentDetails.Size = new System.Drawing.Size(350, 436);
            this.gboCurrentDetails.TabIndex = 2;
            this.gboCurrentDetails.TabStop = false;
            this.gboCurrentDetails.Text = "Edit Current Details";
            this.gboCurrentDetails.Visible = false;
            // 
            // nudEditDoors
            // 
            this.nudEditDoors.Location = new System.Drawing.Point(182, 81);
            this.nudEditDoors.Margin = new System.Windows.Forms.Padding(2);
            this.nudEditDoors.Name = "nudEditDoors";
            this.nudEditDoors.ReadOnly = true;
            this.nudEditDoors.Size = new System.Drawing.Size(99, 26);
            this.nudEditDoors.TabIndex = 27;
            // 
            // cboEditYear
            // 
            this.cboEditYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditYear.FormattingEnabled = true;
            this.cboEditYear.Location = new System.Drawing.Point(182, 239);
            this.cboEditYear.Name = "cboEditYear";
            this.cboEditYear.Size = new System.Drawing.Size(100, 27);
            this.cboEditYear.TabIndex = 26;
            // 
            // cboDrive
            // 
            this.cboDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrive.FormattingEnabled = true;
            this.cboDrive.Items.AddRange(new object[] {
            "4 Wheel ",
            "Rear Wheel",
            "Front Wheel"});
            this.cboDrive.Location = new System.Drawing.Point(182, 185);
            this.cboDrive.Name = "cboDrive";
            this.cboDrive.Size = new System.Drawing.Size(100, 27);
            this.cboDrive.TabIndex = 25;
            // 
            // cboTransmission
            // 
            this.cboTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransmission.FormattingEnabled = true;
            this.cboTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.cboTransmission.Location = new System.Drawing.Point(182, 133);
            this.cboTransmission.Name = "cboTransmission";
            this.cboTransmission.Size = new System.Drawing.Size(100, 27);
            this.cboTransmission.TabIndex = 24;
            // 
            // cboFuel
            // 
            this.cboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.cboFuel.Location = new System.Drawing.Point(182, 108);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(100, 27);
            this.cboFuel.TabIndex = 23;
            // 
            // btnConfirmCancel
            // 
            this.btnConfirmCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCancel.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCancel.Location = new System.Drawing.Point(110, 372);
            this.btnConfirmCancel.Name = "btnConfirmCancel";
            this.btnConfirmCancel.Size = new System.Drawing.Size(86, 32);
            this.btnConfirmCancel.TabIndex = 22;
            this.btnConfirmCancel.Text = "Confirm Cancel";
            this.btnConfirmCancel.UseVisualStyleBackColor = false;
            this.btnConfirmCancel.Visible = false;
            this.btnConfirmCancel.Click += new System.EventHandler(this.btnConfirmCancel_Click);
            // 
            // lblConfirmCancel2
            // 
            this.lblConfirmCancel2.AutoSize = true;
            this.lblConfirmCancel2.Location = new System.Drawing.Point(0, 350);
            this.lblConfirmCancel2.Name = "lblConfirmCancel2";
            this.lblConfirmCancel2.Size = new System.Drawing.Size(316, 19);
            this.lblConfirmCancel2.TabIndex = 21;
            this.lblConfirmCancel2.Text = "No changes will be made to the Database.";
            this.lblConfirmCancel2.Visible = false;
            // 
            // lblConfirmCancel
            // 
            this.lblConfirmCancel.AutoSize = true;
            this.lblConfirmCancel.Location = new System.Drawing.Point(40, 331);
            this.lblConfirmCancel.Name = "lblConfirmCancel";
            this.lblConfirmCancel.Size = new System.Drawing.Size(250, 19);
            this.lblConfirmCancel.TabIndex = 20;
            this.lblConfirmCancel.Text = "Are you sure you want to cancel?";
            this.lblConfirmCancel.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(156, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel Editing";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmEdits
            // 
            this.btnConfirmEdits.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmEdits.ForeColor = System.Drawing.Color.White;
            this.btnConfirmEdits.Location = new System.Drawing.Point(17, 287);
            this.btnConfirmEdits.Name = "btnConfirmEdits";
            this.btnConfirmEdits.Size = new System.Drawing.Size(85, 32);
            this.btnConfirmEdits.TabIndex = 18;
            this.btnConfirmEdits.Text = "Confirm Edits";
            this.btnConfirmEdits.UseVisualStyleBackColor = false;
            this.btnConfirmEdits.Click += new System.EventHandler(this.btnConfirmEdits_Click);
            // 
            // txtEditEmissions
            // 
            this.txtEditEmissions.Location = new System.Drawing.Point(182, 211);
            this.txtEditEmissions.Name = "txtEditEmissions";
            this.txtEditEmissions.Size = new System.Drawing.Size(100, 26);
            this.txtEditEmissions.TabIndex = 16;
            // 
            // txtEditMPG
            // 
            this.txtEditMPG.Location = new System.Drawing.Point(182, 159);
            this.txtEditMPG.Name = "txtEditMPG";
            this.txtEditMPG.Size = new System.Drawing.Size(100, 26);
            this.txtEditMPG.TabIndex = 14;
            // 
            // txtEditEngine
            // 
            this.txtEditEngine.Location = new System.Drawing.Point(182, 55);
            this.txtEditEngine.Name = "txtEditEngine";
            this.txtEditEngine.Size = new System.Drawing.Size(100, 26);
            this.txtEditEngine.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Edit Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Edit Emissions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Edit Drive Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Edit MPG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Edit Transmission Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edit Fuel Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Edit No of Doors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Edit Engine Size:";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(182, 29);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(100, 26);
            this.txtEditPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edit Price:";
            // 
            // gboConfirmEdits
            // 
            this.gboConfirmEdits.Controls.Add(this.btnCancelAndMenuReturn);
            this.gboConfirmEdits.Controls.Add(this.lblConfirmCancel4);
            this.gboConfirmEdits.Controls.Add(this.lblConfirmCancel3);
            this.gboConfirmEdits.Controls.Add(this.btnCancelAndExit);
            this.gboConfirmEdits.Controls.Add(this.btnConfirmAndUpdate);
            this.gboConfirmEdits.Controls.Add(this.lblEditedYear);
            this.gboConfirmEdits.Controls.Add(this.lblEditedEmissions);
            this.gboConfirmEdits.Controls.Add(this.lblEditedDriveType);
            this.gboConfirmEdits.Controls.Add(this.lblEditedMPG);
            this.gboConfirmEdits.Controls.Add(this.lblEditedTransmission);
            this.gboConfirmEdits.Controls.Add(this.lblEditedFuel);
            this.gboConfirmEdits.Controls.Add(this.lblEditedDoors);
            this.gboConfirmEdits.Controls.Add(this.lblEditedEngine);
            this.gboConfirmEdits.Controls.Add(this.lblEditedPrice);
            this.gboConfirmEdits.Controls.Add(this.label21);
            this.gboConfirmEdits.Controls.Add(this.label20);
            this.gboConfirmEdits.Controls.Add(this.label19);
            this.gboConfirmEdits.Controls.Add(this.label18);
            this.gboConfirmEdits.Controls.Add(this.label17);
            this.gboConfirmEdits.Controls.Add(this.label16);
            this.gboConfirmEdits.Controls.Add(this.label15);
            this.gboConfirmEdits.Controls.Add(this.label14);
            this.gboConfirmEdits.Controls.Add(this.label13);
            this.gboConfirmEdits.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboConfirmEdits.Location = new System.Drawing.Point(404, 158);
            this.gboConfirmEdits.Name = "gboConfirmEdits";
            this.gboConfirmEdits.Size = new System.Drawing.Size(359, 427);
            this.gboConfirmEdits.TabIndex = 3;
            this.gboConfirmEdits.TabStop = false;
            this.gboConfirmEdits.Text = "Confirm Edits";
            this.gboConfirmEdits.Visible = false;
            // 
            // btnCancelAndMenuReturn
            // 
            this.btnCancelAndMenuReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelAndMenuReturn.ForeColor = System.Drawing.Color.White;
            this.btnCancelAndMenuReturn.Location = new System.Drawing.Point(120, 372);
            this.btnCancelAndMenuReturn.Name = "btnCancelAndMenuReturn";
            this.btnCancelAndMenuReturn.Size = new System.Drawing.Size(98, 32);
            this.btnCancelAndMenuReturn.TabIndex = 23;
            this.btnCancelAndMenuReturn.Text = "Cancel and Exit";
            this.btnCancelAndMenuReturn.UseVisualStyleBackColor = false;
            this.btnCancelAndMenuReturn.Click += new System.EventHandler(this.btnCancelAndMenuReturn_Click);
            // 
            // lblConfirmCancel4
            // 
            this.lblConfirmCancel4.AutoSize = true;
            this.lblConfirmCancel4.Location = new System.Drawing.Point(29, 350);
            this.lblConfirmCancel4.Name = "lblConfirmCancel4";
            this.lblConfirmCancel4.Size = new System.Drawing.Size(316, 19);
            this.lblConfirmCancel4.TabIndex = 22;
            this.lblConfirmCancel4.Text = "No changes will be made to the Database.";
            this.lblConfirmCancel4.Visible = false;
            // 
            // lblConfirmCancel3
            // 
            this.lblConfirmCancel3.AutoSize = true;
            this.lblConfirmCancel3.Location = new System.Drawing.Point(49, 331);
            this.lblConfirmCancel3.Name = "lblConfirmCancel3";
            this.lblConfirmCancel3.Size = new System.Drawing.Size(250, 19);
            this.lblConfirmCancel3.TabIndex = 21;
            this.lblConfirmCancel3.Text = "Are you sure you want to cancel?";
            this.lblConfirmCancel3.Visible = false;
            // 
            // btnCancelAndExit
            // 
            this.btnCancelAndExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelAndExit.ForeColor = System.Drawing.Color.White;
            this.btnCancelAndExit.Location = new System.Drawing.Point(247, 287);
            this.btnCancelAndExit.Name = "btnCancelAndExit";
            this.btnCancelAndExit.Size = new System.Drawing.Size(98, 32);
            this.btnCancelAndExit.TabIndex = 19;
            this.btnCancelAndExit.Text = "Cancel and Exit";
            this.btnCancelAndExit.UseVisualStyleBackColor = false;
            this.btnCancelAndExit.Click += new System.EventHandler(this.btnCancelAndExit_Click);
            // 
            // btnConfirmAndUpdate
            // 
            this.btnConfirmAndUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmAndUpdate.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAndUpdate.Location = new System.Drawing.Point(32, 287);
            this.btnConfirmAndUpdate.Name = "btnConfirmAndUpdate";
            this.btnConfirmAndUpdate.Size = new System.Drawing.Size(186, 32);
            this.btnConfirmAndUpdate.TabIndex = 18;
            this.btnConfirmAndUpdate.Text = "Confirm And Update";
            this.btnConfirmAndUpdate.UseVisualStyleBackColor = false;
            this.btnConfirmAndUpdate.Click += new System.EventHandler(this.btnConfirmAndUpdate_Click);
            // 
            // lblEditedYear
            // 
            this.lblEditedYear.AutoSize = true;
            this.lblEditedYear.Location = new System.Drawing.Point(259, 241);
            this.lblEditedYear.Name = "lblEditedYear";
            this.lblEditedYear.Size = new System.Drawing.Size(45, 19);
            this.lblEditedYear.TabIndex = 17;
            this.lblEditedYear.Text = "2021";
            // 
            // lblEditedEmissions
            // 
            this.lblEditedEmissions.AutoSize = true;
            this.lblEditedEmissions.Location = new System.Drawing.Point(259, 214);
            this.lblEditedEmissions.Name = "lblEditedEmissions";
            this.lblEditedEmissions.Size = new System.Drawing.Size(59, 19);
            this.lblEditedEmissions.TabIndex = 16;
            this.lblEditedEmissions.Text = "132.55";
            // 
            // lblEditedDriveType
            // 
            this.lblEditedDriveType.AutoSize = true;
            this.lblEditedDriveType.Location = new System.Drawing.Point(259, 188);
            this.lblEditedDriveType.Name = "lblEditedDriveType";
            this.lblEditedDriveType.Size = new System.Drawing.Size(99, 19);
            this.lblEditedDriveType.TabIndex = 15;
            this.lblEditedDriveType.Text = "Front Wheel";
            // 
            // lblEditedMPG
            // 
            this.lblEditedMPG.AutoSize = true;
            this.lblEditedMPG.Location = new System.Drawing.Point(259, 162);
            this.lblEditedMPG.Name = "lblEditedMPG";
            this.lblEditedMPG.Size = new System.Drawing.Size(27, 19);
            this.lblEditedMPG.TabIndex = 14;
            this.lblEditedMPG.Text = "39";
            // 
            // lblEditedTransmission
            // 
            this.lblEditedTransmission.AutoSize = true;
            this.lblEditedTransmission.Location = new System.Drawing.Point(259, 136);
            this.lblEditedTransmission.Name = "lblEditedTransmission";
            this.lblEditedTransmission.Size = new System.Drawing.Size(63, 19);
            this.lblEditedTransmission.TabIndex = 13;
            this.lblEditedTransmission.Text = "Manual";
            // 
            // lblEditedFuel
            // 
            this.lblEditedFuel.AutoSize = true;
            this.lblEditedFuel.Location = new System.Drawing.Point(259, 110);
            this.lblEditedFuel.Name = "lblEditedFuel";
            this.lblEditedFuel.Size = new System.Drawing.Size(52, 19);
            this.lblEditedFuel.TabIndex = 12;
            this.lblEditedFuel.Text = "Petrol";
            // 
            // lblEditedDoors
            // 
            this.lblEditedDoors.AutoSize = true;
            this.lblEditedDoors.Location = new System.Drawing.Point(259, 84);
            this.lblEditedDoors.Name = "lblEditedDoors";
            this.lblEditedDoors.Size = new System.Drawing.Size(18, 19);
            this.lblEditedDoors.TabIndex = 11;
            this.lblEditedDoors.Text = "4";
            // 
            // lblEditedEngine
            // 
            this.lblEditedEngine.AutoSize = true;
            this.lblEditedEngine.Location = new System.Drawing.Point(259, 58);
            this.lblEditedEngine.Name = "lblEditedEngine";
            this.lblEditedEngine.Size = new System.Drawing.Size(45, 19);
            this.lblEditedEngine.TabIndex = 10;
            this.lblEditedEngine.Text = "1299";
            // 
            // lblEditedPrice
            // 
            this.lblEditedPrice.AutoSize = true;
            this.lblEditedPrice.Location = new System.Drawing.Point(259, 36);
            this.lblEditedPrice.Name = "lblEditedPrice";
            this.lblEditedPrice.Size = new System.Drawing.Size(50, 19);
            this.lblEditedPrice.TabIndex = 9;
            this.lblEditedPrice.Text = "£0.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 19);
            this.label21.TabIndex = 8;
            this.label21.Text = "Year:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 19);
            this.label20.TabIndex = 7;
            this.label20.Text = "Emissions";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 19);
            this.label19.TabIndex = 6;
            this.label19.Text = "Drive Type:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 19);
            this.label18.TabIndex = 5;
            this.label18.Text = "MPG:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 19);
            this.label17.TabIndex = 4;
            this.label17.Text = "Transmission:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Fuel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Doors:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Engine Size:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Price:";
            // 
            // lblConfirmChanges
            // 
            this.lblConfirmChanges.AutoSize = true;
            this.lblConfirmChanges.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblConfirmChanges.Location = new System.Drawing.Point(129, 96);
            this.lblConfirmChanges.Name = "lblConfirmChanges";
            this.lblConfirmChanges.Size = new System.Drawing.Size(238, 19);
            this.lblConfirmChanges.TabIndex = 6;
            this.lblConfirmChanges.Text = "New Model Added to Database";
            this.lblConfirmChanges.Visible = false;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMenu.Location = new System.Drawing.Point(394, 80);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(121, 51);
            this.btnReturnToMenu.TabIndex = 7;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblAlert.Location = new System.Drawing.Point(521, 96);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(272, 19);
            this.lblAlert.TabIndex = 8;
            this.lblAlert.Text = "Please fill in all required information";
            this.lblAlert.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(12, 555);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 51);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.lblConfirmChanges);
            this.Controls.Add(this.gboConfirmEdits);
            this.Controls.Add(this.gboCurrentDetails);
            this.Controls.Add(this.gboSelectModel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditVehicle";
            this.Load += new System.EventHandler(this.frmEditVehicle_Load);
            this.gboSelectModel.ResumeLayout(false);
            this.gboSelectModel.PerformLayout();
            this.gboCurrentDetails.ResumeLayout(false);
            this.gboCurrentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditDoors)).EndInit();
            this.gboConfirmEdits.ResumeLayout(false);
            this.gboConfirmEdits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboSelectModel;
        private System.Windows.Forms.Button btnCarChoiceConfirm;
        private System.Windows.Forms.ComboBox cboCarModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarMakes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboCurrentDetails;
        private System.Windows.Forms.Button btnConfirmCancel;
        private System.Windows.Forms.Label lblConfirmCancel2;
        private System.Windows.Forms.Label lblConfirmCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmEdits;
        private System.Windows.Forms.TextBox txtEditEmissions;
        private System.Windows.Forms.TextBox txtEditMPG;
        private System.Windows.Forms.TextBox txtEditEngine;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboConfirmEdits;
        private System.Windows.Forms.Label lblEditedYear;
        private System.Windows.Forms.Label lblEditedEmissions;
        private System.Windows.Forms.Label lblEditedDriveType;
        private System.Windows.Forms.Label lblEditedMPG;
        private System.Windows.Forms.Label lblEditedTransmission;
        private System.Windows.Forms.Label lblEditedFuel;
        private System.Windows.Forms.Label lblEditedDoors;
        private System.Windows.Forms.Label lblEditedEngine;
        private System.Windows.Forms.Label lblEditedPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancelAndExit;
        private System.Windows.Forms.Button btnConfirmAndUpdate;
        private System.Windows.Forms.Button btnCancelAndMenuReturn;
        private System.Windows.Forms.Label lblConfirmCancel4;
        private System.Windows.Forms.Label lblConfirmCancel3;
        private System.Windows.Forms.Label lblConfirmChanges;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.ComboBox cboDrive;
        private System.Windows.Forms.ComboBox cboTransmission;
        private System.Windows.Forms.ComboBox cboEditYear;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.NumericUpDown nudEditDoors;
        private System.Windows.Forms.Button btnReturn;
    }
}