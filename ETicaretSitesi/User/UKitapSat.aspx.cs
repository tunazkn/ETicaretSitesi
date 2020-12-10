using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitapSat : System.Web.UI.Page
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
                    try { }
                    catch { }
                    //FileUpload1.SaveAs(Server.MapPath("/bookimages/" + FileUpload1.FileName));
                    //komut.Parameters.AddWithValue("@p6", "~/resimler/" + FileUpload1.FileName);
                }
            }
        }
        protected void btnUkitapgonder_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("/bookimages/" + FileUpload1.FileName));
            string Kresim = "~/bookimages/" + FileUpload1.FileName;

            DB.yeniKitapOner(txtSatkitapadi.Text, txtSatkitapacıklama.Text, txtSatkitapfiyat.Text, Kresim, txtSatkitapkategori.Text, txtSatkitapyazar.Text, txtSatkitapyayınevi.Text);
        }
    }
}
 