using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class NotPageSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Label1.Text = DB.getYayineviAdi(TextBox1.Text);
            if (Label1.Text == "")
                Label2.Text = "?";
        }
    }
}