using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJECT_5.Models.DAL;

namespace PROJECT_5.Models
{
    public class User
    {
        int userID;
        string userName;
        string userEmail;
        string userPassword;
        string userType;

        public User() { }

        public User(int userID, string userName, string userEmail, string userPassword, string userType)
        {
            UserID = userID;
            UserName = userName;
            UserEmail = userEmail;
            UserPassword = userPassword;
            UserType = userType;
        }

        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserType { get => userType; set => userType = value; }

        //public User( string userEmail, string userPassword)
        //{

        //    UserEmail = userEmail;
        //    UserPassword = userPassword;

        //}

        public void InsertUser()
        {
            DataServices ds = new DataServices();
            ds.InsertUser(this);
        }
 
      
   
        //קריאה
        public User ReadUser(string userEmail, string userPassword)
        {
            DataServices ds = new DataServices();
            return ds.ReadUser(userEmail, userPassword);
        }

            //}
            //public int LogIn()---READ test for Procedures
            //{
            //    int res = 0;
            //    DataServices ds = new DataServices();
            //    res = ds.logInUsr(this);
            //    return res;
            //}




        }
}