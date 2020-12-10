using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitapArama : System.Web.UI.Page
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
                        if (Request.QueryString["arama"] != null)
                        {
                            string arama = Request.QueryString["arama"].ToString();
                            lblArananKitaplarListesi.Text = "'" + arama + "' için arama sonuçları";
                            DataListArananKitaplar.DataSource = DB.KitapAraisim(arama);
                            DataListArananKitaplar.DataBind();

                        }
                    }
                    catch { }
                }
            }
        }
    }
}