using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Domain
{
    public class User
    {
        private int id;

       
        private string name;

        private string email;

       
        private string carne;

        
        private string password;

       
        public User() { 
        
        }
        public User(string name ,string email,string carne ,string password) {
            this.name = name;
            this.email = email;
            this.carne = carne;
            this.password = password;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Carne
        {
            get { return carne; }
            set { carne = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}