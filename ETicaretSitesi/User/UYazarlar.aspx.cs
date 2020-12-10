using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UYazarlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["KullaniciLogin"]) == false)
            {
                Response.Redirect("~/Login.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {
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
}