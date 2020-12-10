using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi.User
{
    public partial class UKitapDetay : System.Web.UI.Page
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
                        string kitid = Request.QueryString["Kitapid"].ToString();

                        DataListyolu.DataSource = DB.getKitapDetay(kitid);
                        DataListyolu.DataBind();

                        DataListKitapResim.DataSource = DB.getKitapDetay(kitid);
                        DataListKitapResim.DataBind();

                        DataListKitapDetay.DataSource = DB.getKitapDetay(kitid);
                        DataListKitapDetay.DataBind();

                        DataListYorumlar.DataSource = DB.getYorumlar(kitid);
                        DataListYorumlar.DataBind();
                    }
                    catch { }
                }
            }
        }

        protected void btnyorumyap_Click(object sender, EventArgs e)
        {
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.yorumEkle(txtyorumicerik.Text, Session["kullanici_ID"].ToString(), kitid);
            txtyorumicerik.Text = "";
            Response.Redirect("UKitapDetay.aspx?Kitapid=" + kitid);
            DataListYorumlar.DataSource = DB.getYorumlar(kitid.ToString());
            DataListYorumlar.DataBind();
        }
        protected void btn0_Click(object sender, EventArgs e)
        {
            string a = "0,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn01_Click(object sender, ImageClickEventArgs e)
        {
            string a = "0,5";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn1_Click(object sender, ImageClickEventArgs e)
        {
            string a = "1,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }
        protected void btn12_Click(object sender, ImageClickEventArgs e)
        {
            string a = "1,5";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }
        protected void btn2_Click(object sender, ImageClickEventArgs e)
        {
            string a = "2,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn23_Click(object sender, ImageClickEventArgs e)
        {
            string a = "2,5";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn3_Click(object sender, ImageClickEventArgs e)
        {
            string a = "3,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn34_Click(object sender, ImageClickEventArgs e)
        {
            string a = "3,5";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn4_Click(object sender, ImageClickEventArgs e)
        {
            string a = "4,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn45_Click(object sender, ImageClickEventArgs e)
        {
            string a = "4,5";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["kullanici_ID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn5_Click(object sender, ImageClickEventArgs e)
        {
            string a = "5,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["KID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void imgbtn0_Click(object sender, ImageClickEventArgs e)
        {

            string a = "4,0";
            float puan = (float)Convert.ToDouble(a.Replace(".", ","));
            int kitid = Convert.ToInt32(Request.QueryString["Kitapid"].ToString());
            DB.KitapPuaniEkle(kitid, Session["KID"].ToString(), puan);

            DataListKitapDetay.DataSource = DB.getKitapDetay(kitid.ToString());
            DataListKitapDetay.DataBind();
        }

        protected void btn01_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void imgbtn01_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}