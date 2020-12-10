using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitapSatinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["KullaniciLogin"]) == false)
            {
                Response.Redirect("~/Login.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {
                if (!IsPostBack)
                {
                    try
                    {
                        string kitid = Request.QueryString["Kitapid"].ToString();

                        DataListsoru.DataSource = DB.getKitapDetay(kitid);
                        DataListsoru.DataBind();

                        DataListKitapResimonay.DataSource = DB.getKitapDetay(kitid);
                        DataListKitapResimonay.DataBind();

                        DataListKitapDetayonay.DataSource = DB.getKitapDetay(kitid);
                        DataListKitapDetayonay.DataBind();
                    }
                    catch { }
                }
            }
        }
    }
}