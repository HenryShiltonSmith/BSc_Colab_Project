namespace year3_collaborative_project
{
    partial class frmDeleteVehicle
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
            this.gboVehicleSelection = new System.Windows.Forms.GroupBox();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            this.cboCarModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarMake = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.btnReConfirm = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnMenuReturn = new System.Windows.Forms.Button();
            this.btnCancelAndExit = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.gboConfirmDeletion = new System.Windows.Forms.GroupBox();
            this.lblExitConfirm = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gboVehicleSelection.SuspendLayout();
            this.gboConfirmDeletion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Vehicle From Database";
            // 
            // gboVehicleSelection
            // 
            this.gboVehicleSelection.Controls.Add(this.btnConfirmSelection);
            this.gboVehicleSelection.Controls.Add(this.cboCarModel);
            this.gboVehicleSelection.Controls.Add(this.label3);
            this.gboVehicleSelection.Controls.Add(this.cboCarMake);
            this.gboVehicleSelection.Controls.Add(this.label2);
            this.gboVehicleSelection.Location = new System.Drawing.Point(387, 69);
            this.gboVehicleSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gboVehicleSelection.Name = "gboVehicleSelection";
            this.gboVehicleSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gboVehicleSelection.Size = new System.Drawing.Size(436, 213);
            this.gboVehicleSelection.TabIndex = 1;
            this.gboVehicleSelection.TabStop = false;
            this.gboVehicleSelection.Text = "Vehicle Selection";
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmSelection.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSelection.Location = new System.Drawing.Point(164, 149);
            this.btnConfirmSelection.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmSelection.TabIndex = 4;
            this.btnConfirmSelection.Text = "Confirm";
            this.btnConfirmSelection.UseVisualStyleBackColor = false;
            this.btnConfirmSelection.Visible = false;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);
            // 
            // cboCarModel
            // 
            this.cboCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarModel.FormattingEnabled = true;
            this.cboCarModel.Location = new System.Drawing.Point(228, 86);
            this.cboCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.cboCarModel.Name = "cboCarModel";
            this.cboCarModel.Size = new System.Drawing.Size(180, 27);
            this.cboCarModel.TabIndex = 3;
            this.cboCarModel.SelectedIndexChanged += new System.EventHandler(this.cboCarModel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Select A Model:";
            // 
            // cboCarMake
            // 
            this.cboCarMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarMake.FormattingEnabled = true;
            this.cboCarMake.Location = new System.Drawing.Point(228, 29);
            this.cboCarMake.Margin = new System.Windows.Forms.Padding(4);
            this.cboCarMake.Name = "cboCarMake";
            this.cboCarMake.Size = new System.Drawing.Size(180, 27);
            this.cboCarMake.TabIndex = 1;
            this.cboCarMake.SelectedIndexChanged += new System.EventHandler(this.cboCarMake_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Select A Make:";
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDelete.Location = new System.Drawing.Point(36, 35);
            this.lblConfirmDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(309, 16);
            this.lblConfirmDelete.TabIndex = 6;
            this.lblConfirmDelete.Text = "Are you sure you want to delete this record?";
            // 
            // btnReConfirm
            // 
            this.btnReConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnReConfirm.ForeColor = System.Drawing.Color.White;
            this.btnReConfirm.Location = new System.Drawing.Point(93, 139);
            this.btnReConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnReConfirm.Name = "btnReConfirm";
            this.btnReConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnReConfirm.TabIndex = 7;
            this.btnReConfirm.Text = "Confirm";
            this.btnReConfirm.UseVisualStyleBackColor = false;
            this.btnReConfirm.Click += new System.EventHandler(this.btnReConfirm_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(456, 538);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(313, 19);
            this.lblSuccess.TabIndex = 8;
            this.lblSuccess.Text = "You have successfully deleted the record.";
            this.lblSuccess.Visible = false;
            // 
            // btnMenuReturn
            // 
            this.btnMenuReturn.BackColor = System.Drawing.Color.Gray;
            this.btnMenuReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuReturn.ForeColor = System.Drawing.Color.White;
            this.btnMenuReturn.Location = new System.Drawing.Point(13, 571);
            this.btnMenuReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuReturn.Name = "btnMenuReturn";
            this.btnMenuReturn.Size = new System.Drawing.Size(150, 34);
            this.btnMenuReturn.TabIndex = 9;
            this.btnMenuReturn.Text = "Return To Menu";
            this.btnMenuReturn.UseVisualStyleBackColor = false;
            this.btnMenuReturn.Click += new System.EventHandler(this.btnMenuReturn_Click);
            // 
            // btnCancelAndExit
            // 
            this.btnCancelAndExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelAndExit.ForeColor = System.Drawing.Color.White;
            this.btnCancelAndExit.Location = new System.Drawing.Point(308, 139);
            this.btnCancelAndExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAndExit.Name = "btnCancelAndExit";
            this.btnCancelAndExit.Size = new System.Drawing.Size(147, 34);
            this.btnCancelAndExit.TabIndex = 10;
            this.btnCancelAndExit.Text = "Cancel And Exit";
            this.btnCancelAndExit.UseVisualStyleBackColor = false;
            this.btnCancelAndExit.Click += new System.EventHandler(this.btnCancelAndExit_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(120, 80);
            this.lblMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(50, 19);
            this.lblMake.TabIndex = 11;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(352, 80);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 19);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Model";
            // 
            // gboConfirmDeletion
            // 
            this.gboConfirmDeletion.Controls.Add(this.lblConfirmDelete);
            this.gboConfirmDeletion.Controls.Add(this.btnCancelAndExit);
            this.gboConfirmDeletion.Controls.Add(this.lblModel);
            this.gboConfirmDeletion.Controls.Add(this.lblMake);
            this.gboConfirmDeletion.Controls.Add(this.btnReConfirm);
            this.gboConfirmDeletion.Location = new System.Drawing.Point(332, 291);
            this.gboConfirmDeletion.Margin = new System.Windows.Forms.Padding(4);
            this.gboConfirmDeletion.Name = "gboConfirmDeletion";
            this.gboConfirmDeletion.Padding = new System.Windows.Forms.Padding(4);
            this.gboConfirmDeletion.Size = new System.Drawing.Size(544, 203);
            this.gboConfirmDeletion.TabIndex = 13;
            this.gboConfirmDeletion.TabStop = false;
            this.gboConfirmDeletion.Text = "Confirm Deletion";
            this.gboConfirmDeletion.Visible = false;
            // 
            // lblExitConfirm
            // 
            this.lblExitConfirm.AutoSize = true;
            this.lblExitConfirm.Location = new System.Drawing.Point(492, 519);
            this.lblExitConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitConfirm.Name = "lblExitConfirm";
            this.lblExitConfirm.Size = new System.Drawing.Size(230, 19);
            this.lblExitConfirm.TabIndex = 14;
            this.lblExitConfirm.Text = "Are you sure you want to exit?";
            this.lblExitConfirm.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(550, 561);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDeleteVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblExitConfirm);
            this.Controls.Add(this.gboConfirmDeletion);
            this.Controls.Add(this.btnMenuReturn);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.gboVehicleSelection);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeleteVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteVehicle";
            this.Load += new System.EventHandler(this.frmDeleteVehicle_Load);
            this.gboVehicleSelection.ResumeLayout(false);
            this.gboVehicleSelection.PerformLayout();
            this.gboConfirmDeletion.ResumeLayout(false);
            this.gboConfirmDeletion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboVehicleSelection;
        private System.Windows.Forms.Button btnConfirmSelection;
        private System.Windows.Forms.ComboBox cboCarModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirmDelete;
        private System.Windows.Forms.Button btnReConfirm;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnMenuReturn;
        private System.Windows.Forms.Button btnCancelAndExit;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox gboConfirmDeletion;
        private System.Windows.Forms.Label lblExitConfirm;
        private System.Windows.Forms.Button btnExit;
    }
}