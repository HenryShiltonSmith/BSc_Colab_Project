﻿using System;
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
    public partial class frmDeactivateMod : Form
    {
        static string sSelectedMod = "";
        clsDatabase_Modifications objDatabase_Modifications = new clsDatabase_Modifications();
        DataTable dt = new DataTable();
        public frmDeactivateMod()
        {
            InitializeComponent();
        }

        private void updateCLB()
        {
            int iCount = 0;
            var slMods = new List<string>();
            dt = objDatabase_Modifications.GetActiveMods();

            foreach (DataRow dr in dt.Rows)
            {
                slMods.Add(dt.Rows[iCount][0].ToString());

                iCount++;
            }

            iCount = 0;

            while (iCount < slMods.Count())
            {
                clbWhichMod.Items.Add(slMods[iCount]);

                iCount++;
            }
        }
        private void frmDeleteMod_Load(object sender, EventArgs e)
        {
            updateCLB();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (clbWhichMod.CheckedItems.Count < 1)
            {
                lblAlert.Text = "You must select at least one option.";
                lblAlert.Visible = true;


                return;
            }

            List<string> slModName = new List<string>();
            int iCount;
            for (iCount = 0; iCount <= (clbWhichMod.Items.Count - 1); iCount++)
            {
                if (clbWhichMod.GetItemChecked(iCount))
                {
                    slModName.Add(Convert.ToString(dt.Rows[iCount][0]));
                }
            }

            sSelectedMod = slModName[0];

            DialogResult dr = MessageBox.Show("Are you shure you wish to deactivate  " + sSelectedMod, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                objDatabase_Modifications.DeactivateMod(sSelectedMod);

                lblAlert.Text = "The mod has been deactivated";
                lblAlert.Visible = true;
                clbWhichMod.Items.Clear();
                updateCLB();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}
