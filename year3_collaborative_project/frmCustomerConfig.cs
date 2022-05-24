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
using System.Text.RegularExpressions;

namespace year3_collaborative_project
{
    public partial class frmCustomerConfig : Form
    {
        List<clsCustomerConfig> colours;
        List<clsCustomerConfig> carMods;
        List<clsAPR> AprOptions;
        clsAPR selectedAPR;
        clsCustomerConfig selectedColour;
        int selectedMakeId;
        decimal dTotalPrice;
        decimal dTotalPriceIncInterest;
        String selectedMods;
        String selectedModsPrice; // <- look up from the mods table eventually
        clsCarModel clsModel = new clsCarModel();
        public frmCustomerConfig(string sModelID, string sMake, string sModel, string sPrice, string sMakeId, string sConfig, string sCustID)
        {

            InitializeComponent();
            lbl_Index.Text = sMakeId;
            lbl_ModelID.Text = sModelID;
            lbl_VehicleMake.Text = sMake;
            lbl_VehicleModel.Text = sModel;
            lblBasePrice.Text = sPrice;
            lblTotalPrice.Text = sPrice;
            lbl_ConfigID.Text = sConfig;
            lbl_CustID.Text = sCustID;

            selectedMakeId = int.Parse(sMakeId);

        }

        private void RunModBoxPopulate()
        {

            clsValidation clsValidate = new clsValidation();

            clbMods.Visible = true;
            lblTotalModPrice.Visible = true;
            lblModCostInd.Visible = true;
            btnConfirmModSelection.Visible = true;

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();

            carMods = clsConfigs.ListCarModifications(clsModel);

            clbMods.Items.Clear();


            foreach (clsCustomerConfig modifications in carMods)
            {
                clbMods.Items.Add(modifications.sModName + "    " + clsValidate.FormatCurrencyForDisplay(modifications.dModPrice.ToString()));
            }

            lblTotalPrice.Location = new Point(373, 296);
            lbl_TotalPriceInd.Location = new Point(404, 277);

        }

        private void frmCustomerConfig_Load(object sender, EventArgs e)
        {

            int iConfig = 0;

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            clsValidation clsValidate = new clsValidation();

            clsModel.iModelId = int.Parse(lbl_ModelID.Text);
            clsModel.sModelName = lbl_VehicleModel.Text;
            clsModel.dModelPrice = clsValidate.FormatCurrencyForCalculation(lblBasePrice.Text);          //Sets model price from lbl, passed into class to be reformatted

            colours = clsConfigs.ListCarColours(clsModel);

            cboColour.Items.Clear();

            foreach (clsCustomerConfig colour in colours)
            {
                cboColour.Items.Add(colour.sColourName);
            }

            if (int.TryParse(lbl_ConfigID.Text, out iConfig) != false)
            {

                //--------------------------------Section-----------------------------------------------------

                //Populates screen with downloaded config settings and adjusts input methods accordingly

                string[] sConfigIDs = clsConfigs.GetBasicConfigDetails(int.Parse(lbl_ConfigID.Text));
                string[] sMod;
                string sModCheck;
                decimal dTotalMod;

                lbl_CustID.Text = sConfigIDs[0];
                string sColour = clsConfigs.GetColourName(int.Parse(sConfigIDs[2]));

                cboColour.SelectedItem = sColour;
                RunModBoxPopulate();

                string[] sIDs = Regex.Split(sConfigIDs[3], @"\D+");
                int iModCount = 0;

                if (sIDs[0] != "")
                {

                    for (int iCount = 0; iCount < clbMods.Items.Count; iCount++)
                    {

                        for (int iCount2 = 0; iCount2 < sIDs.Length; iCount2++)
                        {

                            sMod = clsConfigs.GetMod(int.Parse(sIDs[iCount2]));
                            sModCheck = sMod[0] + "    " + clsValidate.FormatCurrencyForDisplay(decimal.Parse(sMod[1]).ToString());

                            if (clbMods.Items[iModCount].ToString() == sModCheck)
                            {

                                clbMods.SetItemChecked(iModCount, true);
                                dTotalMod = decimal.Parse(lblTotalModPrice.Text);
                                dTotalMod = dTotalMod + decimal.Parse(sMod[1]);
                                lblTotalModPrice.Text = dTotalMod.ToString();

                            }

                        }

                        iModCount = iModCount + 1;

                    }

                }

                lblTotalModPrice.Text = clsValidate.FormatCurrencyForDisplay(decimal.Parse(lblTotalModPrice.Text).ToString());
                btnConfirmModSelection.Visible = false;
                btnSubmitColourSelect.Visible = false;

                AprOptions = clsConfigs.ListAPR();
                gboFinanceOptions.Visible = true;
                foreach (clsAPR APR in AprOptions)
                {
                    cboFinanceLength.Items.Add(APR.iAprLength.ToString());
                }

                cboFinanceLength.SelectedItem = clsConfigs.GetAPRLength(int.Parse(sConfigIDs[1]));

                //--------------------------------End Section-----------------------------------------------

            }
            else
            {

                lblTotalPrice.Location = new Point(373, 244);
                lbl_TotalPriceInd.Location = new Point(404, 225);

            }

        }

