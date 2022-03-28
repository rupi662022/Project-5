using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using FINAL_PROJECT4.Models;
using System.Data;


namespace FINAL_PROJECT4.Models.DAL
{
    

    public class DataServices
    {
        //public int InsertGate(GatePass gatePass)
        //{

        //}


        //public int InsertUser(User user)
        //{
        //    SqlConnection con = null;

        //    try
        //    {
        //        con = Connect("FinalProject");
        //        SqlCommand command = CreateInsertUser(user, con);
        //        int affected = command.ExecuteNonQuery();
        //        //if (UsersList == null)
        //        //    UsersList = new List<User>();
        //        //UsersList.Add(user);
        //        return affected;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Failed in Insert", ex);
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        //SqlCommand CreateInsertUser(User user, SqlConnection con)
        //{
        //    string insertStr = "INSERT INTO [SHAY_User] ([USR_Id],[USR_UserName],[USR_Email],[USR_Password]) " +
        //        "VALUES('" + user.UserID + "','" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "')";
        //    SqlCommand command = new SqlCommand(insertStr, con);
        //    command.CommandType = System.Data.CommandType.Text;
        //    command.CommandTimeout = 30;
        //    return command;
        ////}

        SqlConnection Connect(string connectionStringName)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }


        //SqlConnection Connect(string conString)
        //{

        //    // read the connection string from the web.config file
        //    string connectionString = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;

        //    // create the connection to the db
        //    SqlConnection con = new SqlConnection(connectionString);

        //    // open the database connection
        //    con.Open();

        //    return con;

        //}


        public int InsertGatePass(GatePass g)
        {
            //int res = 0;

            SqlConnection con = null;
            int numEffected = 0;
            try
            {
                con = Connect("FinalProject");

                using (SqlCommand cmd = new SqlCommand("NewGatePass", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                 
                    cmd.Parameters.AddWithValue("@ContainerNum", g.ContainerNum);
                    cmd.Parameters.AddWithValue("@ContainerType", g.ContainerType);
                    cmd.Parameters.AddWithValue("@TransportCompany", g.TransportCompany);
                    cmd.Parameters.AddWithValue("@Importer", g.Importer);
                    cmd.Parameters.AddWithValue("@CustomsBroker", g.CustomsBroker);
                    cmd.Parameters.AddWithValue("@ShippingCompanyAndLine", g.ShippingCompanyAndLine);
                    cmd.Parameters.AddWithValue("@StorageCertificate", g.StorageCertificate);
                    cmd.Parameters.AddWithValue("@CaseNumber", g.CaseNumber);
                    cmd.Parameters.AddWithValue("@Note", g.Note);
                    cmd.Parameters.AddWithValue("@OfficeNote", g.OfficeNote);
                    cmd.Parameters.AddWithValue("@GoToRepair", g.GoToRepair);
                    cmd.Parameters.AddWithValue("@ReturnFromRepair", g.ReturnFromRepair);
                    cmd.Parameters.AddWithValue("@IsActive", g.IsActive);
                    cmd.Parameters.AddWithValue("@UserEmail", g.UserEmail);
                    cmd.Parameters.AddWithValue("@CreatedDate", g.CreatedDate);


                    //var returnParameter = cmd.Parameters.Add("@results", SqlDbType.Int);
                    //returnParameter.Direction = ParameterDirection.ReturnValue;
                    //cmd.ExecuteNonQuery();
                    //var result = returnParameter.Value;
                    numEffected = cmd.ExecuteNonQuery();

                    //if (result.Equals(1))
                    //{
                    //    res = 1;

                    //}
                    //return res;
                }
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
            return numEffected;
        }



        private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
        {

            SqlCommand cmd = new SqlCommand(); // create the command object

            cmd.Connection = con;              // assign the connection to the command object

            cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

            cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

            cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

            return cmd;
        }


    }
}