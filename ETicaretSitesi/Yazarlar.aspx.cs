using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Yazarlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["kullanici_ID"] = "";
            Session["KullaniciLogin"] = false;
            DataListYazarliste.DataSource = DB.getAllYazarlar();
            DataListYazarliste.DataBind();
            if (!IsPostBack)
            {
                try
                {
                    string yazid = Request.QueryString["yaz"].ToString();
                    if (yazid == "all")
                    {
                        lblYazarlarKitapSayisi.Text = "Toplam " +
                            DB.getTumKitapSayisi().ToString() + " Adet Kitap Listelendi.";
                        DataListYazarlar.DataSource =
                            DB.getAllBooks("Tbl_Yazarlar.YazarAdiSoyadi", "asc");
                        DataListYazarlar.DataBind();
                    }
                    else
                    {
                        lblYazarlarKitapSayisi.Text = "'" +
                            DB.getYazarAdi(yazid) + "' için " +
                            DB.getKitapSayisiYazar(yazid).ToString() + 
                            " Adet Kitap Listelendi.";
                        DataListYazarlar.DataSource = 
                            DB.getBookYazar(yazid);
                        DataListYazarlar.DataBind();
                    }
                }
                catch { }
            }
        }
    }
}