        private void btnSubmitColourSelect_Click(object sender, EventArgs e)
        {

            RunModBoxPopulate();

        }

        // When mods are checked add to list and update prices
        private void clbMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsValidation clsValidate = new clsValidation();
            
            decimal modsCost = 0;

            selectedMods = "";

            for (int i = 0; i < clbMods.Items.Count; i++)
            {
                CheckState cS = clbMods.GetItemCheckState(i);
                if (cS == CheckState.Checked)
                {
                    clsCustomerConfig mod = carMods[i];
                    modsCost += mod.dModPrice;

                    if (selectedMods.Equals(""))
                    {
                        selectedMods = mod.iModID.ToString();
                        selectedModsPrice = mod.dModPrice.ToString();
                    } else
                    {
                        selectedMods = selectedMods + "," + mod.iModID.ToString();
                        selectedModsPrice = selectedModsPrice + "," + mod.dModPrice.ToString();
                    }
                }
                
              
            }


            clsCustomerConfig mods = new clsCustomerConfig();
            mods.dTotalModPrice = modsCost;
            lblTotalModPrice.Text = clsValidate.FormatCurrencyForDisplay(mods.dTotalModPrice.ToString());
            lblTotalPrice.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblBasePrice.Text) + modsCost) + "");
        }

        private void btnConfirmModSelection_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            AprOptions = clsConfigs.ListAPR();
            gboFinanceOptions.Visible = true;
            foreach (clsAPR APR in AprOptions)
            {
                cboFinanceLength.Items.Add(APR.iAprLength.ToString());
            }

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {

            int iConfig;
            
            if (int.TryParse(lbl_ConfigID.Text, out iConfig) != false)
            {

                frmLoad_Config frmLoad = new frmLoad_Config();
                frmLoad.Show();
                this.Close();

            }
            else
            {

                int iSelected = int.Parse(lbl_Index.Text);

                frm_VehicleSelection frm_Selection = new frm_VehicleSelection(iSelected);
                frm_Selection.Show();
                this.Close();

            }

        }

        // update costs based on colour selection
        private void cboColour_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsValidation clsValidate = new clsValidation();

            lblColourCost.Text = clsValidate.FormatCurrencyForDisplay(colours[cboColour.SelectedIndex].dColourPrice.ToString());
            lblTotalPrice.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblBasePrice.Text) + clsValidate.FormatCurrencyForCalculation(lblColourCost.Text)).ToString());

            selectedColour = colours[cboColour.SelectedIndex];
        }

        // update total price as mods are added
        private void lblTotalModPrice_TextChanged(object sender, EventArgs e)
        {

            clsValidation clsValidate = new clsValidation();
            

            dTotalPrice = clsValidate.FormatCurrencyForCalculation(lblTotalPrice.Text) + clsValidate.FormatCurrencyForCalculation(lblTotalModPrice.Text);
            lblTotalPrice.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblTotalPrice.Text) + clsValidate.FormatCurrencyForCalculation(lblTotalModPrice.Text)).ToString());
        }

        // store APR for use later
        private void cboFinanceLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblAPR.Visible = true;
            lblAPRValue.Text = AprOptions[cboFinanceLength.SelectedIndex].iAprPercent.ToString();
            lblAPRValue.Visible = true;
            lblPercent.Visible = true;
            btnConfirmFinance.Visible = true;
            selectedAPR = AprOptions[cboFinanceLength.SelectedIndex];
        }

        // work out totalPriceIncInterest and monthly payments based on finance length 
        private void btnConfirmFinance_Click(object sender, EventArgs e)
        {
            
            gboMonthlyPayments.Visible = true;
            clsValidation clsValidate = new clsValidation();

            decimal dRate = AprOptions[cboFinanceLength.SelectedIndex].iAprPercent;
            decimal dPercentageRate = (dRate / 100) + 1;
            lblInterestIncluded.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblTotalPrice.Text) * dPercentageRate).ToString());

            dTotalPriceIncInterest = clsValidate.FormatCurrencyForCalculation(lblInterestIncluded.Text);
            //lblInterestIncluded.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblTotalPrice.Text) * (((AprOptions[cboFinanceLength.SelectedIndex].iAprPercent) +100) / 100)).ToString());

            lblMonthValue.Text = AprOptions[cboFinanceLength.SelectedIndex].iAprLength.ToString();

            lblMonthlyCost.Text = clsValidate.FormatCurrencyForDisplay((clsValidate.FormatCurrencyForCalculation(lblInterestIncluded.Text) / ((AprOptions[cboFinanceLength.SelectedIndex].iAprLength))).ToString());

            img_SelectionImage.Visible = false;
            gboCustConfirm.Visible = true;

        }

        // save configuration to database without submitting for callback
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();

            int iConfig;
            
            if (int.TryParse(lbl_ConfigID.Text, out iConfig) != false)
            {

                clsConfigs.UpdateConfig(selectedAPR.iAprId, selectedColour.iColourId, selectedMods, selectedModsPrice, dTotalPriceIncInterest, 0, int.Parse(lbl_ConfigID.Text));

            }
            else
            {
                clsDatabase_Users objDatabase = new clsDatabase_Users();
                int iCustID = objDatabase.FindUserID(clsUser.IUserID);
                clsConfigs.SaveConfiguration(
                iCustID,
                clsModel.iModelId,
                selectedMakeId,
                selectedAPR.iAprId,
                selectedColour.iColourId,
                selectedMods,
                selectedModsPrice,
                dTotalPriceIncInterest
            );

            }

            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();

        }

        // save config to database and submit to dealership for callback
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();

            int iConfig;

            if (int.TryParse(lbl_ConfigID.Text, out iConfig) != false)
            {

                clsConfigs.UpdateConfig(selectedAPR.iAprId, selectedColour.iColourId, selectedMods, selectedModsPrice, dTotalPriceIncInterest, 1, int.Parse(lbl_ConfigID.Text));

            }
            else
            {
                clsDatabase_Users objDatabase = new clsDatabase_Users();
                int iCustID = objDatabase.FindUserID(clsUser.IUserID);
                clsConfigs.SubmitConfiguration(
                iCustID,
                clsModel.iModelId,
                selectedMakeId,
                selectedAPR.iAprId,
                selectedColour.iColourId,
                selectedMods,
                selectedModsPrice,
                dTotalPriceIncInterest,
                1
            );

            }
            
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();

        }

        // close current form and load menu
        private void btnExit_Click(object sender, EventArgs e)
        {

            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
    

