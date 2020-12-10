using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class KitapDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["KullaniciLogin"] = false;
            Session["kullanici_ID"] = "";
            string kitid = Request.QueryString["Kitapid"].ToString();

            DataListyolu.DataSource = DB.getKitapDetay(kitid);
            DataListyolu.DataBind();

            DataListKitapResim.DataSource = DB.getKitapDetay(kitid);
            DataListKitapResim.DataBind();

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid);
            DataListKitapDetay.DataBind();
        }
    }
}