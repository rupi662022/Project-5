using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using PROJECT_5.Models;
using System.Data;


namespace PROJECT_5.Models.DAL
{


    public class DataServices
    {
        //public int InsertGate(GatePass gatePass)
        //{

        //}



        ////בדיקה טבלה

        //public List<GatePass> ReadgatePass(string id)
        //{
        //    SqlConnection con = null;

        //    try
        //    {
        //        con = Connect("FinalProject");
        //        SqlCommand selectCommand = CreateSelectCommandTableId(con, id);
        //        List<GatePass> gatePassList = new List<GatePass>();
        //        SqlDataReader dataReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

        //        while (dataReader.Read())
        //        {
        //            GatePass a = new GatePass();
        //            a.Id= (string)dataReader["GPS_Id"];
        //            a.ContainerNum = (string)dataReader["GPS_ContainerNum"];

        //            gatePassList.Add(a);
        //        }
        //        return gatePassList;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("failed in reading of artical", ex);
        //    }
        //    finally
        //    {
        //        if (con != null)
        //            con.Close();
        //    }
        //}










        SqlConnection Connect(string connectionStringName)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }




        //        public void InsertUser(User user)
        //        {
        //            SqlConnection con = null;

        //            try
        //            {
        //                con = Connect("FinalProject");
        //                SqlCommand command = CreateInsertUser(user, con);
        //                command.ExecuteNonQuery();
        //                //string emailExist=;
        //                //if (emailExist == user.UserEmail)
        //                //    UsersList = new List<User>();
        //                //UsersList.Add(user);
        //                //return affected;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Failed in Insert user", ex);
        //            }

        //            finally
        //            {
        //                con.Close();
        //            }
        //        }

        //        private SqlCommand CreateInsertUser(User user, SqlConnection con)
        //        {
        //<<<<<<< HEAD
        //            throw new NotImplementedException();
        //=======
        //            string insertStr = "INSERT INTO SHAY_User ([USR_Id],[USR_UserName],[USR_Email],[USR_Password],USR_Type) " +
        //                "VALUES('" + user.UserID + "','" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "','" + user.UserType + "')";
        //            SqlCommand command = new SqlCommand(insertStr, con);
        //            command.CommandType = System.Data.CommandType.Text;
        //            command.CommandTimeout = 30;
        //            return command;
        ////>>>>>>> b126fda96eb08b2a8a45c92140bab2099abc6cfa
        //        }
        //public void InsertUser(User user)
        //{
        //    SqlConnection con = null;

        //    try
        //    {
        //        con = Connect("FinalProject");
        //        SqlCommand command = CreateInsertUser(user, con);
        //        command.ExecuteNonQuery();
        //        //string emailExist=;
        //        //if (emailExist == user.UserEmail)
        //        //    UsersList = new List<User>();
        //        //UsersList.Add(user);
        //        //return affected;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Failed in Insert user", ex);
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        //private SqlCommand CreateInsertUser(User user, SqlConnection con)
        //{
        //    throw new NotImplementedException();
        //    string insertStr = "INSERT INTO SHAY_User ([USR_Id],[USR_UserName],[USR_Email],[USR_Password],USR_Type) " +
        //        "VALUES('" + user.UserID + "','" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "','" + user.UserType + "')";
        //    SqlCommand command = new SqlCommand(insertStr, con);
        //    command.CommandType = System.Data.CommandType.Text;
        //    command.CommandTimeout = 30;
        //    return command;
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










        public int InsertUser(User user)
        {
            //int res = 0;
            SqlConnection con = null;
            int numEffected = 0;
            try
            {
                con = Connect("FinalProject");
                using (SqlCommand cmd = new SqlCommand("NewUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@UserEmail", user.UserEmail);
                         cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);

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






        //   public int logInUsr(User user)------test for Procedure
        //   {
        //       //List<GatePass> Users = new List<GatePass>();
        //       SqlConnection con = null;
        //       int res = 0;

        //       try
        //       {
        //           con = Connect("FinalProject");

        //           using (SqlCommand cmd = new SqlCommand("CheckUser", con))
        //           {
        //               cmd.CommandType = CommandType.StoredProcedure;

        //               cmd.Parameters.AddWithValue("@UserEmail", user.UserEmail);
        //               cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
        //               var returnParameter = cmd.Parameters.Add("@results", SqlDbType.Int);
        //               returnParameter.Direction = ParameterDirection.ReturnValue;
        //               cmd.ExecuteNonQuery();

        //               using (SqlDataReader dr = cmd.ExecuteReader())
        //               {
        //                   var result = returnParameter.Value;
        //                   if (result.Equals(1))
        //                   {
        //                       while (dr.Read())
        //                       {
        //                           if (dr["USR_UserName"] != DBNull.Value)
        //                           {
        //                               user.UserID = Convert.ToInt32(dr["USR_Id"]);
        //                               user.UserName = (string)dr["USR_UserName"];
        //                               user.UserEmail = (string)dr["USR_Email"];
        //                               user.UserPassword = (string)dr["USR_Password"];
        //                               user.UserType = (string)dr["USR_Type"];
        //                               res = 1;
        //                           }
        //                       }

        //                   }
        //               }

        //           }
        //           return res;
        //       }

        //       catch (Exception ex)
        //       {
        //           throw (ex);
        //       }
        //       finally
        //       {
        //           if (con != null)
        //           {
        //               con.Close();
        //           }
        //       }
        //}







        //כניסה לאתר

        public User ReadUser(string userEmail)
        {

            SqlConnection con = null;

            try
            {
                con = Connect("FinalProject");
                SqlCommand selectCommand = CreateSelectCommandUser(con, userEmail);

                SqlDataReader dr = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

                User u = new User();

                while (dr.Read())
                {


                    u.UserID = Convert.ToInt32(dr["USR_Id"]);
                    u.UserEmail = (string)dr["USR_Email"];
                    u.UserPassword = (string)dr["USR_Password"];
                    u.UserName = (string)dr["USR_UserName"];
                    u.UserType = (string)dr["USR_Type"];


                }
                dr.Close();

                return u;

            }
            catch (Exception ex)
            {

                throw new Exception("failed in reading of Users", ex);
            }
            finally
            {

                if (con != null)
                    con.Close();
            }

        }
        private SqlCommand CreateSelectCommandUser(SqlConnection con, string userEmail)
        {
            string commandStr = "SELECT * FROM SHAY_User WHERE USR_Email=@email ";
            SqlCommand cmd = createCommand(con, commandStr);
            //cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters["@email"].Value = userEmail;
            //cmd.Parameters.Add("@password", SqlDbType.VarChar);
            //cmd.Parameters["@password"].Value = userPassword;
            return cmd;
        }




        SqlCommand createCommand(SqlConnection con, string CommandSTR)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = CommandSTR;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 5;
            return cmd;
        }




    }
}