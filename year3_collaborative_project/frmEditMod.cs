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
    public partial class frmEditMod : Form
    {
        static string sSelectedMod = "";
        clsDatabase_Modifications clsMods = new clsDatabase_Modifications();
        clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
        clsDatabase clsData = new clsDatabase();
        DataTable dt = new DataTable();
        bool bFinish = false;
        
        public frmEditMod()
        {
            InitializeComponent();
        }

        private void updateCLB()
        {
            int iCount = 0;
            var slMods = new List<string>();
            dt = clsMods.GetMods();

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
        private void frmEditMod_Load(object sender, EventArgs e)
        {
            lblName.Visible = false;
            lblPrice.Visible = false;
            txtName.Visible = false;
            nudPrice.Visible = false;

            updateCLB();
        }

        private void clbWhichMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int ix = 0; ix < clbWhichMod.Items.Count; ++ix)
            {
                clbWhichMod.SetItemChecked(ix, false);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (clbWhichMod.CheckedItems.Count < 1)
            {
                lblAlert.Text = "You must select at least one option.";
                lblAlert.Visible = true;

                
                return;
            }

            if (bFinish == false)
            {
                List<string> slModNames = new List<string>();
                int iCount;
                for (iCount = 0; iCount <= (clbWhichMod.Items.Count - 1); iCount++)
                {
                    if (clbWhichMod.GetItemChecked(iCount))
                    {
                        slModNames.Add(Convert.ToString(dt.Rows[iCount][0]));
                    }
                }

                sSelectedMod = slModNames[0];

                lblWhichMod.Visible = false;
                clbWhichMod.Visible = false;
                lblName.Visible = true;
                lblPrice.Visible = true;
                txtName.Visible = true;
                nudPrice.Visible = true;

                dt = clsConfigs.GetSelectedMod(sSelectedMod);

                var slSelectedInfo = new List<string>();
                string sName;
                decimal dPrice = 0;

                sName = dt.Rows[0][0].ToString();
                dPrice = Convert.ToDecimal(dt.Rows[0][1]);

                txtName.Text = sName;
                nudPrice.Maximum = Decimal.MaxValue;
                nudPrice.Value = dPrice;

                bFinish = true;
            }
            else
            {

                if(string.IsNullOrEmpty(txtName.Text))
                {
                    lblAlert.Text = "Please input a modification name";
                    lblAlert.Visible = true;

                    return;
                }   
                
                clsMods.UpdateMod(sSelectedMod, txtName.Text, nudPrice.Value);

                lblName.Visible = false;
                lblPrice.Visible = false;
                txtName.Visible = false;
                nudPrice.Visible = false;

                bFinish = false;

                lblWhichMod.Visible = true;
                clbWhichMod.Visible = true;

                lblAlert.Text = "Your edit has been made.";
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
