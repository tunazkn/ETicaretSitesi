using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Yayinevleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = DB.getAllYayinevleri();
            DataList1.DataBind();
            if (!IsPostBack)
            {
                try
                {
                    string yevid = Request.QueryString["yev"].ToString();
                    if (yevid == "all")
                    {
                        lblYayinevleriKitapSayisi.Text = "Toplam " + 
                            DB.getTumKitapSayisi().ToString() + " Adet Kitap Listelendi.";
                        DataListYayinevleri.DataSource = 
                            DB.getAllBooks("Tbl_Yayinevleri.YayineviAdi", "asc");
                        DataListYayinevleri.DataBind();
                    }
                    else
                    {
                        lblYayinevleriKitapSayisi.Text = "'" + 
                            DB.getYayineviAdi(yevid) + "' için " + 
                            DB.getKitapSayisiYayinevi(yevid).ToString() + " Adet Kitap Listelendi.";
                        DataListYayinevleri.DataSource = DB.getBookYayinevi(yevid);
                        DataListYayinevleri.DataBind();
                    }
                    Session["kullanici_ID"] = "";
                    Session["KullaniciLogin"] = false;
                }
                catch { }
            }
        }
    }
}