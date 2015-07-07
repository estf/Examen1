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
    public partial class manUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            UserBusiness ub = new UserBusiness();

            User u = new User(txb_name.Text,txb_email.Text,txb_carne.Text,txb_password.Text);
            ub.Insert(u);
        }
    }
}