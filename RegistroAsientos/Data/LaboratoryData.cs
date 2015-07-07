using FacilityManagement.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroAsientos.Data
{
    public class LaboratoryData:BaseData
    {
        public void Insert(Laboratory laboratory)
        {
            try
            {
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " INSERT INTO laboratory (name,capacity,type,id_Faculty) values (" + "'" + laboratory.Name + "'" + "," + "" + laboratory.Capacity + "" + "," + "'" + laboratory.Type + "'" + "," + "'" + laboratory.FacultyId + "'" + ")";
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
        public IEnumerable<Laboratory> Select()
        {
            List<Laboratory> laboratories = new List<Laboratory>();
            IEnumerable<Laboratory> items = null;
            try
            {

                SqlDataReader myReader = null;
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " SELECT * FROM Reservation";
                sqlcommand = new SqlCommand(databaseCommand, con);
                //Ejecutar el comando SQL
                myReader = sqlcommand.ExecuteReader();
                while (myReader.Read())
                {
                    laboratories.Add(new Laboratory(myReader["name"].ToString(), ((Int32)myReader["capacity"]), myReader["type"].ToString(), ((Int32)myReader["facultyId"])));
                }

                DataBaseConnection("close");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());

            }

            items = laboratories;
            return items;

        }

        public void Delete(int ID)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("DELETE FROM laboratory WHERE ID = @Id", con);
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
        public void Update(Laboratory laboratory)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("UPDATE laboratory SET name=@name ,capacity=@capacity,type=@type,facultyId=@facultyId", con);
                cmdIns.Parameters.Add("@name", laboratory.Name);
                cmdIns.Parameters.Add("@capacity", laboratory.Capacity);
                cmdIns.Parameters.Add("@type", laboratory.Type);
                cmdIns.Parameters.Add("@facultyId", laboratory.FacultyId);
                
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