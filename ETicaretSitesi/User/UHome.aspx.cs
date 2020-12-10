using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UHome : System.Web.UI.Page
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
                        DataListSonEklenen.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.Kitapid", "desc");
                        DataListSonEklenen.DataBind();

                        DataListYuksekPuanli.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.KitapOrtalamaPuani", "desc");
                        DataListYuksekPuanli.DataBind();

                        DataListDusukPuanli.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.KitapOrtalamaPuani", "asc");
                        DataListDusukPuanli.DataBind();

                        DataListilkEklenen.DataSource = DB.getFirstLast5Books("Tbl_Kitaplar.Kitapid", "asc");
                        DataListilkEklenen.DataBind();
                        Session["KullaniciLogin"] = true;
                    }
                    catch { }
                }
            }
        }
    }
}