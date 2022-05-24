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
    public partial class frmAcceptInvoice : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        List<string> slConfig = new List<string>();
        List<string> slInfo = new List<string>();

        string sApproveorDelete;
        public frmAcceptInvoice()
        {
            InitializeComponent();
        }

        private void PopulateList(DataTable dt)
        {
            cbList.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                slConfig.Add(dr[0].ToString() + ") " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());
            }
        }

        private void PopulateListDelete(DataTable dt, DataTable dt2)
        {
            foreach (DataRow dr in dt.Rows)
            {
                slConfig.Add(dr[0].ToString() + ") " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " - Approved");
            }
            foreach (DataRow dr in dt2.Rows)
            {
                slConfig.Add(dr[0].ToString() + ") " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " - Not Approved");
            }
        }

        private void PopulateInfo()
        {
            clsDatabase_Invoicing clsInvoicing = new clsDatabase_Invoicing();
            clsValidation objValidation = new clsValidation();
            List<string> slDiscount = clsInvoicing.GetDiscountPercentages();

            lblConfigID.Text = "Config ID: " + slInfo[0];
            lblCustName.Text = "Customer Name: " + slInfo[1] + " " + slInfo[2];
            lblMakeModel.Text = "Make and Model: " + slInfo[3] + " " + slInfo[4];
            lblAPR.Text = "APR: " + slInfo[5] + "% over " + slInfo[6] + " months";

            cbDiscount.Items.Clear();
            for (int iCount = 0; iCount < slDiscount.Count; iCount++)
            {
                cbDiscount.Items.Add(slDiscount[iCount]);
            }

            lblColour.Text = "Colour: " + slInfo[7];
            lblTotal.Text = "Total Price: " + objValidation.FormatCurrencyForDisplay(slInfo[8]);
        }
        private List<string> SplitMods(int iConfigID)
        {
            List<string> slModIDs = new List<string>();
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            string sMods = clsConfigs.GetConfigMods(iConfigID);
            slModIDs = sMods.Split(',').ToList();

            return slModIDs;
        }
        private void PopulateModList(List<string> slMods)
        {
            lbModNamePrice.Items.Clear();
            clsDatabase_Modifications clsMods = new clsDatabase_Modifications();

            if (!slConfig.Any())
            {
                for (int iCount = 0; iCount < slMods.Count(); iCount++)
                {

                    lbModNamePrice.Items.Add(clsMods.GetModNamePrice(Convert.ToInt32(slMods[iCount])));
                }
            }
        }

        private void FillcbList()
        {
            for (int iCount = 0; iCount < slConfig.Count(); iCount++)
            {
                cbList.Items.Add(slConfig[iCount]);
            }
        }

        private void frmAcceptInvoice_Load(object sender, EventArgs e)
        {
            gbSelection.Visible = false;
            gbInfo.Visible = false;
            clsDatabase objDatabase = new clsDatabase();
            //dt = objDatabase.PopulateConfigList();
            PopulateList(dt);

            for (int iCount = 0; iCount < slConfig.Count(); iCount++)
            {
                cbList.Items.Add(slConfig[iCount]);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnConfirmInvoice_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            List<string> slMods = new List<string>();
            gbInfo.Visible = true;

            slInfo = clsConfigs.GetConfigInfo(Convert.ToInt32(dt.Rows[cbList.SelectedIndex][0]));

            slMods = SplitMods(Convert.ToInt32(slInfo[0]));
            PopulateModList(slMods);

            PopulateInfo();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (sApproveorDelete == "Approve")
            {
                clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
                clsDatabase_Invoicing clsInvoicing = new clsDatabase_Invoicing();
                DialogResult dr = MessageBox.Show("Are you sure you wish to accept " + slInfo[1] + " " + slInfo[2] + " " + slInfo[3] + " " + slInfo[4] + " invoice?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(cbDiscount.Text))
                    {
                        return;
                    }
                    else
                    {
                        clsDatabase_Users objDatabase_Users = new clsDatabase_Users();

                        int iDiscountID = clsInvoicing.GetDiscountID(Convert.ToInt32(cbDiscount.Text));
                        decimal dTotalPrice = Convert.ToDecimal(Convert.ToDouble(slInfo[8]) - (Convert.ToDouble(slInfo[8]) * (Convert.ToDouble(cbDiscount.Text) / 100)));
                        int iAdminID = objDatabase_Users.GetAdminID(clsUser.IUserID);


                        clsInvoicing.AcceptInvoice(iDiscountID, iAdminID, Convert.ToInt32(slInfo[0]), dTotalPrice);

                        gbInfo.Visible = false;

                        dt = clsConfigs.PopulateConfigListApprove();
                        PopulateList(dt);
                        FillcbList();
                        cbList.SelectedItem = null;

                        lblAlert.Text = "You have approved the selected invoice.";
                        lblAlert.Visible = true;
                        sApproveorDelete = "";
                        cbList.Items.Clear();
                        cbDiscount.Items.Clear();
                        lbModNamePrice.Items.Clear();
                    }
                }
            }
            else if (sApproveorDelete == "SignOff")
            {
                clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
                clsDatabase_Invoicing clsInvoicing = new clsDatabase_Invoicing();
                DialogResult dr = MessageBox.Show("Are you sure you wish to sign off on " + slInfo[1] + " " + slInfo[2] + " " + slInfo[3] + " " + slInfo[4] + " invoice?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    clsDatabase_Users objDatabase_Users = new clsDatabase_Users();

                    clsInvoicing.SignOffInvoice(Convert.ToInt32(slInfo[0]));

                    gbInfo.Visible = false;

                    dt = clsConfigs.PopulateConfigListSignOff();
                    PopulateList(dt);
                    FillcbList();
                    cbList.SelectedItem = null;

                    lblAlert.Text = "You have signed off on the selected invoice.";
                    lblAlert.Visible = true;
                    sApproveorDelete = "";
                    cbList.Items.Clear();
                    cbDiscount.Items.Clear();
                    lbModNamePrice.Items.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            DialogResult dr = MessageBox.Show("Are you sure you wish to DELETE " + slInfo[1] + " " + slInfo[2] + " " + slInfo[3] + " " + slInfo[4] + " invoice?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                clsConfigs.DeleteConfig(Convert.ToInt32(slInfo[0]));

                gbInfo.Visible = false;

                dt = clsConfigs.PopulateConfigListApprove();
                PopulateList(dt);
                FillcbList();
                cbList.SelectedItem = null;

                lblAlert.Text = "You have deleted the selected invoice.";
                lblAlert.Visible = true;
                sApproveorDelete = "";
                cbList.Items.Clear();
                cbDiscount.Items.Clear();
                lbModNamePrice.Items.Clear();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            dt = clsConfigs.PopulateConfigListApprove();
            PopulateList(dt);
            FillcbList();
            gbSelection.Visible = true;
            gbAppoveOrDelete.Visible = false;
            sApproveorDelete = "Approve";
        }

        private void btnDeleteChoice_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            dt = clsConfigs.PopulateConfigListDelete();
            dt2 = clsConfigs.PopulateConfigListApprove();
            PopulateListDelete(dt, dt2);
            FillcbList();
            gbSelection.Visible = true;
            gbAppoveOrDelete.Visible = false;
            sApproveorDelete = "Delete";
        }

        private void btnConfirmApprove_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            List<string> slMods = new List<string>();
            gbInfo.Visible = true;

            slInfo = clsConfigs.GetConfigInfo(Convert.ToInt32(dt.Rows[cbList.SelectedIndex][0]));

            slMods = SplitMods(Convert.ToInt32(slInfo[0]));
            PopulateModList(slMods);

            PopulateInfo();
            btnDelete.Visible = false;
        }

        private void btnListConfirmDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbList.Text))
            {
                lblAlert.Text = "Please select an invoice";
                lblAlert.Visible = true;

                return;
            }

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            List<string> slMods = new List<string>();
            gbInfo.Visible = true;

            List<string> slConfigIDs = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                slConfigIDs.Add(dr[0].ToString());
            }

            foreach (DataRow dr in dt2.Rows)
            {
                slConfigIDs.Add(dr[0].ToString());
            }

            slInfo = clsConfigs.GetConfigInfo(Convert.ToInt32(slConfigIDs[cbList.SelectedIndex]));

            slMods = SplitMods(Convert.ToInt32(slInfo[0]));
            PopulateModList(slMods);

            PopulateInfo();

            if (sApproveorDelete == "Delete")
            {
                lblDiscount.Visible = false;
                cbDiscount.Visible = false;
                btnConfirm.Visible = false;

                lblColour.Top = 133;
                lblMods.Top = 166;
                lbModNamePrice.Top = 166;
                lblTotal.Top = 238;
            }   
            else if (sApproveorDelete == "Approve")
            {
                btnDelete.Visible = false;
            }
            else if (sApproveorDelete == "SignOff")
            {
                lblDiscount.Visible = false;
                cbDiscount.Visible = false;
                btnDelete.Visible = false;

                lblColour.Top = 133;
                lblMods.Top = 166;
                lbModNamePrice.Top = 166;
                lblTotal.Top = 238;
            }
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            dt = clsConfigs.PopulateConfigListSignOff();
            PopulateList(dt);
            FillcbList();
            gbSelection.Visible = true;
            gbAppoveOrDelete.Visible = false;
            sApproveorDelete = "SignOff";
        }

        private void btnConfirmSignOff_Click(object sender, EventArgs e)
        {

        }
    }

}