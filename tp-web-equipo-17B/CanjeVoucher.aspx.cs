using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_17B
{
    public partial class CanjeVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVoucher_Click(object sender, EventArgs e)
        {
            string voucher = TextVoucher.Text;
            LblCanjenado.Text = "Canjeando voucher: " + voucher;

            Response.Redirect("ElegiPremio.aspx");
        }
    }
}