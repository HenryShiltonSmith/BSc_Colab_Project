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
    public partial class frmLoad_Config : Form
    {
        public frmLoad_Config()
        {
            InitializeComponent();
        }

        private void frmLoad_Config_Load(object sender, EventArgs e)
        {

            clsDatabase_Users clsUsers = new clsDatabase_Users();

            //--------------------------------Section-----------------------------------------------------

            //Populates user dropbox by pulling down an array from class database

            string[,] sUsers = clsUsers.GetUsers(0);

            for (int iCount = 0; iCount < sUsers.GetLength(0); iCount++)
            {

                ddl_Customers.Items.Add(sUsers[iCount, 1] + " " + sUsers[iCount, 0] + " : " + sUsers[iCount, 2]);
                ddl_CID.Items.Add(sUsers[iCount, 4]);

            }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //change screen layout based on access level

            if (clsUser.AccessLevel == 0)
            {

                ddl_Customers.Visible = false;
                ddl_CID.SelectedItem = clsUsers.GetCutomerID(clsUser.IUserID.ToString());
                ddl_Customers.SelectedIndex = ddl_CID.SelectedIndex;

                ddl_Configs.Location = new Point(26, 79);

            }
            else
            {

                ddl_Customers.Visible = true;
                ddl_Customers.Enabled = true;

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void ddl_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddl_CID.SelectedIndex = ddl_Customers.SelectedIndex;
            ddl_Configs.Items.Clear();
            ddl_ConfigID.Items.Clear();
            ddl_Configs.Visible = true;
            ddl_Configs.Enabled = true;
            btn_Confirm.Visible = false;

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();

            //--------------------------------Section-----------------------------------------------------

            //Populates config dropboxs by pulling down an array from class database

            string[,] sConfigs = clsConfigs.GetUserConfigs(int.Parse(ddl_CID.Text));

            for (int iCount = 0; iCount < sConfigs.GetLength(0); iCount++)
            {

                ddl_Configs.Items.Add(sConfigs[iCount, 1] + " " + sConfigs[iCount, 2]);
                ddl_ConfigID.Items.Add(sConfigs[iCount, 0]);

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void ddl_Configs_SelectedIndexChanged(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Set up pass variables for edit config, activates confirmation buttons

            ddl_ConfigID.SelectedIndex = ddl_Configs.SelectedIndex;

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();
            clsValidation clsValidate = new clsValidation();
            string[] sConfig = clsConfigs.GetBasicConfigDetails(int.Parse(ddl_ConfigID.Text));

            lbl_MakeID.Text = sConfig[4];
            lbl_ModelID.Text = sConfig[5];
            lbl_VehicleMake.Text = clsConfigs.GetMakeName(int.Parse(sConfig[4]));
            lbl_VehicleModel.Text = clsConfigs.GetModelName(int.Parse(sConfig[5]));
            lbl_Price.Text = clsValidate.FormatCurrencyForDisplay(clsVehicles.GetModelPrice(int.Parse(sConfig[5])).ToString());

            btn_Confirm.Visible = true;
            btn_Confirm.Enabled = true;

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            frmCustomerConfig frm_Config = new frmCustomerConfig(lbl_ModelID.Text, lbl_VehicleMake.Text, lbl_VehicleModel.Text, lbl_Price.Text, lbl_MakeID.Text, ddl_ConfigID.Text, ddl_CID.Text);
            frm_Config.Show();
            this.Close();

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
    }
}
