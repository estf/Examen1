using FacilityManagement.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroAsientos.Data
{
    public class FacultyData:BaseData
    {
        public void Insert(Faculty faculty)
        {
            try
            {
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " INSERT INTO faculty (name) values (" + "'" + faculty.Name + "')";
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
        public IEnumerable<Faculty> Select()
        {
            List<Faculty> faculties = new List<Faculty>();
            IEnumerable<Faculty> items = null;
            try
            {

                SqlDataReader myReader = null;
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " SELECT * FROM faculty";
                sqlcommand = new SqlCommand(databaseCommand, con);
                //Ejecutar el comando SQL
                myReader = sqlcommand.ExecuteReader();
                while (myReader.Read())
                {
                    faculties.Add(new Faculty(myReader["Date"].ToString()));
                }

                DataBaseConnection("close");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());

            }

            items = faculties;
            return items;

        }

        public void Delete(int ID)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("DELETE FROM faculty WHERE ID = @Id", con);
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
        public void Update(Faculty faculty)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("UPDATE Reservation SET Name=@Name", con);
                cmdIns.Parameters.Add("@Name", faculty.Name);
                
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