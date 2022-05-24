
namespace year3_collaborative_project
{
    partial class frm_VehicleSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VehicleSelection));
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.img_SelectionImage = new System.Windows.Forms.PictureBox();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.ddl_VehicleSelect = new System.Windows.Forms.ComboBox();
            this.img_TextBacking = new System.Windows.Forms.PictureBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.lbl_VehicleMake = new System.Windows.Forms.Label();
            this.lbl_VehicleModel = new System.Windows.Forms.Label();
            this.img_BrandLogo = new System.Windows.Forms.PictureBox();
            this.lbl_EngineInd = new System.Windows.Forms.Label();
            this.lbl_DoorsInd = new System.Windows.Forms.Label();
            this.lbl_FuelInd = new System.Windows.Forms.Label();
            this.lbl_TransmissionInd = new System.Windows.Forms.Label();
            this.lbl_YearInd = new System.Windows.Forms.Label();
            this.lbl_MilesPGInd = new System.Windows.Forms.Label();
            this.lbl_DriveInd = new System.Windows.Forms.Label();
            this.lbl_EmissionInd = new System.Windows.Forms.Label();
            this.lbl_BasePriceInd = new System.Windows.Forms.Label();
            this.lbl_BasePrice = new System.Windows.Forms.Label();
            this.lbl_Emission = new System.Windows.Forms.Label();
            this.lbl_Drive = new System.Windows.Forms.Label();
            this.lbl_MilesPG = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Transmission = new System.Windows.Forms.Label();
            this.lbl_Fuel = new System.Windows.Forms.Label();
            this.lbl_Doors = new System.Windows.Forms.Label();
            this.lbl_Engine = new System.Windows.Forms.Label();
            this.ddl_VehicleID = new System.Windows.Forms.ComboBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lbl_Index = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_SelectionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_TextBacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_BrandLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(101, 17);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(83, 33);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(451, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(285, 39);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Vehicle Selection";
            // 
            // img_SelectionImage
            // 
            this.img_SelectionImage.BackColor = System.Drawing.Color.White;
            this.img_SelectionImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_SelectionImage.BackgroundImage")));
            this.img_SelectionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_SelectionImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_SelectionImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_SelectionImage.Location = new System.Drawing.Point(12, 64);
            this.img_SelectionImage.Name = "img_SelectionImage";
            this.img_SelectionImage.Size = new System.Drawing.Size(777, 494);
            this.img_SelectionImage.TabIndex = 3;
            this.img_SelectionImage.TabStop = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Previous.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(142, 564);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(140, 49);
            this.btn_Previous.TabIndex = 4;
            this.btn_Previous.Text = "<< Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Next.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(649, 564);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(140, 49);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next >>";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // ddl_VehicleSelect
            // 
            this.ddl_VehicleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_VehicleSelect.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_VehicleSelect.FormattingEnabled = true;
            this.ddl_VehicleSelect.Location = new System.Drawing.Point(291, 573);
            this.ddl_VehicleSelect.Name = "ddl_VehicleSelect";
            this.ddl_VehicleSelect.Size = new System.Drawing.Size(340, 31);
            this.ddl_VehicleSelect.TabIndex = 6;
            this.ddl_VehicleSelect.SelectedIndexChanged += new System.EventHandler(this.ddl_VehicleSelect_SelectedIndexChanged);
            // 
            // img_TextBacking
            // 
            this.img_TextBacking.BackColor = System.Drawing.Color.White;
            this.img_TextBacking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_TextBacking.BackgroundImage")));
            this.img_TextBacking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_TextBacking.Location = new System.Drawing.Point(795, 64);
            this.img_TextBacking.Name = "img_TextBacking";
            this.img_TextBacking.Size = new System.Drawing.Size(306, 494);
            this.img_TextBacking.TabIndex = 7;
            this.img_TextBacking.TabStop = false;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Gray;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Menu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu.Location = new System.Drawing.Point(12, 17);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(83, 33);
            this.btn_Menu.TabIndex = 8;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // lbl_VehicleMake
            // 
            this.lbl_VehicleMake.AutoSize = true;
            this.lbl_VehicleMake.BackColor = System.Drawing.Color.White;
            this.lbl_VehicleMake.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleMake.Location = new System.Drawing.Point(823, 99);
            this.lbl_VehicleMake.Name = "lbl_VehicleMake";
            this.lbl_VehicleMake.Size = new System.Drawing.Size(118, 29);
            this.lbl_VehicleMake.TabIndex = 9;
            this.lbl_VehicleMake.Text = "*MAKE*";
            // 
            // lbl_VehicleModel
            // 
            this.lbl_VehicleModel.AutoSize = true;
            this.lbl_VehicleModel.BackColor = System.Drawing.Color.White;
            this.lbl_VehicleModel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleModel.Location = new System.Drawing.Point(823, 128);
            this.lbl_VehicleModel.Name = "lbl_VehicleModel";
            this.lbl_VehicleModel.Size = new System.Drawing.Size(134, 30);
            this.lbl_VehicleModel.TabIndex = 10;
            this.lbl_VehicleModel.Text = "*MODEL*";
            // 
            // img_BrandLogo
            // 
            this.img_BrandLogo.BackColor = System.Drawing.Color.White;
            this.img_BrandLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_BrandLogo.BackgroundImage")));
            this.img_BrandLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_BrandLogo.Location = new System.Drawing.Point(990, 94);
            this.img_BrandLogo.Name = "img_BrandLogo";
            this.img_BrandLogo.Size = new System.Drawing.Size(85, 80);
            this.img_BrandLogo.TabIndex = 11;
            this.img_BrandLogo.TabStop = false;
            // 
            // lbl_EngineInd
            // 
            this.lbl_EngineInd.AutoSize = true;
            this.lbl_EngineInd.BackColor = System.Drawing.Color.White;
            this.lbl_EngineInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EngineInd.Location = new System.Drawing.Point(827, 311);
            this.lbl_EngineInd.Name = "lbl_EngineInd";
            this.lbl_EngineInd.Size = new System.Drawing.Size(98, 19);
            this.lbl_EngineInd.TabIndex = 12;
            this.lbl_EngineInd.Text = "Engine Size:";
            // 
            // lbl_DoorsInd
            // 
            this.lbl_DoorsInd.AutoSize = true;
            this.lbl_DoorsInd.BackColor = System.Drawing.Color.White;
            this.lbl_DoorsInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoorsInd.Location = new System.Drawing.Point(827, 206);
            this.lbl_DoorsInd.Name = "lbl_DoorsInd";
            this.lbl_DoorsInd.Size = new System.Drawing.Size(58, 19);
            this.lbl_DoorsInd.TabIndex = 13;
            this.lbl_DoorsInd.Text = "Doors:";
            // 
            // lbl_FuelInd
            // 
            this.lbl_FuelInd.AutoSize = true;
            this.lbl_FuelInd.BackColor = System.Drawing.Color.White;
            this.lbl_FuelInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FuelInd.Location = new System.Drawing.Point(827, 345);
            this.lbl_FuelInd.Name = "lbl_FuelInd";
            this.lbl_FuelInd.Size = new System.Drawing.Size(86, 19);
            this.lbl_FuelInd.TabIndex = 14;
            this.lbl_FuelInd.Text = "Fuel Type:";
            // 
            // lbl_TransmissionInd
            // 
            this.lbl_TransmissionInd.AutoSize = true;
            this.lbl_TransmissionInd.BackColor = System.Drawing.Color.White;
            this.lbl_TransmissionInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransmissionInd.Location = new System.Drawing.Point(827, 453);
            this.lbl_TransmissionInd.Name = "lbl_TransmissionInd";
            this.lbl_TransmissionInd.Size = new System.Drawing.Size(109, 19);
            this.lbl_TransmissionInd.TabIndex = 15;
            this.lbl_TransmissionInd.Text = "Transmission:";
            // 
            // lbl_YearInd
            // 
            this.lbl_YearInd.AutoSize = true;
            this.lbl_YearInd.BackColor = System.Drawing.Color.White;
            this.lbl_YearInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YearInd.Location = new System.Drawing.Point(827, 382);
            this.lbl_YearInd.Name = "lbl_YearInd";
            this.lbl_YearInd.Size = new System.Drawing.Size(117, 19);
            this.lbl_YearInd.TabIndex = 16;
            this.lbl_YearInd.Text = "Manufactured:";
            // 
            // lbl_MilesPGInd
            // 
            this.lbl_MilesPGInd.AutoSize = true;
            this.lbl_MilesPGInd.BackColor = System.Drawing.Color.White;
            this.lbl_MilesPGInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MilesPGInd.Location = new System.Drawing.Point(827, 275);
            this.lbl_MilesPGInd.Name = "lbl_MilesPGInd";
            this.lbl_MilesPGInd.Size = new System.Drawing.Size(51, 19);
            this.lbl_MilesPGInd.TabIndex = 17;
            this.lbl_MilesPGInd.Text = "MpG:";
            // 
            // lbl_DriveInd
            // 
            this.lbl_DriveInd.AutoSize = true;
            this.lbl_DriveInd.BackColor = System.Drawing.Color.White;
            this.lbl_DriveInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DriveInd.Location = new System.Drawing.Point(827, 239);
            this.lbl_DriveInd.Name = "lbl_DriveInd";
            this.lbl_DriveInd.Size = new System.Drawing.Size(96, 19);
            this.lbl_DriveInd.TabIndex = 18;
            this.lbl_DriveInd.Text = "Drive Type:";
            // 
            // lbl_EmissionInd
            // 
            this.lbl_EmissionInd.AutoSize = true;
            this.lbl_EmissionInd.BackColor = System.Drawing.Color.White;
            this.lbl_EmissionInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmissionInd.Location = new System.Drawing.Point(827, 419);
            this.lbl_EmissionInd.Name = "lbl_EmissionInd";
            this.lbl_EmissionInd.Size = new System.Drawing.Size(85, 19);
            this.lbl_EmissionInd.TabIndex = 19;
            this.lbl_EmissionInd.Text = "Emissions:";
            // 
            // lbl_BasePriceInd
            // 
            this.lbl_BasePriceInd.AutoSize = true;
            this.lbl_BasePriceInd.BackColor = System.Drawing.Color.White;
            this.lbl_BasePriceInd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BasePriceInd.Location = new System.Drawing.Point(827, 176);
            this.lbl_BasePriceInd.Name = "lbl_BasePriceInd";
            this.lbl_BasePriceInd.Size = new System.Drawing.Size(89, 19);
            this.lbl_BasePriceInd.TabIndex = 20;
            this.lbl_BasePriceInd.Text = "Base Price:";
            // 
            // lbl_BasePrice
            // 
            this.lbl_BasePrice.AutoSize = true;
            this.lbl_BasePrice.BackColor = System.Drawing.Color.White;
            this.lbl_BasePrice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BasePrice.Location = new System.Drawing.Point(922, 176);
            this.lbl_BasePrice.Name = "lbl_BasePrice";
            this.lbl_BasePrice.Size = new System.Drawing.Size(57, 18);
            this.lbl_BasePrice.TabIndex = 29;
            this.lbl_BasePrice.Text = "£££££££";
            // 
            // lbl_Emission
            // 
            this.lbl_Emission.AutoSize = true;
            this.lbl_Emission.BackColor = System.Drawing.Color.White;
            this.lbl_Emission.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emission.Location = new System.Drawing.Point(918, 419);
            this.lbl_Emission.Name = "lbl_Emission";
            this.lbl_Emission.Size = new System.Drawing.Size(94, 18);
            this.lbl_Emission.TabIndex = 28;
            this.lbl_Emission.Text = "*Emissions*";
            // 
            // lbl_Drive
            // 
            this.lbl_Drive.AutoSize = true;
            this.lbl_Drive.BackColor = System.Drawing.Color.White;
            this.lbl_Drive.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drive.Location = new System.Drawing.Point(929, 239);
            this.lbl_Drive.Name = "lbl_Drive";
            this.lbl_Drive.Size = new System.Drawing.Size(62, 18);
            this.lbl_Drive.TabIndex = 27;
            this.lbl_Drive.Text = "*Drive*";
            // 
            // lbl_MilesPG
            // 
            this.lbl_MilesPG.AutoSize = true;
            this.lbl_MilesPG.BackColor = System.Drawing.Color.White;
            this.lbl_MilesPG.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MilesPG.Location = new System.Drawing.Point(884, 275);
            this.lbl_MilesPG.Name = "lbl_MilesPG";
            this.lbl_MilesPG.Size = new System.Drawing.Size(60, 18);
            this.lbl_MilesPG.TabIndex = 26;
            this.lbl_MilesPG.Text = "*MpG*";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.BackColor = System.Drawing.Color.White;
            this.lbl_Year.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(950, 382);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(57, 18);
            this.lbl_Year.TabIndex = 25;
            this.lbl_Year.Text = "*Year*";
            // 
            // lbl_Transmission
            // 
            this.lbl_Transmission.AutoSize = true;
            this.lbl_Transmission.BackColor = System.Drawing.Color.White;
            this.lbl_Transmission.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transmission.Location = new System.Drawing.Point(949, 453);
            this.lbl_Transmission.Name = "lbl_Transmission";
            this.lbl_Transmission.Size = new System.Drawing.Size(125, 18);
            this.lbl_Transmission.TabIndex = 24;
            this.lbl_Transmission.Text = "*Transmissions*";
            // 
            // lbl_Fuel
            // 
            this.lbl_Fuel.AutoSize = true;
            this.lbl_Fuel.BackColor = System.Drawing.Color.White;
            this.lbl_Fuel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fuel.Location = new System.Drawing.Point(919, 345);
            this.lbl_Fuel.Name = "lbl_Fuel";
            this.lbl_Fuel.Size = new System.Drawing.Size(94, 18);
            this.lbl_Fuel.TabIndex = 23;
            this.lbl_Fuel.Text = "*Fuel Type*";
            // 
            // lbl_Doors
            // 
            this.lbl_Doors.AutoSize = true;
            this.lbl_Doors.BackColor = System.Drawing.Color.White;
            this.lbl_Doors.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doors.Location = new System.Drawing.Point(891, 206);
            this.lbl_Doors.Name = "lbl_Doors";
            this.lbl_Doors.Size = new System.Drawing.Size(66, 18);
            this.lbl_Doors.TabIndex = 22;
            this.lbl_Doors.Text = "*Doors*";
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.BackColor = System.Drawing.Color.White;
            this.lbl_Engine.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Engine.Location = new System.Drawing.Point(931, 311);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(106, 18);
            this.lbl_Engine.TabIndex = 21;
            this.lbl_Engine.Text = "*Engine Size*";
            // 
            // ddl_VehicleID
            // 
            this.ddl_VehicleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_VehicleID.FormattingEnabled = true;
            this.ddl_VehicleID.Location = new System.Drawing.Point(407, 611);
            this.ddl_VehicleID.Name = "ddl_VehicleID";
            this.ddl_VehicleID.Size = new System.Drawing.Size(121, 21);
            this.ddl_VehicleID.TabIndex = 30;
            this.ddl_VehicleID.Visible = false;
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Select.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(885, 484);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(140, 40);
            this.btn_Select.TabIndex = 31;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // lbl_Index
            // 
            this.lbl_Index.AutoSize = true;
            this.lbl_Index.Location = new System.Drawing.Point(1094, 9);
            this.lbl_Index.Name = "lbl_Index";
            this.lbl_Index.Size = new System.Drawing.Size(35, 13);
            this.lbl_Index.TabIndex = 32;
            this.lbl_Index.Text = "label1";
            this.lbl_Index.Visible = false;
            // 
            // frm_VehicleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1141, 657);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Index);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.ddl_VehicleID);
            this.Controls.Add(this.lbl_BasePrice);
            this.Controls.Add(this.lbl_Emission);
            this.Controls.Add(this.lbl_Drive);
            this.Controls.Add(this.lbl_MilesPG);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Transmission);
            this.Controls.Add(this.lbl_Fuel);
            this.Controls.Add(this.lbl_Doors);
            this.Controls.Add(this.lbl_Engine);
            this.Controls.Add(this.lbl_BasePriceInd);
            this.Controls.Add(this.lbl_EmissionInd);
            this.Controls.Add(this.lbl_DriveInd);
            this.Controls.Add(this.lbl_MilesPGInd);
            this.Controls.Add(this.lbl_YearInd);
            this.Controls.Add(this.lbl_TransmissionInd);
            this.Controls.Add(this.lbl_FuelInd);
            this.Controls.Add(this.lbl_DoorsInd);
            this.Controls.Add(this.lbl_EngineInd);
            this.Controls.Add(this.img_BrandLogo);
            this.Controls.Add(this.lbl_VehicleModel);
            this.Controls.Add(this.lbl_VehicleMake);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.img_TextBacking);
            this.Controls.Add(this.ddl_VehicleSelect);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.img_SelectionImage);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VehicleSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.frm_VehicleSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_SelectionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_TextBacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_BrandLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox img_SelectionImage;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ComboBox ddl_VehicleSelect;
        private System.Windows.Forms.PictureBox img_TextBacking;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label lbl_VehicleMake;
        private System.Windows.Forms.Label lbl_VehicleModel;
        private System.Windows.Forms.PictureBox img_BrandLogo;
        private System.Windows.Forms.Label lbl_EngineInd;
        private System.Windows.Forms.Label lbl_DoorsInd;
        private System.Windows.Forms.Label lbl_FuelInd;
        private System.Windows.Forms.Label lbl_TransmissionInd;
        private System.Windows.Forms.Label lbl_YearInd;
        private System.Windows.Forms.Label lbl_MilesPGInd;
        private System.Windows.Forms.Label lbl_DriveInd;
        private System.Windows.Forms.Label lbl_EmissionInd;
        private System.Windows.Forms.Label lbl_BasePriceInd;
        private System.Windows.Forms.Label lbl_BasePrice;
        private System.Windows.Forms.Label lbl_Emission;
        private System.Windows.Forms.Label lbl_Drive;
        private System.Windows.Forms.Label lbl_MilesPG;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Transmission;
        private System.Windows.Forms.Label lbl_Fuel;
        private System.Windows.Forms.Label lbl_Doors;
        private System.Windows.Forms.Label lbl_Engine;
        private System.Windows.Forms.ComboBox ddl_VehicleID;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label lbl_Index;
    }
}