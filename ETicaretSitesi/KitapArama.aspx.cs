using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class KitapArama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["KullaniciLogin"] = false;
            Session["kullanici_ID"] = "";
            if (!IsPostBack)
            {
                if (Request.QueryString["arama"] != null)
                {
                    string arama = Request.QueryString["arama"].ToString();
                    lblArananKitaplarListesi.Text = "'" + arama + "' için arama sonuçları";
                    DataListArananKitaplar.DataSource = DB.KitapAraisim(arama);
                    DataListArananKitaplar.DataBind();
                    
                }
            }
        }
    }
}