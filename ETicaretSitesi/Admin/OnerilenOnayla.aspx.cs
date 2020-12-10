using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.Admin
{
    public partial class OnerilenOnayla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["AdminLogin"]) == false)
            {
                Response.Redirect("~/AdminLogin.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {
                if (!IsPostBack)
                {
                    try
                    {
                        string kitid = Request.QueryString["Kitid"].ToString();
                        txtSatkitapid.Text = DB.OnerilenOku(kitid)[0];
                        txtsatkitapadi.Text = DB.OnerilenOku(kitid)[1];
                        txtsatkitapaciklama.Text = DB.OnerilenOku(kitid)[2];
                        txtkitapsatfiyat.Text = DB.OnerilenOku(kitid)[3];
                        txtkitapsatresimyolu.Text = DB.OnerilenOku(kitid)[4];
                        txtkitapsatkategori.Text = DB.OnerilenOku(kitid)[5];
                        txtkitapsatyazar.Text = DB.OnerilenOku(kitid)[6];
                        txtkitapsatyayınev.Text = DB.OnerilenOku(kitid)[7];
                    }
                    catch { }
                }
            }
        }
        protected void btnUkitaponayla_Click(object sender, EventArgs e)
        {
            DB.kategoriekle(txtkitapsatkategori.Text);
            DB.yazarekle(txtkitapsatyazar.Text);
            DB.yayineviekle(txtkitapsatyayınev.Text);
            float fiyat = (float) Convert.ToDouble(txtkitapsatfiyat.Text);
            string katid = DB.getkategoriid(txtkitapsatkategori.Text).ToString();
            string yazid = DB.getyazarid(txtkitapsatyazar.Text).ToString();
            string yayid = DB.getyayineviid(txtkitapsatyayınev.Text).ToString();

            DB.yeniKitapekle(txtsatkitapadi.Text, txtsatkitapaciklama.Text, fiyat, txtkitapsatresimyolu.Text, katid, yazid, yayid);
            DB.onerilenSİl(Convert.ToInt32(txtSatkitapid.Text));
            Response.Redirect("AHome.aspx");
        }
    }
}
 