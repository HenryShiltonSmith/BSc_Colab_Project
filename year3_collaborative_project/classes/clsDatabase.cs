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
    class clsDatabase
    {
        private const string conString = "server=plesk.remote.ac;user=WS1318_colabprojectteam;database=WS1318_colabproject;password=V!j40g9y;CharSet=utf8;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection cnn = new MySqlConnection(conString);
            return cnn;

        }

        //public List<string> GetModificationCategories()
        //{
        //    var saModificationCategories = new List<string>();
        //    DataTable dt = new DataTable();

        //    MySqlConnection cnn = GetConnection();
        //    MySqlCommand com = new MySqlCommand("get_mod_categories", cnn);
        //    com.CommandType = CommandType.StoredProcedure;

        //    try
        //    {
        //        cnn.Open();

        //        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(com);
        //        dataAdapter.Fill(dt);

        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        saModificationCategories.Add(dr[0].ToString());
        //    }

        //    return saModificationCategories;
        //}



        //public int GetCatID(string sCatName)
        //{
        //    int iCatID = 0;
        //    MySqlConnection cnn = GetConnection();
        //    MySqlCommand com = new MySqlCommand("get_category_id", cnn);
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.AddWithValue("@ModName", sCatName);

        //    try
        //    {
        //        cnn.Open();
        //        iCatID = Convert.ToInt32(com.ExecuteScalar());
        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return iCatID;
        //}
        
    }
}
