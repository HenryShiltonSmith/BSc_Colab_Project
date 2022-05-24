namespace year3_collaborative_project
{
    partial class frmCustomerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerConfig));
            this.lbl_BasePriceIndicator = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboColour = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblColourCost = new System.Windows.Forms.Label();
            this.btnSubmitColourSelect = new System.Windows.Forms.Button();
            this.clbMods = new System.Windows.Forms.CheckedListBox();
            this.lblModCostInd = new System.Windows.Forms.Label();
            this.lblTotalModPrice = new System.Windows.Forms.Label();
            this.btnConfirmModSelection = new System.Windows.Forms.Button();
            this.lbl_TotalPriceInd = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Index = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_ModelID = new System.Windows.Forms.Label();
            this.lbl_VehicleModel = new System.Windows.Forms.Label();
            this.lbl_VehicleMake = new System.Windows.Forms.Label();
            this.img_SelectionImage = new System.Windows.Forms.PictureBox();
            this.gboFinanceOptions = new System.Windows.Forms.GroupBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblFinanceLength = new System.Windows.Forms.Label();
            this.btnConfirmFinance = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblAPRValue = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.cboFinanceLength = new System.Windows.Forms.ComboBox();
            this.gboMonthlyPayments = new System.Windows.Forms.GroupBox();
            this.lblMonthlyCost = new System.Windows.Forms.Label();
            this.lblMonthlyPayments = new System.Windows.Forms.Label();
            this.lblMonthValue = new System.Windows.Forms.Label();
            this.lblInterestIncluded = new System.Windows.Forms.Label();
            this.lblPriceIncInterest = new System.Windows.Forms.Label();
            this.gboCustConfirm = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.ttpCboColourOptions = new System.Windows.Forms.ToolTip(this.components);
            this.ttpBtnSubmitColour = new System.Windows.Forms.ToolTip(this.components);
            this.ttpClbMods = new System.Windows.Forms.ToolTip(this.components);
            this.ttpBtnConfirmMods = new System.Windows.Forms.ToolTip(this.components);
            this.ttpBasePrice = new System.Windows.Forms.ToolTip(this.components);
            this.ttpModsCost = new System.Windows.Forms.ToolTip(this.components);
            this.ttpSubTotal = new System.Windows.Forms.ToolTip(this.components);
            this.ttpFinanceLength = new System.Windows.Forms.ToolTip(this.components);
            this.ttpConfirmFinanceLength = new System.Windows.Forms.ToolTip(this.components);
            this.ttpTotalPrice = new System.Windows.Forms.ToolTip(this.components);
            this.ttpMonthlyPayments = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_ConfigID = new System.Windows.Forms.Label();
            this.lbl_CustID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_SelectionImage)).BeginInit();
            this.gboFinanceOptions.SuspendLayout();
            this.gboMonthlyPayments.SuspendLayout();
            this.gboCustConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BasePriceIndicator
            // 
            this.lbl_BasePriceIndicator.AutoSize = true;
            this.lbl_BasePriceIndicator.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lbl_BasePriceIndicator.Location = new System.Drawing.Point(360, 130);
            this.lbl_BasePriceIndicator.Name = "lbl_BasePriceIndicator";
            this.lbl_BasePriceIndicator.Size = new System.Drawing.Size(174, 19);
            this.lbl_BasePriceIndicator.TabIndex = 4;
            this.lbl_BasePriceIndicator.Text = "Vehicle Selection Price";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblBasePrice.Location = new System.Drawing.Point(373, 149);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(41, 19);
            this.lblBasePrice.TabIndex = 6;
            this.lblBasePrice.Text = "0.00";
            this.ttpBasePrice.SetToolTip(this.lblBasePrice, "Base Price of Your Chosen Vehicle");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label5.Location = new System.Drawing.Point(99, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Available Colour Options";
            // 
            // cboColour
            // 
            this.cboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColour.Font = new System.Drawing.Font("Rockwell", 12F);
            this.cboColour.FormattingEnabled = true;
            this.cboColour.Location = new System.Drawing.Point(129, 147);
            this.cboColour.Name = "cboColour";
            this.cboColour.Size = new System.Drawing.Size(121, 27);
            this.cboColour.TabIndex = 8;
            this.ttpCboColourOptions.SetToolTip(this.cboColour, "Select a Vehicle Colour");
            this.cboColour.SelectedIndexChanged += new System.EventHandler(this.cboColour_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label6.Location = new System.Drawing.Point(394, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Colour Cost";
            // 
            // lblColourCost
            // 
            this.lblColourCost.AutoSize = true;
            this.lblColourCost.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblColourCost.Location = new System.Drawing.Point(373, 199);
            this.lblColourCost.Name = "lblColourCost";
            this.lblColourCost.Size = new System.Drawing.Size(41, 19);
            this.lblColourCost.TabIndex = 11;
            this.lblColourCost.Text = "0.00";
            // 
            // btnSubmitColourSelect
            // 
            this.btnSubmitColourSelect.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmitColourSelect.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnSubmitColourSelect.ForeColor = System.Drawing.Color.White;
            this.btnSubmitColourSelect.Location = new System.Drawing.Point(88, 180);
            this.btnSubmitColourSelect.Name = "btnSubmitColourSelect";
            this.btnSubmitColourSelect.Size = new System.Drawing.Size(204, 45);
            this.btnSubmitColourSelect.TabIndex = 12;
            this.btnSubmitColourSelect.Text = "Submit Colour Selection";
            this.ttpBtnSubmitColour.SetToolTip(this.btnSubmitColourSelect, "Submit your Colour Selection");
            this.btnSubmitColourSelect.UseVisualStyleBackColor = false;
            this.btnSubmitColourSelect.Click += new System.EventHandler(this.btnSubmitColourSelect_Click);
            // 
            // clbMods
            // 
            this.clbMods.Font = new System.Drawing.Font("Rockwell", 12F);
            this.clbMods.FormattingEnabled = true;
            this.clbMods.Location = new System.Drawing.Point(44, 240);
            this.clbMods.Name = "clbMods";
            this.clbMods.Size = new System.Drawing.Size(286, 340);
            this.clbMods.TabIndex = 13;
            this.ttpClbMods.SetToolTip(this.clbMods, "Select which Modifications you wish to add.");
            this.clbMods.Visible = false;
            this.clbMods.SelectedIndexChanged += new System.EventHandler(this.clbMods_SelectedIndexChanged);
            // 
            // lblModCostInd
            // 
            this.lblModCostInd.AutoSize = true;
            this.lblModCostInd.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblModCostInd.Location = new System.Drawing.Point(373, 225);
            this.lblModCostInd.Name = "lblModCostInd";
            this.lblModCostInd.Size = new System.Drawing.Size(144, 19);
            this.lblModCostInd.TabIndex = 14;
            this.lblModCostInd.Text = "Total Cost of Mods";
            this.lblModCostInd.Visible = false;
            // 
            // lblTotalModPrice
            // 
            this.lblTotalModPrice.AutoSize = true;
            this.lblTotalModPrice.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblTotalModPrice.Location = new System.Drawing.Point(373, 244);
            this.lblTotalModPrice.Name = "lblTotalModPrice";
            this.lblTotalModPrice.Size = new System.Drawing.Size(41, 19);
            this.lblTotalModPrice.TabIndex = 16;
            this.lblTotalModPrice.Text = "0.00";
            this.ttpModsCost.SetToolTip(this.lblTotalModPrice, "Total Cost of the Selected Mods");
            this.lblTotalModPrice.Visible = false;
            this.lblTotalModPrice.TextChanged += new System.EventHandler(this.lblTotalModPrice_TextChanged);
            // 
            // btnConfirmModSelection
            // 
            this.btnConfirmModSelection.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmModSelection.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnConfirmModSelection.ForeColor = System.Drawing.Color.White;
            this.btnConfirmModSelection.Location = new System.Drawing.Point(94, 586);
            this.btnConfirmModSelection.Name = "btnConfirmModSelection";
            this.btnConfirmModSelection.Size = new System.Drawing.Size(198, 28);
            this.btnConfirmModSelection.TabIndex = 17;
            this.btnConfirmModSelection.Text = "Confirm Mod Selection";
            this.ttpBtnConfirmMods.SetToolTip(this.btnConfirmModSelection, "Confirm your selected Modifications");
            this.btnConfirmModSelection.UseVisualStyleBackColor = false;
            this.btnConfirmModSelection.Visible = false;
            this.btnConfirmModSelection.Click += new System.EventHandler(this.btnConfirmModSelection_Click);
            // 
            // lbl_TotalPriceInd
            // 
            this.lbl_TotalPriceInd.AutoSize = true;
            this.lbl_TotalPriceInd.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lbl_TotalPriceInd.Location = new System.Drawing.Point(404, 277);
            this.lbl_TotalPriceInd.Name = "lbl_TotalPriceInd";
            this.lbl_TotalPriceInd.Size = new System.Drawing.Size(86, 19);
            this.lbl_TotalPriceInd.TabIndex = 18;
            this.lbl_TotalPriceInd.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(373, 296);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(41, 19);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "0.00";
            this.ttpSubTotal.SetToolTip(this.lblTotalPrice, "Price inc Vehicle and Modifications");
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(402, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(332, 36);
            this.lbl_Title.TabIndex = 21;
            this.lbl_Title.Text = "Vehicle Configuration";
            // 
            // lbl_Index
            // 
            this.lbl_Index.AutoSize = true;
            this.lbl_Index.Location = new System.Drawing.Point(1094, 9);
            this.lbl_Index.Name = "lbl_Index";
            this.lbl_Index.Size = new System.Drawing.Size(35, 13);
            this.lbl_Index.TabIndex = 22;
            this.lbl_Index.Text = "label1";
            this.lbl_Index.Visible = false;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Gray;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Return.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.Color.Black;
            this.btn_Return.Location = new System.Drawing.Point(12, 12);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(83, 33);
            this.btn_Return.TabIndex = 23;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lbl_ModelID
            // 
            this.lbl_ModelID.AutoSize = true;
            this.lbl_ModelID.Location = new System.Drawing.Point(1053, 9);
            this.lbl_ModelID.Name = "lbl_ModelID";
            this.lbl_ModelID.Size = new System.Drawing.Size(35, 13);
            this.lbl_ModelID.TabIndex = 24;
            this.lbl_ModelID.Text = "label1";
            this.lbl_ModelID.Visible = false;
            // 
            // lbl_VehicleModel
            // 
            this.lbl_VehicleModel.AutoSize = true;
            this.lbl_VehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VehicleModel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleModel.Location = new System.Drawing.Point(132, 82);
            this.lbl_VehicleModel.Name = "lbl_VehicleModel";
            this.lbl_VehicleModel.Size = new System.Drawing.Size(134, 30);
            this.lbl_VehicleModel.TabIndex = 26;
            this.lbl_VehicleModel.Text = "*MODEL*";
            // 
            // lbl_VehicleMake
            // 
            this.lbl_VehicleMake.AutoSize = true;
            this.lbl_VehicleMake.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VehicleMake.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleMake.Location = new System.Drawing.Point(132, 53);
            this.lbl_VehicleMake.Name = "lbl_VehicleMake";
            this.lbl_VehicleMake.Size = new System.Drawing.Size(118, 29);
            this.lbl_VehicleMake.TabIndex = 25;
            this.lbl_VehicleMake.Text = "*MAKE*";
            // 
            // img_SelectionImage
            // 
            this.img_SelectionImage.BackColor = System.Drawing.Color.White;
            this.img_SelectionImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_SelectionImage.BackgroundImage")));
            this.img_SelectionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_SelectionImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_SelectionImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_SelectionImage.Location = new System.Drawing.Point(540, 120);
            this.img_SelectionImage.Name = "img_SelectionImage";
            this.img_SelectionImage.Size = new System.Drawing.Size(589, 494);
            this.img_SelectionImage.TabIndex = 27;
            this.img_SelectionImage.TabStop = false;
            // 
            // gboFinanceOptions
            // 
            this.gboFinanceOptions.Controls.Add(this.lblMonths);
            this.gboFinanceOptions.Controls.Add(this.lblFinanceLength);
            this.gboFinanceOptions.Controls.Add(this.btnConfirmFinance);
            this.gboFinanceOptions.Controls.Add(this.lblPercent);
            this.gboFinanceOptions.Controls.Add(this.lblAPRValue);
            this.gboFinanceOptions.Controls.Add(this.lblAPR);
            this.gboFinanceOptions.Controls.Add(this.cboFinanceLength);
            this.gboFinanceOptions.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboFinanceOptions.Location = new System.Drawing.Point(336, 318);
            this.gboFinanceOptions.Name = "gboFinanceOptions";
            this.gboFinanceOptions.Size = new System.Drawing.Size(198, 154);
            this.gboFinanceOptions.TabIndex = 28;
            this.gboFinanceOptions.TabStop = false;
            this.gboFinanceOptions.Text = "Finance Options";
            this.gboFinanceOptions.Visible = false;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(92, 76);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(62, 19);
            this.lblMonths.TabIndex = 6;
            this.lblMonths.Text = "Months";
            // 
            // lblFinanceLength
            // 
            this.lblFinanceLength.AutoSize = true;
            this.lblFinanceLength.Location = new System.Drawing.Point(5, 40);
            this.lblFinanceLength.Name = "lblFinanceLength";
            this.lblFinanceLength.Size = new System.Drawing.Size(187, 19);
            this.lblFinanceLength.TabIndex = 5;
            this.lblFinanceLength.Text = "Choose Lenth of Finance";
            // 
            // btnConfirmFinance
            // 
            this.btnConfirmFinance.Location = new System.Drawing.Point(22, 125);
            this.btnConfirmFinance.Name = "btnConfirmFinance";
            this.btnConfirmFinance.Size = new System.Drawing.Size(127, 23);
            this.btnConfirmFinance.TabIndex = 4;
            this.btnConfirmFinance.Text = "Confirm Finance";
            this.ttpConfirmFinanceLength.SetToolTip(this.btnConfirmFinance, "Confirm the Length of Your Finance");
            this.btnConfirmFinance.UseVisualStyleBackColor = true;
            this.btnConfirmFinance.Visible = false;
            this.btnConfirmFinance.Click += new System.EventHandler(this.btnConfirmFinance_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(121, 103);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(25, 19);
            this.lblPercent.TabIndex = 3;
            this.lblPercent.Text = "%";
            this.lblPercent.Visible = false;
            // 
            // lblAPRValue
            // 
            this.lblAPRValue.AutoSize = true;
            this.lblAPRValue.Location = new System.Drawing.Point(64, 103);
            this.lblAPRValue.Name = "lblAPRValue";
            this.lblAPRValue.Size = new System.Drawing.Size(51, 19);
            this.lblAPRValue.TabIndex = 2;
            this.lblAPRValue.Text = "Value";
            this.lblAPRValue.Visible = false;
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(20, 103);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(44, 19);
            this.lblAPR.TabIndex = 1;
            this.lblAPR.Text = "APR:";
            this.lblAPR.Visible = false;
            // 
            // cboFinanceLength
            // 
            this.cboFinanceLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFinanceLength.FormattingEnabled = true;
            this.cboFinanceLength.Location = new System.Drawing.Point(24, 73);
            this.cboFinanceLength.Name = "cboFinanceLength";
            this.cboFinanceLength.Size = new System.Drawing.Size(62, 27);
            this.cboFinanceLength.TabIndex = 0;
            this.ttpFinanceLength.SetToolTip(this.cboFinanceLength, "Select the Length (months) of Finance You Require");
            this.cboFinanceLength.SelectedIndexChanged += new System.EventHandler(this.cboFinanceLength_SelectedIndexChanged);
            // 
            // gboMonthlyPayments
            // 
            this.gboMonthlyPayments.Controls.Add(this.lblMonthlyCost);
            this.gboMonthlyPayments.Controls.Add(this.lblMonthlyPayments);
            this.gboMonthlyPayments.Controls.Add(this.lblMonthValue);
            this.gboMonthlyPayments.Controls.Add(this.lblInterestIncluded);
            this.gboMonthlyPayments.Controls.Add(this.lblPriceIncInterest);
            this.gboMonthlyPayments.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboMonthlyPayments.Location = new System.Drawing.Point(336, 480);
            this.gboMonthlyPayments.Name = "gboMonthlyPayments";
            this.gboMonthlyPayments.Size = new System.Drawing.Size(198, 134);
            this.gboMonthlyPayments.TabIndex = 29;
            this.gboMonthlyPayments.TabStop = false;
            this.gboMonthlyPayments.Text = "Monthly Payments";
            this.gboMonthlyPayments.Visible = false;
            // 
            // lblMonthlyCost
            // 
            this.lblMonthlyCost.AutoSize = true;
            this.lblMonthlyCost.Location = new System.Drawing.Point(68, 95);
            this.lblMonthlyCost.Name = "lblMonthlyCost";
            this.lblMonthlyCost.Size = new System.Drawing.Size(41, 19);
            this.lblMonthlyCost.TabIndex = 4;
            this.lblMonthlyCost.Text = "0.00";
            this.ttpMonthlyPayments.SetToolTip(this.lblMonthlyCost, "Cost of Monthly Payments");
            // 
            // lblMonthlyPayments
            // 
            this.lblMonthlyPayments.AutoSize = true;
            this.lblMonthlyPayments.Location = new System.Drawing.Point(26, 64);
            this.lblMonthlyPayments.Name = "lblMonthlyPayments";
            this.lblMonthlyPayments.Size = new System.Drawing.Size(166, 19);
            this.lblMonthlyPayments.TabIndex = 3;
            this.lblMonthlyPayments.Text = "Monthly Payments of:";
            // 
            // lblMonthValue
            // 
            this.lblMonthValue.AutoSize = true;
            this.lblMonthValue.Location = new System.Drawing.Point(6, 64);
            this.lblMonthValue.Name = "lblMonthValue";
            this.lblMonthValue.Size = new System.Drawing.Size(18, 19);
            this.lblMonthValue.TabIndex = 2;
            this.lblMonthValue.Text = "0";
            // 
            // lblInterestIncluded
            // 
            this.lblInterestIncluded.AutoSize = true;
            this.lblInterestIncluded.Location = new System.Drawing.Point(10, 37);
            this.lblInterestIncluded.Name = "lblInterestIncluded";
            this.lblInterestIncluded.Size = new System.Drawing.Size(41, 19);
            this.lblInterestIncluded.TabIndex = 1;
            this.lblInterestIncluded.Text = "0.00";
            this.ttpTotalPrice.SetToolTip(this.lblInterestIncluded, "Total Price for Vehicle and Modifications and Cost of Finance");
            // 
            // lblPriceIncInterest
            // 
            this.lblPriceIncInterest.AutoSize = true;
            this.lblPriceIncInterest.Location = new System.Drawing.Point(7, 20);
            this.lblPriceIncInterest.Name = "lblPriceIncInterest";
            this.lblPriceIncInterest.Size = new System.Drawing.Size(172, 19);
            this.lblPriceIncInterest.TabIndex = 0;
            this.lblPriceIncInterest.Text = "Total Price Inc Interest";
            // 
            // gboCustConfirm
            // 
            this.gboCustConfirm.Controls.Add(this.btnExit);
            this.gboCustConfirm.Controls.Add(this.lblExit);
            this.gboCustConfirm.Controls.Add(this.btnSubmit);
            this.gboCustConfirm.Controls.Add(this.lblSubmit);
            this.gboCustConfirm.Controls.Add(this.btnSave);
            this.gboCustConfirm.Controls.Add(this.lblSave);
            this.gboCustConfirm.Location = new System.Drawing.Point(725, 225);
            this.gboCustConfirm.Name = "gboCustConfirm";
            this.gboCustConfirm.Size = new System.Drawing.Size(251, 256);
            this.gboCustConfirm.TabIndex = 30;
            this.gboCustConfirm.TabStop = false;
            this.gboCustConfirm.Text = "Confirm Selections";
            this.gboCustConfirm.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(72, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(59, 165);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(100, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "Exit Without Saving";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 119);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Location = new System.Drawing.Point(5, 101);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(246, 13);
            this.lblSubmit.TabIndex = 2;
            this.lblSubmit.Text = "Submit Configuration for Callback and Exit to Menu";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(13, 41);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(180, 13);
            this.lblSave.TabIndex = 0;
            this.lblSave.Text = "Save Configuration and Exit to Menu";
            // 
            // ttpCboColourOptions
            // 
            this.ttpCboColourOptions.ToolTipTitle = "Select a Colour";
            // 
            // lbl_ConfigID
            // 
            this.lbl_ConfigID.AutoSize = true;
            this.lbl_ConfigID.Location = new System.Drawing.Point(1012, 9);
            this.lbl_ConfigID.Name = "lbl_ConfigID";
            this.lbl_ConfigID.Size = new System.Drawing.Size(35, 13);
            this.lbl_ConfigID.TabIndex = 31;
            this.lbl_ConfigID.Text = "label1";
            this.lbl_ConfigID.Visible = false;
            // 
            // lbl_CustID
            // 
            this.lbl_CustID.AutoSize = true;
            this.lbl_CustID.Location = new System.Drawing.Point(971, 9);
            this.lbl_CustID.Name = "lbl_CustID";
            this.lbl_CustID.Size = new System.Drawing.Size(35, 13);
            this.lbl_CustID.TabIndex = 32;
            this.lbl_CustID.Text = "label1";
            this.lbl_CustID.Visible = false;
            // 
            // frmCustomerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_CustID);
            this.Controls.Add(this.lbl_ConfigID);
            this.Controls.Add(this.gboCustConfirm);
            this.Controls.Add(this.gboMonthlyPayments);
            this.Controls.Add(this.gboFinanceOptions);
            this.Controls.Add(this.img_SelectionImage);
            this.Controls.Add(this.lbl_VehicleModel);
            this.Controls.Add(this.lbl_VehicleMake);
            this.Controls.Add(this.lbl_ModelID);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_Index);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbl_TotalPriceInd);
            this.Controls.Add(this.btnConfirmModSelection);
            this.Controls.Add(this.lblTotalModPrice);
            this.Controls.Add(this.lblModCostInd);
            this.Controls.Add(this.btnSubmitColourSelect);
            this.Controls.Add(this.lblColourCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboColour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lbl_BasePriceIndicator);
            this.Controls.Add(this.clbMods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerConfig";
            this.Load += new System.EventHandler(this.frmCustomerConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_SelectionImage)).EndInit();
            this.gboFinanceOptions.ResumeLayout(false);
            this.gboFinanceOptions.PerformLayout();
            this.gboMonthlyPayments.ResumeLayout(false);
            this.gboMonthlyPayments.PerformLayout();
            this.gboCustConfirm.ResumeLayout(false);
            this.gboCustConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BasePriceIndicator;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboColour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblColourCost;
        private System.Windows.Forms.Button btnSubmitColourSelect;
        private System.Windows.Forms.CheckedListBox clbMods;
        private System.Windows.Forms.Label lblModCostInd;
        private System.Windows.Forms.Label lblTotalModPrice;
        private System.Windows.Forms.Button btnConfirmModSelection;
        private System.Windows.Forms.Label lbl_TotalPriceInd;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Index;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_ModelID;
        private System.Windows.Forms.Label lbl_VehicleModel;
        private System.Windows.Forms.Label lbl_VehicleMake;
        private System.Windows.Forms.PictureBox img_SelectionImage;
        private System.Windows.Forms.GroupBox gboFinanceOptions;
        private System.Windows.Forms.Button btnConfirmFinance;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblAPRValue;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.ComboBox cboFinanceLength;
        private System.Windows.Forms.Label lblFinanceLength;
        private System.Windows.Forms.GroupBox gboMonthlyPayments;
        private System.Windows.Forms.Label lblInterestIncluded;
        private System.Windows.Forms.Label lblPriceIncInterest;
        private System.Windows.Forms.Label lblMonthlyPayments;
        private System.Windows.Forms.Label lblMonthValue;
        private System.Windows.Forms.Label lblMonthlyCost;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.GroupBox gboCustConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.ToolTip ttpCboColourOptions;
        private System.Windows.Forms.ToolTip ttpBtnSubmitColour;
        private System.Windows.Forms.ToolTip ttpClbMods;
        private System.Windows.Forms.ToolTip ttpBasePrice;
        private System.Windows.Forms.ToolTip ttpModsCost;
        private System.Windows.Forms.ToolTip ttpBtnConfirmMods;
        private System.Windows.Forms.ToolTip ttpSubTotal;
        private System.Windows.Forms.ToolTip ttpConfirmFinanceLength;
        private System.Windows.Forms.ToolTip ttpFinanceLength;
        private System.Windows.Forms.ToolTip ttpMonthlyPayments;
        private System.Windows.Forms.ToolTip ttpTotalPrice;
        private System.Windows.Forms.Label lbl_ConfigID;
        private System.Windows.Forms.Label lbl_CustID;
    }
}