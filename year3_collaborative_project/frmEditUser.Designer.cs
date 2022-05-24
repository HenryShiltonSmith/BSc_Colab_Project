
namespace year3_collaborative_project
{
    partial class frmEditUser
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
            this.lbl_FNameError = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.lbl_LNameError = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.lbl_EmailError = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_PhoneError = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btn_PassHint = new System.Windows.Forms.Button();
            this.lbl_PasswordError = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_UserHint = new System.Windows.Forms.Button();
            this.lbl_UsernameError = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_PassHint = new System.Windows.Forms.TextBox();
            this.lbl_HouseNumberError = new System.Windows.Forms.Label();
            this.lbl_HouseNumber = new System.Windows.Forms.Label();
            this.txt_HouseNumber = new System.Windows.Forms.TextBox();
            this.lbl_RoadNameError = new System.Windows.Forms.Label();
            this.lbl_RoadName = new System.Windows.Forms.Label();
            this.txt_RoadName = new System.Windows.Forms.TextBox();
            this.lbl_TownNameError = new System.Windows.Forms.Label();
            this.lbl_TownName = new System.Windows.Forms.Label();
            this.txt_TownName = new System.Windows.Forms.TextBox();
            this.lbl_PostCodeError = new System.Windows.Forms.Label();
            this.lbl_PostCode = new System.Windows.Forms.Label();
            this.txt_PostCode = new System.Windows.Forms.TextBox();
            this.ddl_DoBYear = new System.Windows.Forms.ComboBox();
            this.ddl_DoBMonth = new System.Windows.Forms.ComboBox();
            this.ddl_DoBDay = new System.Windows.Forms.ComboBox();
            this.lbl_DoBError = new System.Windows.Forms.Label();
            this.lbl_DoB = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.cbx_HidePassword = new System.Windows.Forms.CheckBox();
            this.btn_ConfirmDetails = new System.Windows.Forms.Button();
            this.ddl_Users = new System.Windows.Forms.ComboBox();
            this.ddl_LogID = new System.Windows.Forms.ComboBox();
            this.ddl_UID = new System.Windows.Forms.ComboBox();
            this.ddl_AddID = new System.Windows.Forms.ComboBox();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.cbx_UserName = new System.Windows.Forms.CheckBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(477, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(158, 39);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Edit User";
            // 
            // lbl_FNameError
            // 
            this.lbl_FNameError.AutoSize = true;
            this.lbl_FNameError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_FNameError.Location = new System.Drawing.Point(387, 133);
            this.lbl_FNameError.Name = "lbl_FNameError";
            this.lbl_FNameError.Size = new System.Drawing.Size(224, 18);
            this.lbl_FNameError.TabIndex = 29;
            this.lbl_FNameError.Text = "Please enter a valid first name";
            this.lbl_FNameError.Visible = false;
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FName.Location = new System.Drawing.Point(386, 82);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(89, 19);
            this.lbl_FName.TabIndex = 28;
            this.lbl_FName.Text = "First Name";
            this.lbl_FName.Visible = false;
            // 
            // txt_FName
            // 
            this.txt_FName.Enabled = false;
            this.txt_FName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.Location = new System.Drawing.Point(390, 104);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(300, 26);
            this.txt_FName.TabIndex = 27;
            this.txt_FName.Visible = false;
            // 
            // lbl_LNameError
            // 
            this.lbl_LNameError.AutoSize = true;
            this.lbl_LNameError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_LNameError.Location = new System.Drawing.Point(387, 212);
            this.lbl_LNameError.Name = "lbl_LNameError";
            this.lbl_LNameError.Size = new System.Drawing.Size(223, 18);
            this.lbl_LNameError.TabIndex = 32;
            this.lbl_LNameError.Text = "Please enter a valid last name";
            this.lbl_LNameError.Visible = false;
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.Location = new System.Drawing.Point(386, 161);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(123, 19);
            this.lbl_LName.TabIndex = 31;
            this.lbl_LName.Text = "Surname Name";
            this.lbl_LName.Visible = false;
            // 
            // txt_LName
            // 
            this.txt_LName.Enabled = false;
            this.txt_LName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName.Location = new System.Drawing.Point(390, 183);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(300, 26);
            this.txt_LName.TabIndex = 30;
            this.txt_LName.Visible = false;
            // 
            // lbl_EmailError
            // 
            this.lbl_EmailError.AutoSize = true;
            this.lbl_EmailError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailError.ForeColor = System.Drawing.Color.Red;
            this.lbl_EmailError.Location = new System.Drawing.Point(387, 287);
            this.lbl_EmailError.Name = "lbl_EmailError";
            this.lbl_EmailError.Size = new System.Drawing.Size(193, 18);
            this.lbl_EmailError.TabIndex = 35;
            this.lbl_EmailError.Text = "Please enter a valid email";
            this.lbl_EmailError.Visible = false;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(386, 236);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(50, 19);
            this.lbl_Email.TabIndex = 34;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Visible = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(390, 258);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(300, 26);
            this.txt_Email.TabIndex = 33;
            this.txt_Email.Visible = false;
            // 
            // lbl_PhoneError
            // 
            this.lbl_PhoneError.AutoSize = true;
            this.lbl_PhoneError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneError.ForeColor = System.Drawing.Color.Red;
            this.lbl_PhoneError.Location = new System.Drawing.Point(387, 362);
            this.lbl_PhoneError.Name = "lbl_PhoneError";
            this.lbl_PhoneError.Size = new System.Drawing.Size(260, 18);
            this.lbl_PhoneError.TabIndex = 38;
            this.lbl_PhoneError.Text = "Please enter a valid phone number";
            this.lbl_PhoneError.Visible = false;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(386, 311);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(119, 19);
            this.lbl_Phone.TabIndex = 37;
            this.lbl_Phone.Text = "Phone Number";
            this.lbl_Phone.Visible = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Enabled = false;
            this.txt_Phone.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(390, 333);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(300, 26);
            this.txt_Phone.TabIndex = 36;
            this.txt_Phone.Visible = false;
            // 
            // btn_PassHint
            // 
            this.btn_PassHint.BackColor = System.Drawing.Color.DarkGray;
            this.btn_PassHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PassHint.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PassHint.ForeColor = System.Drawing.Color.White;
            this.btn_PassHint.Location = new System.Drawing.Point(140, 495);
            this.btn_PassHint.Name = "btn_PassHint";
            this.btn_PassHint.Size = new System.Drawing.Size(23, 21);
            this.btn_PassHint.TabIndex = 44;
            this.btn_PassHint.Text = "?";
            this.btn_PassHint.UseVisualStyleBackColor = false;
            this.btn_PassHint.Visible = false;
            this.btn_PassHint.Click += new System.EventHandler(this.btn_PassHint_Click);
            // 
            // lbl_PasswordError
            // 
            this.lbl_PasswordError.AutoSize = true;
            this.lbl_PasswordError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_PasswordError.Location = new System.Drawing.Point(56, 546);
            this.lbl_PasswordError.Name = "lbl_PasswordError";
            this.lbl_PasswordError.Size = new System.Drawing.Size(223, 18);
            this.lbl_PasswordError.TabIndex = 43;
            this.lbl_PasswordError.Text = "Please enter a valid password";
            this.lbl_PasswordError.Visible = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(55, 495);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(79, 19);
            this.lbl_Password.TabIndex = 42;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Visible = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Enabled = false;
            this.txt_Password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(59, 517);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(418, 26);
            this.txt_Password.TabIndex = 41;
            this.txt_Password.Visible = false;
            // 
            // btn_UserHint
            // 
            this.btn_UserHint.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UserHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UserHint.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserHint.ForeColor = System.Drawing.Color.White;
            this.btn_UserHint.Location = new System.Drawing.Point(145, 424);
            this.btn_UserHint.Name = "btn_UserHint";
            this.btn_UserHint.Size = new System.Drawing.Size(23, 21);
            this.btn_UserHint.TabIndex = 61;
            this.btn_UserHint.Text = "?";
            this.btn_UserHint.UseVisualStyleBackColor = false;
            this.btn_UserHint.Visible = false;
            this.btn_UserHint.Click += new System.EventHandler(this.btn_UserHint_Click);
            // 
            // lbl_UsernameError
            // 
            this.lbl_UsernameError.AutoSize = true;
            this.lbl_UsernameError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_UsernameError.Location = new System.Drawing.Point(56, 474);
            this.lbl_UsernameError.Name = "lbl_UsernameError";
            this.lbl_UsernameError.Size = new System.Drawing.Size(225, 18);
            this.lbl_UsernameError.TabIndex = 60;
            this.lbl_UsernameError.Text = "Please enter a valid username";
            this.lbl_UsernameError.Visible = false;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(55, 426);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(84, 19);
            this.lbl_Username.TabIndex = 59;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Visible = false;
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(59, 448);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(418, 26);
            this.txt_Username.TabIndex = 58;
            this.txt_Username.Visible = false;
            // 
            // txt_PassHint
            // 
            this.txt_PassHint.Enabled = false;
            this.txt_PassHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassHint.Location = new System.Drawing.Point(575, 485);
            this.txt_PassHint.Multiline = true;
            this.txt_PassHint.Name = "txt_PassHint";
            this.txt_PassHint.Size = new System.Drawing.Size(280, 58);
            this.txt_PassHint.TabIndex = 62;
            this.txt_PassHint.Text = "Passwords must contain 1 each of: upper case, lower case, special character and n" +
    "umber . The password must also contain no less than 8 characters.";
            this.txt_PassHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PassHint.Visible = false;
            // 
            // lbl_HouseNumberError
            // 
            this.lbl_HouseNumberError.AutoSize = true;
            this.lbl_HouseNumberError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HouseNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbl_HouseNumberError.Location = new System.Drawing.Point(737, 133);
            this.lbl_HouseNumberError.Name = "lbl_HouseNumberError";
            this.lbl_HouseNumberError.Size = new System.Drawing.Size(210, 18);
            this.lbl_HouseNumberError.TabIndex = 65;
            this.lbl_HouseNumberError.Text = "Please enter a valid number";
            this.lbl_HouseNumberError.Visible = false;
            // 
            // lbl_HouseNumber
            // 
            this.lbl_HouseNumber.AutoSize = true;
            this.lbl_HouseNumber.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HouseNumber.Location = new System.Drawing.Point(736, 82);
            this.lbl_HouseNumber.Name = "lbl_HouseNumber";
            this.lbl_HouseNumber.Size = new System.Drawing.Size(119, 19);
            this.lbl_HouseNumber.TabIndex = 64;
            this.lbl_HouseNumber.Text = "House Number";
            this.lbl_HouseNumber.Visible = false;
            // 
            // txt_HouseNumber
            // 
            this.txt_HouseNumber.Enabled = false;
            this.txt_HouseNumber.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HouseNumber.Location = new System.Drawing.Point(740, 104);
            this.txt_HouseNumber.Name = "txt_HouseNumber";
            this.txt_HouseNumber.Size = new System.Drawing.Size(115, 26);
            this.txt_HouseNumber.TabIndex = 63;
            this.txt_HouseNumber.Visible = false;
            // 
            // lbl_RoadNameError
            // 
            this.lbl_RoadNameError.AutoSize = true;
            this.lbl_RoadNameError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoadNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RoadNameError.Location = new System.Drawing.Point(737, 212);
            this.lbl_RoadNameError.Name = "lbl_RoadNameError";
            this.lbl_RoadNameError.Size = new System.Drawing.Size(232, 18);
            this.lbl_RoadNameError.TabIndex = 68;
            this.lbl_RoadNameError.Text = "Please enter a valid road name";
            this.lbl_RoadNameError.Visible = false;
            // 
            // lbl_RoadName
            // 
            this.lbl_RoadName.AutoSize = true;
            this.lbl_RoadName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoadName.Location = new System.Drawing.Point(736, 161);
            this.lbl_RoadName.Name = "lbl_RoadName";
            this.lbl_RoadName.Size = new System.Drawing.Size(95, 19);
            this.lbl_RoadName.TabIndex = 67;
            this.lbl_RoadName.Text = "Road Name";
            this.lbl_RoadName.Visible = false;
            // 
            // txt_RoadName
            // 
            this.txt_RoadName.Enabled = false;
            this.txt_RoadName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoadName.Location = new System.Drawing.Point(740, 183);
            this.txt_RoadName.Name = "txt_RoadName";
            this.txt_RoadName.Size = new System.Drawing.Size(346, 26);
            this.txt_RoadName.TabIndex = 66;
            this.txt_RoadName.Visible = false;
            // 
            // lbl_TownNameError
            // 
            this.lbl_TownNameError.AutoSize = true;
            this.lbl_TownNameError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TownNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_TownNameError.Location = new System.Drawing.Point(737, 287);
            this.lbl_TownNameError.Name = "lbl_TownNameError";
            this.lbl_TownNameError.Size = new System.Drawing.Size(265, 18);
            this.lbl_TownNameError.TabIndex = 71;
            this.lbl_TownNameError.Text = "Please enter a valid town/city name";
            this.lbl_TownNameError.Visible = false;
            // 
            // lbl_TownName
            // 
            this.lbl_TownName.AutoSize = true;
            this.lbl_TownName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TownName.Location = new System.Drawing.Point(736, 236);
            this.lbl_TownName.Name = "lbl_TownName";
            this.lbl_TownName.Size = new System.Drawing.Size(85, 19);
            this.lbl_TownName.TabIndex = 70;
            this.lbl_TownName.Text = "Town/City";
            this.lbl_TownName.Visible = false;
            // 
            // txt_TownName
            // 
            this.txt_TownName.Enabled = false;
            this.txt_TownName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TownName.Location = new System.Drawing.Point(740, 258);
            this.txt_TownName.Name = "txt_TownName";
            this.txt_TownName.Size = new System.Drawing.Size(346, 26);
            this.txt_TownName.TabIndex = 69;
            this.txt_TownName.Visible = false;
            // 
            // lbl_PostCodeError
            // 
            this.lbl_PostCodeError.AutoSize = true;
            this.lbl_PostCodeError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostCodeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_PostCodeError.Location = new System.Drawing.Point(737, 362);
            this.lbl_PostCodeError.Name = "lbl_PostCodeError";
            this.lbl_PostCodeError.Size = new System.Drawing.Size(224, 18);
            this.lbl_PostCodeError.TabIndex = 74;
            this.lbl_PostCodeError.Text = "Please enter a valid post code";
            this.lbl_PostCodeError.Visible = false;
            // 
            // lbl_PostCode
            // 
            this.lbl_PostCode.AutoSize = true;
            this.lbl_PostCode.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostCode.Location = new System.Drawing.Point(736, 311);
            this.lbl_PostCode.Name = "lbl_PostCode";
            this.lbl_PostCode.Size = new System.Drawing.Size(83, 19);
            this.lbl_PostCode.TabIndex = 73;
            this.lbl_PostCode.Text = "Post Code";
            this.lbl_PostCode.Visible = false;
            // 
            // txt_PostCode
            // 
            this.txt_PostCode.Enabled = false;
            this.txt_PostCode.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PostCode.Location = new System.Drawing.Point(740, 333);
            this.txt_PostCode.Name = "txt_PostCode";
            this.txt_PostCode.Size = new System.Drawing.Size(115, 26);
            this.txt_PostCode.TabIndex = 72;
            this.txt_PostCode.Visible = false;
            // 
            // ddl_DoBYear
            // 
            this.ddl_DoBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_DoBYear.Enabled = false;
            this.ddl_DoBYear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_DoBYear.FormattingEnabled = true;
            this.ddl_DoBYear.Location = new System.Drawing.Point(714, 417);
            this.ddl_DoBYear.Name = "ddl_DoBYear";
            this.ddl_DoBYear.Size = new System.Drawing.Size(111, 27);
            this.ddl_DoBYear.TabIndex = 79;
            this.ddl_DoBYear.Visible = false;
            // 
            // ddl_DoBMonth
            // 
            this.ddl_DoBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_DoBMonth.Enabled = false;
            this.ddl_DoBMonth.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_DoBMonth.FormattingEnabled = true;
            this.ddl_DoBMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ddl_DoBMonth.Location = new System.Drawing.Point(657, 417);
            this.ddl_DoBMonth.Name = "ddl_DoBMonth";
            this.ddl_DoBMonth.Size = new System.Drawing.Size(42, 27);
            this.ddl_DoBMonth.TabIndex = 78;
            this.ddl_DoBMonth.Visible = false;
            // 
            // ddl_DoBDay
            // 
            this.ddl_DoBDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_DoBDay.Enabled = false;
            this.ddl_DoBDay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_DoBDay.FormattingEnabled = true;
            this.ddl_DoBDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ddl_DoBDay.Location = new System.Drawing.Point(603, 417);
            this.ddl_DoBDay.Name = "ddl_DoBDay";
            this.ddl_DoBDay.Size = new System.Drawing.Size(42, 27);
            this.ddl_DoBDay.TabIndex = 77;
            this.ddl_DoBDay.Visible = false;
            // 
            // lbl_DoBError
            // 
            this.lbl_DoBError.AutoSize = true;
            this.lbl_DoBError.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoBError.ForeColor = System.Drawing.Color.Red;
            this.lbl_DoBError.Location = new System.Drawing.Point(600, 447);
            this.lbl_DoBError.Name = "lbl_DoBError";
            this.lbl_DoBError.Size = new System.Drawing.Size(241, 18);
            this.lbl_DoBError.TabIndex = 76;
            this.lbl_DoBError.Text = "Please enter a valid date of birth";
            this.lbl_DoBError.Visible = false;
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.AutoSize = true;
            this.lbl_DoB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.Location = new System.Drawing.Point(599, 396);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(100, 19);
            this.lbl_DoB.TabIndex = 75;
            this.lbl_DoB.Text = "Date of Birth";
            this.lbl_DoB.Visible = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Admin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(262, 100);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(125, 32);
            this.btn_Admin.TabIndex = 82;
            this.btn_Admin.Text = "Administrator";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sales.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.White;
            this.btn_Sales.Location = new System.Drawing.Point(134, 100);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(125, 32);
            this.btn_Sales.TabIndex = 81;
            this.btn_Sales.Text = "Sales Rep";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Customer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(6, 100);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(125, 32);
            this.btn_Customer.TabIndex = 80;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // cbx_HidePassword
            // 
            this.cbx_HidePassword.AutoSize = true;
            this.cbx_HidePassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_HidePassword.Location = new System.Drawing.Point(336, 549);
            this.cbx_HidePassword.Name = "cbx_HidePassword";
            this.cbx_HidePassword.Size = new System.Drawing.Size(141, 23);
            this.cbx_HidePassword.TabIndex = 83;
            this.cbx_HidePassword.Text = "Show Password";
            this.cbx_HidePassword.UseVisualStyleBackColor = true;
            this.cbx_HidePassword.Visible = false;
            this.cbx_HidePassword.CheckedChanged += new System.EventHandler(this.cbx_HidePassword_CheckedChanged);
            // 
            // btn_ConfirmDetails
            // 
            this.btn_ConfirmDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ConfirmDetails.Enabled = false;
            this.btn_ConfirmDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmDetails.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmDetails.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmDetails.Location = new System.Drawing.Point(921, 459);
            this.btn_ConfirmDetails.Name = "btn_ConfirmDetails";
            this.btn_ConfirmDetails.Size = new System.Drawing.Size(146, 49);
            this.btn_ConfirmDetails.TabIndex = 85;
            this.btn_ConfirmDetails.Text = "Confirm";
            this.btn_ConfirmDetails.UseVisualStyleBackColor = false;
            this.btn_ConfirmDetails.Visible = false;
            this.btn_ConfirmDetails.Click += new System.EventHandler(this.btn_ConfirmDetails_Click);
            // 
            // ddl_Users
            // 
            this.ddl_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Users.Enabled = false;
            this.ddl_Users.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_Users.FormattingEnabled = true;
            this.ddl_Users.Location = new System.Drawing.Point(12, 182);
            this.ddl_Users.Name = "ddl_Users";
            this.ddl_Users.Size = new System.Drawing.Size(372, 27);
            this.ddl_Users.TabIndex = 86;
            this.ddl_Users.Visible = false;
            this.ddl_Users.SelectedIndexChanged += new System.EventHandler(this.ddl_Users_SelectedIndexChanged);
            // 
            // ddl_LogID
            // 
            this.ddl_LogID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_LogID.Enabled = false;
            this.ddl_LogID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_LogID.FormattingEnabled = true;
            this.ddl_LogID.Location = new System.Drawing.Point(12, 215);
            this.ddl_LogID.Name = "ddl_LogID";
            this.ddl_LogID.Size = new System.Drawing.Size(111, 27);
            this.ddl_LogID.TabIndex = 87;
            this.ddl_LogID.Visible = false;
            // 
            // ddl_UID
            // 
            this.ddl_UID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_UID.Enabled = false;
            this.ddl_UID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_UID.FormattingEnabled = true;
            this.ddl_UID.Location = new System.Drawing.Point(148, 215);
            this.ddl_UID.Name = "ddl_UID";
            this.ddl_UID.Size = new System.Drawing.Size(111, 27);
            this.ddl_UID.TabIndex = 88;
            this.ddl_UID.Visible = false;
            // 
            // ddl_AddID
            // 
            this.ddl_AddID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_AddID.Enabled = false;
            this.ddl_AddID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_AddID.FormattingEnabled = true;
            this.ddl_AddID.Location = new System.Drawing.Point(273, 215);
            this.ddl_AddID.Name = "ddl_AddID";
            this.ddl_AddID.Size = new System.Drawing.Size(111, 27);
            this.ddl_AddID.TabIndex = 89;
            this.ddl_AddID.Visible = false;
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Users.Location = new System.Drawing.Point(8, 161);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(107, 19);
            this.lbl_Users.TabIndex = 90;
            this.lbl_Users.Text = "Select a user:";
            this.lbl_Users.Visible = false;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Message.Location = new System.Drawing.Point(130, 311);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(942, 23);
            this.lbl_Message.TabIndex = 91;
            this.lbl_Message.Text = "You have successfully updated all details for this user. Either select a new user" +
    " or return to menu.";
            this.lbl_Message.Visible = false;
            // 
            // cbx_UserName
            // 
            this.cbx_UserName.AutoSize = true;
            this.cbx_UserName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_UserName.Location = new System.Drawing.Point(336, 480);
            this.cbx_UserName.Name = "cbx_UserName";
            this.cbx_UserName.Size = new System.Drawing.Size(145, 23);
            this.cbx_UserName.TabIndex = 92;
            this.cbx_UserName.Text = "Keep Username";
            this.cbx_UserName.UseVisualStyleBackColor = true;
            this.cbx_UserName.Visible = false;
            this.cbx_UserName.CheckedChanged += new System.EventHandler(this.cbx_UserName_CheckedChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Gray;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Menu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu.Location = new System.Drawing.Point(12, 9);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(83, 33);
            this.btn_Menu.TabIndex = 94;
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
            this.btn_Logout.Location = new System.Drawing.Point(101, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(83, 33);
            this.btn_Logout.TabIndex = 93;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteUser.Enabled = false;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Location = new System.Drawing.Point(484, 273);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(146, 49);
            this.btn_DeleteUser.TabIndex = 95;
            this.btn_DeleteUser.Text = "Delete";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Visible = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(484, 337);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(146, 49);
            this.btn_Cancel.TabIndex = 96;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.cbx_UserName);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Users);
            this.Controls.Add(this.ddl_AddID);
            this.Controls.Add(this.ddl_UID);
            this.Controls.Add(this.ddl_LogID);
            this.Controls.Add(this.ddl_Users);
            this.Controls.Add(this.btn_ConfirmDetails);
            this.Controls.Add(this.cbx_HidePassword);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Sales);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.ddl_DoBYear);
            this.Controls.Add(this.ddl_DoBMonth);
            this.Controls.Add(this.ddl_DoBDay);
            this.Controls.Add(this.lbl_DoBError);
            this.Controls.Add(this.lbl_DoB);
            this.Controls.Add(this.lbl_PostCodeError);
            this.Controls.Add(this.lbl_PostCode);
            this.Controls.Add(this.txt_PostCode);
            this.Controls.Add(this.lbl_TownNameError);
            this.Controls.Add(this.lbl_TownName);
            this.Controls.Add(this.txt_TownName);
            this.Controls.Add(this.lbl_RoadNameError);
            this.Controls.Add(this.lbl_RoadName);
            this.Controls.Add(this.txt_RoadName);
            this.Controls.Add(this.lbl_HouseNumberError);
            this.Controls.Add(this.lbl_HouseNumber);
            this.Controls.Add(this.txt_HouseNumber);
            this.Controls.Add(this.txt_PassHint);
            this.Controls.Add(this.btn_UserHint);
            this.Controls.Add(this.lbl_UsernameError);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_PassHint);
            this.Controls.Add(this.lbl_PasswordError);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_PhoneError);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_EmailError);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_LNameError);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.lbl_FNameError);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditUser";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_FNameError;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label lbl_LNameError;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.Label lbl_EmailError;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_PhoneError;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btn_PassHint;
        private System.Windows.Forms.Label lbl_PasswordError;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_UserHint;
        private System.Windows.Forms.Label lbl_UsernameError;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_PassHint;
        private System.Windows.Forms.Label lbl_HouseNumberError;
        private System.Windows.Forms.Label lbl_HouseNumber;
        private System.Windows.Forms.TextBox txt_HouseNumber;
        private System.Windows.Forms.Label lbl_RoadNameError;
        private System.Windows.Forms.Label lbl_RoadName;
        private System.Windows.Forms.TextBox txt_RoadName;
        private System.Windows.Forms.Label lbl_TownNameError;
        private System.Windows.Forms.Label lbl_TownName;
        private System.Windows.Forms.TextBox txt_TownName;
        private System.Windows.Forms.Label lbl_PostCodeError;
        private System.Windows.Forms.Label lbl_PostCode;
        private System.Windows.Forms.TextBox txt_PostCode;
        private System.Windows.Forms.ComboBox ddl_DoBYear;
        private System.Windows.Forms.ComboBox ddl_DoBMonth;
        private System.Windows.Forms.ComboBox ddl_DoBDay;
        private System.Windows.Forms.Label lbl_DoBError;
        private System.Windows.Forms.Label lbl_DoB;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.CheckBox cbx_HidePassword;
        private System.Windows.Forms.Button btn_ConfirmDetails;
        private System.Windows.Forms.ComboBox ddl_Users;
        private System.Windows.Forms.ComboBox ddl_LogID;
        private System.Windows.Forms.ComboBox ddl_UID;
        private System.Windows.Forms.ComboBox ddl_AddID;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.CheckBox cbx_UserName;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_Cancel;
    }
}