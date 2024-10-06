using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_17B
{
    public partial class IngresaDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCP.Text = "****";
                txtApellido.Text = "Apellido...";
                txtCiudad.Text = "Ciudad...";
                txtDireccion.Text = "Direccion...";
                txtDNI.Text = "DNI";
                txtMail.Text = "E-MAIl";
                txtNombre.Text = "Nombre...";
            }
        }
    }
}