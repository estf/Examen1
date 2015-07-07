using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroAsientos.Data
{
    public class BaseData
    {
        public SqlConnection DataBaseConnection(string actionToPerform)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Proyecto;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                if (actionToPerform.Equals("open"))
                {
                    sqlConnection.Open();
                }
                else
                {
                    sqlConnection.Close();
                }



            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());
            }
            return sqlConnection;

        }
    }
}