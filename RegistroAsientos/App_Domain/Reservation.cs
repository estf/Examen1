using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Domain
{
    public class Reservation
    {
        private int starTime;
        private int endTime;
        private string course;
        private string observation;
        private string date;
        private int user_id;


       
        public Reservation(){
        
        }
        public Reservation(int starTime, int endTime, string course, string observation, string date, int User_id)
        {
            this.starTime = starTime;
            this.endTime = endTime;
            this.course = course;
            this.observation = observation;
            this.date = date;
            this.user_id = User_id;
        }
        public int StarTime
        {
            get { return starTime; }
            set { starTime = value; }
        }
        public int EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
    }
}