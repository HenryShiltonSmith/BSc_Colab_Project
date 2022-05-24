
namespace year3_collaborative_project
{
    partial class frmLoad_Config
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.ddl_Configs = new System.Windows.Forms.ComboBox();
            this.ddl_Customers = new System.Windows.Forms.ComboBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.ddl_ConfigID = new System.Windows.Forms.ComboBox();
            this.ddl_CID = new System.Windows.Forms.ComboBox();
            this.lbl_VehicleModel = new System.Windows.Forms.Label();
            this.lbl_VehicleMake = new System.Windows.Forms.Label();
            this.lbl_ModelID = new System.Windows.Forms.Label();
            this.lbl_MakeID = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Rockwell", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(60, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(310, 36);
            this.lbl_Title.TabIndex = 22;
            this.lbl_Title.Text = "Select Configuration";
            // 
            // ddl_Configs
            // 
            this.ddl_Configs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Configs.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_Configs.FormattingEnabled = true;
            this.ddl_Configs.Location = new System.Drawing.Point(26, 96);
            this.ddl_Configs.Name = "ddl_Configs";
            this.ddl_Configs.Size = new System.Drawing.Size(372, 27);
            this.ddl_Configs.TabIndex = 87;
            this.ddl_Configs.Visible = false;
            this.ddl_Configs.SelectedIndexChanged += new System.EventHandler(this.ddl_Configs_SelectedIndexChanged);
            // 
            // ddl_Customers
            // 
            this.ddl_Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Customers.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_Customers.FormattingEnabled = true;
            this.ddl_Customers.Location = new System.Drawing.Point(26, 63);
            this.ddl_Customers.Name = "ddl_Customers";
            this.ddl_Customers.Size = new System.Drawing.Size(372, 27);
            this.ddl_Customers.TabIndex = 88;
            this.ddl_Customers.Visible = false;
            this.ddl_Customers.SelectedIndexChanged += new System.EventHandler(this.ddl_Customers_SelectedIndexChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirm.Enabled = false;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Location = new System.Drawing.Point(142, 133);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(146, 49);
            this.btn_Confirm.TabIndex = 89;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ddl_ConfigID
            // 
            this.ddl_ConfigID.FormattingEnabled = true;
            this.ddl_ConfigID.Location = new System.Drawing.Point(84, 129);
            this.ddl_ConfigID.Name = "ddl_ConfigID";
            this.ddl_ConfigID.Size = new System.Drawing.Size(40, 21);
            this.ddl_ConfigID.TabIndex = 90;
            this.ddl_ConfigID.Visible = false;
            // 
            // ddl_CID
            // 
            this.ddl_CID.FormattingEnabled = true;
            this.ddl_CID.Location = new System.Drawing.Point(26, 129);
            this.ddl_CID.Name = "ddl_CID";
            this.ddl_CID.Size = new System.Drawing.Size(40, 21);
            this.ddl_CID.TabIndex = 91;
            this.ddl_CID.Visible = false;
            // 
            // lbl_VehicleModel
            // 
            this.lbl_VehicleModel.AutoSize = true;
            this.lbl_VehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VehicleModel.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleModel.Location = new System.Drawing.Point(311, 146);
            this.lbl_VehicleModel.Name = "lbl_VehicleModel";
            this.lbl_VehicleModel.Size = new System.Drawing.Size(59, 13);
            this.lbl_VehicleModel.TabIndex = 93;
            this.lbl_VehicleModel.Text = "*MODEL*";
            this.lbl_VehicleModel.Visible = false;
            // 
            // lbl_VehicleMake
            // 
            this.lbl_VehicleMake.AutoSize = true;
            this.lbl_VehicleMake.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VehicleMake.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleMake.Location = new System.Drawing.Point(311, 133);
            this.lbl_VehicleMake.Name = "lbl_VehicleMake";
            this.lbl_VehicleMake.Size = new System.Drawing.Size(51, 13);
            this.lbl_VehicleMake.TabIndex = 92;
            this.lbl_VehicleMake.Text = "*MAKE*";
            this.lbl_VehicleMake.Visible = false;
            // 
            // lbl_ModelID
            // 
            this.lbl_ModelID.AutoSize = true;
            this.lbl_ModelID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ModelID.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModelID.Location = new System.Drawing.Point(368, 146);
            this.lbl_ModelID.Name = "lbl_ModelID";
            this.lbl_ModelID.Size = new System.Drawing.Size(30, 13);
            this.lbl_ModelID.TabIndex = 95;
            this.lbl_ModelID.Text = "*ID*";
            this.lbl_ModelID.Visible = false;
            // 
            // lbl_MakeID
            // 
            this.lbl_MakeID.AutoSize = true;
            this.lbl_MakeID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MakeID.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MakeID.Location = new System.Drawing.Point(368, 133);
            this.lbl_MakeID.Name = "lbl_MakeID";
            this.lbl_MakeID.Size = new System.Drawing.Size(30, 13);
            this.lbl_MakeID.TabIndex = 94;
            this.lbl_MakeID.Text = "*ID*";
            this.lbl_MakeID.Visible = false;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Gray;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Menu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu.Location = new System.Drawing.Point(12, 185);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(70, 31);
            this.btn_Menu.TabIndex = 97;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(343, 185);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(70, 31);
            this.btn_Logout.TabIndex = 96;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(311, 159);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(50, 13);
            this.lbl_Price.TabIndex = 98;
            this.lbl_Price.Text = "*PRICE*";
            this.lbl_Price.Visible = false;
            // 
            // frmLoad_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(425, 220);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_ModelID);
            this.Controls.Add(this.lbl_MakeID);
            this.Controls.Add(this.lbl_VehicleModel);
            this.Controls.Add(this.lbl_VehicleMake);
            this.Controls.Add(this.ddl_CID);
            this.Controls.Add(this.ddl_ConfigID);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.ddl_Customers);
            this.Controls.Add(this.ddl_Configs);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoad_Config";
            this.Load += new System.EventHandler(this.frmLoad_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox ddl_Configs;
        private System.Windows.Forms.ComboBox ddl_Customers;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ComboBox ddl_ConfigID;
        private System.Windows.Forms.ComboBox ddl_CID;
        private System.Windows.Forms.Label lbl_VehicleModel;
        private System.Windows.Forms.Label lbl_VehicleMake;
        private System.Windows.Forms.Label lbl_ModelID;
        private System.Windows.Forms.Label lbl_MakeID;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Price;
    }
}