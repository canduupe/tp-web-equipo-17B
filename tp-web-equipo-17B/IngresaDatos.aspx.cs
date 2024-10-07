using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        protected void btnParticipar_Click(object sender, EventArgs e)
        {

            try
            {

                Cliente cliente = new Cliente();
                ClienteNegocio negocio = new ClienteNegocio();

                if (!Regex.IsMatch(txtDNI.Text, @"^\d+$"))
                {
                    
                    lblDNI.Text = "Formato incorrecto, ingrese numeros";
                    lblDNI.CssClass = "text-danger";
                    return;  
                }

                if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
                {
                    lblNombre.Text = "Formato incorrecto, utilice solo letras";
                    lblNombre.CssClass = "text-danger";
                    return;
                }

               
                if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+$"))
                {
                    lblApellido.Text = "Formato incorrecto, utilice solo letras";
                    lblApellido.CssClass = "text-danger";
                    return; 
                }



                if (!Regex.IsMatch(txtMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    lblMail.Text = "Correo electrónico no válido.";
                    lblMail.CssClass = "text-danger";
                    return;
                }

               
                int codpos;
                if (!int.TryParse(txtCP.Text, out codpos))
                {
  
                    lblCP.Text = "Por favor, ingrese solo números enteros en el campo CP.";
                    lblCP.CssClass = "text-danger";
                    return; 
                }


                cliente.Documento = txtDNI.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Ciudad = txtCiudad.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Cp = int.Parse(txtCP.Text);
                cliente.Email  =  txtMail.Text;

               negocio.agregar(cliente);

                Response.Redirect("RegistroExitoso.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
        }
    }
}