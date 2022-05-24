using System;
using System.IO;
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
    public partial class frmStats : Form
    {
        List<clsStatistics> Popular;
        List<clsStatistics> LeastPopular;
        public frmStats()
        {
            InitializeComponent();
        }

        public void RunHideSales()
        {

            ddl_Salesmen.Visible = false;
            gbo_Sales.Visible = false;

        }

        public void RunHideCar()
        {

            gboPopular.Visible = false;
            gboPopular.Location = new Point(-100, 130);
            gboLeastPopular.Visible = false;
            gboLeastPopular.Location = new Point(-100, 247);
            btnDownloadCar.Visible = false;
            btnDownloadCar.Location = new Point(26, 398);

        }

        public void RunHideInvoice()
        {

            gbInvoiceStats.Visible = false;
            gbInvoiceStats.Location = new Point(810, 117);
            btnDownloadInvoiceStats.Visible = false;

        }

        private void btnCarStats_Click(object sender, EventArgs e)
        {
            
            if(gboPopular.Visible == false)
            {

                RunHideInvoice();
                RunHideSales();
                lblAlert.Visible = false;

                clsDatabse_Stats objDatabse_Stats = new clsDatabse_Stats();
                Popular = objDatabse_Stats.MostPopularCar();
                LeastPopular = objDatabse_Stats.LeastPopularCar();
                clsValidation clsValidate = new clsValidation();

                lblModelName.Text = Convert.ToString(Popular[0].sModelName);
                lblModelCount.Text = Convert.ToString(Popular[0].iModelCount);
                lblModelSum.Text = clsValidate.FormatCurrencyForDisplay(Popular[0].dModelSum.ToString());

                lblModelNameLeast.Text = Convert.ToString(LeastPopular[0].sModelName);
                lblModelCountLeast.Text = Convert.ToString(LeastPopular[0].iModelCount);
                lblModelSumLeast.Text = clsValidate.FormatCurrencyForDisplay(LeastPopular[0].dModelSum.ToString());

                gboPopular.Visible = true;
                gboPopular.Location = new Point(398, 137);
                gboLeastPopular.Visible = true;
                gboLeastPopular.Location = new Point(398, 254);
                btnDownloadCar.Visible = true;
                btnDownloadCar.Location = new Point(398, 405);

            }
            else
            {

                RunHideCar();

            }

        }

        private void btnDownloadCar_Click(object sender, EventArgs e)
        {

            clsValidation clsValidate = new clsValidation();

            StreamWriter File = new StreamWriter("StatsFile.txt");

            File.Write("Dealership Stats\r\n\r\n");
            File.Write("Most Popular Vehicle\r\n\r\n");
            File.Write("The Most Popular Model is: " + Convert.ToString(Popular[0].sModelName) + "\r\n");
            File.Write("There Have Been " + Convert.ToString(Popular[0].iModelCount) + " of this Model sold.\r\n");
            File.Write("The Sum Total of Sales for this Model is: " + clsValidate.FormatCurrencyForDisplay(Popular[0].dModelSum.ToString()) + "\r\n\r\n");
            File.Write("Least Popular Vehicle\r\n\r\n");
            File.Write("The Least Popular Model is: " + Convert.ToString(LeastPopular[0].sModelName) + "\r\n");
            File.Write("There Have Been " + Convert.ToString(LeastPopular[0].iModelCount) + "of this Model Sold.\r\n");
            File.Write("The Sum Total of Sales for this Model is: " + clsValidate.FormatCurrencyForDisplay(LeastPopular[0].dModelSum.ToString()) + "\r\n");
            File.Close();

            lblAlert.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frm_Menu = new frmMenu();
            frm_Menu.Show();
            this.Close();
        }

        private void btnInvoiceStats_Click(object sender, EventArgs e)
        {
            
            if (gbInvoiceStats.Visible == false)
            {

                RunHideCar();
                RunHideSales();
                lblAlert.Visible = false;

                clsDatabse_Stats objDatabse_Stats = new clsDatabse_Stats();

                decimal dIncomPrice = objDatabse_Stats.TotalIncompletePrice();
                decimal dCompletePrice = objDatabse_Stats.TotalCompletePrice();
                decimal dTotalPrice = dIncomPrice + dCompletePrice;
                int iTotalIncomInvoice = objDatabse_Stats.TotalIncompleteInvocies();
                int iTotalCompleteInvoice = objDatabse_Stats.TotalCompleteInvocies();
                int iTotalInvoices = iTotalCompleteInvoice + iTotalIncomInvoice;

                clsValidation objValidate = new clsValidation();

                lblComplete.Text = "There are " + iTotalCompleteInvoice.ToString() + " completed invoices in the database";
                lblIncomplete.Text = "There are " + iTotalIncomInvoice.ToString() + " incompleted invoices in the database";
                lblTotalAmount.Text = "In total there are " + iTotalInvoices.ToString() + " invoices in the database";

                lblTotalIncompletePrice.Text = "The incomplete invoices total to " + objValidate.FormatCurrencyForDisplay(dIncomPrice.ToString());
                lblTotalCompletePrice.Text = "The complete invoices total to " + objValidate.FormatCurrencyForDisplay(dCompletePrice.ToString());
                lblTotalPrice.Text = "In total there are " + objValidate.FormatCurrencyForDisplay(dTotalPrice.ToString()) + " worth of invoices";

                gbInvoiceStats.Visible = true;
                gbInvoiceStats.Location = new Point(398, 117);
                btnDownloadInvoiceStats.Visible = true;

            }
            else
            {

                RunHideInvoice();

            }
            
            
        }

        private void btnDownloadInvoiceStats_Click(object sender, EventArgs e)
        {
            clsValidation objValidate = new clsValidation();
            clsDatabse_Stats objDatabse_Stats = new clsDatabse_Stats();

            int iTotalIncomInvoice = objDatabse_Stats.TotalIncompleteInvocies();
            int iTotalCompleteInvoice = objDatabse_Stats.TotalCompleteInvocies();
            int iTotalInvoices = iTotalCompleteInvoice + iTotalIncomInvoice;
            decimal dIncomPrice = objDatabse_Stats.TotalIncompletePrice();
            decimal dCompletePrice = objDatabse_Stats.TotalCompletePrice();
            decimal dTotalPrice = dIncomPrice + dCompletePrice;

            StreamWriter File = new StreamWriter("InvoiceStatsFile.txt");

            File.Write("Invoice Stats\r\n\r\n");
            File.Write("There are " + iTotalCompleteInvoice + " completed invoices in the database" + "\r\n");
            File.Write("There are " + iTotalIncomInvoice + " incomplet invoices in the database.\r\n");
            File.Write("In total there are " + iTotalInvoices + " invoices in the database\r\n\r\n");
            File.Write("The incomplete invoices total to " + objValidate.FormatCurrencyForDisplay(dIncomPrice.ToString()) + "\r\n");
            File.Write("The complete invoices total to " + objValidate.FormatCurrencyForDisplay(dCompletePrice.ToString())+ "\r\n");
            File.Write("In total there are " + objValidate.FormatCurrencyForDisplay(dTotalPrice.ToString()) + " worth of invoices\r\n");
            File.Close();

            lblAlert.Visible = true;
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {

            if (ddl_Salesmen.Visible == false)
            {

                gboLeastPopular.Visible = false;
                gboPopular.Visible = false;
                btnDownloadCar.Visible = false;
                lblAlert.Visible = false;
                gbInvoiceStats.Visible = false;
                lblAlert.Visible = false;
                btnDownloadInvoiceStats.Visible = false;

                ddl_Salesmen.Visible = true;
                ddl_Salesmen.Items.Clear();

                clsDatabase_Users clsUers = new clsDatabase_Users();

                //--------------------------------Section-----------------------------------------------------

                //Populates salesmen dropbox by pulling down an array from class database

                string[,] sUsers = clsUers.GetUsers(1);

                for (int iCount = 0; iCount < sUsers.GetLength(0); iCount++)
                {

                    ddl_Salesmen.Items.Add(sUsers[iCount, 1] + " " + sUsers[iCount, 0] + " : " + sUsers[iCount, 2]);
                    ddl_SID.Items.Add(sUsers[iCount, 4]);

                }

                //--------------------------------End Section-----------------------------------------------

            }
            else
            {

                RunHideSales();

            }

        }

        private void ddl_Salesmen_SelectedIndexChanged(object sender, EventArgs e)
        {

            gbo_Sales.Visible = true;
            lblAlert.Visible = false;
            ddl_SID.SelectedIndex = ddl_Salesmen.SelectedIndex;
            clsDatabse_Stats clsStats = new clsDatabse_Stats();
            clsValidation clsValidate = new clsValidation();

            //--------------------------------Section-----------------------------------------------------

            //Populates fields based on user selection

            lbl_SalesIncomplete.Text = clsStats.GetIncompleteInvoices(int.Parse(ddl_SID.Text)).ToString();
            lbl_SalesCompleted.Text = clsStats.GetCompleteInvoices(int.Parse(ddl_SID.Text)).ToString();
            lbl_SalesTotal.Text = clsValidate.FormatCurrencyForDisplay(clsStats.GetTotalInvoices(int.Parse(ddl_SID.Text)).ToString());

            //--------------------------------End Section-----------------------------------------------

        }

        private void btn_DownloadSales_Click(object sender, EventArgs e)
        {

            clsDatabase_Users clsUser = new clsDatabase_Users();
            string[] sUser = clsUser.GetUserDetails(int.Parse(ddl_SID.Text), 1);

            StreamWriter File = new StreamWriter(sUser[0] + "_" + sUser[1] + "_Sales_States.txt");

            File.Write(sUser[0] + " " + sUser[1] + "Sales Stats\r\n\r\n");
            File.Write("They have " + lbl_SalesIncomplete.Text + " incompleted invoice(s) that still require review." + "\r\n");
            File.Write("They have successfully completed " + lbl_SalesCompleted + " invoices.\r\n");
            File.Write("They have currently sold " + lbl_SalesTotal.Text + " worth of invoices.\r\n\r\n");
            File.Close();

            lblAlert.Visible = true;

        }
    }
}
