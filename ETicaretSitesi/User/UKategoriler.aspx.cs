using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKategoriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Convert.ToBoolean(Session["KullaniciLogin"]) == false)
            {
                Response.Redirect("~/Login.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {
                DataList1.DataSource = DB.getAllKategori();
                DataList1.DataBind();
                if (!IsPostBack)
                {
                    try
                    {
                        string katid = Request.QueryString["kat"].ToString();
                        if (katid == "all")
                        {
                            lblKategorilerKitapSayisi.Text = "Toplam " +
                                DB.getTumKitapSayisi().ToString() + " Adet Kitap Listelendi.";
                            DataListKategoriler.DataSource =
                                DB.getAllBooks("Tbl_Kategoriler.KategoriAdi", "asc");
                            DataListKategoriler.DataBind();
                        }
                        else
                        {
                            lblKategorilerKitapSayisi.Text = "'" +
                                DB.getKategoriAdi(katid) + "' için " +
                                DB.getKitapSayisiKategori(katid).ToString() +
                                " Adet Kitap Listelendi.";
                            DataListKategoriler.DataSource =
                                DB.getBookKategori(katid);
                            DataListKategoriler.DataBind();
                        }
                    }
                    catch { }
                }
            }
        }
    }
}