using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitaplar : System.Web.UI.Page
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
                        lblTumKitaplarinSayisi.Text = "Toplam " + DB.getTumKitapSayisi().ToString() + " Adet Kitap Listelendi.";
                        string liste = Request.QueryString["liste"].ToString();
                        string sira = Request.QueryString["sira"].ToString();
                        if (liste == "0")
                        {
                            /*liste 0 ise kitapid ye göre*/
                            if (sira == "0")
                            {
                                DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.KitapAdi", "asc");
                                DataListTumKitaplar.DataBind();
                            }
                            else
                            {
                                DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.KitapAdi", "desc");
                                DataListTumKitaplar.DataBind();
                            }
                        }
                        else
                        {
                            /*list =1 ise kitap puanına ye göre sırala*/
                            if (sira == "0")
                            {
                                DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.KitapOrtalamaPuani", "desc");
                                DataListTumKitaplar.DataBind();
                            }
                            else
                            {
                                DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.KitapOrtalamaPuani", "asc");
                                DataListTumKitaplar.DataBind();
                            }
                        }
                    }
                    catch { }
                }
            }
        }
    }
}