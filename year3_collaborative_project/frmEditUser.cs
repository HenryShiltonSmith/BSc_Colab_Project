using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using year3_collaborative_project.classes;

namespace year3_collaborative_project
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {

            txt_FName.Text = "";
            txt_LName.Text = "";
            txt_Email.Text = "";
            txt_Phone.Text = "";
            txt_HouseNumber.Text = "";
            txt_RoadName.Text = "";
            txt_TownName.Text = "";
            txt_PostCode.Text = "";
            ddl_DoBDay.Text = "";
            ddl_DoBMonth.Text = "";
            ddl_DoBYear.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";

        }

        public void HideFormLayout()
        {

            //--------------------------------Section-----------------------------------------------------

            //Users details form Layout Configuration

            ddl_Users.Visible = false;
            ddl_Users.Enabled = false;

            lbl_FName.Visible = false;

            txt_FName.Visible = false;
            txt_FName.Enabled = false;

            lbl_FNameError.Visible = false;

            lbl_LName.Visible = false;

            txt_LName.Visible = false;
            txt_LName.Enabled = false;

            lbl_LNameError.Visible = false;

            lbl_Email.Visible = false;

            txt_Email.Visible = false;
            txt_Email.Enabled = false;

            lbl_EmailError.Visible = false;

            lbl_Phone.Visible = false;

            txt_Phone.Visible = false;
            txt_Phone.Enabled = false;

            lbl_PhoneError.Visible = false;

            lbl_DoB.Visible = false;

            ddl_DoBDay.Visible = false;
            ddl_DoBDay.Enabled = false;

            ddl_DoBMonth.Visible = false;
            ddl_DoBMonth.Enabled = false;

            ddl_DoBYear.Visible = false;
            ddl_DoBYear.Enabled = false;

            lbl_DoBError.Visible = false;

            lbl_HouseNumber.Visible = false;

            txt_HouseNumber.Enabled = false;
            txt_HouseNumber.Visible = false;

            lbl_HouseNumberError.Visible = false;

            lbl_RoadName.Visible = false;

            txt_RoadName.Enabled = false;
            txt_RoadName.Visible = false;

            lbl_RoadNameError.Visible = false;

            lbl_TownName.Visible = false;

            txt_TownName.Enabled = false;
            txt_TownName.Visible = false;

            lbl_TownNameError.Visible = false;

            lbl_PostCode.Visible = false;

            txt_PostCode.Enabled = false;
            txt_PostCode.Visible = false;

            lbl_PostCodeError.Visible = false;

            lbl_Username.Visible = false;

            txt_Username.Visible = false;
            txt_Username.Enabled = false;

            lbl_UsernameError.Visible = false;

            cbx_UserName.Visible = false;

            lbl_Password.Visible = false;

            txt_Password.Visible = false;
            txt_Password.Enabled = false;

            cbx_HidePassword.Visible = false;

            btn_PassHint.Visible = false;

            btn_UserHint.Visible = false;

            txt_PassHint.Visible = false;

            lbl_PasswordError.Visible = false;

            lbl_Message.Visible = false;

            //--------------------------------End Section-----------------------------------------------

        }

        public void PopulateUserBox()
        {

            ddl_Users.Items.Clear();
            ddl_UID.Items.Clear();
            ddl_LogID.Items.Clear();
            ddl_AddID.Items.Clear();
            
            int iLvl = 0;
            int iCount = 0;

            if (btn_Admin.Enabled == false)
            {

                iLvl = 2;

            }
            else if (btn_Sales.Enabled == false)
            {

                iLvl = 1;

            }

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            //--------------------------------Section-----------------------------------------------------

            //Populates dropboxs by pulling down an array from class database

            string[,] sUsers = clsUsers.GetUsers(iLvl);

            for (iCount = 0; iCount < sUsers.GetLength(0); iCount++)
            {

                ddl_Users.Items.Add(sUsers[iCount, 1] + " " + sUsers[iCount, 0] + " : " + sUsers[iCount, 2]);
                ddl_LogID.Items.Add(sUsers[iCount, 3]);
                ddl_UID.Items.Add(sUsers[iCount, 4]);

                if (btn_Customer.Enabled == false)
                {

                    ddl_AddID.Items.Add(sUsers[iCount, 5]);

                }

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void SetFormLayout()
        {

            //--------------------------------Section-----------------------------------------------------

            //Users details form Layout Configuration

            ddl_Users.Visible = true;
            ddl_Users.Enabled = true;
            
            lbl_FName.Visible = true;

            txt_FName.Visible = true;
            txt_FName.Enabled = true;

            lbl_FNameError.Visible = false;

            lbl_LName.Visible = true;

            txt_LName.Visible = true;
            txt_LName.Enabled = true;

            lbl_LNameError.Visible = false;

            lbl_Email.Visible = true;

            txt_Email.Visible = true;
            txt_Email.Enabled = true;

            lbl_EmailError.Visible = false;

            lbl_Phone.Visible = true;

            txt_Phone.Visible = true;
            txt_Phone.Enabled = true;

            lbl_PhoneError.Visible = false;

            if (btn_Customer.Enabled == false)
            {

                lbl_DoB.Visible = true;

                ddl_DoBDay.Visible = true;
                ddl_DoBDay.Enabled = true;

                ddl_DoBMonth.Visible = true;
                ddl_DoBMonth.Enabled = true;

                ddl_DoBYear.Visible = true;
                ddl_DoBYear.Enabled = true;

                lbl_DoBError.Visible = false;

                lbl_HouseNumber.Visible = true;

                txt_HouseNumber.Enabled = true;
                txt_HouseNumber.Visible = true;

                lbl_HouseNumberError.Visible = false;

                lbl_RoadName.Visible = true;

                txt_RoadName.Enabled = true;
                txt_RoadName.Visible = true;

                lbl_RoadNameError.Visible = false;

                lbl_TownName.Visible = true;

                txt_TownName.Enabled = true;
                txt_TownName.Visible = true;

                lbl_TownNameError.Visible = false;

                lbl_PostCode.Visible = true;

                txt_PostCode.Enabled = true;
                txt_PostCode.Visible = true;

                lbl_PostCodeError.Visible = false;

            }
            else
            {

                lbl_DoB.Visible = false;

                ddl_DoBDay.Visible = false;
                ddl_DoBDay.Enabled = false;

                ddl_DoBMonth.Visible = false;
                ddl_DoBMonth.Enabled = false;

                ddl_DoBYear.Visible = false;
                ddl_DoBYear.Enabled = false;

                lbl_DoBError.Visible = false;

                lbl_HouseNumber.Visible = false;

                txt_HouseNumber.Enabled = false;
                txt_HouseNumber.Visible = false;

                lbl_HouseNumberError.Visible = false;

                lbl_RoadName.Visible = false;

                txt_RoadName.Enabled = false;
                txt_RoadName.Visible = false;

                lbl_RoadNameError.Visible = false;

                lbl_TownName.Visible = false;

                txt_TownName.Enabled = false;
                txt_TownName.Visible = false;

                lbl_TownNameError.Visible = false;

                lbl_PostCode.Visible = false;

                txt_PostCode.Enabled = false;
                txt_PostCode.Visible = false;

                lbl_PostCodeError.Visible = false;

            }

            lbl_Username.Visible = true;

            txt_Username.Visible = true;

            lbl_UsernameError.Visible = false;

            cbx_UserName.Visible = true;
            cbx_UserName.Checked = true;

            lbl_Password.Visible = true;

            txt_Password.Visible = true;
            txt_Password.Enabled = true;

            cbx_HidePassword.Visible = true;

            btn_PassHint.Visible = true;

            btn_UserHint.Visible = true;

            txt_PassHint.Visible = false;

            lbl_PasswordError.Visible = false;

            lbl_Message.Visible = false;
            lbl_Message.Location = new Point(130, 311);
            lbl_Message.ForeColor = Color.Black;

            //--------------------------------End Section-----------------------------------------------

        }

        public void HidePrimarySelection()
        {

            btn_Customer.Visible = false;
            btn_Sales.Visible = false;
            btn_Admin.Visible = false;

        }

        public void SetPrimarySelection()
        {

            //--------------Formats main selection buttons

            if (btn_Customer.Enabled == false)
            {

                btn_Customer.BackColor = Color.Orange;
                btn_Customer.Enabled = false;

            }
            else
            {

                btn_Customer.BackColor = Color.DarkGray;
                btn_Customer.Enabled = true;

            }

            //---------------------------------------------------

            if (btn_Sales.Enabled == false)
            {

                btn_Sales.BackColor = Color.Orange;
                btn_Sales.Enabled = false;

            }
            else
            {

                btn_Sales.BackColor = Color.DarkGray;
                btn_Sales.Enabled = true;

            }

            //---------------------------------------------------

            if (btn_Admin.Enabled == false)
            {

                btn_Admin.BackColor = Color.Orange;
                btn_Admin.Enabled = false;

            }
            else
            {

                btn_Admin.BackColor = Color.DarkGray;
                btn_Admin.Enabled = true;

            }

            btn_Admin.Visible = true;
            btn_Sales.Visible = true;
            btn_Customer.Visible = true;

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

            btn_Customer.Enabled = false;
            btn_Sales.Enabled = true;
            btn_Admin.Enabled = true;
            btn_ConfirmDetails.Visible = false;
            btn_DeleteUser.Visible = false;
            ClearFields();
            SetPrimarySelection();
            SetFormLayout();
            PopulateUserBox();

        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {

            btn_Customer.Enabled = true;
            btn_Sales.Enabled = false;
            btn_Admin.Enabled = true;
            btn_ConfirmDetails.Visible = false;
            btn_DeleteUser.Visible = false;
            ClearFields();
            SetPrimarySelection();
            SetFormLayout();
            PopulateUserBox();

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            btn_Customer.Enabled = true;
            btn_Sales.Enabled = true;
            btn_Admin.Enabled = false;
            btn_ConfirmDetails.Visible = false;
            btn_DeleteUser.Visible = false;
            ClearFields();
            SetPrimarySelection();
            SetFormLayout();
            PopulateUserBox();

        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {

            cbx_HidePassword.Checked = false;

            //--------------------------------Section-----------------------------------------------------

            //Initialise date of birth drop down lists

            for (int iCount = 0; iCount < 130; iCount++)
            {

                ddl_DoBYear.Items.Add(DateTime.Now.Year - iCount);

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_UserHint_Click(object sender, EventArgs e)
        {

            if (txt_PassHint.Visible == false)
            {

                txt_PassHint.Visible = true;
                txt_PassHint.Text = "Usernames can include any alpha or numeric characters, and any of: full stop, comma, dash or underscore. It cannot however end with any of these special characters. Max length is 24 characters.";

            }
            else
            {

                txt_PassHint.Visible = false;

            }

        }

        private void btn_PassHint_Click(object sender, EventArgs e)
        {

            if (txt_PassHint.Visible == false)
            {

                txt_PassHint.Visible = true;
                txt_PassHint.Text = "Passwords must contain 1 each of: upper case, lower case, special character and number . The password must also contain no less than 8 characters.";

            }
            else
            {

                txt_PassHint.Visible = false;

            }

        }

        private void cbx_HidePassword_CheckedChanged(object sender, EventArgs e)
        {

            //Hide & Show password and change label when combo box is selected
            if (cbx_HidePassword.Checked)
            {
                txt_Password.PasswordChar = '\0'; //'\0' equals a null character 
                cbx_HidePassword.Text = "Hide Password";
            }
            else
            {
                txt_Password.PasswordChar = '*';
                cbx_HidePassword.Text = "Show Password";
            }

        }

        private void ddl_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Populates all input fields based on user selection

            ddl_LogID.SelectedIndex = ddl_Users.SelectedIndex;
            ddl_UID.SelectedIndex = ddl_Users.SelectedIndex;

            int iType = 0;
            clsDatabase_Users clsUsers = new clsDatabase_Users();
            string[] sDetails = clsUsers.GetLoginDetails(int.Parse(ddl_LogID.Text));

            txt_Username.Text = sDetails[0];
            txt_Password.Text = sDetails[1];

            if (btn_Admin.Enabled == false)
            {

                iType = 2;

            }
            else if (btn_Sales.Enabled == false)
            {

                iType = 1;

            }

            sDetails = clsUsers.GetUserDetails(int.Parse(ddl_UID.Text), iType);

            txt_FName.Text = sDetails[0];
            txt_LName.Text = sDetails[1];
            txt_Email.Text = sDetails[2];
            txt_Phone.Text = sDetails[3];

            if (btn_Customer.Enabled == false)
            {

                ddl_AddID.SelectedIndex = ddl_Users.SelectedIndex;
                sDetails = clsUsers.GetAddress(int.Parse(ddl_AddID.Text));

                txt_HouseNumber.Text = sDetails[0];
                txt_RoadName.Text = sDetails[1];
                txt_TownName.Text = sDetails[2];
                txt_PostCode.Text = sDetails[3];

                string sDoB = clsUsers.GetDoB(int.Parse(ddl_UID.Text));
                string sDay = sDoB[0].ToString() + sDoB[1].ToString();
                string sMonth = sDoB[3].ToString() + sDoB[4].ToString();
                string sYear = sDoB[6].ToString() + sDoB[7].ToString() + sDoB[8].ToString() + sDoB[9].ToString();

                ddl_DoBDay.SelectedIndex = int.Parse(sDay) - 1;
                ddl_DoBMonth.SelectedIndex = int.Parse(sMonth) - 1;

                int iYear = int.Parse(sYear);
                string sCurrentYear = DateTime.Now.Year.ToString();
                iYear = int.Parse(sCurrentYear) - iYear;

                ddl_DoBYear.SelectedIndex = iYear;

            }

            btn_ConfirmDetails.Visible = true;
            btn_ConfirmDetails.Enabled = true;
            btn_DeleteUser.Visible = true;
            btn_DeleteUser.Enabled = true;
            btn_DeleteUser.Location = new Point(921, 517);
            lbl_Message.Visible = false;

            //--------------------------------End-----------------------------------------------------

        }

        private void btn_ConfirmDetails_Click(object sender, EventArgs e)
        {

            clsValidation clsValidation = new clsValidation();
            bool bAllValid = true;

            //--------------------------------Section-----------------------------------------------------

            //Validate User Input and error messaging

            //----------------------------------first Name---------------------------------------------------

            if (txt_FName.Text == "" || clsValidation.ValidateName(txt_FName.Text) == false)
            {

                lbl_FNameError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_FNameError.Visible = false;

            }

            //----------------------------------Last Name---------------------------------------------------

            if (txt_LName.Text == "" || clsValidation.ValidateName(txt_LName.Text) == false)
            {

                lbl_LNameError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_LNameError.Visible = false;

            }

            //--------------------------------Email-----------------------------------------------------

            if (txt_Email.Text == "" || clsValidation.ValidateEmail(txt_Email.Text) == false)
            {

                lbl_EmailError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_EmailError.Visible = false;

            }

            //---------------------------------Phone----------------------------------------------------

            if (txt_Phone.Text == "" || clsValidation.ValidatePhone(txt_Phone.Text) == false)
            {

                lbl_PhoneError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_PhoneError.Visible = false;

            }

            //---------------------------------Username----------------------------------------------------

            if(cbx_UserName.Checked == false)
            {

                if (txt_Username.Text == "" || clsValidation.ValidateUsername(txt_Username.Text) == false)
                {

                    lbl_UsernameError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_UsernameError.Visible = false;

                }

            }

            //---------------------------------Password----------------------------------------------------

            if (txt_Password.Text == "" || clsValidation.ValidatePassword(txt_Password.Text) == false)
            {

                lbl_PasswordError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_PasswordError.Visible = false;

            }

            if (btn_Customer.Enabled == false)
            {



                //----------------------------------Date of Birth---------------------------------------------------

                if (clsValidation.ValidateDate_Over18(ddl_DoBDay.Text, ddl_DoBMonth.Text, ddl_DoBYear.Text) == false)
                {

                    lbl_DoBError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_DoBError.Visible = false;

                }

                //----------------------------------Post Code---------------------------------------------------

                if (txt_PostCode.Text == "" || clsValidation.ValidatePostCode(txt_PostCode.Text.ToLower()) == false)
                {

                    lbl_PostCodeError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_PostCodeError.Visible = false;

                }

                //----------------------------------House Number---------------------------------------------------

                if (txt_HouseNumber.Text == "" || clsValidation.ValidateIsNumber(txt_HouseNumber.Text) == false)
                {

                    lbl_HouseNumberError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_HouseNumberError.Visible = false;

                }

                //----------------------------------Road Name---------------------------------------------------

                if (txt_RoadName.Text == "")
                {

                    lbl_RoadNameError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_RoadNameError.Visible = false;

                }

                //----------------------------------Town Name---------------------------------------------------

                if (txt_TownName.Text == "")
                {

                    lbl_TownNameError.Visible = true;
                    bAllValid = false;

                }
                else
                {

                    lbl_TownNameError.Visible = false;

                }

            }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Submits form to database upon completetion of checks

            clsDatabase_Users clsUsers = new clsDatabase_Users();
            clsEncryption clsEncrypt = new clsEncryption();
            List<string> lUserDetails = new List<string>();

            if (bAllValid == true)
            {

                //----------Populate Array with users details

                lUserDetails.Add(txt_Username.Text);
                lUserDetails.Add(clsEncrypt.EncryptPassword(txt_Password.Text));
                lUserDetails.Add(txt_FName.Text);
                lUserDetails.Add(txt_LName.Text);
                lUserDetails.Add(txt_Email.Text);
                lUserDetails.Add(txt_Phone.Text);

                //----------Upload Staff details

                clsUsers.UpdateLogin(lUserDetails, int.Parse(ddl_LogID.Text));

                //-------------------------------------------

                if (btn_Admin.Enabled == false || btn_Sales.Enabled == false)
                {

                    //----------Upload Staff details

                    clsUsers.UpdateStaff(lUserDetails, int.Parse(ddl_UID.Text));

                    //-------------------------------------------

                }
                else
                {

                    //----------Upload Customer details

                    lUserDetails.Add(ddl_DoBYear.Text + "-" + ddl_DoBMonth.Text + "-" + ddl_DoBDay.Text);
                    clsUsers.UpdateCustomer(lUserDetails, int.Parse(ddl_UID.Text));

                    //-------------------------------------------

                    //----------Upload Address details

                    lUserDetails.Add(txt_HouseNumber.Text);
                    lUserDetails.Add(txt_RoadName.Text);
                    lUserDetails.Add(txt_TownName.Text);
                    lUserDetails.Add(txt_PostCode.Text);

                    clsUsers.UpdateAddress(lUserDetails, int.Parse(ddl_AddID.Text));


                    //-------------------------------------------

                }

                //----------Display completion message

                HideFormLayout();
                ClearFields();
                btn_ConfirmDetails.Visible = false;
                btn_ConfirmDetails.Enabled = false;
                btn_DeleteUser.Enabled = false;
                btn_DeleteUser.Enabled = false;
                lbl_Message.Text = "You have successfully updated all details for this user. Either select a new user or return to menu.";
                lbl_Message.Visible = true;

                //-------------------------------------------

            }
            else
            {

                //MessageBox.Show("Critical Error");

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void cbx_UserName_CheckedChanged(object sender, EventArgs e)
        {

            //Hide & Show password and change label when combo box is selected
            if (cbx_UserName.Checked)
            {
                txt_Username.Enabled = false; 
                cbx_UserName.Text = "Keep Username";
            }
            else
            {
                txt_Username.Enabled = true;
                cbx_UserName.Text = "Change Username";
            }

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {

            //Return to the Main Menu

            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            clsUser.AccessLevel = '\0';
            clsUser.Username = "";
            clsUser.Password = "";
            FormGenerator.frm_Login.Show();
            this.Close();

        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {

            if (btn_Cancel.Visible == true)
            {

                clsDatabase_Users clsUsers = new clsDatabase_Users();

                if(btn_Customer.Enabled == false)
                {

                    clsUsers.DeleteAddress(int.Parse(ddl_AddID.Text));
                    clsUsers.DeleteUser(int.Parse(ddl_UID.Text), 0);

                }
                else
                {

                    clsUsers.DeleteUser(int.Parse(ddl_UID.Text), 1);

                }

                clsUsers.DeleteLogin(int.Parse(ddl_LogID.Text));

                btn_Cancel.Enabled = false;
                btn_Cancel.Visible = false;
                btn_DeleteUser.Visible = false;
                lbl_Message.Text = "You have now deleted " + txt_FName.Text + " " + txt_LName.Text + " from the system?";
                lbl_Message.ForeColor = Color.Green;

            }
            else
            {

                HideFormLayout();
                HidePrimarySelection();
                btn_Cancel.Enabled = true;
                btn_Cancel.Visible = true;
                btn_ConfirmDetails.Visible = false;
                btn_ConfirmDetails.Enabled = false;
                lbl_Message.Text = "Are you absolutly sure you wish to DELETE " + txt_FName.Text + " " + txt_LName.Text + " from the system?";
                lbl_Message.Location = new Point(220, 219);
                lbl_Message.Visible = true;
                btn_DeleteUser.Location = new Point(484, 273);

            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {


            btn_Cancel.Enabled = false;
            btn_Cancel.Visible = false;
            btn_DeleteUser.Location = new Point(921, 517);
            btn_ConfirmDetails.Visible = true;
            btn_ConfirmDetails.Enabled = true;
            SetFormLayout();
            SetPrimarySelection();

        }
    }
}
