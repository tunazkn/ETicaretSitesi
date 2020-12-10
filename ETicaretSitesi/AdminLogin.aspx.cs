using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginUyari.Visible = false;
            lblLoginUyari.ForeColor = System.Drawing.Color.Transparent;
            lblLoginUyari.Text = ".";
            if (!IsPostBack)
            {
                try
                {
                    if (Request.QueryString["msg"] != null)
                    {
                        string msg = Request.QueryString["msg"].ToString();
                        lblLoginUyari.Visible = true;
                        lblLoginUyari.ForeColor = System.Drawing.Color.Red;
                        lblLoginUyari.Text = "Önce Giriş Yapmalısınız..";
                    }
                }
                catch { }
            }
        }
        protected void btnAdminLoginAdminGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                lblULoginAdminGiris.Visible = false;
                lblULoginAdminGiris.ForeColor = System.Drawing.Color.Transparent;
                lblULoginAdminGiris.Text = ".";
                txtLoginAdminEposta.BorderColor = System.Drawing.Color.Transparent;
                txtLoginAdminSifre.BorderColor = System.Drawing.Color.Transparent;

                bool result = DB.AdminGirisKontrol(txtLoginAdminEposta.Text, txtLoginAdminSifre.Text);
                if (result == false)
                {
                    lblULoginAdminGiris.Visible = true;
                    lblULoginAdminGiris.ForeColor = System.Drawing.Color.Red;
                    lblULoginAdminGiris.Text = "E-posta adresi ya da şifre yanlış. Tekrar deneyiniz...";
                    txtLoginAdminEposta.BorderColor = System.Drawing.Color.Red;
                    txtLoginAdminSifre.BorderColor = System.Drawing.Color.Red;
                }
                else
                {
                    Session["AdminLogin"] = true;
                    int adminid = DB.getAdminid(txtLoginAdminEposta.Text, txtLoginAdminSifre.Text);
                    Session["Adminid"] = adminid;
                    Response.Redirect("~/Admin/AHome.aspx?Adminid=" + adminid + "");
                }
            }
            catch { }
        }
    }
}