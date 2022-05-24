using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("UnitTestProject1")]

namespace year3_collaborative_project.classes
{
    class clsDatabase_Users
    {

        public string GetUsername(string sUsername)
        {

            clsDatabase clsData = new clsDatabase();

            string sReturn = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_username", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", sUsername);

            try
            {
                cnn.Open();
                object objUserName = com.ExecuteScalar();

                if (objUserName != null)
                {
                    sReturn = objUserName.ToString();
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
            }
            return sReturn;

        }

        public string GetPassword(string sUsername)
        {

            clsDatabase clsData = new clsDatabase();

            string sReturn = "";
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_password", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", sUsername);
            try
            {
                cnn.Open();
                sReturn = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sReturn;
        }

        public int GetAccessLevel(string sUsername)
        {

            clsDatabase clsData = new clsDatabase();

            string sReturn = "";
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_access_level", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", sUsername);

            com.Connection = cnn;

            try
            {
                cnn.Open();
                sReturn = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return Convert.ToInt32(sReturn);
        }

        public int GetUserID(string sUsername)
        {

            clsDatabase clsData = new clsDatabase();

            string sReturn = "";
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_user_id", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", sUsername);

            com.Connection = cnn;

            try
            {
                cnn.Open();
                sReturn = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return Convert.ToInt32(sReturn);
        }

