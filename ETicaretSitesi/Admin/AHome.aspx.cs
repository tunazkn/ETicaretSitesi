using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.Admin
{
    public partial class AHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["AdminLogin"]) == false)
            {
                Response.Redirect("~/Login.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {
                if (!IsPostBack)
                {
                    try
                    {
                        Session["AdminLogin"] = true;
                    }
                    catch { }
                }
            }
        }
    }
}