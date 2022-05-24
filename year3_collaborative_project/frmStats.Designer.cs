namespace year3_collaborative_project
{
    partial class frmStats
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
            this.btnCarStats = new System.Windows.Forms.Button();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelCount = new System.Windows.Forms.Label();
            this.lblModelSum = new System.Windows.Forms.Label();
            this.gboPopular = new System.Windows.Forms.GroupBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblNumberSold = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.gboLeastPopular = new System.Windows.Forms.GroupBox();
            this.lblModelSumLeast = new System.Windows.Forms.Label();
            this.lblModelCountLeast = new System.Windows.Forms.Label();
            this.lblModelNameLeast = new System.Windows.Forms.Label();
            this.lblLeastTotal = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblModelLeast = new System.Windows.Forms.Label();
            this.btnSalesman = new System.Windows.Forms.Button();
            this.btnInvoiceStats = new System.Windows.Forms.Button();
            this.btnDownloadCar = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInvoiceStats = new System.Windows.Forms.GroupBox();
            this.btnDownloadInvoiceStats = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalCompletePrice = new System.Windows.Forms.Label();
            this.lblTotalIncompletePrice = new System.Windows.Forms.Label();
            this.lblIncomplete = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.ddl_Salesmen = new System.Windows.Forms.ComboBox();
            this.ddl_SID = new System.Windows.Forms.ComboBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbo_Sales = new System.Windows.Forms.GroupBox();
            this.lbl_SalesIncompleteInd = new System.Windows.Forms.Label();
            this.lbl_SalesIncomplete = new System.Windows.Forms.Label();
            this.lbl_SalesCompleted = new System.Windows.Forms.Label();
            this.lbl_SalesCompletedInd = new System.Windows.Forms.Label();
            this.lbl_SalesTotal = new System.Windows.Forms.Label();
            this.lbl_SalesTotalInd = new System.Windows.Forms.Label();
            this.btn_DownloadSales = new System.Windows.Forms.Button();
            this.gboPopular.SuspendLayout();
            this.gboLeastPopular.SuspendLayout();
            this.gbInvoiceStats.SuspendLayout();
            this.gbo_Sales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarStats
            // 
            this.btnCarStats.BackColor = System.Drawing.Color.DarkGray;
            this.btnCarStats.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnCarStats.ForeColor = System.Drawing.Color.White;
            this.btnCarStats.Location = new System.Drawing.Point(139, 48);
            this.btnCarStats.Name = "btnCarStats";
            this.btnCarStats.Size = new System.Drawing.Size(129, 40);
            this.btnCarStats.TabIndex = 0;
            this.btnCarStats.Text = "Car Sales Stats";
            this.btnCarStats.UseVisualStyleBackColor = false;
            this.btnCarStats.Click += new System.EventHandler(this.btnCarStats_Click);
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(182, 25);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(103, 19);
            this.lblModelName.TabIndex = 1;
            this.lblModelName.Text = "Model Name";
            // 
            // lblModelCount
            // 
            this.lblModelCount.AutoSize = true;
            this.lblModelCount.Location = new System.Drawing.Point(182, 50);
            this.lblModelCount.Name = "lblModelCount";
            this.lblModelCount.Size = new System.Drawing.Size(103, 19);
            this.lblModelCount.TabIndex = 2;
            this.lblModelCount.Text = "Model Count";
            // 
            // lblModelSum
            // 
            this.lblModelSum.AutoSize = true;
            this.lblModelSum.Location = new System.Drawing.Point(182, 74);
            this.lblModelSum.Name = "lblModelSum";
            this.lblModelSum.Size = new System.Drawing.Size(91, 19);
            this.lblModelSum.TabIndex = 3;
            this.lblModelSum.Text = "Model Sum";
            // 
            // gboPopular
            // 
            this.gboPopular.Controls.Add(this.groupBox1);
            this.gboPopular.Controls.Add(this.lblTotalSales);
            this.gboPopular.Controls.Add(this.lblNumberSold);
            this.gboPopular.Controls.Add(this.lblModel);
            this.gboPopular.Controls.Add(this.lblModelName);
            this.gboPopular.Controls.Add(this.lblModelSum);
            this.gboPopular.Controls.Add(this.lblModelCount);
            this.gboPopular.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboPopular.Location = new System.Drawing.Point(-100, 130);
            this.gboPopular.Margin = new System.Windows.Forms.Padding(4);
            this.gboPopular.Name = "gboPopular";
            this.gboPopular.Padding = new System.Windows.Forms.Padding(4);
            this.gboPopular.Size = new System.Drawing.Size(414, 120);
            this.gboPopular.TabIndex = 4;
            this.gboPopular.TabStop = false;
            this.gboPopular.Text = "Most Popular Model";
            this.gboPopular.Visible = false;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(6, 74);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(142, 19);
            this.lblTotalSales.TabIndex = 6;
            this.lblTotalSales.Text = "Total Model Sales:";
            // 
            // lblNumberSold
            // 
            this.lblNumberSold.AutoSize = true;
            this.lblNumberSold.Location = new System.Drawing.Point(6, 50);
            this.lblNumberSold.Name = "lblNumberSold";
            this.lblNumberSold.Size = new System.Drawing.Size(166, 19);
            this.lblNumberSold.TabIndex = 5;
            this.lblNumberSold.Text = "No of this model sold:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 25);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(160, 19);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Most Popular Model:";
            // 
            // gboLeastPopular
            // 
            this.gboLeastPopular.Controls.Add(this.lblModelSumLeast);
            this.gboLeastPopular.Controls.Add(this.lblModelCountLeast);
            this.gboLeastPopular.Controls.Add(this.lblModelNameLeast);
            this.gboLeastPopular.Controls.Add(this.lblLeastTotal);
            this.gboLeastPopular.Controls.Add(this.lblSold);
            this.gboLeastPopular.Controls.Add(this.lblModelLeast);
            this.gboLeastPopular.Font = new System.Drawing.Font("Rockwell", 12F);
            this.gboLeastPopular.Location = new System.Drawing.Point(-100, 247);
            this.gboLeastPopular.Margin = new System.Windows.Forms.Padding(4);
            this.gboLeastPopular.Name = "gboLeastPopular";
            this.gboLeastPopular.Size = new System.Drawing.Size(421, 116);
            this.gboLeastPopular.TabIndex = 5;
            this.gboLeastPopular.TabStop = false;
            this.gboLeastPopular.Text = "Least popular Model";
            this.gboLeastPopular.Visible = false;
            // 
            // lblModelSumLeast
            // 
            this.lblModelSumLeast.AutoSize = true;
            this.lblModelSumLeast.Location = new System.Drawing.Point(182, 90);
            this.lblModelSumLeast.Name = "lblModelSumLeast";
            this.lblModelSumLeast.Size = new System.Drawing.Size(91, 19);
            this.lblModelSumLeast.TabIndex = 5;
            this.lblModelSumLeast.Text = "Model Sum";
            // 
            // lblModelCountLeast
            // 
            this.lblModelCountLeast.AutoSize = true;
            this.lblModelCountLeast.Location = new System.Drawing.Point(182, 60);
            this.lblModelCountLeast.Name = "lblModelCountLeast";
            this.lblModelCountLeast.Size = new System.Drawing.Size(103, 19);
            this.lblModelCountLeast.TabIndex = 4;
            this.lblModelCountLeast.Text = "Model Count";
            // 
            // lblModelNameLeast
            // 
            this.lblModelNameLeast.AutoSize = true;
            this.lblModelNameLeast.Location = new System.Drawing.Point(182, 31);
            this.lblModelNameLeast.Name = "lblModelNameLeast";
            this.lblModelNameLeast.Size = new System.Drawing.Size(103, 19);
            this.lblModelNameLeast.TabIndex = 3;
            this.lblModelNameLeast.Text = "Model Name";
            // 
            // lblLeastTotal
            // 
            this.lblLeastTotal.AutoSize = true;
            this.lblLeastTotal.Location = new System.Drawing.Point(6, 90);
            this.lblLeastTotal.Name = "lblLeastTotal";
            this.lblLeastTotal.Size = new System.Drawing.Size(142, 19);
            this.lblLeastTotal.TabIndex = 2;
            this.lblLeastTotal.Text = "Total Model Sales:";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(6, 60);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(166, 19);
            this.lblSold.TabIndex = 1;
            this.lblSold.Text = "No of this Model sold:";
            // 
            // lblModelLeast
            // 
            this.lblModelLeast.AutoSize = true;
            this.lblModelLeast.Location = new System.Drawing.Point(6, 31);
            this.lblModelLeast.Name = "lblModelLeast";
            this.lblModelLeast.Size = new System.Drawing.Size(163, 19);
            this.lblModelLeast.TabIndex = 0;
            this.lblModelLeast.Text = "Least Popular Model:";
            // 
            // btnSalesman
            // 
            this.btnSalesman.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalesman.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnSalesman.ForeColor = System.Drawing.Color.White;
            this.btnSalesman.Location = new System.Drawing.Point(482, 48);
            this.btnSalesman.Name = "btnSalesman";
            this.btnSalesman.Size = new System.Drawing.Size(138, 40);
            this.btnSalesman.TabIndex = 6;
            this.btnSalesman.Text = "Salesman Stats";
            this.btnSalesman.UseVisualStyleBackColor = false;
            this.btnSalesman.Click += new System.EventHandler(this.btnSalesman_Click);
            // 
            // btnInvoiceStats
            // 
            this.btnInvoiceStats.BackColor = System.Drawing.Color.DarkGray;
            this.btnInvoiceStats.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnInvoiceStats.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceStats.Location = new System.Drawing.Point(874, 48);
            this.btnInvoiceStats.Name = "btnInvoiceStats";
            this.btnInvoiceStats.Size = new System.Drawing.Size(130, 40);
            this.btnInvoiceStats.TabIndex = 7;
            this.btnInvoiceStats.Text = "Invoice Stats";
            this.btnInvoiceStats.UseVisualStyleBackColor = false;
            this.btnInvoiceStats.Click += new System.EventHandler(this.btnInvoiceStats_Click);
            // 
            // btnDownloadCar
            // 
            this.btnDownloadCar.BackColor = System.Drawing.Color.DarkGray;
            this.btnDownloadCar.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnDownloadCar.ForeColor = System.Drawing.Color.White;
            this.btnDownloadCar.Location = new System.Drawing.Point(26, 398);
            this.btnDownloadCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadCar.Name = "btnDownloadCar";
            this.btnDownloadCar.Size = new System.Drawing.Size(121, 49);
            this.btnDownloadCar.TabIndex = 8;
            this.btnDownloadCar.Text = "Download Car Stats";
            this.btnDownloadCar.UseVisualStyleBackColor = false;
            this.btnDownloadCar.Visible = false;
            this.btnDownloadCar.Click += new System.EventHandler(this.btnDownloadCar_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(12, 558);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 48);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return To Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(478, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 36);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Statistics";
            // 
            // gbInvoiceStats
            // 
            this.gbInvoiceStats.Controls.Add(this.btnDownloadInvoiceStats);
            this.gbInvoiceStats.Controls.Add(this.lblTotalAmount);
            this.gbInvoiceStats.Controls.Add(this.lblTotalPrice);
            this.gbInvoiceStats.Controls.Add(this.lblTotalCompletePrice);
            this.gbInvoiceStats.Controls.Add(this.lblTotalIncompletePrice);
            this.gbInvoiceStats.Controls.Add(this.lblIncomplete);
            this.gbInvoiceStats.Controls.Add(this.lblComplete);
            this.gbInvoiceStats.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvoiceStats.Location = new System.Drawing.Point(810, 117);
            this.gbInvoiceStats.Name = "gbInvoiceStats";
            this.gbInvoiceStats.Size = new System.Drawing.Size(433, 337);
            this.gbInvoiceStats.TabIndex = 11;
            this.gbInvoiceStats.TabStop = false;
            this.gbInvoiceStats.Text = "Invoice Statistics";
            this.gbInvoiceStats.Visible = false;
            // 
            // btnDownloadInvoiceStats
            // 
            this.btnDownloadInvoiceStats.BackColor = System.Drawing.Color.DarkGray;
            this.btnDownloadInvoiceStats.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnDownloadInvoiceStats.ForeColor = System.Drawing.Color.White;
            this.btnDownloadInvoiceStats.Location = new System.Drawing.Point(0, 218);
            this.btnDownloadInvoiceStats.Name = "btnDownloadInvoiceStats";
            this.btnDownloadInvoiceStats.Size = new System.Drawing.Size(140, 49);
            this.btnDownloadInvoiceStats.TabIndex = 9;
            this.btnDownloadInvoiceStats.Text = "Download Invoice Stats";
            this.btnDownloadInvoiceStats.UseVisualStyleBackColor = false;
            this.btnDownloadInvoiceStats.Visible = false;
            this.btnDownloadInvoiceStats.Click += new System.EventHandler(this.btnDownloadInvoiceStats_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(7, 96);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(119, 17);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(7, 197);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(101, 17);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "lblTotalPrice";
            // 
            // lblTotalCompletePrice
            // 
            this.lblTotalCompletePrice.AutoSize = true;
            this.lblTotalCompletePrice.Location = new System.Drawing.Point(7, 167);
            this.lblTotalCompletePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompletePrice.Name = "lblTotalCompletePrice";
            this.lblTotalCompletePrice.Size = new System.Drawing.Size(171, 17);
            this.lblTotalCompletePrice.TabIndex = 3;
            this.lblTotalCompletePrice.Text = "lblTotalCompletePrice";
            // 
            // lblTotalIncompletePrice
            // 
            this.lblTotalIncompletePrice.AutoSize = true;
            this.lblTotalIncompletePrice.Location = new System.Drawing.Point(7, 132);
            this.lblTotalIncompletePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalIncompletePrice.Name = "lblTotalIncompletePrice";
            this.lblTotalIncompletePrice.Size = new System.Drawing.Size(182, 17);
            this.lblTotalIncompletePrice.TabIndex = 2;
            this.lblTotalIncompletePrice.Text = "lblTotalIncompletePrice";
            // 
            // lblIncomplete
            // 
            this.lblIncomplete.AutoSize = true;
            this.lblIncomplete.Location = new System.Drawing.Point(7, 65);
            this.lblIncomplete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomplete.Name = "lblIncomplete";
            this.lblIncomplete.Size = new System.Drawing.Size(109, 17);
            this.lblIncomplete.TabIndex = 1;
            this.lblIncomplete.Text = "lblIncomplete";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(7, 30);
            this.lblComplete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(98, 17);
            this.lblComplete.TabIndex = 0;
            this.lblComplete.Text = "lblComplete";
            // 
            // ddl_Salesmen
            // 
            this.ddl_Salesmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Salesmen.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_Salesmen.FormattingEnabled = true;
            this.ddl_Salesmen.Location = new System.Drawing.Point(336, 106);
            this.ddl_Salesmen.Name = "ddl_Salesmen";
            this.ddl_Salesmen.Size = new System.Drawing.Size(372, 27);
            this.ddl_Salesmen.TabIndex = 89;
            this.ddl_Salesmen.Visible = false;
            this.ddl_Salesmen.SelectedIndexChanged += new System.EventHandler(this.ddl_Salesmen_SelectedIndexChanged);
            // 
            // ddl_SID
            // 
            this.ddl_SID.FormattingEnabled = true;
            this.ddl_SID.Location = new System.Drawing.Point(336, 79);
            this.ddl_SID.Name = "ddl_SID";
            this.ddl_SID.Size = new System.Drawing.Size(40, 21);
            this.ddl_SID.TabIndex = 92;
            this.ddl_SID.Visible = false;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(102, 402);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(234, 17);
            this.lblAlert.TabIndex = 12;
            this.lblAlert.Text = "Your file has been downloaded.";
            this.lblAlert.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(421, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 323);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbo_Sales
            // 
            this.gbo_Sales.Controls.Add(this.btn_DownloadSales);
            this.gbo_Sales.Controls.Add(this.lbl_SalesTotal);
            this.gbo_Sales.Controls.Add(this.lbl_SalesTotalInd);
            this.gbo_Sales.Controls.Add(this.lbl_SalesCompleted);
            this.gbo_Sales.Controls.Add(this.lbl_SalesCompletedInd);
            this.gbo_Sales.Controls.Add(this.lbl_SalesIncomplete);
            this.gbo_Sales.Controls.Add(this.lbl_SalesIncompleteInd);
            this.gbo_Sales.Location = new System.Drawing.Point(336, 139);
            this.gbo_Sales.Name = "gbo_Sales";
            this.gbo_Sales.Size = new System.Drawing.Size(372, 353);
            this.gbo_Sales.TabIndex = 93;
            this.gbo_Sales.TabStop = false;
            this.gbo_Sales.Visible = false;
            // 
            // lbl_SalesIncompleteInd
            // 
            this.lbl_SalesIncompleteInd.AutoSize = true;
            this.lbl_SalesIncompleteInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesIncompleteInd.Location = new System.Drawing.Point(6, 22);
            this.lbl_SalesIncompleteInd.Name = "lbl_SalesIncompleteInd";
            this.lbl_SalesIncompleteInd.Size = new System.Drawing.Size(250, 19);
            this.lbl_SalesIncompleteInd.TabIndex = 0;
            this.lbl_SalesIncompleteInd.Text = "Number of Outstanding invoices:";
            // 
            // lbl_SalesIncomplete
            // 
            this.lbl_SalesIncomplete.AutoSize = true;
            this.lbl_SalesIncomplete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesIncomplete.Location = new System.Drawing.Point(6, 55);
            this.lbl_SalesIncomplete.Name = "lbl_SalesIncomplete";
            this.lbl_SalesIncomplete.Size = new System.Drawing.Size(86, 19);
            this.lbl_SalesIncomplete.TabIndex = 1;
            this.lbl_SalesIncomplete.Text = "*Number*";
            // 
            // lbl_SalesCompleted
            // 
            this.lbl_SalesCompleted.AutoSize = true;
            this.lbl_SalesCompleted.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesCompleted.Location = new System.Drawing.Point(6, 141);
            this.lbl_SalesCompleted.Name = "lbl_SalesCompleted";
            this.lbl_SalesCompleted.Size = new System.Drawing.Size(90, 19);
            this.lbl_SalesCompleted.TabIndex = 3;
            this.lbl_SalesCompleted.Text = "*Number *";
            // 
            // lbl_SalesCompletedInd
            // 
            this.lbl_SalesCompletedInd.AutoSize = true;
            this.lbl_SalesCompletedInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesCompletedInd.Location = new System.Drawing.Point(6, 108);
            this.lbl_SalesCompletedInd.Name = "lbl_SalesCompletedInd";
            this.lbl_SalesCompletedInd.Size = new System.Drawing.Size(243, 19);
            this.lbl_SalesCompletedInd.TabIndex = 2;
            this.lbl_SalesCompletedInd.Text = "Number of Completed Invoices:";
            // 
            // lbl_SalesTotal
            // 
            this.lbl_SalesTotal.AutoSize = true;
            this.lbl_SalesTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesTotal.Location = new System.Drawing.Point(6, 232);
            this.lbl_SalesTotal.Name = "lbl_SalesTotal";
            this.lbl_SalesTotal.Size = new System.Drawing.Size(90, 19);
            this.lbl_SalesTotal.TabIndex = 5;
            this.lbl_SalesTotal.Text = "*Number *";
            // 
            // lbl_SalesTotalInd
            // 
            this.lbl_SalesTotalInd.AutoSize = true;
            this.lbl_SalesTotalInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesTotalInd.Location = new System.Drawing.Point(6, 199);
            this.lbl_SalesTotalInd.Name = "lbl_SalesTotalInd";
            this.lbl_SalesTotalInd.Size = new System.Drawing.Size(243, 19);
            this.lbl_SalesTotalInd.TabIndex = 4;
            this.lbl_SalesTotalInd.Text = "Number of Completed Invoices:";
            // 
            // btn_DownloadSales
            // 
            this.btn_DownloadSales.BackColor = System.Drawing.Color.DarkGray;
            this.btn_DownloadSales.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btn_DownloadSales.ForeColor = System.Drawing.Color.White;
            this.btn_DownloadSales.Location = new System.Drawing.Point(100, 271);
            this.btn_DownloadSales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DownloadSales.Name = "btn_DownloadSales";
            this.btn_DownloadSales.Size = new System.Drawing.Size(140, 49);
            this.btn_DownloadSales.TabIndex = 10;
            this.btn_DownloadSales.Text = "Download Sales Rep Report";
            this.btn_DownloadSales.UseVisualStyleBackColor = false;
            this.btn_DownloadSales.Click += new System.EventHandler(this.btn_DownloadSales_Click);
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.ControlBox = false;
            this.Controls.Add(this.gbo_Sales);
            this.Controls.Add(this.ddl_SID);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ddl_Salesmen);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDownloadCar);
            this.Controls.Add(this.btnInvoiceStats);
            this.Controls.Add(this.btnSalesman);
            this.Controls.Add(this.gboLeastPopular);
            this.Controls.Add(this.gboPopular);
            this.Controls.Add(this.btnCarStats);
            this.Controls.Add(this.gbInvoiceStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStats";
            this.gboPopular.ResumeLayout(false);
            this.gboPopular.PerformLayout();
            this.gboLeastPopular.ResumeLayout(false);
            this.gboLeastPopular.PerformLayout();
            this.gbInvoiceStats.ResumeLayout(false);
            this.gbInvoiceStats.PerformLayout();
            this.gbo_Sales.ResumeLayout(false);
            this.gbo_Sales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarStats;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblModelCount;
        private System.Windows.Forms.Label lblModelSum;
        private System.Windows.Forms.GroupBox gboPopular;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblNumberSold;
        private System.Windows.Forms.GroupBox gboLeastPopular;
        private System.Windows.Forms.Label lblLeastTotal;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblModelLeast;
        private System.Windows.Forms.Label lblModelSumLeast;
        private System.Windows.Forms.Label lblModelCountLeast;
        private System.Windows.Forms.Label lblModelNameLeast;
        private System.Windows.Forms.Button btnSalesman;
        private System.Windows.Forms.Button btnInvoiceStats;
        private System.Windows.Forms.Button btnDownloadCar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInvoiceStats;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalCompletePrice;
        private System.Windows.Forms.Label lblTotalIncompletePrice;
        private System.Windows.Forms.Label lblIncomplete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Button btnDownloadInvoiceStats;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.ComboBox ddl_Salesmen;
        private System.Windows.Forms.ComboBox ddl_SID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbo_Sales;
        private System.Windows.Forms.Button btn_DownloadSales;
        private System.Windows.Forms.Label lbl_SalesTotal;
        private System.Windows.Forms.Label lbl_SalesTotalInd;
        private System.Windows.Forms.Label lbl_SalesCompleted;
        private System.Windows.Forms.Label lbl_SalesCompletedInd;
        private System.Windows.Forms.Label lbl_SalesIncomplete;
        private System.Windows.Forms.Label lbl_SalesIncompleteInd;
    }
}