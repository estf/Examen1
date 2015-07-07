using RegistroAsientos.App_Business;
using RegistroAsientos.App_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroAsientos
{
    public partial class RegistroAsientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation(Int32.Parse(txb_starTime.Text), Int32.Parse(txb_endTime.Text), txb_course.Text, txb_Observation.Text,Cld_Date.SelectedDate.ToShortDateString(),12);
            lbl_muestra.Text = r.Date.ToString();
            ReservationBusiness rb = new ReservationBusiness();
            rb.Insert(r);
        }
    }
}