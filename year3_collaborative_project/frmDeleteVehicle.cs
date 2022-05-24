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
    public partial class frmDeleteVehicle : Form
    {
        List<clsCarMake> carMakes;
        List<clsCarModel> carModel;
        public frmDeleteVehicle()
        {
            InitializeComponent();
        }

        // Populates combo box with existing carmakes on form load
        private void frmDeleteVehicle_Load(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            carMakes = clsVehicles.ListCarMakes();

            foreach (clsCarMake make in carMakes)
            {
                cboCarMake.Items.Add(make.sMakeName);

            }
        }

        // Populates combo box with models only for selected make
        private void cboCarMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmSelection.Visible = false;

            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            carModel = clsVehicles.ListCarModels(carMakes[cboCarMake.SelectedIndex]);

            cboCarModel.Items.Clear();
            cboCarModel.ResetText();

            foreach (clsCarModel model in carModel)
            {
                cboCarModel.Items.Add(model.sModelName);
            }
        }

        private void cboCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmSelection.Visible = true;
        }

        // Ensures confirmation of deletion before actually carrying it out
        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            gboVehicleSelection.Visible = false;
            gboConfirmDeletion.Visible = true;
            lblMake.Text = carMakes[cboCarMake.SelectedIndex].sMakeName.ToString();
            lblModel.Text = carModel[cboCarModel.SelectedIndex].sModelName.ToString();
          
           
        }

        // Delets Make and Model from Database
        private void btnReConfirm_Click(object sender, EventArgs e)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            clsVehicles.DeleteModel(carModel[cboCarModel.SelectedIndex].iModelId);

            gboConfirmDeletion.Visible = false;
            lblSuccess.Visible = true;
            btnMenuReturn.Visible = true;

        }

        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelAndExit_Click(object sender, EventArgs e)
        {
            btnReConfirm.Visible = false;
            lblExitConfirm.Visible = true;
            btnExit.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
