using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Kitaplar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["kullanici_ID"] = "";
            Session["KullaniciLogin"] = false;
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
                        DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.Kitapid", "asc");
                        DataListTumKitaplar.DataBind();
                    }
                    else
                    {
                        DataListTumKitaplar.DataSource = DB.getAllBooks("Tbl_Kitaplar.Kitapid", "desc");
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