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
    public partial class frm_VehicleSelection : Form
    {
        int selectedMakeId;

        public frm_VehicleSelection(int iIndexSelected)
        {

            InitializeComponent();
            lbl_Index.Text = iIndexSelected.ToString();

        }

        private void ddl_VehicleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            int iIndex = 0;
            string[] sDetails;
            string[] sName;
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();
            string sSelected;

            //--------------------------------Section-----------------------------------------------------

            //Switched indexs based on user selection of vehicle

            iIndex = ddl_VehicleSelect.SelectedIndex;
            ddl_VehicleID.SelectedIndex = iIndex;
            sSelected = ddl_VehicleID.Text;

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Pulls vehicle details from the database to populate the sDetails array, used to populate form labels

            sDetails = clsVehicles.GetVehicleDetails(sSelected);
            sName = clsVehicles.GetVehicleName(sSelected);

            decimal dTemp = decimal.Parse(sDetails[0]);
            string sFormatPrice = dTemp.ToString("C");

            lbl_BasePrice.Text = sFormatPrice;
            lbl_Doors.Text = sDetails[1];
            lbl_Drive.Text = sDetails[2];
            lbl_MilesPG.Text = sDetails[3];
            lbl_Engine.Text = sDetails[4];
            lbl_Fuel.Text = sDetails[5];
            lbl_Year.Text = sDetails[6];
            lbl_Emission.Text = sDetails[7];
            lbl_Transmission.Text = sDetails[8];

            lbl_VehicleMake.Text = sName[0];
            lbl_VehicleModel.Text = sName[1];
            selectedMakeId = Convert.ToInt32(sName[2]);

            //--------------------------------End Section-----------------------------------------------

        }

        private void frm_VehicleSelection_Load(object sender, EventArgs e)
        {

            img_SelectionImage.Image = year3_collaborative_project.Properties.Resources.fordMondeo;

            int iCount = 0;

            clsDatabase_Vehicles objDatabase = new clsDatabase_Vehicles();

            //--------------------------------Section-----------------------------------------------------

            //Populates dropboxs by pulling down an array from class database

            string[,] sVehicles = objDatabase.GetAllVehicles();

            for (iCount = 0; iCount < sVehicles.GetLength(0); iCount++)
            {

                ddl_VehicleSelect.Items.Add(sVehicles[iCount, 1] + " " + sVehicles[iCount, 2]);
                ddl_VehicleID.Items.Add(sVehicles[iCount, 0]);

            }

            //--------------------------------End Section-----------------------------------------------


            int iSelected = int.Parse(lbl_Index.Text);

            ddl_VehicleSelect.SelectedIndex = iSelected;
            ddl_VehicleID.SelectedIndex = iSelected;

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Iterates through the dropdown by increasing selection index

            if (ddl_VehicleSelect.SelectedIndex == ddl_VehicleSelect.Items.Count - 1)
            {

                ddl_VehicleSelect.SelectedIndex = 0;

            }
            else
            {

                ddl_VehicleSelect.SelectedIndex = ddl_VehicleSelect.SelectedIndex + 1;

            }

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {

            //--------------------------------Section-----------------------------------------------------

            //Iterates through the dropdown by decreasing selection index

            if (ddl_VehicleSelect.SelectedIndex == 0)
            {

                ddl_VehicleSelect.SelectedIndex = ddl_VehicleSelect.Items.Count - 1;

            }
            else
            {

                ddl_VehicleSelect.SelectedIndex = ddl_VehicleSelect.SelectedIndex - 1;

            }

            //--------------------------------End Section-----------------------------------------------

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

        private void btn_Select_Click(object sender, EventArgs e)
        {

            frmCustomerConfig frm_Config = new frmCustomerConfig(ddl_VehicleID.SelectedItem.ToString(), lbl_VehicleMake.Text, lbl_VehicleModel.Text, lbl_BasePrice.Text, selectedMakeId.ToString(), "A", "A");
            frm_Config.Show();
            this.Close();

        }
    }
}
