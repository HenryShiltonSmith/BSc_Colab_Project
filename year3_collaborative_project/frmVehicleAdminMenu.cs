using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace year3_collaborative_project
{
    public partial class frmVehicleAdminMenu : Form
    {
        public frmVehicleAdminMenu()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click_1(object sender, EventArgs e)
        {
            frmAddVehicle changeForm = new frmAddVehicle();
            changeForm.FormClosed += new FormClosedEventHandler(changeForm_FormClosed);

            changeForm.Show();
            this.Hide();
        }

        void changeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnEditVehicle_Click_1(object sender, EventArgs e)
        {
            frmEditVehicle changeForm1 = new frmEditVehicle();
            changeForm1.FormClosed += new FormClosedEventHandler(changeForm1_FormClosed);

            this.Hide();
            changeForm1.Show();
        }

        void changeForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnDeleteVehicle_Click_1(object sender, EventArgs e)
        {
            frmDeleteVehicle changeForm2 = new frmDeleteVehicle();
            changeForm2.FormClosed += new FormClosedEventHandler(changeForm2_FormClosed);

            this.Hide();
            changeForm2.Show();
        }

        void changeForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frm_Menu = new frmMenu();
            frm_Menu.Show();
            this.Close();
        }
    }
}
