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
    public partial class manLaboratory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            LaboratoryBusiness lb = new LaboratoryBusiness();
            Laboratory l = new Laboratory(txb_name.Text,Int32.Parse(txb_capacity.Text),txb_type.Text,Int32.Parse(ddl_faculties.SelectedValue));
            lb.Insert(l);
        }
    }
}