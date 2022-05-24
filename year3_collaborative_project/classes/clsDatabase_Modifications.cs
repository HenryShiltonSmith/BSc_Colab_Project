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
    class clsDatabase_Modifications
    {

        public void AddColour(string sName, decimal dPrice, List<int> ilModIDs)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("insert_colour", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", sName);
            com.Parameters.AddWithValue("@Price", dPrice);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            AddColourCarsToList(ilModIDs, sName);
        }

        public void AddMod(string sModName, decimal dPrice, List<int> ilModIDs)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("insert_modification", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Price", dPrice);
            com.Parameters.AddWithValue("@ModName", sModName);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }
            AddCarModToList(ilModIDs, sModName);
        }

        public int GetModID(string sName)
        {

            clsDatabase clsData = new clsDatabase();

            int iModID = 0;
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_mod_id", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", sName);

            try
            {
                cnn.Open();
                iModID = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return iModID;
        }

        public DataTable GetMods()
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //string sCommand = "SELECT `modName` FROM `tblModifications`";

            MySqlCommand com = new MySqlCommand("get_mods", cnn);
            //MySqlCommand com = new MySqlCommand(sCommand, cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();
                adapter.SelectCommand = com;

                adapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public DataTable GetInactiveMods()
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //string sCommand = "SELECT `modName` FROM `tblModifications`";

            //MySqlCommand com = new MySqlCommand("get_mods", cnn);
            //MySqlCommand com = new MySqlCommand(sCommand, cnn);
            MySqlCommand com = new MySqlCommand("get_inactive_mods", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();
                adapter.SelectCommand = com;

                adapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public int GetColourID(string sName)
        {

            clsDatabase clsData = new clsDatabase();

            int iColourID = 0;
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_colour_ID", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", sName);

            try
            {
                cnn.Open();
                iColourID = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return iColourID;
        }

        public void AddColourCarsToList(List<int> ilModIDs, string sName)
        {

            clsDatabase clsData = new clsDatabase();

            int iCount = 0;
            int iColourID = GetColourID(sName);
            MySqlConnection cnn = clsData.GetConnection();

            while (iCount < ilModIDs.Count())
            {
                MySqlCommand com = new MySqlCommand("insert_car_colour", cnn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ModelID", ilModIDs[iCount]);
                com.Parameters.AddWithValue("@ColourID", iColourID);
                try
                {
                    cnn.Open();
                    com.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex)
                {

                }
                iCount++;
            }
        }

        public void AddCarModToList(List<int> ilModIDs, string sName)
        {

            clsDatabase clsData = new clsDatabase();

            int iCount = 0;
            int iModID = GetModID(sName);
            MySqlConnection cnn = clsData.GetConnection();

            while (iCount < ilModIDs.Count())
            {
                MySqlCommand com = new MySqlCommand("insert_car_mods", cnn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ModelID", ilModIDs[iCount]);
                com.Parameters.AddWithValue("@ModID", iModID);
                try
                {
                    cnn.Open();
                    com.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex)
                {

                }
                iCount++;
            }
        }

        public void ActivateMod(string sSelectedName)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("activate_mod", cnn);
            com.Parameters.AddWithValue("@name", sSelectedName);

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

        public void DeactivateMod(string sSelectedName)
        {
            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("deactivate_modification", cnn);
            com.Parameters.AddWithValue("@name", sSelectedName);

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

        public decimal GetColourPrice(int iColourID)
        {

            clsDatabase clsData = new clsDatabase();

            decimal dPrice = 0;

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_colour_price", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ColourID", iColourID);
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

        public string GetModNamePrice(int iModID)
        {

            clsDatabase clsData = new clsDatabase();

            clsValidation objValidation = new clsValidation();
            DataTable dt = new DataTable();

            List<string> slMods = new List<string>();
            string sReturn = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_mod_name_price", cnn);
            com.Parameters.AddWithValue("@modID", iModID);

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

            sReturn = dt.Rows[0][0] + " " + objValidation.FormatCurrencyForDisplay(dt.Rows[0][1].ToString());

            return sReturn;
        }

        public void UpdateMod(string sSelectedName, string sName, decimal dPrice)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("update_modifications", cnn);
            com.Parameters.AddWithValue("@name", sName);
            com.Parameters.AddWithValue("@price", dPrice);
            com.Parameters.AddWithValue("@selectedName", sSelectedName);

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
        public DataTable GetActiveMods()
        {
            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("get_active_mods", cnn);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                adapter.SelectCommand = com;

                adapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
    }
}
