namespace year3_collaborative_project
{
    partial class frmMenu
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
            this.btnUserSelections = new System.Windows.Forms.Button();
            this.btnUserLoadPrior = new System.Windows.Forms.Button();
            this.btnUserChangeDetails = new System.Windows.Forms.Button();
            this.btnAdminAddVehicle = new System.Windows.Forms.Button();
            this.btnAdminAddMod = new System.Windows.Forms.Button();
            this.btnAdminAddUser = new System.Windows.Forms.Button();
            this.btnRepViewInvoice = new System.Windows.Forms.Button();
            this.btnAdminDeleteMod = new System.Windows.Forms.Button();
            this.btnAdminModMod = new System.Windows.Forms.Button();
            this.btnAdminActivateMod = new System.Windows.Forms.Button();
            this.btnAdminStats = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(495, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu";
            // 
            // btnUserSelections
            // 
            this.btnUserSelections.BackColor = System.Drawing.Color.DarkGray;
            this.btnUserSelections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserSelections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSelections.Location = new System.Drawing.Point(267, 66);
            this.btnUserSelections.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserSelections.Name = "btnUserSelections";
            this.btnUserSelections.Size = new System.Drawing.Size(223, 66);
            this.btnUserSelections.TabIndex = 3;
            this.btnUserSelections.Text = "Select Vehicle and Customisations";
            this.btnUserSelections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserSelections.UseVisualStyleBackColor = false;
            this.btnUserSelections.Click += new System.EventHandler(this.btnUserSelections_Click);
            // 
            // btnUserLoadPrior
            // 
            this.btnUserLoadPrior.BackColor = System.Drawing.Color.DarkGray;
            this.btnUserLoadPrior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserLoadPrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLoadPrior.Location = new System.Drawing.Point(247, 146);
            this.btnUserLoadPrior.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserLoadPrior.Name = "btnUserLoadPrior";
            this.btnUserLoadPrior.Size = new System.Drawing.Size(255, 42);
            this.btnUserLoadPrior.TabIndex = 4;
            this.btnUserLoadPrior.Text = "Load Saved Choices";
            this.btnUserLoadPrior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserLoadPrior.UseVisualStyleBackColor = false;
            this.btnUserLoadPrior.Click += new System.EventHandler(this.btnUserLoadPrior_Click);
            // 
            // btnUserChangeDetails
            // 
            this.btnUserChangeDetails.BackColor = System.Drawing.Color.DarkGray;
            this.btnUserChangeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserChangeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserChangeDetails.Location = new System.Drawing.Point(247, 196);
            this.btnUserChangeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserChangeDetails.Name = "btnUserChangeDetails";
            this.btnUserChangeDetails.Size = new System.Drawing.Size(255, 42);
            this.btnUserChangeDetails.TabIndex = 6;
            this.btnUserChangeDetails.Text = "Edit User";
            this.btnUserChangeDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserChangeDetails.UseVisualStyleBackColor = false;
            this.btnUserChangeDetails.Click += new System.EventHandler(this.btnUserChangeDetails_Click);
            // 
            // btnAdminAddVehicle
            // 
            this.btnAdminAddVehicle.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddVehicle.Location = new System.Drawing.Point(647, 66);
            this.btnAdminAddVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminAddVehicle.Name = "btnAdminAddVehicle";
            this.btnAdminAddVehicle.Size = new System.Drawing.Size(171, 42);
            this.btnAdminAddVehicle.TabIndex = 7;
            this.btnAdminAddVehicle.Text = "Vehicle Admin";
            this.btnAdminAddVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminAddVehicle.UseVisualStyleBackColor = false;
            this.btnAdminAddVehicle.Click += new System.EventHandler(this.btnAdminAddVehicle_Click);
            // 
            // btnAdminAddMod
            // 
            this.btnAdminAddMod.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminAddMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddMod.Location = new System.Drawing.Point(623, 116);
            this.btnAdminAddMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminAddMod.Name = "btnAdminAddMod";
            this.btnAdminAddMod.Size = new System.Drawing.Size(209, 42);
            this.btnAdminAddMod.TabIndex = 8;
            this.btnAdminAddMod.Text = "Add Modification";
            this.btnAdminAddMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminAddMod.UseVisualStyleBackColor = false;
            this.btnAdminAddMod.Click += new System.EventHandler(this.btnAdminAddMod_Click);
            // 
            // btnAdminAddUser
            // 
            this.btnAdminAddUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddUser.Location = new System.Drawing.Point(267, 246);
            this.btnAdminAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminAddUser.Name = "btnAdminAddUser";
            this.btnAdminAddUser.Size = new System.Drawing.Size(209, 42);
            this.btnAdminAddUser.TabIndex = 9;
            this.btnAdminAddUser.Text = "Add New User";
            this.btnAdminAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminAddUser.UseVisualStyleBackColor = false;
            this.btnAdminAddUser.Click += new System.EventHandler(this.btnAdminAddUser_Click);
            // 
            // btnRepViewInvoice
            // 
            this.btnRepViewInvoice.BackColor = System.Drawing.Color.DarkGray;
            this.btnRepViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepViewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepViewInvoice.Location = new System.Drawing.Point(267, 296);
            this.btnRepViewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepViewInvoice.Name = "btnRepViewInvoice";
            this.btnRepViewInvoice.Size = new System.Drawing.Size(215, 42);
            this.btnRepViewInvoice.TabIndex = 10;
            this.btnRepViewInvoice.Text = "Accept Invoices";
            this.btnRepViewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRepViewInvoice.UseVisualStyleBackColor = false;
            this.btnRepViewInvoice.Click += new System.EventHandler(this.btnRepViewInvoice_Click);
            // 
            // btnAdminDeleteMod
            // 
            this.btnAdminDeleteMod.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminDeleteMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminDeleteMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDeleteMod.Location = new System.Drawing.Point(596, 220);
            this.btnAdminDeleteMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminDeleteMod.Name = "btnAdminDeleteMod";
            this.btnAdminDeleteMod.Size = new System.Drawing.Size(276, 42);
            this.btnAdminDeleteMod.TabIndex = 15;
            this.btnAdminDeleteMod.Text = "Deactivate a Modification";
            this.btnAdminDeleteMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminDeleteMod.UseVisualStyleBackColor = false;
            this.btnAdminDeleteMod.Click += new System.EventHandler(this.btnAdminDeleteMod_Click);
            // 
            // btnAdminModMod
            // 
            this.btnAdminModMod.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminModMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminModMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminModMod.Location = new System.Drawing.Point(612, 170);
            this.btnAdminModMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminModMod.Name = "btnAdminModMod";
            this.btnAdminModMod.Size = new System.Drawing.Size(243, 42);
            this.btnAdminModMod.TabIndex = 16;
            this.btnAdminModMod.Text = "Modify a Modification";
            this.btnAdminModMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminModMod.UseVisualStyleBackColor = false;
            this.btnAdminModMod.Click += new System.EventHandler(this.btnAdminModMod_Click);
            // 
            // btnAdminActivateMod
            // 
            this.btnAdminActivateMod.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminActivateMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminActivateMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminActivateMod.Location = new System.Drawing.Point(612, 270);
            this.btnAdminActivateMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminActivateMod.Name = "btnAdminActivateMod";
            this.btnAdminActivateMod.Size = new System.Drawing.Size(243, 42);
            this.btnAdminActivateMod.TabIndex = 17;
            this.btnAdminActivateMod.Text = "Activate a Modification";
            this.btnAdminActivateMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminActivateMod.UseVisualStyleBackColor = false;
            this.btnAdminActivateMod.Click += new System.EventHandler(this.btnAdminActivateMod_Click);
            // 
            // btnAdminStats
            // 
            this.btnAdminStats.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminStats.Location = new System.Drawing.Point(614, 321);
            this.btnAdminStats.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdminStats.Name = "btnAdminStats";
            this.btnAdminStats.Size = new System.Drawing.Size(241, 52);
            this.btnAdminStats.TabIndex = 18;
            this.btnAdminStats.Text = "View Statistics";
            this.btnAdminStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminStats.UseVisualStyleBackColor = false;
            this.btnAdminStats.Click += new System.EventHandler(this.btnAdminStats_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(942, 498);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(112, 43);
            this.btn_Logout.TabIndex = 97;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btnAdminStats);
            this.Controls.Add(this.btnAdminActivateMod);
            this.Controls.Add(this.btnAdminModMod);
            this.Controls.Add(this.btnAdminDeleteMod);
            this.Controls.Add(this.btnRepViewInvoice);
            this.Controls.Add(this.btnAdminAddUser);
            this.Controls.Add(this.btnAdminAddMod);
            this.Controls.Add(this.btnAdminAddVehicle);
            this.Controls.Add(this.btnUserChangeDetails);
            this.Controls.Add(this.btnUserLoadPrior);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUserSelections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUserSelections;
        private System.Windows.Forms.Button btnUserLoadPrior;
        private System.Windows.Forms.Button btnUserChangeDetails;
        private System.Windows.Forms.Button btnAdminAddVehicle;
        private System.Windows.Forms.Button btnAdminAddMod;
        private System.Windows.Forms.Button btnAdminAddUser;
        private System.Windows.Forms.Button btnRepViewInvoice;
        private System.Windows.Forms.Button btnAdminDeleteMod;
        private System.Windows.Forms.Button btnAdminModMod;
        private System.Windows.Forms.Button btnAdminActivateMod;
        private System.Windows.Forms.Button btnAdminStats;
        private System.Windows.Forms.Button btn_Logout;
    }
}