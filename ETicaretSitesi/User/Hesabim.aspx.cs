using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class Hesabim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Masterpagedeki neyneye böyle erişiyoruz ama master page arka planda fonk yazmamız lazm
            //((Kullanici)Master).LabelSepetSayisiOnMasterPage.Text = "0";

            /*if (Convert.ToBoolean(Session["KullaniciLogin"]) == false)
            {
                Response.Redirect("~/Login.aspx?msg=Once Giris Yapmalisiniz...");
            }
            else
            {*/
                if (!IsPostBack)
                {
                    try
                    {
                    }
                    catch { }
                }
            
        }
    }
}