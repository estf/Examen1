using RegistroAsientos.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroAsientos.Data
{
    public class UserData:BaseData
    {
        public void Insert(User user)
        {
            try
            {
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " INSERT INTO [dbo].[User] (name,email,carne,password)values (" + "'" + user.Name + "'" + "," + "'" + user.Email + "'" + "," + "'" + user.Carne + "'" + "," + "'" + user.Password + "'" + ")";
                sqlcommand = new SqlCommand(databaseCommand, con);
                sqlcommand.ExecuteNonQuery();
                sqlcommand.Dispose();
                DataBaseConnection("close");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());

            }
        }
        public IEnumerable<User> Select()
        {
            List<User> users = new List<User>();
            IEnumerable<User> items = null;
            try
            {

                SqlDataReader myReader = null;
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " SELECT * FROM user";
                sqlcommand = new SqlCommand(databaseCommand, con);
                //Ejecutar el comando SQL
                myReader = sqlcommand.ExecuteReader();
                while (myReader.Read())
                {
                    users.Add(new User(myReader["name"].ToString(), myReader["email"].ToString(), myReader["carne"].ToString(), myReader["password"].ToString()));
                }

                DataBaseConnection("close");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());

            }

            items = users;
            return items;

        }

        public void Delete(int ID)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("DELETE FROM user WHERE ID = @Id", con);
                cmdIns.Parameters.Add("@Id", ID);
                cmdIns.ExecuteNonQuery();

                cmdIns.Dispose();
                cmdIns = null;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                DataBaseConnection("close");
            }
        }
        public void Update(User user)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("UPDATE user SET name=@name ,email=@email,carne=@carne,password=@password", con);
                cmdIns.Parameters.Add("@name", user.Name);
                cmdIns.Parameters.Add("@email", user.Email);
                cmdIns.Parameters.Add("@carne", user.Carne);
                cmdIns.Parameters.Add("@password", user.Password);

                cmdIns.ExecuteNonQuery();
                cmdIns.Dispose();
                cmdIns = null;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                DataBaseConnection("close");
            }
        }
    }
}