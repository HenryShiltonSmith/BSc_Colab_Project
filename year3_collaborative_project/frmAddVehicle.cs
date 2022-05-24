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
    public partial class frmAddVehicle : Form
    {
        List<clsCarMake> carMakes;
        List<clsCarModel> carModels;
        clsCarMake newMake;
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        // Get list of all makes currently in database
        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            carMakes = clsVehicles.ListCarMakes();

            foreach (clsCarMake make in carMakes)
            {
                cboCarMakes.Items.Add(make.sMakeName);

            }
        }

        // Output combo box list of makes if user selects existing make, output text box for manual input if user selects new make
        private void chbExistingMake_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbExistingMake.Checked == true)
            {
                cboCarMakes.Visible = true;
                chbNewMake.Checked = false;
            }
            else
            {
                cboCarMakes.Visible = false;
                btnMakeConfirm.Visible = false;
                cboCarMakes.SelectedItem = null;
            }

        }

        private void chbNewMake_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbNewMake.Checked == true)
            {
                txtAddNewMake.Visible = true;
                chbExistingMake.Checked = false;
            }
            else
            {
                txtAddNewMake.Visible = false;
                btnMakeConfirm.Visible = false;
                txtAddNewMake.Text = "";
                txtAddCarModel.Text = "";
                gboModelChoice.Visible = false;
            }

        }

        private void cboCarMakes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (chbExistingMake.Checked == false)
            {
                return;
            }


            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            

            carModels = clsVehicles.ListCarModels(carMakes[cboCarMakes.SelectedIndex]);

            btnMakeConfirm.Visible = true;
        }
       

        private void txtAddNewMake_TextChanged(object sender, EventArgs e)
        {
            btnMakeConfirm.Visible = true;
        }

        // If adding a new make, inserts new make into database and returns the makeID so it can be used to populate tblConfig details
        private void btnMakeConfirm_Click(object sender, EventArgs e)
        {
            clsCarMake make = new clsCarMake();
            make.sAddNewMake = txtAddNewMake.Text.ToString();



            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();


            if (chbExistingMake.Checked == true)
            {

                lblSelectedMake.Text = carMakes[cboCarMakes.SelectedIndex].sMakeName.ToString();
                newMake = new clsCarMake();

                newMake.iInsertMakeID = carMakes[cboCarMakes.SelectedIndex].iMakeId;

            }
            else if (chbNewMake.Checked == true)
            {

                lblSelectedMake.Text = make.sAddNewMake.ToString();
                

                if (clsVehicles.InsertNewMake(txtAddNewMake.Text.ToString()) == null)
                {
                    return;
                }
            }

            lblSelection.Visible = true;
            lblSelectedMake.Visible = true;
            gboModelChoice.Visible = true;
        }

        private void txtAddCarModel_TextChanged(object sender, EventArgs e)
        {
            btnModelConfirm.Visible = true;
        }

        private void btnModelConfirm_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtAddCarModel.Text))
            {
                lblAlert.Text = "Please insert all required information.";
                lblAlert.Visible = true;
                return;
            }



            clsCarModel model = new clsCarModel();
            model.sModelName = txtAddCarModel.Text.ToString();
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            if (clsVehicles.CheckExistingModel(txtAddCarModel.Text.ToString()) == null)
            {
                return;
            }

            lblNewModel.Visible = true;
            lblNewModelSelection.Text = model.sModelName.ToString();
            lblNewModelSelection.Visible = true;
            gboAddDetails.Visible = true;
            gboMakeChoice.Visible = false;
            gboModelChoice.Visible = false;
            lblAlert.Visible = false;
        }


        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
            clsValidation objValidation = new clsValidation();
            if (String.IsNullOrEmpty(txtModelPrice.Text) || String.IsNullOrEmpty(txtEngineSize.Text) || String.IsNullOrEmpty(cboFuelPick.Text) || String.IsNullOrEmpty(cboTransmissionPick.Text) || String.IsNullOrEmpty(txtMPG.Text) || String.IsNullOrEmpty(cboDrivePick.Text) || String.IsNullOrEmpty(txtEmissions.Text))
            {
                lblAlert.Text = "Please insert all required information.";
                lblAlert.Visible = true;
                return;
            }

            if(objValidation.ValidateIsDecimal(txtModelPrice.Text) != true || objValidation.ValidateIsNumber(txtEngineSize.Text) != true || objValidation.ValidateIsNumber(txtMPG.Text) != true || objValidation.ValidateIsNumber(txtEmissions.Text) != true)
            {
                lblAlert.Text = "Please ensure you data is correct and all numerical values are inputted as numbers.";
                lblAlert.Visible = true;
                return;
            }

            

            gboCheckDetails.Visible = true;
            gboAddDetails.Visible = false;
            lblConfirmPrice.Text = txtModelPrice.Text.ToString();
            lblConfirmEngine.Text = txtEngineSize.Text.ToString();
            lblConfirmDoors.Text = nudDoors.Text.ToString();
            lblConfirmFuel.Text = cboFuelPick.Text.ToString();
            lblConfirmTransmission.Text = cboTransmissionPick.Text.ToString();
            lblConfirmMPG.Text = txtMPG.Text.ToString();
            lblConfirmDrive.Text = cboDrivePick.Text.ToString();
            lblConfirmEmissions.Text = txtEmissions.Text.ToString();
            lblConfirmYear.Text = dtpYear.Text.ToString();
            lblAlert.Visible = false;
        }

        private void btnCommitChanges_Click(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            clsVehicles.InsertModel(
                newMake.iInsertMakeID,
                Convert.ToString(txtAddCarModel.Text),
                Convert.ToDecimal(txtModelPrice.Text),
                Convert.ToInt32(txtEngineSize.Text),
                Convert.ToInt32(nudDoors.Text),
                cboFuelPick.Text, cboTransmissionPick.Text,
                Convert.ToInt32(txtMPG.Text),
                cboDrivePick.Text,
                Convert.ToDouble(txtEmissions.Text),
                Convert.ToInt32(dtpYear.Text)
          );

            gboAddDetails.Visible = false;
            gboCheckDetails.Visible = false;
            lblConfirmChanges.Visible = true;
            btnMenuReturn.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}