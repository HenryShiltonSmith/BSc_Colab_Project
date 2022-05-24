namespace year3_collaborative_project
{
    partial class frmLogin
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbHidePassword = new System.Windows.Forms.CheckBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btn_TestAdmin = new System.Windows.Forms.Button();
            this.btn_TestSales = new System.Windows.Forms.Button();
            this.btn_TestUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(316, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 33);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(313, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(316, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(316, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(313, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // cbHidePassword
            // 
            this.cbHidePassword.AutoSize = true;
            this.cbHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHidePassword.Location = new System.Drawing.Point(494, 153);
            this.cbHidePassword.Name = "cbHidePassword";
            this.cbHidePassword.Size = new System.Drawing.Size(123, 20);
            this.cbHidePassword.TabIndex = 5;
            this.cbHidePassword.Text = "Show Password";
            this.cbHidePassword.UseVisualStyleBackColor = true;
            this.cbHidePassword.CheckedChanged += new System.EventHandler(this.cbHidePassword_CheckedChanged);
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(490, 92);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(305, 58);
            this.lblAlert.TabIndex = 6;
            this.lblAlert.Text = "label";
            this.lblAlert.Visible = false;
            // 
            // btn_TestAdmin
            // 
            this.btn_TestAdmin.Location = new System.Drawing.Point(103, 183);
            this.btn_TestAdmin.Name = "btn_TestAdmin";
            this.btn_TestAdmin.Size = new System.Drawing.Size(75, 23);
            this.btn_TestAdmin.TabIndex = 23;
            this.btn_TestAdmin.Text = "Admin";
            this.btn_TestAdmin.UseVisualStyleBackColor = true;
            this.btn_TestAdmin.Visible = false;
            this.btn_TestAdmin.Click += new System.EventHandler(this.btn_TestAdmin_Click);
            // 
            // btn_TestSales
            // 
            this.btn_TestSales.Location = new System.Drawing.Point(103, 143);
            this.btn_TestSales.Name = "btn_TestSales";
            this.btn_TestSales.Size = new System.Drawing.Size(75, 23);
            this.btn_TestSales.TabIndex = 22;
            this.btn_TestSales.Text = "Sales";
            this.btn_TestSales.UseVisualStyleBackColor = true;
            this.btn_TestSales.Visible = false;
            this.btn_TestSales.Click += new System.EventHandler(this.btn_TestSales_Click);
            // 
            // btn_TestUser
            // 
            this.btn_TestUser.Location = new System.Drawing.Point(103, 107);
            this.btn_TestUser.Name = "btn_TestUser";
            this.btn_TestUser.Size = new System.Drawing.Size(75, 23);
            this.btn_TestUser.TabIndex = 21;
            this.btn_TestUser.Text = "User";
            this.btn_TestUser.UseVisualStyleBackColor = true;
            this.btn_TestUser.Visible = false;
            this.btn_TestUser.Click += new System.EventHandler(this.btn_TestUser_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TestAdmin);
            this.Controls.Add(this.btn_TestSales);
            this.Controls.Add(this.btn_TestUser);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.cbHidePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbHidePassword;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btn_TestAdmin;
        private System.Windows.Forms.Button btn_TestSales;
        private System.Windows.Forms.Button btn_TestUser;
    }
}

