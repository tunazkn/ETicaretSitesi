using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class SiparisTakip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
                {
                    lblSiparisTakipUyari.Visible = false;
                    lblSiparisTakipUyari.ForeColor = System.Drawing.Color.Transparent;
                    lblSiparisTakipUyari.Text = ".";
                }
                catch { }
            }
        }

        protected void btnSiparisSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                lblSiparisTakipUyari.Visible = false;
                lblSiparisTakipUyari.ForeColor = System.Drawing.Color.Transparent;
                lblSiparisTakipUyari.Text = ".";
                string code = txtSiparisNumarası.Text;
                if (DB.CodeControl(code) == true)
                {
                    lblSiparisTakipUyari.Visible = true;
                    lblSiparisTakipUyari.ForeColor = System.Drawing.Color.Black;
                    lblSiparisTakipUyari.Text = "Siparişiniz Henüz Kargoya Verilmedi. Lütfen Takipte Kalın.";
                }
                else
                {
                    lblSiparisTakipUyari.Visible = true;
                    lblSiparisTakipUyari.ForeColor = System.Drawing.Color.Red;
                    lblSiparisTakipUyari.Text = "Sipariş Bulunamadı!";
                }
            }
            catch { }
        }
    }
}