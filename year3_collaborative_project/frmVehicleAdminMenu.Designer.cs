namespace year3_collaborative_project
{
    partial class frmVehicleAdminMenu
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Admin Menu";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddVehicle.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnAddVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.Location = new System.Drawing.Point(467, 99);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(204, 66);
            this.btnAddVehicle.TabIndex = 1;
            this.btnAddVehicle.Text = "Add New Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click_1);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditVehicle.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnEditVehicle.ForeColor = System.Drawing.Color.White;
            this.btnEditVehicle.Location = new System.Drawing.Point(457, 195);
            this.btnEditVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(231, 76);
            this.btnEditVehicle.TabIndex = 2;
            this.btnEditVehicle.Text = "Edit Existing Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = false;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click_1);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(467, 301);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(204, 63);
            this.btnDeleteVehicle.TabIndex = 3;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(46, 543);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 50);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmVehicleAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVehicleAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVehicleAdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnReturn;
    }
}