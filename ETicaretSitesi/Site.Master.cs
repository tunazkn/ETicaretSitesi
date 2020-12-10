using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["KullaniciLogin"] = false;
            }
        }

        protected void BtnKitapAra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/KitapArama.aspx?arama=" + txtKitapAra.Text+"");
        }
    }
}