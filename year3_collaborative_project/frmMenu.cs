using System;
using System.Windows.Forms;

using year3_collaborative_project.classes;

namespace year3_collaborative_project
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            /*Test2*/
            int iAccessLevel = clsUser.AccessLevel;

            if (iAccessLevel == 0)
            {
                btnAdminAddVehicle.Visible = false;
                btnAdminAddMod.Visible = false;
                btnAdminModMod.Visible = false;
                btnAdminDeleteMod.Visible = false;
                btnAdminActivateMod.Visible = false;
                btnAdminStats.Visible = false;
                btnAdminAddUser.Visible = false;

                btnRepViewInvoice.Visible = false;

                btnUserSelections.Left = 348;
                btnUserLoadPrior.Left = 339;
                btnAdminAddUser.Left = 350;
                btnAdminAddUser.Top = 163;

                btnUserChangeDetails.Visible = false;

            }
            if (iAccessLevel == 1)
            {
                lblTitle.Text = "Sales Rep Menu";
                lblTitle.Left = 300;

                btnUserSelections.Visible = false;
                btnAdminAddVehicle.Visible = false;
                btnAdminAddMod.Visible = false;
                btnAdminAddUser.Visible = true;
                btnAdminModMod.Visible = false;
                btnAdminDeleteMod.Visible = false;
                btnAdminActivateMod.Visible = false;
                btnAdminStats.Visible = false;

                btnRepViewInvoice.Top = 54;
                btnRepViewInvoice.Left = 348;
                btnUserLoadPrior.Top = 140;
                btnUserLoadPrior.Left = 348;
                btnAdminAddUser.Left = 348;


                btnUserChangeDetails.Visible = false;

            }
            if (iAccessLevel == 2)
            {
                btnUserSelections.Visible = false;
                lblTitle.Left = 320;

                lblTitle.Text = "Admin Menu";


                btnUserChangeDetails.Visible = true;

            }
        }

        private void btnUserSelections_Click(object sender, EventArgs e)
        {

            //Transfers from Menu to Vehicle Selection Screen

            frm_VehicleSelection frm_VehicleSelection = new frm_VehicleSelection(0);
            frm_VehicleSelection.Show();
            this.Close();
            
        }

        private void btnUserLoadPrior_Click(object sender, EventArgs e)
        {

            frmLoad_Config frmLoad = new frmLoad_Config();
            frmLoad.Show();
            this.Close();

        }
        private void btnUserChangeDetails_Click(object sender, EventArgs e)
        {
            
            frmEditUser frmEditUser = new frmEditUser();
            frmEditUser.Show();
            this.Close();

        }

        private void btnAdminAddVehicle_Click(object sender, EventArgs e)
        {

            frmVehicleAdminMenu frmVehicleMenu = new frmVehicleAdminMenu();
            frmVehicleMenu.Show();
            this.Close();

        }

        private void btnAdminAddMod_Click(object sender, EventArgs e)
        {
            frmAddMod frmAddMod = new frmAddMod();
            frmAddMod.Show();
            this.Close();
        }

        private void btnAdminAddUser_Click(object sender, EventArgs e)
        {
            frm_CreateNewUser frmAddUser = new frm_CreateNewUser();
            frmAddUser.Show();
            this.Close();
        }

        private void btnRepViewInvoice_Click(object sender, EventArgs e)
        {
            frmAcceptInvoice frmViewInvoices = new frmAcceptInvoice();
            frmViewInvoices.Show();
            this.Close();
        }

        private void btnAdminModMod_Click(object sender, EventArgs e)
        {
            frmEditMod frmEditMod = new frmEditMod();
            frmEditMod.Show();
            this.Close();
        }

        private void btnAdminDeleteMod_Click(object sender, EventArgs e)
        {
            frmDeactivateMod frmDeactivateMod = new frmDeactivateMod();
            frmDeactivateMod.Show();
            this.Close();
        }

        private void btnAdminActivateMod_Click(object sender, EventArgs e)
        {
            frmActivateMod frmActivateMod = new frmActivateMod();
            frmActivateMod.Show();
            this.Close();
        }

        private void btnAdminStats_Click(object sender, EventArgs e)
        {
            frmStats frmStats = new frmStats();
            frmStats.Show();
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
