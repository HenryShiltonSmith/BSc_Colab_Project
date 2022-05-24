using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace year3_collaborative_project.classes
{
    class clsDatabase_Vehicles
    {

        public DataTable GetModelMake()
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //string sCommand = "SELECT tblCarMake.carMakeName, tblCarModel.carModelName FROM tblCarMake INNER JOIN tblCarModel ON tblCarMake.carMakeID = tblCarModel.carMakeID";

            MySqlCommand com = new MySqlCommand("get_make_and_model_and_ID", cnn);
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

        // Gets list of car makes from database
        public List<clsCarMake> ListCarMakes()
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            List<clsCarMake> carMakes = new List<clsCarMake>();

            MySqlCommand myCommand = new MySqlCommand("GetCarMakes", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsCarMake make = new clsCarMake();
                    make.iMakeId = reader.GetInt32(0);
                    make.sMakeName = reader.GetString(1);

                    carMakes.Add(make);
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return carMakes;
        }

        // Gets a list of models for the selected car make
        public List<clsCarModel> ListCarModels(clsCarMake selectedMake)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            List<clsCarModel> carModels = new List<clsCarModel>();

            MySqlCommand myCommand = new MySqlCommand("GetModelName", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@ID", selectedMake.iMakeId);

            try
            {
                cnn.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    clsCarModel model = new clsCarModel();
                    model.iModelId = reader.GetInt32(0);
                    model.sModelName = reader.GetString(1);
                    model.dModelPrice = reader.GetDecimal(2);
                    carModels.Add(model);
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

            }

            return carModels;
        }

        public string[,] GetAllVehicles()
        {

            clsDatabase clsData = new clsDatabase();

            int iVehicleCount = 0;
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Works out the overall count of unique vehicles

            MySqlCommand com = new MySqlCommand("get_vehicle_count", cnn);
            com.CommandType = CommandType.StoredProcedure;

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                iVehicleCount = reader.GetInt32(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Pulls down the make, model and ID for all unique vehicles that are within the database and returns them as an arry for easy processing later

            string[,] sVehicles = new string[iVehicleCount, 3];

            com = new MySqlCommand("get_make_and_model_and_ID", cnn);
            com.CommandType = CommandType.StoredProcedure;

            try
            {

                cnn.Open();

                using (MySqlDataReader reader = com.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        sVehicles[iCount, 0] = reader.GetValue(2).ToString();
                        sVehicles[iCount, 1] = reader.GetValue(0).ToString();
                        sVehicles[iCount, 2] = reader.GetValue(1).ToString();
                        iCount = iCount + 1;

                    }

                }

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return sVehicles;

            //--------------------------------End Section-----------------------------------------------

        }

        public string[] GetVehicleDetails(string sSelected)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sVehicle = new string[9];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves all details relating to a single selected vehicle within the database and returns as an array for easy processing

            MySqlCommand com = new MySqlCommand("get_vehicle_details", cnn);
            com.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();

                com.Parameters.AddWithValue("@Selected", sSelected);
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sVehicle.Length; iCount++)
            {

                sVehicle[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sVehicle;

            //--------------------------------End Section-----------------------------------------------

        }

        public string[] GetVehicleName(string sID)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sVehicleName = new string[3];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves vehicle name - the make and model, based on a selected ID

            MySqlCommand com = new MySqlCommand("get_make_model_with_ID", cnn);
            com.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();

                com.Parameters.AddWithValue("@ID", sID);
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sVehicleName.Length; iCount++)
            {

                sVehicleName[iCount] = dt.Rows[0][iCount].ToString();
            }

            return sVehicleName;

            //--------------------------------End Section-----------------------------------------------

        }

        public int GetMakeID(int iModelID)
        {

            clsDatabase clsData = new clsDatabase();

            int iMakeID = 0;

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_make_id", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ModelID", iModelID);

            try
            {
                cnn.Open();
                iMakeID = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {
            }

            return iMakeID;
        }

        public decimal GetModelPrice(int iModelID)
        {

            clsDatabase clsData = new clsDatabase();

            decimal dPrice = 0;

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_model_price", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ModelID", iModelID);
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

        // Runs a check to see if Model already exists to avoid duplication
        public clsCarModel CheckExistingModel(string sModel)
        {
            int iNameCheck = 0;
            clsDatabase data = new clsDatabase();

            MySqlConnection cnn = data.GetConnection();

            MySqlCommand myComm = new MySqlCommand("CheckModelExists", cnn);
            myComm.CommandType = CommandType.StoredProcedure;
            clsCarModel model = new clsCarModel();
            try
            {
                cnn.Open();
                myComm.Parameters.AddWithValue("@MODELNAME", sModel);
                myComm.Prepare();
                iNameCheck = Convert.ToInt32(myComm.ExecuteScalar());
                if (iNameCheck != 0)
                {
                    MessageBox.Show("Model already exists");

                    return null;
                }
            }
            catch
            {

            }
            return model;
        }

        // Checks to see if Make already exists in database to avoid duplication, if make doesn't already exist it adds it to the database
                public clsCarMake InsertNewMake(string sNewMake)
        {
            int iNameCheck = 0;
            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand myComm = new MySqlCommand("CheckMakeExists", cnn);
            myComm.CommandType = CommandType.StoredProcedure;
            clsCarMake make = new clsCarMake();
            try
            {
                cnn.Open();
                myComm.Parameters.AddWithValue("@MAKENAME", sNewMake);
                myComm.Prepare();
                iNameCheck = Convert.ToInt32(myComm.ExecuteScalar());
                if (iNameCheck == 0)
                {

                    MySqlCommand myCommand = new MySqlCommand("InsertNewMake", cnn);
                    myCommand.CommandType = CommandType.StoredProcedure;

                   

                    try
                    {
                        

                        myCommand.Parameters.AddWithValue("@MAKE", sNewMake);
                        myCommand.Prepare();


                        make.iInsertMakeID = Convert.ToInt32(myCommand.ExecuteScalar());


                        cnn.Close();
                    }

                    catch
                    {
                        return null;
                    }

                   
                   
                }

                else
                {
                    MessageBox.Show("Make already exists");

                    return null;
                }
                
            }

            catch
            {

            }
            return make;
        }
            
    // Takes customer input and prepares for insertion into database
        public void InsertModel(int iMakeID, string sName, decimal dPrice, int iEngineSize, int iDoors, string sFuel, string sTransmission, int iMPG, string sDrive, double dCO2, int iYearBuilt)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand myCommand = new MySqlCommand("InsertNewModel", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                myCommand.Parameters.AddWithValue("@MAKEID", iMakeID);
                myCommand.Parameters.AddWithValue("@NAME", sName);
                myCommand.Parameters.AddWithValue("@PRICE", dPrice);
                myCommand.Parameters.AddWithValue("@ENGINESIZE", iEngineSize);
                myCommand.Parameters.AddWithValue("@DOORS", iDoors);
                myCommand.Parameters.AddWithValue("@FUEL", sFuel);
                myCommand.Parameters.AddWithValue("@TRANSMISSION", sTransmission);
                myCommand.Parameters.AddWithValue("@MPG", iMPG);
                myCommand.Parameters.AddWithValue("@DRIVE", sDrive);
                myCommand.Parameters.AddWithValue("@CO2", dCO2);
                myCommand.Parameters.AddWithValue("@YEARBUILT", iYearBuilt);
                myCommand.Prepare();


                myCommand.ExecuteScalar();



                cnn.Close();
            }

            catch
            {

            }

        }

        // Pulls the vehicle details of selected make and model and displays to user for edit
        public clsCarModel GetCarDetails(clsCarModel selectedModel)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand myCommand = new MySqlCommand("GetCarEditDetails", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;


            myCommand.Parameters.AddWithValue("@MODELID", selectedModel.iModelId);

            clsCarModel modelDetails = new clsCarModel();
            try
            {
                cnn.Open();



                MySqlDataReader reader = myCommand.ExecuteReader();


                while (reader.Read())
                {





                    modelDetails.iModelId = reader.GetInt32(0);
                    modelDetails.dModelPrice = reader.GetDecimal(1);
                    modelDetails.iEngineSize = reader.GetInt32(2);
                    modelDetails.iDoors = reader.GetInt32(3);
                    modelDetails.sFuel = reader.GetString(4);
                    modelDetails.sTransmission = reader.GetString(5);
                    modelDetails.iMPG = reader.GetInt32(6);
                    modelDetails.sDriveType = reader.GetString(7);
                    modelDetails.dEmissions = reader.GetDouble(8);
                    modelDetails.iYear = reader.GetInt32(9);


                }
                cnn.Close();
            }
            catch
            {

            }

            return modelDetails;

        }

        // Takes updates to car details and updates database record
        public void UpdateModel(int iModelID, decimal dPrice, int iEngineSize, int iDoors, string sFuel, string sTransmission, int iMPG, string sDrive, double dCO2, int iYearBuilt)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand myCommand = new MySqlCommand("UpdateModel", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                myCommand.Parameters.AddWithValue("@MODELID", iModelID);
                myCommand.Parameters.AddWithValue("@PRICE", dPrice);
                myCommand.Parameters.AddWithValue("@ENGINESIZE", iEngineSize);
                myCommand.Parameters.AddWithValue("@DOORS", iDoors);
                myCommand.Parameters.AddWithValue("@FUEL", sFuel);
                myCommand.Parameters.AddWithValue("@TRANSMISSION", sTransmission);
                myCommand.Parameters.AddWithValue("@MPG", iMPG);
                myCommand.Parameters.AddWithValue("@DRIVE", sDrive);
                myCommand.Parameters.AddWithValue("@CO2", dCO2);
                myCommand.Parameters.AddWithValue("@YEARBUILT", iYearBuilt);
                myCommand.Prepare();


                myCommand.ExecuteScalar();



                cnn.Close();
            }

            catch
            {

            }

        }

        //Deletes make and model from database
        public void DeleteModel(int iModelID)
        {

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand myCommand = new MySqlCommand("DeleteModel", cnn);
            myCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                cnn.Open();

                myCommand.Parameters.AddWithValue("@MODELID", iModelID);
                myCommand.Prepare();


                myCommand.ExecuteScalar();



                cnn.Close();
            }

            catch
            {

            }
        }

    }
}
