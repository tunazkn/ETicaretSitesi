using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckBoxuyeliksozlesmeN.Checked = false;
            }
        }

        protected void btnRegisterKulUyeOL_Click(object sender, EventArgs e)
        {
            try
            {
                lblRegisterBasari.Visible = false;
                lblRegisterBasari.ForeColor = System.Drawing.Color.Transparent;
                lblRegisterBasari.Text = ".";
                lblUCheckBoxuyeliksozlesmeN.Visible = false;
                lblUCheckBoxuyeliksozlesmeN.ForeColor = System.Drawing.Color.Transparent;
                lblUCheckBoxuyeliksozlesmeN.Text = ".";
                CheckBoxuyeliksozlesmeN.BorderColor = System.Drawing.Color.Transparent;
                lblURegisterKulAdiN.Visible = false;
                lblURegisterKulAdiN.ForeColor = System.Drawing.Color.Transparent;
                lblURegisterKulAdiN.Text = ".";
                txtRegisterKulAdiN.BorderColor = System.Drawing.Color.Transparent;
                lblURegisterKulSoyadiN.Visible = false;
                lblURegisterKulSoyadiN.ForeColor = System.Drawing.Color.Transparent;
                lblURegisterKulSoyadiN.Text = ".";
                txtRegisterKulSoyadiN.BorderColor = System.Drawing.Color.Transparent;
                lblURegisterKulEpostaN.Visible = false;
                lblURegisterKulEpostaN.ForeColor = System.Drawing.Color.Transparent;
                lblURegisterKulEpostaN.Text = ".";
                txtRegisterKulEpostaN.BorderColor = System.Drawing.Color.Transparent;
                lblURegisterKulSifreN.Visible = false;
                lblURegisterKulSifreN.ForeColor = System.Drawing.Color.Transparent;
                lblURegisterKulSifreN.Text = ".";
                txtRegisterKulSifreN.BorderColor = System.Drawing.Color.Transparent;
                lblURegisterKulSifreTekrarN.Visible = false;
                lblURegisterKulSifreTekrarN.ForeColor = System.Drawing.Color.Transparent;
                lblURegisterKulSifreTekrarN.Text = ".";
                txtRegisterKulSifreTekrarN.BorderColor = System.Drawing.Color.Transparent;

                if (!(CheckBoxuyeliksozlesmeN.Checked))
                {
                    lblUCheckBoxuyeliksozlesmeN.Visible = true;
                    lblUCheckBoxuyeliksozlesmeN.ForeColor = System.Drawing.Color.Red;
                    lblUCheckBoxuyeliksozlesmeN.Text = "Lütfen üyelik sözleşmesini okuyup anladığınızı belirdiniz...";
                    CheckBoxuyeliksozlesmeN.BorderColor = System.Drawing.Color.Red;
                    lblRegisterBasari.Visible = true;
                    lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                    lblRegisterBasari.Text = "Başarısız !";
                }
                else
                {
                    if (DB.TextBoxKontrolBosmu(txtRegisterKulAdiN.Text) == true)
                    {
                        lblURegisterKulAdiN.Visible = true;
                        lblURegisterKulAdiN.ForeColor = System.Drawing.Color.Red;
                        lblURegisterKulAdiN.Text = "Boş bırakılamaz. Lütfen adınızı giriniz..";
                        txtRegisterKulAdiN.BorderColor = System.Drawing.Color.Red;
                        lblRegisterBasari.Visible = true;
                        lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                        lblRegisterBasari.Text = "Başarısız !";
                    }
                    else
                    {
                        if (DB.TextBoxKontrolBosmu(txtRegisterKulSoyadiN.Text) == true)
                        {
                            lblURegisterKulSoyadiN.Visible = true;
                            lblURegisterKulSoyadiN.ForeColor = System.Drawing.Color.Red;
                            lblURegisterKulSoyadiN.Text = "Boş bırakılamaz. Lütfen soyadınızı giriniz..";
                            txtRegisterKulSoyadiN.BorderColor = System.Drawing.Color.Red;
                            lblRegisterBasari.Visible = true;
                            lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                            lblRegisterBasari.Text = "Başarısız !";
                        }
                        else
                        {
                            if (DB.TextBoxKontrolBosmu(txtRegisterKulEpostaN.Text) == true)
                            {
                                lblURegisterKulEpostaN.Visible = true;
                                lblURegisterKulEpostaN.ForeColor = System.Drawing.Color.Red;
                                lblURegisterKulEpostaN.Text = "Boş bırakılamaz. Lütfen E-posta adresiniz giriniz..";
                                txtRegisterKulEpostaN.BorderColor = System.Drawing.Color.Red;
                                lblRegisterBasari.Visible = true;
                                lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                lblRegisterBasari.Text = "Başarısız !";
                            }
                            else
                            {
                                if (DB.TextBoxKontrolBosmu(txtRegisterKulSifreN.Text) == true)
                                {
                                    lblURegisterKulSifreN.Visible = true;
                                    lblURegisterKulSifreN.ForeColor = System.Drawing.Color.Red;
                                    lblURegisterKulSifreN.Text = "Boş bırakılamaz. Lütfen şifrenizi giriniz..";
                                    txtRegisterKulSifreN.BorderColor = System.Drawing.Color.Red;
                                    lblRegisterBasari.Visible = true;
                                    lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                    lblRegisterBasari.Text = "Başarısız !";
                                }
                                else
                                {
                                    /*uzunluk har falan kontrolu*/
                                    if ((txtRegisterKulSifreN.Text).Length < 8)
                                    {
                                        lblURegisterKulSifreN.Visible = true;
                                        lblURegisterKulSifreN.ForeColor = System.Drawing.Color.Red;
                                        lblURegisterKulSifreN.Text = "Şifreniz minimum 8 karekter olmalı..";
                                        lblRegisterBasari.Visible = true;
                                        lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                        lblRegisterBasari.Text = "Başarısız !";
                                    }
                                    else if (DB.AnyUpper(txtRegisterKulSifreN.Text) == false)
                                    {
                                        lblURegisterKulSifreN.Visible = true;
                                        lblURegisterKulSifreN.ForeColor = System.Drawing.Color.Red;
                                        lblURegisterKulSifreN.Text = "Şifreniz en az bir büyük harf içermeli..";
                                        lblRegisterBasari.Visible = true;
                                        lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                        lblRegisterBasari.Text = "Başarısız !";
                                    }
                                    else if (DB.AnyNumber(txtRegisterKulSifreN.Text) == false)
                                    {
                                        lblURegisterKulSifreN.Visible = true;
                                        lblURegisterKulSifreN.ForeColor = System.Drawing.Color.Red;
                                        lblURegisterKulSifreN.Text = "Şifreniz en az bir rakam içermeli..";
                                        lblRegisterBasari.Visible = true;
                                        lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                        lblRegisterBasari.Text = "Başarısız !";
                                    }
                                    else
                                    {
                                        if (DB.TextBoxKontrolBosmu(txtRegisterKulSifreTekrarN.Text) == true)
                                        {
                                            lblURegisterKulSifreTekrarN.Visible = true;
                                            lblURegisterKulSifreTekrarN.ForeColor = System.Drawing.Color.Red;
                                            lblURegisterKulSifreTekrarN.Text = "Boş bırakılamaz. Lütfen şifrenizi tekrar giriniz..";
                                            txtRegisterKulSifreTekrarN.BorderColor = System.Drawing.Color.Red;
                                            lblRegisterBasari.Visible = true;
                                            lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                            lblRegisterBasari.Text = "Başarısız !";
                                        }
                                        else
                                        {
                                            if (txtRegisterKulSifreTekrarN.Text != txtRegisterKulSifreN.Text)
                                            {
                                                lblURegisterKulSifreTekrarN.Visible = true;
                                                lblURegisterKulSifreTekrarN.ForeColor = System.Drawing.Color.Red;
                                                lblURegisterKulSifreTekrarN.Text = "Şifreler uyuşmuyor, lütfen kontrol ediniz..";
                                                txtRegisterKulSifreTekrarN.BorderColor = System.Drawing.Color.Red;
                                                txtRegisterKulSifreN.BorderColor = System.Drawing.Color.Red;
                                                lblRegisterBasari.Visible = true;
                                                lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                                lblRegisterBasari.Text = "Başarısız !";
                                            }
                                            else
                                            {
                                                if (DB.kontrolKullaniciMail(txtRegisterKulEpostaN.Text) == true)
                                                {
                                                    lblURegisterKulEpostaN.Visible = true;
                                                    lblURegisterKulEpostaN.ForeColor = System.Drawing.Color.Red;
                                                    lblURegisterKulEpostaN.Text = "E-posta adresi daha önce kullanılmış!";
                                                    txtRegisterKulEpostaN.BorderColor = System.Drawing.Color.Red;
                                                    lblRegisterBasari.Visible = true;
                                                    lblRegisterBasari.ForeColor = System.Drawing.Color.Red;
                                                    lblRegisterBasari.Text = "Başarısız !";
                                                }
                                                else
                                                {
                                                    /*burada kayıt etme olacak.*/
                                                    try
                                                    {
                                                        DB.UyeOlKullanici(txtRegisterKulAdiN.Text, txtRegisterKulSoyadiN.Text, txtRegisterKulEpostaN.Text, txtRegisterKulSifreN.Text);
                                                        CheckBoxuyeliksozlesmeN.Checked = false;
                                                        Response.Redirect("~/Login.aspx");
                                                    }
                                                    catch { }
                                                    /* Response.Redirect("AnaSayfa.aspx?kullanici_ID=" + txtKullaniciAdi.Text + "");}
                                                     if (Convert.ToBoolean(Session["KullaniciLogin"]) == false)
                                                     txtSifreDegistirKullabiciAdi.Text = Session["kullanici_ID"].ToString();*/
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Bu kodlar postback oldugunda txtboxların içini boşaltmasın yazdıklarımız kalıcı olsun diye yazıldı.
                txtRegisterKulSifreN.Attributes.Add("value", txtRegisterKulSifreN.Text);
                txtRegisterKulSifreTekrarN.Attributes.Add("value", txtRegisterKulSifreTekrarN.Text);
            }
            catch { }
        }
    }
}