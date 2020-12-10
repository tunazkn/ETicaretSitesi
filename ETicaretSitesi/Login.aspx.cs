using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginUyari.Visible = false;
            lblLoginUyari.ForeColor = System.Drawing.Color.Transparent;
            lblLoginUyari.Text = ".";
            if (!IsPostBack)
            {
                if (Request.QueryString["msg"] != null)
                {
                    lblLoginUyari.Visible = true;
                    lblLoginUyari.ForeColor = System.Drawing.Color.Red;
                    lblLoginUyari.Text = "Önce Giriş Yapmalısınız..";
                }
                Session["KullaniciLogin"] = false;
            }
        }

        protected void btnLoginKulGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                lblULoginKulGiris.Visible = false;
                lblULoginKulGiris.ForeColor = System.Drawing.Color.Transparent;
                lblULoginKulGiris.Text = ".";
                txtLoginKulEposta.BorderColor = System.Drawing.Color.Transparent;
                txtLoginKulSifre.BorderColor = System.Drawing.Color.Transparent;

                bool result = DB.KullaniciGirisKontrol(txtLoginKulEposta.Text, txtLoginKulSifre.Text);
                if (result == false)
                {
                    lblULoginKulGiris.Visible = true;
                    lblULoginKulGiris.ForeColor = System.Drawing.Color.Red;
                    lblULoginKulGiris.Text = "E-posta adresi ya da şifre yanlış. Tekrar deneyiniz...";
                    txtLoginKulEposta.BorderColor = System.Drawing.Color.Red;
                    txtLoginKulSifre.BorderColor = System.Drawing.Color.Red;
                }
                else
                {
                    Session["KullaniciLogin"] = true;
                    int kid = DB.getkid(txtLoginKulEposta.Text, txtLoginKulSifre.Text);
                    Session["kullanici_ID"] = kid;
                    Response.Redirect("~/User/UHome.aspx?kullaniciid=" + kid + "");
                }
            }
            catch { }
        }
    }
}