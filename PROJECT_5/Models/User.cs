using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FINAL_PROJECT4.Models.DAL;

namespace FINAL_PROJECT4.Models
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


        //public int InsertUser()
        //{
        //    DataServices ds = new DataServices();
        //    int status = ds.InsertUser(this);
        //    return status;
        //}





    }
}