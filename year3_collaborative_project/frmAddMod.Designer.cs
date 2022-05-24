namespace year3_collaborative_project
{
    partial class frmAddMod
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
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.lblModName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblComplete = new System.Windows.Forms.Label();
            this.clbAvailable = new System.Windows.Forms.CheckedListBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Nova", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(250, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add a Modification";
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLabel.Location = new System.Drawing.Point(235, 66);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(133, 22);
            this.lblPriceLabel.TabIndex = 2;
            this.lblPriceLabel.Text = "Price in Pounds";
            // 
            // cbColour
            // 
            this.cbColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbColour.Location = new System.Drawing.Point(377, 109);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(121, 21);
            this.cbColour.TabIndex = 3;
            this.cbColour.Visible = false;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(149, 109);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(219, 22);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Is The New Mod a Colour?";
            this.lblColour.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 403);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 33);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(377, 94);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(377, 149);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(100, 20);
            this.txtModName.TabIndex = 16;
            this.txtModName.Visible = false;
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModName.Location = new System.Drawing.Point(159, 149);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(209, 22);
            this.lblModName.TabIndex = 17;
            this.lblModName.Text = "What Is the Mod\'s Name?";
            this.lblModName.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(377, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(377, 66);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 19;
            // 
            // lblComplete
            // 
            this.lblComplete.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(516, 62);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(272, 94);
            this.lblComplete.TabIndex = 20;
            this.lblComplete.Text = "label1";
            this.lblComplete.Visible = false;
            // 
            // clbAvailable
            // 
            this.clbAvailable.FormattingEnabled = true;
            this.clbAvailable.Location = new System.Drawing.Point(377, 185);
            this.clbAvailable.Name = "clbAvailable";
            this.clbAvailable.Size = new System.Drawing.Size(120, 94);
            this.clbAvailable.TabIndex = 21;
            this.clbAvailable.Visible = false;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(49, 185);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(319, 22);
            this.lblAvailable.TabIndex = 22;
            this.lblAvailable.Text = "What Cars is This Mod Available With?";
            this.lblAvailable.Visible = false;
            // 
            // frmAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.clbAvailable);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.cbColour);
            this.Controls.Add(this.lblPriceLabel);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMod";
            this.Text = "frmAddMod";
            this.Load += new System.EventHandler(this.frmAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.CheckedListBox clbAvailable;
        private System.Windows.Forms.Label lblAvailable;
    }
}