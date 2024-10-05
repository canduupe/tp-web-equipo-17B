using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_17B
{
    public partial class ElegiPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCargaDatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresaDatos.aspx",false);
        }
    }
}