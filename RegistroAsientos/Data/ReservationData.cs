using RegistroAsientos.App_Domain;
using RegistroAsientos.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroAsientos
{
    public class ReservationData:BaseData
    {
        public void InsertReservation(Reservation reservation)
        {
            try
            {
                SqlConnection con = DataBaseConnection("open");
                SqlCommand sqlcommand;
                string databaseCommand = " INSERT INTO Reservation (StartTime,EndTime,Course,Observation,Date,User_id) values (" + "'" + reservation.StarTime + "'" + "," + "'" + reservation.EndTime + "'" + "," + "'" + reservation.Course + "'" + "," + "'" + reservation.Observation + "'" + "," + "'" + reservation.Date + "'" + ",'"+reservation.User_id+"')";
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
        public IEnumerable<Reservation> SelectReservation()
        {
            List<Reservation> reservations = new List<Reservation>();
            IEnumerable<Reservation> items = null;
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
                    reservations.Add(new Reservation(((Int32)myReader["StartTime"]), ((Int32)myReader["EndTime"]), myReader["Course"].ToString(), myReader["Observation"].ToString(), myReader["Date"].ToString(),(Int32)myReader["User_id"]));
                }

                DataBaseConnection("close");
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error:" + sqlException.ToString());

            }

            items = reservations;
            return items;

        }
    
        public void Delete(int ID)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("DELETE FROM Reservation WHERE ID = @Id", con);
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
        public void Update(Reservation reservation)
        {

            SqlConnection con = DataBaseConnection("open");
            try
            {
                SqlCommand cmdIns = new SqlCommand("UPDATE Reservation SET StartTime=@StartTime ,EndTime=@EndTime,Course=@Course,Observation=@Observation,Date=@Date User_id=@User_id", con);
                cmdIns.Parameters.Add("@StartTime", reservation.StarTime);
                cmdIns.Parameters.Add("@EndTime", reservation.EndTime);
                cmdIns.Parameters.Add("@Course", reservation.Course);
                cmdIns.Parameters.Add("@Observation", reservation.Observation);
                cmdIns.Parameters.Add("@Date", reservation.Date);
                cmdIns.Parameters.Add("@User_id", reservation.User_id);
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