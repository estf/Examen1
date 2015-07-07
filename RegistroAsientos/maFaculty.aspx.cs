using FacilityManagement.App_Domain;
using RegistroAsientos.App_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroAsientos
{
    public partial class maFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            FacultyBusiness fb = new FacultyBusiness();
            Faculty f = new Faculty(txb_name.Text);
            fb.Insert(f);
        }
    }
}