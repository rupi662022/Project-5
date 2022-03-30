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


        //public void InsertUser()
        //{
        //    DataServices ds = new DataServices();
        //    ds.InsertUser(this);
        //}
        //public User Read(string email)
        //{

        //    DataServices ds = new DataServices();
        //    return ds.ReadUser(email);

        //}




    }
}