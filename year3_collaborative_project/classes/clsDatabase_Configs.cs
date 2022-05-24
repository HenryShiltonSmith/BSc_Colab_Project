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
    class clsDatabase_Configs
    {

        public List<clsCustomerConfig> ListCarColours(clsCarModel selectedModel)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            List<clsCustomerConfig> carColours = new List<clsCustomerConfig>();

            MySqlCommand myCommand = new MySqlCommand("GetAvailableColours", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@ID", selectedModel.iModelId);

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsCustomerConfig colour = new clsCustomerConfig();
                    colour.iColourId = reader.GetInt32(0);
                    colour.sColourName = reader.GetString(1);
                    colour.dColourPrice = reader.GetDecimal(2);
                    carColours.Add(colour);
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return carColours;

        }

        public List<clsCustomerConfig> ListCarModifications(clsCarModel selectedModel)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            List<clsCustomerConfig> carMods = new List<clsCustomerConfig>();

            MySqlCommand myCommand = new MySqlCommand("GetAvailableModifications", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@ID", selectedModel.iModelId);

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsCustomerConfig mods = new clsCustomerConfig();
                    mods.iModID = reader.GetInt32(0);
                    mods.sModName = reader.GetString(1);
                    mods.dModPrice = reader.GetDecimal(2);
                    carMods.Add(mods);
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return carMods;
        }

        public int GetAPRPercent(int iAprID)
        {

            clsDatabase clsData = new clsDatabase();

            int iAPRPercent = 0;
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_APR_percent", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@APRID", iAprID);
            try
            {
                cnn.Open();
                iAPRPercent = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex) { }

            return iAPRPercent;
        }

        public List<clsAPR> ListAPR()
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            List<clsAPR> APR = new List<clsAPR>();

            MySqlCommand myCommand = new MySqlCommand("GetAPR", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsAPR aprs = new clsAPR();
                    aprs.iAprId = reader.GetInt32(0);
                    aprs.iAprLength = reader.GetInt32(1);
                    aprs.iAprPercent = reader.GetInt32(2);

                    APR.Add(aprs);
                }

                cnn.Close();
            }
            catch (Exception ex)
            {

            }
            return APR;
        }

        public void SaveConfiguration(int iCustID, int iModelID, int iMakeID, int iAprID, int iColourID, string sModsID, string sModsPrice, decimal dTotalPrice)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("SaveCustomerConfig", cnn);
            com.Parameters.AddWithValue("@custID", iCustID);
            com.Parameters.AddWithValue("@MODELID", iModelID);
            com.Parameters.AddWithValue("@MAKEID", iMakeID);
            com.Parameters.AddWithValue("@APRID", iAprID);
            com.Parameters.AddWithValue("@COLOURID", iColourID);
            com.Parameters.AddWithValue("@MODSID", sModsID);
            com.Parameters.AddWithValue("@MODSPRICE", sModsPrice);
            com.Parameters.AddWithValue("@TOTALPRICE", dTotalPrice);

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

        public DataTable PopulateConfigListApprove()
        {

            clsDatabase clsData = new clsDatabase();
            DataTable dt = new DataTable();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_config_name_make_model_approve", cnn);
            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
                dataAdapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public DataTable PopulateConfigListDelete()
        {

            clsDatabase clsData = new clsDatabase();
            DataTable dt = new DataTable();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_config_name_make_model_delete", cnn);
            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
                dataAdapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
        public DataTable PopulateConfigListSignOff()
        {
            clsDatabase clsData = new clsDatabase();
            clsDatabase_Users objDatabase_Users = new clsDatabase_Users();
            DataTable dt = new DataTable();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_config_name_make_model_sign_off", cnn);
            com.Parameters.AddWithValue("@ID", objDatabase_Users.GetAdminID(clsUser.IUserID));
            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
                dataAdapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return dt;
        }
        public List<string> GetConfigInfo(int iConfigID)
        {

            clsDatabase clsData = new clsDatabase();
            DataTable dt = new DataTable();

            List<string> slConfig = new List<string>();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_config_info", cnn);
            com.Parameters.AddWithValue("@configID", iConfigID);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
                dataAdapter.Fill(dt);

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            foreach (DataRow dr in dt.Rows)
            {
                slConfig.Add(dr[0].ToString());
            }

            return slConfig;
        }

        public string GetConfigMods(int iConfigID)
        {

            clsDatabase clsData = new clsDatabase();
            string sConfigMods = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_mod_from_config", cnn);
            com.Parameters.AddWithValue("@configID", iConfigID);

            com.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                sConfigMods = com.ExecuteScalar().ToString();

                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sConfigMods;
        }

        public void SubmitConfiguration(int iCustID, int iModelID, int iMakeID, int iAprID, int iColourID, string sModsID, string sModsPrice, decimal dTotalPrice, int iSubmit)
        {

            clsDatabase clsData = new clsDatabase();
            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("SubmitCustomerConfig", cnn);
            com.Parameters.AddWithValue("@custID", iCustID);
            com.Parameters.AddWithValue("@MODELID", iModelID);
            com.Parameters.AddWithValue("@MAKEID", iMakeID);
            com.Parameters.AddWithValue("@APRID", iAprID);
            com.Parameters.AddWithValue("@COLOURID", iColourID);
            com.Parameters.AddWithValue("@MODSID", sModsID);
            com.Parameters.AddWithValue("@MODSPRICE", sModsPrice);
            com.Parameters.AddWithValue("@TOTALPRICE", dTotalPrice);
            com.Parameters.AddWithValue("@SUBMIT", iSubmit);
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

        public void DeleteConfig(int iConfigID)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("delete_config", cnn);
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

        public DataTable GetSelectedMod(string sName)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("get_selected_mod", cnn);
            com.Parameters.AddWithValue("@name", sName);

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

        public string[,] GetUserConfigs(int iID)
        {

            clsDatabase clsData = new clsDatabase();
            int iConfigCount = 0;
            int iCount = 0;

            //--------------------------------Section-----------------------------------------------------

            //Works out the number of configs saved per customer

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand com = new MySqlCommand("Get_Count_Configs_By_Customer", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CID", iID);

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                iConfigCount = reader.GetInt32(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Get users basic information

            string[,] sConfig = new string[iConfigCount, 3];

            com = new MySqlCommand("Get_Config_Identifiers", cnn);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CID", iID);

            iCount = 0;

            try
            {

                cnn.Open();

                using (MySqlDataReader reader = com.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        sConfig[iCount, 0] = reader.GetValue(0).ToString();
                        sConfig[iCount, 1] = reader.GetValue(1).ToString();
                        sConfig[iCount, 2] = reader.GetValue(2).ToString();

                        iCount = iCount + 1;

                    }

                }

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return sConfig;

            //--------------------------------End Section-----------------------------------------------

        }

        public string GetColourName(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            string sColour = "";
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_Colour_Name", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {
                cnn.Open();
                sColour = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sColour;

        }

        public string[] GetBasicConfigDetails(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sConfig = new string[6];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section---------------------------------------------------- -

            //Retrieves information IDs from Config table for selected config

            MySqlCommand com = new MySqlCommand("Get_Config_IDs", cnn);
            com.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();

                com.Parameters.AddWithValue("@ConID", iID);
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sConfig.Length; iCount++)
            {

                sConfig[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sConfig;

            //--------------------------------End Section---------------------------------------------- -

        }

        public string GetMakeName(int iID)
        {

            clsDatabase clsData = new clsDatabase();
            string sMakeName = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_Make_Name", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {
                cnn.Open();
                sMakeName = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sMakeName;

        }

        public string GetModelName(int iID)
        {

            clsDatabase clsData = new clsDatabase();
            string sModelName = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_Model_Name", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {
                cnn.Open();
                sModelName = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sModelName;

        }

        public string[] GetMod(int iID)
        {

            clsDatabase clsData = new clsDatabase();
            string[] sMod = new string[2];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section---------------------------------------------------- -

            //Retrieves information IDs from Config table for selected config

            MySqlCommand com = new MySqlCommand("Get_Mod", cnn);
            com.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();

                com.Parameters.AddWithValue("@iID", iID);
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sMod.Length; iCount++)
            {

                sMod[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sMod;

            //--------------------------------End Section---------------------------------------------- -

        }

        public string GetAPRLength(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section---------------------------------------------------- -

            //Retrieves APR details for selected config

            string sAPR = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_APR_Length", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@iID", iID);

            try
            {
                cnn.Open();
                sAPR = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sAPR;

            //--------------------------------End Section---------------------------------------------- -

        }

        public void UpdateConfig(int iAprID, int iColourID, string sModsID, string sModsPrice, decimal dTotalPrice, int iSubmit, int iConfigID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section---------------------------------------------------- -

            //Updates config

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand com = new MySqlCommand("Update_Config", cnn);
            com.Parameters.AddWithValue("@APR_ID", iAprID);
            com.Parameters.AddWithValue("@ColID", iColourID);
            com.Parameters.AddWithValue("@ModIDs", sModsID);
            com.Parameters.AddWithValue("@ModPrices", sModsPrice);
            com.Parameters.AddWithValue("@Total", dTotalPrice);
            com.Parameters.AddWithValue("@Sub", iSubmit);
            com.Parameters.AddWithValue("@ConID", iConfigID);

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

            //--------------------------------End Section---------------------------------------------- -

        }

    }
}
