using RegistroAsientos.App_Domain;
using RegistroAsientos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Business
{
    public class UserBusiness
    {
         UserData userData;
        public UserBusiness(){
            userData = new UserData();
        }
        public void Insert(User user)
        {

            userData.Insert(user);
        }
        public IEnumerable<User> Select()
        {

            return userData.Select();
        }
        public void Delete(int Id) {
            userData.Delete(Id);
        }
        public void Update(User user)
        {
            userData.Update(user);
        }
    }
}