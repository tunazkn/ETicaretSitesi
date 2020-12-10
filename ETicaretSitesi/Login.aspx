<%@ Page Title="Giriş" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ETicaretSitesi.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .shadow {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        }

        .girisyap {
            color: black;
            text-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }

        .borderuyariicin {
            border: 1px solid white;
        }

        div #girisyapin .nav-link {
            color: orange;
        }
            /*!important yazarsan kırmızı oluyor ama hoverı gidiyor*/
            div#girisyapin .nav-link:hover {
                color: green !important;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container">
            <div class="row mt-3">
                <div class="shadow col-md-5">
                    <div class=" col-lg-8 mb-2">
                        <h2 class="girisyap">Giriş Yapın</h2>
                        <asp:Label ID="lblLoginUyari" runat="server" Text="."
                            ForeColor="Transparent" Visible="false" Font-Size="13"></asp:Label>
                    </div>
                    <div class="col-lg-12">
                        <div class="form-group">
                            <asp:Label ID="lblLoginEposta" runat="server" Font-Size="13pt" Text="E-Posta Adresi"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtLoginKulEposta" runat="server" placeholder="E-Posta Adresinizi Giriniz..." title="Sisteme kayıtlı olan mail adresinizi yazınız!" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblLoginKulSifre" runat="server" Font-Size="13pt" Text="Şifre"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtLoginKulSifre" runat="server"
                                placeholder="Şifrenizi giriniz..." title="Lütfen şifrenizi giriniz!" TextMode="Password" AutoCompleteType="Disabled">
                            </asp:TextBox>
                        </div>
                        <div class="row form-group mx-2">
                            <div class="mr-auto">
                                <p>
                                    <asp:CheckBox CssClass="borderuyariicin" ID="CheckBoxBeniHatirla" runat="server" BorderColor="Transparent" />Beni Hatırla
                                </p>
                            </div>
                            <div class="ml-auto">
                                <a href="#" class="nav-item" runat="server">Şifremi Unuttum</a>
                            </div>
                        </div>
                        <div class="form-group clearfix">
                            <asp:Button CssClass="btn btn-lg btn-warning btn-block text-uppercase" ID="btnLoginKulGirisYap" runat="server" Text="GİRİŞ YAP" OnClick="btnLoginKulGirisYap_Click" />
                            <asp:Label ID="lblULoginKulGiris" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="clear"></div>
                        <div class="row justify-content-center" style="margin-bottom: 40px;">
                            <div class="nav navbar" id="girisyapin">
                                Hesabınız yok mu?<a href="~/Register.aspx" class="nav-item nav-link" runat="server" style="font: bold 20px arial, verdana; font-style: italic;">Üye Olun</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-2 shadow"></div>
                <div class="col-md-5  shadow">
                    <div class="nav navbar navbar-nav">
                        <div class="nav navbar">
                            <br />
                            <br />
                            <br />
                            <h5>Kitap Satıyorum'a Üye Olmanın Avantajları</h5>
                            <br />
                            <br />
                            <br />
                            <br />
                            <ul class="navbar-nav">
                                <li><span class="fas fa-plus mr-3"></span>Siparişlerinizin takibini yapabilir, tüm siparişlerinizin detaylarına ulaşabilirsiniz.
                                </li>
                                <br />
                                <li><span class="fas fa-plus mr-3"></span>Kişisel bilgilerinizi güncelleyebilirsiniz
                                </li>
                                <br />
                                <li><span class="fas fa-plus mr-3"></span>Şiparişlerinizi tek tıkla takip edebilirsiniz
                                </li>
                                <br />
                                <li><span class="fas fa-plus mr-3"></span>Sevdiklerinize hediye çekleri gönderebilirsiniz
                                </li>
                                <br />
                                <li><span class="fas fa-plus mr-3"></span></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
