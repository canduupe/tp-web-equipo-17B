using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_17B
{
    public partial class CanjeVoucher : System.Web.UI.Page
    {

        private bool voucherValidado (string input)
        {
            return input.All(char.IsLetterOrDigit);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextVoucher.Text = "******************";
        }

        protected void BtnVoucher_Click(object sender, EventArgs e)
        {

            string voucher = TextVoucher.Text;
            if (voucherValidado(voucher))
            {
               
                LblCanjenado.Text = "Codigo aceptado." + voucher;
                Response.Redirect("ElegiPremio.aspx", false);
            }
            else
            {
                
                LblCanjenado.Text = "codigo rechazado";
                LblCanjenado.CssClass = "text-danger"; 
            }


   

        }

       
    }
}