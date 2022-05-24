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
    public partial class frmEditVehicle : Form
    {
        List<clsCarMake> carMakes;
        List<clsCarModel> carModels;
        clsCarModel carDetails;
        public frmEditVehicle()
        {
            InitializeComponent();
        }

        // Populates combo box with list of car makes
        private void frmEditVehicle_Load(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            carMakes = clsVehicles.ListCarMakes();

            foreach (clsCarMake make in carMakes)
            {
                cboCarMakes.Items.Add(make.sMakeName);

            }
        }

        //Populates combo box with only models for selected make
        private void cboCarMakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCarChoiceConfirm.Visible = false;

            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            carModels = clsVehicles.ListCarModels(carMakes[cboCarMakes.SelectedIndex]);


            cboCarModels.Items.Clear();
            cboCarModels.ResetText();

            foreach (clsCarModel model in carModels)
            {
                cboCarModels.Items.Add(model.sModelName);
            }

           
        }

        private void cboCarModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCarChoiceConfirm.Visible = true;
        }


        private void btnCarChoiceConfirm_Click(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();
            carDetails = clsVehicles.GetCarDetails(carModels[cboCarModels.SelectedIndex]);

            for (int iCount = 0; iCount < 80; iCount++)
            {
                cboEditYear.Items.Add(DateTime.Now.Year - iCount);
            }

            gboCurrentDetails.Visible = true;

            txtEditPrice.Text = carDetails.dModelPrice.ToString();
            txtEditEngine.Text = carDetails.iEngineSize.ToString();
            nudEditDoors.Text = carDetails.iDoors.ToString();
            cboFuel.Text = carDetails.sFuel.ToString();
            cboTransmission.Text = carDetails.sTransmission.ToString();
            txtEditMPG.Text = carDetails.iMPG.ToString();
            cboDrive.Text = carDetails.sDriveType.ToString();
            txtEditEmissions.Text = carDetails.dEmissions.ToString();
            cboEditYear.Text = carDetails.iYear.ToString();


        }

        private void btnConfirmEdits_Click(object sender, EventArgs e)
        {

            clsValidation objValidation = new clsValidation();
            if (String.IsNullOrEmpty(txtEditPrice.Text) || String.IsNullOrEmpty(txtEditEngine.Text) || String.IsNullOrEmpty(nudEditDoors.Text) || String.IsNullOrEmpty(cboFuel.Text) || String.IsNullOrEmpty(cboTransmission.Text) || String.IsNullOrEmpty(txtEditMPG.Text) || String.IsNullOrEmpty(cboDrive.Text) || String.IsNullOrEmpty(txtEditEmissions.Text) || String.IsNullOrEmpty(cboEditYear.Text))
            {
                lblAlert.Visible = true;
                return;
            }

            if (objValidation.ValidateIsDecimal(txtEditPrice.Text) != true || objValidation.ValidateIsNumber(txtEditEngine.Text) != true || objValidation.ValidateIsNumber(txtEditMPG.Text) != true || objValidation.ValidateIsNumber(txtEditEmissions.Text) != true)
            {
                lblAlert.Text = "Please ensure you data is correct and all numerical values are inputted as numbers.";
                lblAlert.Visible = true;
                return;
            }

            gboConfirmEdits.Visible = true;

            lblEditedPrice.Text = txtEditPrice.Text;
            lblEditedEngine.Text = txtEditEngine.Text;
            lblEditedDoors.Text = nudEditDoors.Text;
            lblEditedFuel.Text = cboFuel.Text;
            lblEditedTransmission.Text = cboTransmission.Text;
            lblEditedMPG.Text = txtEditMPG.Text;
            lblEditedDriveType.Text = cboDrive.Text;
            lblEditedEmissions.Text = txtEditEmissions.Text;
            lblEditedYear.Text = cboEditYear.Text;

            gboCurrentDetails.Visible = false;
            lblAlert.Visible = false;
        }

        // Confirm edits and update database entry
        private void btnConfirmAndUpdate_Click(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new  clsDatabase_Vehicles();

            clsVehicles.UpdateModel(
                carDetails.iModelId,
                Convert.ToDecimal(lblEditedPrice.Text),
                Convert.ToInt32(lblEditedEngine.Text),
                Convert.ToInt32(lblEditedDoors.Text),
                lblEditedFuel.Text,
                lblEditedTransmission.Text,
                Convert.ToInt32(lblEditedMPG.Text),
                lblEditedDriveType.Text,
                Convert.ToDouble(lblEditedEmissions.Text),
                Convert.ToInt32(lblEditedYear.Text)
                );

            lblConfirmChanges.Visible = true;
            btnReturnToMenu.Visible = true;

            
            gboConfirmEdits.Visible = false;
            gboSelectModel.Visible = false;
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblConfirmCancel.Visible = true;
            lblConfirmCancel2.Visible = true;
            btnConfirmCancel.Visible = true;
        }

        private void btnConfirmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelAndExit_Click(object sender, EventArgs e)
        {
            lblConfirmCancel3.Visible = true;
            lblConfirmCancel4.Visible = true;
            btnCancelAndMenuReturn.Visible = true;
        }

        private void btnCancelAndMenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frm_Menu = new frmMenu();
            frm_Menu.Show();
            this.Close();
        }
    }
}