        public void AddUser(List<string> lUserDetails)
        {

            //--------------------------------Section-----------------------------------------------------

            //Add User details to database

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Add_User_Login", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", lUserDetails[0]);
            com.Parameters.AddWithValue("@Pass", lUserDetails[1]);
            com.Parameters.AddWithValue("@AccLvl", lUserDetails[2]);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public string GetUserID_String(string sUName)
        {

            //--------------------------------Section-----------------------------------------------------

            //Retrieve user ID

            clsDatabase clsData = new clsDatabase();


            string sID = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("get_user_id", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", sUName);

            try
            {
                cnn.Open();
                sID = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sID;

            //--------------------------------End Section-----------------------------------------------

        }

        public string GetCutomerID(string sID)
        {

            //--------------------------------Section-----------------------------------------------------

            //Retrieve user ID

            clsDatabase clsData = new clsDatabase();


            string sCID = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_Customer_ID", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID", sID);

            try
            {
                cnn.Open();

                com.ExecuteNonQuery();
                sCID = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sCID;

            //--------------------------------End Section-----------------------------------------------

        }

        public int GetAdminID(int iLoginID)
        {

            //--------------------------------Section-----------------------------------------------------

            //Retrieve admin ID

            clsDatabase objDatabase = new clsDatabase();

            int iAdminID = 0;

            MySqlConnection cnn = objDatabase.GetConnection();
            MySqlCommand com = new MySqlCommand("get_admin_id", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@userID", iLoginID);

            try
            {
                cnn.Open();
                iAdminID = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return iAdminID;

            //--------------------------------End Section-----------------------------------------------

        }

        public void AddUserDetails(List<string> lUserDetails, string sID, int iCount)
        {

            //--------------------------------Section-----------------------------------------------------

            //Add User details to database

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Add_Staff_Details", cnn);

            if (iCount == 1)
            {

                com = new MySqlCommand("Add_Customer_Details", cnn);


            }

            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FName", lUserDetails[3]);
            com.Parameters.AddWithValue("@LName", lUserDetails[4]);
            com.Parameters.AddWithValue("@Email", lUserDetails[5]);
            com.Parameters.AddWithValue("@Phone", lUserDetails[6]);
            com.Parameters.AddWithValue("@UID", sID);

            if (iCount == 1)
            {

                com.Parameters.AddWithValue("@DoB", lUserDetails[7]);


            }

            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void AddAddress(List<string> lUserDetails, string sCID)
        {

            //--------------------------------Section-----------------------------------------------------

            //Add address details to database

            clsDatabase clsData = new clsDatabase();

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Add_Address_Details", cnn);

            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@HouseNo", lUserDetails[8]);
            com.Parameters.AddWithValue("@Road", lUserDetails[9]);
            com.Parameters.AddWithValue("@Town", lUserDetails[10]);
            com.Parameters.AddWithValue("@Post", lUserDetails[11]);
            com.Parameters.AddWithValue("@CID", sCID);

            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------
        }

        public string[,] GetUsers(int iType)
        {

            clsDatabase clsData = new clsDatabase();

            int iUserCount = 0;
            int iCount = 0;

            //--------------------------------Section-----------------------------------------------------

            //Works out the number of users by access level

            MySqlConnection cnn = clsData.GetConnection();

            MySqlCommand com = new MySqlCommand("Get_User_Count_By_Level", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AccLvl", iType);

            try
            {

                cnn.Open();

                MySqlDataReader reader = com.ExecuteReader();
                reader.Read();
                iUserCount = reader.GetInt32(0);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            //--------------------------------End Section-----------------------------------------------

            //--------------------------------Section-----------------------------------------------------

            //Get users basic information

            if (iType == 0)
            {

                iCount = 6;

            }
            else
            {

                iCount = 5;

            }

            string[,] sUsers = new string[iUserCount, iCount];

            com = new MySqlCommand("Get_Staff_Basic", cnn);

            if (iType == 0)
            {

                com = new MySqlCommand("Get_Customer_Basic", cnn);

            }

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AccLvl", iType);

            iCount = 0;

            try
            {

                cnn.Open();

                using (MySqlDataReader reader = com.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        sUsers[iCount, 0] = reader.GetValue(0).ToString();
                        sUsers[iCount, 1] = reader.GetValue(1).ToString();
                        sUsers[iCount, 2] = reader.GetValue(2).ToString();
                        sUsers[iCount, 3] = reader.GetValue(3).ToString();
                        sUsers[iCount, 4] = reader.GetValue(4).ToString();

                        if (iType == 0)
                        {

                            sUsers[iCount, 5] = reader.GetValue(5).ToString();

                        }

                        iCount = iCount + 1;

                    }

                }

                cnn.Close();

            }
            catch (Exception ex)
            { }

            return sUsers;

            //--------------------------------End Section-----------------------------------------------

        }

        public string[] GetLoginDetails(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sLogin = new string[2];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves all details relating to selected user login and returns as an array for easy processing

            MySqlCommand com = new MySqlCommand("Get_Login_Details", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LogID", iID);

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sLogin.Length; iCount++)
            {

                sLogin[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sLogin;

            //--------------------------------End Section-----------------------------------------------

        }

        public string[] GetUserDetails(int iID, int iType)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sUser = new string[4];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves all details relating to selected user and returns as an array for easy processing

            MySqlCommand com = new MySqlCommand("Get_Staff_Details", cnn);

            if (iType == 0)
            {

                com = new MySqlCommand("Get_Customer_Details", cnn);

            }

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UID", iID);

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sUser.Length; iCount++)
            {

                sUser[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sUser;

            //--------------------------------End Section-----------------------------------------------

        }

        public string[] GetAddress(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            string[] sAddress = new string[4];
            int iCount = 0;

            MySqlConnection cnn = clsData.GetConnection();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves all details relating to selected user's address and returns as an array for easy processing

            MySqlCommand com = new MySqlCommand("Get_Address_Details", cnn);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UID", iID);

            DataTable dt = new DataTable();

            try
            {

                cnn.Open();
                com.Prepare();

                MySqlDataAdapter dAdapter = new MySqlDataAdapter(com);
                dAdapter.Fill(dt);

                cnn.Close();

            }
            catch (Exception ex)
            { }

            for (iCount = 0; iCount < sAddress.Length; iCount++)
            {

                sAddress[iCount] = dt.Rows[0][iCount].ToString();

            }

            return sAddress;

            //--------------------------------End Section-----------------------------------------------

        }

        public string GetDoB(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Retrieves address for selected user

            string sDoB = "";

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Get_DoB", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UID", iID);

            com.Connection = cnn;

            try
            {
                cnn.Open();
                sDoB = com.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return sDoB;

            //--------------------------------End Section-----------------------------------------------

        }

        public void UpdateLogin(List<string> lUserDetails, int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Updates login details to database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Update_Login", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UName", lUserDetails[0]);
            com.Parameters.AddWithValue("@Pass", lUserDetails[1]);
            com.Parameters.AddWithValue("@LID", iID);

            try
            {

                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void UpdateStaff(List<string> lUserDetails, int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Updates staff details to database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Update_Staff", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FName", lUserDetails[2]);
            com.Parameters.AddWithValue("@LName", lUserDetails[3]);
            com.Parameters.AddWithValue("@Email", lUserDetails[4]);
            com.Parameters.AddWithValue("@Phone", lUserDetails[5]);
            com.Parameters.AddWithValue("@UID", iID);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void UpdateCustomer(List<string> lUserDetails, int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Updates staff details to database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Update_Customer", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FName", lUserDetails[2]);
            com.Parameters.AddWithValue("@LName", lUserDetails[3]);
            com.Parameters.AddWithValue("@Email", lUserDetails[4]);
            com.Parameters.AddWithValue("@Phone", lUserDetails[5]);
            com.Parameters.AddWithValue("@DoB", lUserDetails[6]);
            com.Parameters.AddWithValue("@UID", iID);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void UpdateAddress(List<string> lUserDetails, int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Updates address details to database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Update_Address", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("HNo", lUserDetails[7]);
            com.Parameters.AddWithValue("RName", lUserDetails[8]);
            com.Parameters.AddWithValue("TName", lUserDetails[9]);
            com.Parameters.AddWithValue("PCode", lUserDetails[10]);
            com.Parameters.AddWithValue("@AID", iID);
            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void DeleteAddress(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Removes address details from database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Delete_Address", cnn);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AID", iID);

            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void DeleteUser(int iID, int iAccLvl)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Removes user's details from database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Delete_Staff", cnn);

            if (iAccLvl == 0)
            {

                com = new MySqlCommand("Delete_Customer", cnn);

            }

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UID", iID);

            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        public void DeleteLogin(int iID)
        {

            clsDatabase clsData = new clsDatabase();

            //--------------------------------Section-----------------------------------------------------

            //Removes login details from database

            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("Delete_Login", cnn);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LID", iID);

            try
            {
                cnn.Open();
                com.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            //--------------------------------End Section-----------------------------------------------

        }

        // Find the customerID based on current customer LoginID
        public int FindUserID(int iLoginID)
        {

            clsDatabase clsData = new clsDatabase();

            int iCustID = 0;
            MySqlConnection cnn = clsData.GetConnection();
            MySqlCommand com = new MySqlCommand("GetCustomerID", cnn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LOGINID", iLoginID);

            com.Connection = cnn;

            try
            {
                cnn.Open();
                iCustID = Convert.ToInt32(com.ExecuteScalar());
                cnn.Close();
            }
            catch (Exception ex)
            {

            }

            return iCustID;
        }


    }
}
