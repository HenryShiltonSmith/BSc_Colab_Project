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
    public partial class frmAddMod : Form
    {
        int iCount = 0;
        List<int> ilModelID = new List<int>();
        DataTable dt = new DataTable();

        public frmAddMod()
        {
            InitializeComponent();
        }

        private void frmAddMod_Load(object sender, EventArgs e)
        {
            nudPrice.Maximum = decimal.MaxValue;
            this.AcceptButton = btnConfirm;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clsDatabase_Vehicles objDatabase = new clsDatabase_Vehicles();

            if (iCount == 0 || cbColour.SelectedIndex == -1)
            {
                iCount = 0;
                lblColour.Visible = true;
                cbColour.Visible = true;
                btnConfirm.Top = 134;
                iCount++;
                return;
            }
            if (iCount == 1)
            {
                iCount = 1;
                txtModName.Visible = true;
                lblModName.Visible = true;
                iCount++;
                btnConfirm.Top = 185;
                return;
            }
            if (iCount == 2)
            {
                lblAvailable.Visible = true;
                clbAvailable.Visible = true;

                var slMakeModel = new List<string>();
                int iCount = 0;
                dt = objDatabase.GetModelMake();

                foreach (DataRow dr in dt.Rows)
                {
                    //sHolderMake = dt.Rows[iCount][0].ToString();
                    //sHolderModel = dt.Rows[iCount][1].ToString();

                    slMakeModel.Add(dt.Rows[iCount][0].ToString() + " " + dt.Rows[iCount][1].ToString());

                    iCount++;
                }

                iCount = 0;

                while (iCount < slMakeModel.Count())
                {
                    clbAvailable.Items.Add(slMakeModel[iCount]);

                    iCount++;
                }

                iCount = 0;

                btnConfirm.Visible = false;
                btnSubmit.Visible = true;
                iCount = 2;
                return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsDatabase_Modifications clsMods = new clsDatabase_Modifications();
            //Add New Mod
            if (cbColour.Text == "No")
            {
                ilModelID.Clear();
                for (iCount = 0; iCount <= (clbAvailable.Items.Count - 1); iCount++)
                {
                    if (clbAvailable.GetItemChecked(iCount))
                    {
                        ilModelID.Add(Convert.ToInt32(dt.Rows[iCount][2]));
                    }
                }

                clsMods.AddMod(txtModName.Text, nudPrice.Value, ilModelID);

                lblColour.Visible = false;
                cbColour.Visible = false;
                lblModName.Visible = false;
                txtModName.Visible = false;
                btnSubmit.Visible = false;
                lblAvailable.Visible = false;
                clbAvailable.Visible = false;

                btnConfirm.Left = 377;
                btnConfirm.Top = 94;
                btnConfirm.Visible = true;

                lblComplete.Text = "Your new modification has been added";
                lblComplete.Visible = true;

                iCount = 0;
            }
            //Add New Colour
            if (cbColour.Text == "Yes")
            {
                ilModelID.Clear();
                for (iCount = 0; iCount <= (clbAvailable.Items.Count - 1); iCount++)
                {
                    if (clbAvailable.GetItemChecked(iCount))
                    {
                        ilModelID.Add(Convert.ToInt32(dt.Rows[iCount][2]));
                    }
                }

                clsMods.AddColour(txtModName.Text, nudPrice.Value, ilModelID);

                lblColour.Visible = false;
                cbColour.Visible = false;
                txtModName.Visible = false;
                lblModName.Visible = false;
                btnSubmit.Visible = false;
                lblAvailable.Visible = false;
                clbAvailable.Visible = false;

                btnConfirm.Left = 377;
                btnConfirm.Top = 94;
                btnConfirm.Visible = true;

                lblComplete.Text = "Your new colour has been added";
                lblComplete.Visible = true;

                iCount = 0;
            }
        }
    }
}
