
namespace year3_collaborative_project
{
    partial class frmActivateMod
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.clbWhichMod = new System.Windows.Forms.CheckedListBox();
            this.lblWhichMod = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(15, 464);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 41);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(646, 161);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(415, 52);
            this.lblAlert.TabIndex = 28;
            this.lblAlert.Text = "lblAlert";
            this.lblAlert.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(228, 295);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 43);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // clbWhichMod
            // 
            this.clbWhichMod.FormattingEnabled = true;
            this.clbWhichMod.Location = new System.Drawing.Point(228, 148);
            this.clbWhichMod.Name = "clbWhichMod";
            this.clbWhichMod.Size = new System.Drawing.Size(412, 140);
            this.clbWhichMod.TabIndex = 26;
            // 
            // lblWhichMod
            // 
            this.lblWhichMod.AutoSize = true;
            this.lblWhichMod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichMod.Location = new System.Drawing.Point(224, 123);
            this.lblWhichMod.Name = "lblWhichMod";
            this.lblWhichMod.Size = new System.Drawing.Size(453, 22);
            this.lblWhichMod.TabIndex = 25;
            this.lblWhichMod.Text = "Which Modification Would You Like To Activate?";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(219, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 50);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Activate A Modification";
            // 
            // frmActivateMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1073, 525);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.clbWhichMod);
            this.Controls.Add(this.lblWhichMod);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivateMod";
            this.Text = "d";
            this.Load += new System.EventHandler(this.frmActivateMod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckedListBox clbWhichMod;
        private System.Windows.Forms.Label lblWhichMod;
        private System.Windows.Forms.Label lblTitle;
    }
}