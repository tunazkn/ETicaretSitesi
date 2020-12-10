using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web.DynamicData;

namespace ETicaretSitesi
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["KullaniciLogin"] = false;
            Session["kullanici_ID"] = "";
            try
            {
                DataListSonEklenen.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.Kitapid", "desc");
                DataListSonEklenen.DataBind();

                DataListYuksekPuanli.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.KitapOrtalamaPuani", "desc");
                DataListYuksekPuanli.DataBind();

                DataListDusukPuanli.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.KitapOrtalamaPuani", "asc");
                DataListDusukPuanli.DataBind();

                DataListilkEklenen.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.Kitapid", "asc");
                DataListilkEklenen.DataBind();
            }
            catch { }
        }

        protected void LinkbtnSonEklenenlerTumu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Kitaplar.aspx?liste=0&sira=0");
        }
        protected void LinkbtnYuksekPuanli_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Kitaplar.aspx?liste=1&sira=0");
        }
        protected void LinkbtnDusukPuanli_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Kitaplar.aspx?liste=1&sira=1");
        }
        protected void LinkbtnilkEklenenlerTumu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Kitaplar.aspx?liste=0&sira=1");
        }

    }
}