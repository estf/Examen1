using RegistroAsientos.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Business
{
    public class ReservationBusiness
    {
        ReservationData reservationData;
        public ReservationBusiness(){
            reservationData = new ReservationData();
        }
        public void Insert(Reservation reservation)
        {

            reservationData.InsertReservation(reservation);
        }
        public IEnumerable<Reservation> Select()
        {

            return reservationData.SelectReservation();
        }
        public void Delete(int Id) {
            reservationData.Delete(Id);
        }
        public void Update(Reservation reservation)
        {
            reservationData.Update(reservation);
        }
            
        
    }
}