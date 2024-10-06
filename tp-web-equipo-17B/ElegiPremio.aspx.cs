using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace tp_web_equipo_17B
{
    public partial class ElegiPremio : System.Web.UI.Page
    {

        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
             negocio neg = new negocio();
            ListaArticulos = neg.ListarConSP();

        }

        protected void BtnCargaDatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresaDatos.aspx",false);
        }
    }
}