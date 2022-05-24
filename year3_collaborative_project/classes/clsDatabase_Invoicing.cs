using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using year3_collaborative_project.classes;

namespace year3_collaborative_project.classes
{
    class clsDatabase_Invoicing
    {

        public void AddInvoice(int iCustID, int iModelID, int iAprID, int iColourID, string sModsID, string sModsPrice, decimal dTotalPrice)
        {

            clsDatabase clsData = new clsDatabase();
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            int iMakeID = clsVehicles.GetMakeID(iModelID);

            MySqlCommand com = new MySqlCommand("add_invoice", cnn);
            com.Parameters.AddWithValue("@custID", iCustID);
            com.Parameters.AddWithValue("@makeID", iMakeID);
            com.Parameters.AddWithValue("@modelID", iModelID);
            com.Parameters.AddWithValue("@aprID", iAprID);
            com.Parameters.AddWithValue("@iColourID", iColourID);
            com.Parameters.AddWithValue("@modsID", sModsID);
            com.Parameters.AddWithValue("@modsPrice", sModsPrice);
            com.Parameters.AddWithValue("@totalPrice", dTotalPrice);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                com.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public List<string> GetDiscountPercentages()
        {

            clsDatabase clsData = new clsDatabase();

            List<string> slDiscounts = new List<string>();
            DataTable dt = new DataTable();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_discount_percentages", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
                dataAdapter.SelectCommand = com;

                dataAdapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            foreach (DataRow dr in dt.Rows)
            {
                slDiscounts.Add(dr[0].ToString());
            }

            return slDiscounts;
        }

        public int GetDiscountID(int iPercent)
        {

            int iDiscountID = 0;
            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_discount_id_with_percent", cnn);
            com.Parameters.AddWithValue("@percent", iPercent);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                iDiscountID = Convert.ToInt32(com.ExecuteScalar());

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return iDiscountID;
        }

        public void AcceptInvoice(int iDiscountID, int iAdminID, int iConfigID, decimal dTotalPrice)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("update_invoice_acceptence", cnn);
            com.Parameters.AddWithValue("@discountID", iDiscountID);
            com.Parameters.AddWithValue("@adminID", iAdminID);
            com.Parameters.AddWithValue("@configID", iConfigID);
            com.Parameters.AddWithValue("@totalPrice", dTotalPrice);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                com.ExecuteScalar();

                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void SignOffInvoice(int iConfigID)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("update_invoice_sign_off", cnn);
            com.Parameters.AddWithValue("@ID", clsUser.IUserID);
            com.Parameters.AddWithValue("@configID", iConfigID);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                com.ExecuteScalar();

                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
