using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace year3_collaborative_project.classes
{
    class clsDatabse_Stats
    {
        public List<clsStatistics> MostPopularCar()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();

            List<clsStatistics> stats = new List<clsStatistics>();

            MySqlCommand myCommand = new MySqlCommand("FindMostPopularCar", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsStatistics stat = new clsStatistics();
                    stat.sModelName = reader.GetString(2);
                    stat.iModelCount = reader.GetInt32(3);
                    stat.dModelSum = reader.GetDecimal(4);

                    stats.Add(stat);

                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return stats;
        }

        public List<clsStatistics> LeastPopularCar()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();

            List<clsStatistics> least = new List<clsStatistics>();

            MySqlCommand myCommand = new MySqlCommand("FindLeastPopularCar", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsStatistics stat = new clsStatistics();
                    stat.sModelName = reader.GetString(2);
                    stat.iModelCount = reader.GetInt32(3);
                    stat.dModelSum = reader.GetDecimal(4);

                    least.Add(stat);

                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return least;
        }

        public decimal TotalIncompletePrice()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();
            decimal dPrice = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("total_incomplete_price", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                dPrice = Convert.ToDecimal(com.ExecuteScalar());

                cnn.Close();
            }
            catch (Exception ex)
            {
            }
            return dPrice;
        }

        public decimal TotalCompletePrice()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();
            decimal dPrice = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("total_complete_price", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                dPrice = Convert.ToDecimal(com.ExecuteScalar());

                cnn.Close();
            }
            catch (Exception ex)
            {
            }

            return dPrice;
        }

        public int TotalIncompleteInvocies()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();
            int TotalInvoices = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("total_incomplete_invoice", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                TotalInvoices = Convert.ToInt32(com.ExecuteScalar());

                cnn.Close();
            }
            catch (Exception ex)
            {
            }

            return TotalInvoices;
        }

        public int TotalCompleteInvocies()
        {
            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();
            int TotalInvoices = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("total_complete_invoice", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                TotalInvoices = Convert.ToInt32(com.ExecuteScalar());

                cnn.Close();
            }
            catch (Exception ex)
            {
            }

            return TotalInvoices;
        }

        public int GetIncompleteInvoices(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            int iInvoiceCount = 0;

            //--------------------------------Section-----------------------------------------------------

            //Works out the number of incomplete invoice by rep Id

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand com = new MySqlCommand("Count_Incomplete_Invoice_By_Rep", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                iInvoiceCount = reader.GetInt32(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return iInvoiceCount;

            //--------------------------------End Section-----------------------------------------------

        }

        public int GetCompleteInvoices(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            int iInvoiceCount = 0;

            //--------------------------------Section-----------------------------------------------------

            //Works out the number of complete invoice by rep Id

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand com = new MySqlCommand("Count_Complete_Invoice_By_Rep", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                iInvoiceCount = reader.GetInt32(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return iInvoiceCount;

            //--------------------------------End Section-----------------------------------------------

        }

        public decimal GetTotalInvoices(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            decimal dInvoicesTotal = 0;

            //--------------------------------Section-----------------------------------------------------

            //Works out the total value of invoices by rep Id

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand com = new MySqlCommand("Sum_Complete_Invoice_By_Rep", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                dInvoicesTotal = reader.GetDecimal(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return dInvoicesTotal;

            //--------------------------------End Section-----------------------------------------------

        }

    }
}
