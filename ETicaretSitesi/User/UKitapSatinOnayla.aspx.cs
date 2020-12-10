using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitapSatinOnayla : System.Web.UI.Page
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
                        string islem = Request.QueryString["islem"].ToString();
                        string kulid = "1";
                        string sipariscode = "";
                        if (islem == "1")
                        {
                            sipariscode = DB.RandomCode();
                            LabelSiparisKodu.Text = "'" + sipariscode + "' kodu ile siparişinizi takip edebilirsiniz.";
                            DB.KullaniciSiparisEkle(kitid, kulid, sipariscode);
                        }
                    }
                    catch { }
                }
            }
        }
    }
}