using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class Kullanici : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public Label LabelSepetSayisiOnMasterPage
        {
            get
            {
                return this.lblSepetSayisi;
            }
        }

        protected void BtnUKitapAra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/UKitapArama.aspx?arama=" + txtUKitapAra.Text + "");
        }
    }
}