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
    public partial class frm_CreateNewUser : Form
    {
        public frm_CreateNewUser()
        {
            InitializeComponent();
        }

        private void SetNavigationButtons()
        {

            //--------------------------------Section-----------------------------------------------------

            //Reposition Primary Navigation Buttons

            btn_Menu.Location = new Point(12, 17);
            btn_Menu.Visible = true;
            btn_Menu.Enabled = true;
            btn_Menu.Size = new Size(83, 33);
            btn_Menu.Font = new Font("Rockwell", 12);
            btn_Menu.ForeColor = Color.Black;
            btn_Menu.BackColor = Color.Gray;

            btn_Logout.Location = new Point(101, 17);
            btn_Logout.Visible = true;
            btn_Logout.Enabled = true;
            btn_Logout.Size = new Size(83, 33);
            btn_Logout.Font = new Font("Rockwell", 12);
            btn_Logout.ForeColor = Color.Black;
            btn_Logout.BackColor = Color.Gray;

            //--------------------------------End Section-----------------------------------------------

        }

        public void HideUserFormLayout()
        {

            lbl_Username.Visible = false;
            txt_Username.Visible = false;
            lbl_UsernameError.Visible = false;
            lbl_Password.Visible = false;
            txt_Password.Visible = false;
            cbx_HidePassword.Visible = false;
            btn_PassHint.Visible = false;
            txt_PassHint.Visible = false;
            btn_UserHint.Visible = false;
            lbl_PasswordError.Visible = false;
            btn_ReturnToAddress.Visible = false;
            btn_Submit.Visible = false;
            btn_ResetDetails.Visible = false;
            lbl_AdminMessage.Visible = false;

        }

        public void SetUserFormLayout()
        {

            //--------------------------------Section-----------------------------------------------------

            //Create layout for user creation form

            lbl_Username.Location = new Point(411, 152);
            lbl_Username.Visible = true;

            txt_Username.Location = new Point(415, 174);
            txt_Username.Visible = true;
            txt_Username.Enabled = true;

            lbl_UsernameError.Location = new Point(412, 200);
            lbl_UsernameError.Visible = false;

            lbl_Password.Location = new Point(411, 226);
            lbl_Password.Visible = true;

            txt_Password.Location = new Point(415, 248);
            txt_Password.Visible = true;
            txt_Password.Enabled = true;

            cbx_HidePassword.Location = new Point(848, 250);
            cbx_HidePassword.Visible = true;

            btn_PassHint.Location = new Point(496, 226);
            btn_PassHint.Visible = true;

            btn_UserHint.Location = new Point(501, 150);
            btn_UserHint.Visible = true;

            txt_PassHint.Location = new Point(802, 289);
            txt_PassHint.Visible = false;

            lbl_PasswordError.Location = new Point(412, 277);
            lbl_PasswordError.Visible = false;

            if (btn_Admin.Enabled == false)
            {

                btn_Submit.Location = new Point(534, 392);
                btn_ResetDetails.Location = new Point(534, 456);
                lbl_AdminMessage.Location = new Point(71, 327);
                lbl_AdminMessage.Visible = true;

            }
            else if (btn_Customer.Enabled == false)
            {

                btn_Submit.Location = new Point(543, 323);
                btn_ResetDetails.Location = new Point(543, 387);

                btn_ReturnToAddress.Location = new Point(543, 457);
                btn_ReturnToAddress.Visible = true;
                btn_ReturnToAddress.Enabled = true;



            }
            else
            {

                btn_Submit.Location = new Point(543, 323);
                btn_ResetDetails.Location = new Point(543, 387);

            }


            btn_Submit.Visible = true;
            btn_Submit.Enabled = true;

            btn_ResetDetails.Visible = true;
            btn_ResetDetails.Enabled = true;
            btn_ResetDetails.Size = new Size(146, 54);

            //--------------------------------End Section-----------------------------------------------

        }

        public void HideAddressFormLayout()
        {

            lbl_HouseNumber.Visible = false;
            txt_HouseNumber.Visible = false;
            lbl_HouseNumberError.Visible = false;
            lbl_RoadName.Visible = false;
            txt_RoadName.Visible = false;
            lbl_RoadNameError.Visible = false;
            lbl_TownName.Visible = false;
            txt_TownName.Visible = false;
            lbl_TownNameError.Visible = false;
            lbl_PostCode.Visible = false;
            txt_PostCode.Visible = false;
            lbl_PostCodeError.Visible = false;
            btn_ConfirmAddress.Visible = false;

        }

        private void SetAddressFormLayout()
        {

            //--------------------------------Section-----------------------------------------------------

            //Users address form Layout Configuration

            lbl_HouseNumber.Location = new Point(275, 127);
            lbl_HouseNumber.Visible = true;

            txt_HouseNumber.Location = new Point(279, 149);
            txt_HouseNumber.Enabled = true;
            txt_HouseNumber.Visible = true;

            lbl_HouseNumberError.Location = new Point(276, 178);
            lbl_HouseNumberError.Visible = false;

            lbl_RoadName.Location = new Point(517, 127);
            lbl_RoadName.Visible = true;

            txt_RoadName.Location = new Point(521, 149);
            txt_RoadName.Enabled = true;
            txt_RoadName.Visible = true;

            lbl_RoadNameError.Location = new Point(518, 178);
            lbl_RoadNameError.Visible = false;

            lbl_TownName.Location = new Point(275, 226);
            lbl_TownName.Visible = true;

            txt_TownName.Location = new Point(279, 248);
            txt_TownName.Enabled = true;
            txt_TownName.Visible = true;

            lbl_TownNameError.Location = new Point(276, 277);
            lbl_TownNameError.Visible = false;

            lbl_PostCode.Location = new Point(750, 226);
            lbl_PostCode.Visible = true;

            txt_PostCode.Location = new Point(754, 248);
            txt_PostCode.Enabled = true;
            txt_PostCode.Visible = true;

            lbl_PostCodeError.Location = new Point(751, 277);
            lbl_PostCodeError.Visible = false;

            btn_ConfirmAddress.Location = new Point(490, 343);
            btn_ConfirmAddress.Enabled = true;
            btn_ConfirmAddress.Visible = true;

            btn_ResetDetails.Location = new Point(490, 407);
            btn_ResetDetails.Size = new Size(261, 49);
            btn_ResetDetails.Visible = true;
            btn_ResetDetails.Enabled = true;

            //--------------------------------End Section-----------------------------------------------

        }

        private void HideDetailsFormLayout()
        {

            txt_FName.Enabled = false;
            txt_LName.Enabled = false;
            ddl_DoBDay.Enabled = false;
            ddl_DoBMonth.Enabled = false;
            ddl_DoBYear.Enabled = false;
            txt_Email.Enabled = false;
            txt_Phone.Enabled = false;
            btn_ConfirmDetails.Enabled = false;

            lbl_FName.Visible = false;
            lbl_LName.Visible = false;
            lbl_DoB.Visible = false;
            lbl_Email.Visible = false;
            lbl_Phone.Visible = false;

            txt_FName.Visible = false;
            txt_LName.Visible = false;
            ddl_DoBDay.Visible = false;
            ddl_DoBMonth.Visible = false;
            ddl_DoBYear.Visible = false;
            txt_Email.Visible = false;
            txt_Phone.Visible = false;

        }

        private void SetDetailsFormLayout()
        {

            //--------------------------------Section-----------------------------------------------------

            //Users details form Layout Configuration

            lbl_FName.Location = new Point(130, 129);
            lbl_FName.Visible = true;

            txt_FName.Location = new Point(134, 151);
            txt_FName.Visible = true;
            txt_FName.Enabled = true;

            lbl_FNameError.Location = new Point(131, 180);
            lbl_FNameError.Visible = false;

            lbl_LName.Location = new Point(639, 129);
            lbl_LName.Visible = true;

            txt_LName.Location = new Point(643, 151);
            txt_LName.Visible = true;
            txt_LName.Enabled = true;

            lbl_LNameError.Location = new Point(640, 180);
            lbl_LNameError.Visible = false;

            lbl_DoB.Location = new Point(129, 217);
            lbl_DoB.Visible = true;

            ddl_DoBDay.Location = new Point(133, 238);
            ddl_DoBDay.Visible = true;
            ddl_DoBDay.Enabled = true;

            ddl_DoBMonth.Location = new Point(187, 238);
            ddl_DoBMonth.Visible = true;
            ddl_DoBMonth.Enabled = true;

            ddl_DoBYear.Location = new Point(244, 238);
            ddl_DoBYear.Visible = true;
            ddl_DoBYear.Enabled = true;

            lbl_DoBError.Location = new Point(130, 268);
            lbl_DoBError.Visible = false;

            lbl_Email.Location = new Point(639, 217);
            lbl_Email.Visible = true;

            txt_Email.Location = new Point(643, 239);
            txt_Email.Visible = true;
            txt_Email.Enabled = true;

            lbl_EmailError.Location = new Point(640, 268);
            lbl_EmailError.Visible = false;

            lbl_Phone.Location = new Point(130, 299);
            lbl_Phone.Visible = true;

            txt_Phone.Location = new Point(134, 321);
            txt_Phone.Visible = true;
            txt_Phone.Enabled = true;

            lbl_PhoneError.Location = new Point(131, 350);
            lbl_PhoneError.Visible = false;

            btn_ConfirmDetails.Location = new Point(501, 387);
            btn_ConfirmDetails.Visible = true;
            btn_ConfirmDetails.Enabled = true;

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Initialise date of birth drop down lists

            for (int iCount = 0; iCount < 130; iCount++)
            {

                ddl_DoBYear.Items.Add(DateTime.Now.Year - iCount);

            }

            ddl_DoBYear.SelectedIndex = 0;
            ddl_DoBMonth.SelectedIndex = 0;
            ddl_DoBDay.SelectedIndex = 0;

            //--------------------------------End Section-----------------------------------------------

        }

        private void SetPrimaryButtons()
        {

            //--------------------------------Section-----------------------------------------------------

            //Reposition and restyle buttons

            if (clsUser.AccessLevel == 0)
            {

                //--------------removes all buttons from the screen, customer needs no access

                btn_Admin.Visible = false;
                btn_Sales.Visible = false;
                btn_Customer.Visible = false;
                btn_Customer.Enabled = false;

            }
            else if (clsUser.AccessLevel == 1)
            {

                //--------------Formats customer and rep buttons while disabling admin access

                if (lbl_Selected.Text == "0")
                {

                    btn_Customer.BackColor = Color.Orange;
                    btn_Customer.Enabled = false;

                }
                else
                {

                    btn_Customer.BackColor = Color.DarkGray;
                    btn_Customer.Enabled = true;

                }

                btn_Customer.Location = new Point(399, 64);
                

                //---------------------------------------------------

                if (lbl_Selected.Text == "1")
                {

                    btn_Sales.BackColor = Color.Orange;
                    btn_Sales.Enabled = false;

                }
                else
                {

                    btn_Sales.BackColor = Color.DarkGray;
                    btn_Sales.Enabled = true;

                }

                btn_Sales.Location = new Point(643, 64);

                //---------------------------------------------------

                btn_Admin.Visible = false;

            }
            else if (clsUser.AccessLevel == 2)
            {

                //--------------Formats all three buttons for the admin account user
                
                if (lbl_Selected.Text == "0")
                {

                    btn_Customer.BackColor = Color.Orange;
                    btn_Customer.Enabled = false;

                }
                else
                {

                    btn_Customer.BackColor = Color.DarkGray;
                    btn_Customer.Enabled = true;

                }

                btn_Customer.Location = new Point(233, 64);

                //---------------------------------------------------

                if (lbl_Selected.Text == "1")
                {

                    btn_Sales.BackColor = Color.Orange;
                    btn_Sales.Enabled = false;

                }
                else
                {

                    btn_Sales.BackColor = Color.DarkGray;
                    btn_Sales.Enabled = true;

                }

                btn_Sales.Location = new Point(515, 64);

                //---------------------------------------------------

                if (lbl_Selected.Text == "2")
                {

                    btn_Admin.BackColor = Color.Orange;
                    btn_Admin.Enabled = false;

                }
                else
                {

                    btn_Admin.BackColor = Color.DarkGray;
                    btn_Admin.Enabled = true;

                }

                btn_Admin.Location = new Point(822, 64);

            }
            else
            {

                MessageBox.Show("Error has occured. Please reload application");

            }

            btn_Customer.Font = new Font("Rockwell", 14);
            btn_Customer.Size = new Size(153, 47);
            btn_Sales.Font = new Font("Rockwell", 14);
            btn_Sales.Size = new Size(153, 47);
            btn_Admin.Font = new Font("Rockwell", 14);
            btn_Admin.Size = new Size(153, 47);

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Initialise form for user

            HideAddressFormLayout();
            HideUserFormLayout();
            lbl_Selected.Text = "0";
            SetDetailsFormLayout();
            SetNavigationButtons();
            SetPrimaryButtons();

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Initialise form for user

            HideAddressFormLayout();
            HideUserFormLayout();
            lbl_Selected.Text = "1";
            SetDetailsFormLayout();
            SetNavigationButtons();
            SetPrimaryButtons();

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Initialise form for user

            HideAddressFormLayout();
            HideUserFormLayout();
            lbl_Selected.Text = "2";
            SetDetailsFormLayout();
            SetNavigationButtons();
            SetPrimaryButtons();

            //--------------------------------End Section-----------------------------------------------

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

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Changes form when all valid inputs are comfirmed

            if (bAllValid == true)
            {

                if (btn_Customer.Enabled == false)
                {

                    HideDetailsFormLayout();
                    btn_ConfirmDetails.Visible = false;
                    SetAddressFormLayout();

                }
                else
                {

                    HideDetailsFormLayout();
                    btn_ConfirmDetails.Visible = false;
                    SetUserFormLayout();

                }

            }
            else 
            {

                //MessageBox.Show("Critical Error");

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_test_Click(object sender, EventArgs e)
        {

            txt_FName.Text = "Jay";
            txt_LName.Text = "Miles";
            ddl_DoBDay.SelectedIndex = 1;
            ddl_DoBMonth.SelectedIndex = 1;
            ddl_DoBYear.SelectedItem = 1994;
            txt_Email.Text = "ws298241@weston.ac.uk";
            txt_Phone.Text = "01934411411";

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Checks inputs are valid

            clsValidation clsValidation = new clsValidation();
            bool bAllValid = true;

            if (txt_Username.Text == "" || clsValidation.ValidateUsername(txt_Username.Text) == false)
            {

                lbl_UsernameError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_UsernameError.Visible = false;

            }

            if (txt_Password.Text == "" || clsValidation.ValidatePassword(txt_Password.Text) == false)
            {

                lbl_PasswordError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_PasswordError.Visible = false;

            }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Submits form to database upn completetion of checks

            clsDatabase_Users clsData = new clsDatabase_Users();
            clsEncryption clsEncrypt = new clsEncryption();
            List<string> lUserDetails = new List<string>();
            string sID = "";
            string sCID = "";

            if (bAllValid == true)
            {

                //----------Populate Array with users details

                lUserDetails.Add(txt_Username.Text);
                lUserDetails.Add(clsEncrypt.EncryptPassword(txt_Password.Text));

                if (btn_Customer.Enabled == false)
                {

                    lUserDetails.Add("0");

                }
                else if (btn_Sales.Enabled == false)
                {

                    lUserDetails.Add("1");

                }
                else
                {

                    lUserDetails.Add("2");

                }

                //-------------------------------------------

                clsData.AddUser(lUserDetails);
                sID = clsData.GetUserID_String(lUserDetails[0]);

                lUserDetails.Add(txt_FName.Text);
                lUserDetails.Add(txt_LName.Text);
                lUserDetails.Add(txt_Email.Text);
                lUserDetails.Add(txt_Phone.Text);

                if (btn_Admin.Enabled == false || btn_Sales.Enabled == false)
                {

                    //----------Upload Staff details

                    clsData.AddUserDetails(lUserDetails, sID, 0);

                    //-------------------------------------------

                }
                else
                {

                    //----------Upload Customer details

                    lUserDetails.Add(ddl_DoBYear.Text + "-" + ddl_DoBMonth.Text + "-" + ddl_DoBDay.Text);
                    clsData.AddUserDetails(lUserDetails, sID, 1);

                    //-------------------------------------------

                    //----------Populate Address details

                    sCID = clsData.GetCutomerID(sID);
                    lUserDetails.Add(txt_HouseNumber.Text);
                    lUserDetails.Add(txt_RoadName.Text);
                    lUserDetails.Add(txt_TownName.Text);
                    lUserDetails.Add(txt_PostCode.Text);
                    clsData.AddAddress(lUserDetails, sCID);


                    //-------------------------------------------

                }

                //----------Display completion message

                HideUserFormLayout();
                lbl_Title.Visible = false;
                btn_Admin.Visible = false;
                btn_Sales.Visible = false;
                btn_Customer.Visible = false;

                lbl_AdminMessage.Text = "New user successfully created! Please return to the menu or logout.";
                lbl_AdminMessage.Visible = true;

                //-------------------------------------------

            }
            else
            {

                //MessageBox.Show("Critical Error");

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void frm_CreateNewUser_Load(object sender, EventArgs e)
        {

            if (clsUser.AccessLevel == 0)
            {

                SetPrimaryButtons();
                SetDetailsFormLayout();
                SetNavigationButtons();

            }
            else if (clsUser.AccessLevel == 1)
            {

                btn_Admin.Visible = false;
                btn_Menu.Location = new Point(462, 291);
                btn_Logout.Location = new Point(462, 387);

            }

            cbx_HidePassword.Checked = false;

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

        private void btn_ResetDetails_Click(object sender, EventArgs e)
        {

            HideAddressFormLayout();
            HideUserFormLayout();
            SetDetailsFormLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void btn_ReturnToAddress_Click(object sender, EventArgs e)
        {

            HideUserFormLayout();
            SetAddressFormLayout();

        }

        private void btn_ConfirmAddress_Click(object sender, EventArgs e)
        {

            clsValidation clsValidate = new clsValidation();
            bool bAllValid = true;
            
            if (txt_PostCode.Text == "" || clsValidate.ValidatePostCode(txt_PostCode.Text.ToLower()) == false)
            {

                lbl_PostCodeError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_PostCodeError.Visible = false;

            }

            if (txt_HouseNumber.Text == "" || clsValidate.ValidateIsNumber(txt_HouseNumber.Text) == false)
            {

                lbl_HouseNumberError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_HouseNumberError.Visible = false;

            }

            if (txt_RoadName.Text == "")
            {

                lbl_RoadNameError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_RoadNameError.Visible = false;

            }

            if (txt_TownName.Text == "")
            {

                lbl_TownNameError.Visible = true;
                bAllValid = false;

            }
            else
            {

                lbl_TownNameError.Visible = false;

            }

            //--------------------------------Section-----------------------------------------------------

            //Changes form when all valid inputs are comfirmed

            if (bAllValid == true)
            {

                HideAddressFormLayout();
                btn_ConfirmAddress.Visible = false;
                SetUserFormLayout();

            }
            else
            {

                //MessageBox.Show("Critical Error");

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
    }
}
