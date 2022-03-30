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


<<<<<<< HEAD
        //public void InsertUser()
        //{
        //    DataServices ds = new DataServices();
        //    ds.InsertUser(this);
        //}
        //public User Read(string email)
        //{
=======
        public void InsertUser()
        {
            DataServices ds = new DataServices();
            ds.InsertUser(this);
        }
        public User ReadUser(string email)
        {
>>>>>>> 37608bb11f5e59fa402de06a9162aa402409c3b0

            DataServices ds = new DataServices();
            return ds.ReadUser(email);

        }




    }
}