
namespace year3_collaborative_project
{
    partial class frmAcceptInvoice
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListConfirmDelete = new System.Windows.Forms.Button();
            this.btnConfirmApprove = new System.Windows.Forms.Button();
            this.btnConfirmInvoice = new System.Windows.Forms.Button();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMods = new System.Windows.Forms.Label();
            this.lbModNamePrice = new System.Windows.Forms.ListBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblConfigID = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.gbAppoveOrDelete = new System.Windows.Forms.GroupBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDeleteChoice = new System.Windows.Forms.Button();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.gbSelection.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbAppoveOrDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(252, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Accept Invoices";
            // 
            // gbSelection
            // 
            this.gbSelection.Controls.Add(this.button2);
            this.gbSelection.Controls.Add(this.lblAlert);
            this.gbSelection.Controls.Add(this.btnListConfirmDelete);
            this.gbSelection.Controls.Add(this.btnConfirmApprove);
            this.gbSelection.Controls.Add(this.btnConfirmInvoice);
            this.gbSelection.Controls.Add(this.cbList);
            this.gbSelection.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelection.Location = new System.Drawing.Point(38, 218);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(296, 178);
            this.gbSelection.TabIndex = 2;
            this.gbSelection.TabStop = false;
            this.gbSelection.Text = "Please Select The Invoice.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(0, -71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnListConfirmDelete
            // 
            this.btnListConfirmDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnListConfirmDelete.Location = new System.Drawing.Point(6, 70);
            this.btnListConfirmDelete.Name = "btnListConfirmDelete";
            this.btnListConfirmDelete.Size = new System.Drawing.Size(131, 55);
            this.btnListConfirmDelete.TabIndex = 13;
            this.btnListConfirmDelete.Text = "Confirm";
            this.btnListConfirmDelete.UseVisualStyleBackColor = false;
            this.btnListConfirmDelete.Click += new System.EventHandler(this.btnListConfirmDelete_Click);
            // 
            // btnConfirmApprove
            // 
            this.btnConfirmApprove.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmApprove.Location = new System.Drawing.Point(6, 70);
            this.btnConfirmApprove.Name = "btnConfirmApprove";
            this.btnConfirmApprove.Size = new System.Drawing.Size(131, 55);
            this.btnConfirmApprove.TabIndex = 10;
            this.btnConfirmApprove.Text = "Confirm";
            this.btnConfirmApprove.UseVisualStyleBackColor = false;
            this.btnConfirmApprove.Click += new System.EventHandler(this.btnConfirmApprove_Click);
            // 
            // btnConfirmInvoice
            // 
            this.btnConfirmInvoice.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmInvoice.Location = new System.Drawing.Point(6, 70);
            this.btnConfirmInvoice.Name = "btnConfirmInvoice";
            this.btnConfirmInvoice.Size = new System.Drawing.Size(131, 55);
            this.btnConfirmInvoice.TabIndex = 10;
            this.btnConfirmInvoice.Text = "Confirm";
            this.btnConfirmInvoice.UseVisualStyleBackColor = false;
            this.btnConfirmInvoice.Click += new System.EventHandler(this.btnConfirmInvoice_Click);
            // 
            // cbList
            // 
            this.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(6, 28);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(233, 28);
            this.cbList.TabIndex = 3;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbDiscount);
            this.gbInfo.Controls.Add(this.btnDelete);
            this.gbInfo.Controls.Add(this.btnConfirm);
            this.gbInfo.Controls.Add(this.lblTotal);
            this.gbInfo.Controls.Add(this.lblMods);
            this.gbInfo.Controls.Add(this.lbModNamePrice);
            this.gbInfo.Controls.Add(this.lblColour);
            this.gbInfo.Controls.Add(this.lblDiscount);
            this.gbInfo.Controls.Add(this.lblAPR);
            this.gbInfo.Controls.Add(this.lblMakeModel);
            this.gbInfo.Controls.Add(this.lblCustName);
            this.gbInfo.Controls.Add(this.lblConfigID);
            this.gbInfo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(340, 73);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(536, 371);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info On The Invoice";
            // 
            // cbDiscount
            // 
            this.cbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(107, 163);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(121, 28);
            this.cbDiscount.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(0, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 55);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.Location = new System.Drawing.Point(0, 255);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 55);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(183, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 21);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Location = new System.Drawing.Point(6, 230);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(160, 21);
            this.lblMods.TabIndex = 7;
            this.lblMods.Text = "Mod Name/Price";
            // 
            // lbModNamePrice
            // 
            this.lbModNamePrice.FormattingEnabled = true;
            this.lbModNamePrice.ItemHeight = 20;
            this.lbModNamePrice.Location = new System.Drawing.Point(185, 230);
            this.lbModNamePrice.Name = "lbModNamePrice";
            this.lbModNamePrice.Size = new System.Drawing.Size(264, 104);
            this.lbModNamePrice.TabIndex = 6;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(6, 198);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(95, 21);
            this.lblColour.TabIndex = 5;
            this.lblColour.Text = "lblColour";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(6, 166);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(99, 21);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount: ";
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(6, 133);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(69, 21);
            this.lblAPR.TabIndex = 3;
            this.lblAPR.Text = "lblAPR";
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Location = new System.Drawing.Point(6, 102);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(140, 21);
            this.lblMakeModel.TabIndex = 2;
            this.lblMakeModel.Text = "lblMakeModel";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(6, 70);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(125, 21);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "lblCustName";
            // 
            // lblConfigID
            // 
            this.lblConfigID.AutoSize = true;
            this.lblConfigID.Location = new System.Drawing.Point(6, 35);
            this.lblConfigID.Name = "lblConfigID";
            this.lblConfigID.Size = new System.Drawing.Size(114, 21);
            this.lblConfigID.TabIndex = 0;
            this.lblConfigID.Text = "lblConfigID";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(13, 403);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 41);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(2, 128);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(265, 57);
            this.lblAlert.TabIndex = 12;
            this.lblAlert.Text = "You have approved the selected invoice.";
            this.lblAlert.Visible = false;
            // 
            // gbAppoveOrDelete
            // 
            this.gbAppoveOrDelete.Controls.Add(this.btnSignOff);
            this.gbAppoveOrDelete.Controls.Add(this.btnApprove);
            this.gbAppoveOrDelete.Controls.Add(this.btnDeleteChoice);
            this.gbAppoveOrDelete.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAppoveOrDelete.Location = new System.Drawing.Point(44, 79);
            this.gbAppoveOrDelete.Name = "gbAppoveOrDelete";
            this.gbAppoveOrDelete.Size = new System.Drawing.Size(296, 133);
            this.gbAppoveOrDelete.TabIndex = 31;
            this.gbAppoveOrDelete.TabStop = false;
            this.gbAppoveOrDelete.Text = "Do You Wish To Approve or Delete an Invoice?";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.DarkGray;
            this.btnApprove.Location = new System.Drawing.Point(6, 39);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(131, 46);
            this.btnApprove.TabIndex = 12;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDeleteChoice
            // 
            this.btnDeleteChoice.BackColor = System.Drawing.Color.Red;
            this.btnDeleteChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteChoice.Location = new System.Drawing.Point(143, 39);
            this.btnDeleteChoice.Name = "btnDeleteChoice";
            this.btnDeleteChoice.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteChoice.TabIndex = 13;
            this.btnDeleteChoice.Text = "Delete";
            this.btnDeleteChoice.UseVisualStyleBackColor = false;
            this.btnDeleteChoice.Click += new System.EventHandler(this.btnDeleteChoice_Click);
            // 
            // btnSignOff
            // 
            this.btnSignOff.BackColor = System.Drawing.Color.DarkGray;
            this.btnSignOff.Location = new System.Drawing.Point(77, 81);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(131, 46);
            this.btnSignOff.TabIndex = 14;
            this.btnSignOff.Text = "Sign Off";
            this.btnSignOff.UseVisualStyleBackColor = false;
            this.btnSignOff.Click += new System.EventHandler(this.btnSignOff_Click);
            // 
            // frmAcceptInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.gbAppoveOrDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbSelection);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcceptInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcceptInvoice";
            this.Load += new System.EventHandler(this.frmAcceptInvoice_Load);
            this.gbSelection.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbAppoveOrDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblConfigID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.ListBox lbModNamePrice;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnConfirmApprove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbAppoveOrDelete;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDeleteChoice;
        private System.Windows.Forms.Button btnListConfirmDelete;
        private System.Windows.Forms.Button btnConfirmInvoice;
        private System.Windows.Forms.Button btnSignOff;
    }
}