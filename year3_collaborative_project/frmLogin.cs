using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Connection to classes file
using year3_collaborative_project.classes;

namespace year3_collaborative_project
{
    using BCrypt = BCrypt.Net.BCrypt;
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsDatabase objDatabase = new clsDatabase();
            lblAlert.Visible = false;
            clsUser.AccessLevel = '\0';
            clsUser.Username = "";
            clsUser.Password = "";
            this.AcceptButton = btnSubmit;

        }

        private void cbHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            //Hide & Show password and change label when combo box is selected
            if (cbHidePassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; //'\0' equals a null character 
                cbHidePassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                cbHidePassword.Text = "Show Password";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblAlert.Text = "Please input your username and password.";
                lblAlert.Visible = true;
                return;
            }

            //Set sUsername & sPassword to their respective text boxes (Set username to all lowercase)
            string sUsername = txtUsername.Text.ToLower();
            string sPassword = txtPassword.Text;
            string sEncryptedPassword;
            clsDatabase_Users objDatabase = new clsDatabase_Users();

            //Create object from clsEncryption.cs
            clsEncryption objEncryption = new clsEncryption();

            //set sEncryptedPassword to the result of the EncryptPassword function
            sEncryptedPassword = objEncryption.EncryptPassword(sPassword);

            string sUsernameVerify = objDatabase.GetUsername(sUsername).ToLower();

            if (objDatabase.GetPassword(sUsername) != "")
            {
                bool bVerify = BCrypt.Verify(txtPassword.Text, objDatabase.GetPassword(sUsername));

                if (sUsername == sUsernameVerify && bVerify == true) //Check username/password match one stored in database
                {
                    //show new menu form and hide frmLogin
                    int iAccessLevel = objDatabase.GetAccessLevel(sUsername);
                    int iUserID = objDatabase.GetUserID(sUsername);
                    clsUser.AccessLevel = iAccessLevel;
                    clsUser.Username = sUsername;
                    clsUser.Password = sPassword;
                    clsUser.IUserID = iUserID;

                    clsUser.BLoggedIn = true;

                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    //Display the alert label and change its text
                    lblAlert.Visible = true;
                    lblAlert.Text = "You have inputted your detils incorrectly.";

                    //Future job...add sound on fail
                }
            }
            else
            {
                //Display the alert label and change its text
                lblAlert.Visible = true;
                lblAlert.Text = "You have inputted your detils incorrectly.";

                //Future job...add sound on fail
            }
        }

        private void btn_TestUser_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void btn_TestSales_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void btn_TestAdmin_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}
