<%@ Page Title="Kayıt Ol" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ETicaretSitesi.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .shadow {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        }

        .uyeol {
            color: black;
            text-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }

        .borderuyariicin {
            border: 1px solid white;
        }

        div#girisyapin .nav-link {
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
                    <div class=" col-lg-8">
                        <h2 class="uyeol">Üye Olun</h2>
                        <asp:Label ID="lblRegisterBasari" runat="server" Text="."
                            ForeColor="Transparent" Visible="false" Font-Size="15"></asp:Label>
                    </div>
                    <div class="col-lg-12 mb-2">
                        <div class="form-group">
                            <asp:Label ID="lblRegisterKulAdiN" runat="server" Font-Size="13pt" Text="Adınız *"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtRegisterKulAdiN" runat="server" placeholder="Adınızı giriniz..." AutoCompleteType="Disabled"></asp:TextBox>
                            <asp:Label ID="lblURegisterKulAdiN" runat="server" Text="."
                                ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRegisterKulSoyadiN" runat="server" Font-Size="13pt" Text="Soyadınız *"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtRegisterKulSoyadiN" runat="server" placeholder="Soyadınızı giriniz..." AutoCompleteType="Disabled">
                            </asp:TextBox>
                            <asp:Label ID="lblURegisterKulSoyadiN" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRegisterKulEpostaN" runat="server" Font-Size="13pt" Text="E-posta Adresiniz *"></asp:Label>
                            <asp:TextBox CssClass="form-control " ID="txtRegisterKulEpostaN" runat="server" placeholder="E-posta adresinizi giriniz..." TextMode="Email" AutoCompleteType="Disabled"></asp:TextBox>
                            <asp:Label ID="lblURegisterKulEpostaN" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRegisterKulSifreN" runat="server" Font-Size="13pt" Text="Şifre *"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtRegisterKulSifreN" runat="server" placeholder="Şifrenizi giriniz" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
                            <asp:Label ID="lblURegisterKulSifreN" runat="server" Text="."
                                ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                            <div>
                                <span style="font-size: 15px;">*Minimum 8 Karakter,</span>
                                <span style="font-size: 15px;">*En az bir büyük harf,</span>
                                <span style="font-size: 15px;">*En az bir rakam</span>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRegisterKulSifreTekrarN" runat="server" Font-Size="13pt"
                                Text="Şifre Tekrar *"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtRegisterKulSifreTekrarN" runat="server" placeholder="Şifrenizi tekrar giriniz" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
                            <asp:Label ID="lblURegisterKulSifreTekrarN" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="form-group">
                            <p>
                                <asp:CheckBox CssClass="borderuyariicin" ID="CheckBoxuyeliksozlesmeN" runat="server" BorderColor="Transparent" title="Üyelik Sözleşmesi'ni okudum, onaylıyorum." />
                                <a href="Tasarlanmadi.aspx" id="contractLink1" title="Üyelik Sözleşmesi"><strong>Üyelik Sözleşmesi</strong></a>'ni okudum, onaylıyorum.
                            </p>
                            <span id="registerDateNow" data-today="6.23.2020" style="display: none;"></span>
                            <asp:Label ID="lblUCheckBoxuyeliksozlesmeN" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="form-group  clearfix">
                            <asp:Button CssClass="btn btn-lg btn-warning btn-block text-uppercase" ID="btnRegisterKulUyeOL" runat="server" Text="ÜYE OL" OnClick="btnRegisterKulUyeOL_Click" />
                            <br />
                        </div>
                        <div class="row justify-content-center align-middle">
                            <i class="fas fa-circle mt-2 mr-2" style="font-size: 6px;"></i>
                            <i class="fas fa-circle mt-2 mr-2" style="font-size: 9px;"></i>
                            <i class="fas fa-circle mt-2 mr-2" style="font-size: 12px;"></i>
                            <asp:Label ID="lblor" runat="server" Font-Size="13pt" Text="ya da"></asp:Label>
                            <i class="fas fa-circle mt-2 ml-2" style="font-size: 12px;"></i>
                            <i class="fas fa-circle mt-2 ml-2" style="font-size: 9px;"></i>
                            <i class="fas fa-circle mt-2 ml-2" style="font-size: 6px;"></i>
                        </div>
                        <div class="row justify-content-center" style="margin-bottom: 30px;">
                            <div class="nav navbar" id="girisyapin">
                                Hesabınız var mı? <a href="~/Login.aspx" class="nav-item nav-link" id="linkgirisyapin" runat="server" style="font: bold 20px arial, verdana; font-style: italic;">Giriş Yapın</a>
                            </div>
                            <asp:Label CssClass="ml-2" ID="lblnot" runat="server" Font-Size="10pt" ForeColor="DarkBlue" Text="NOT: Kayıt işlemi başarılı olursa giriş yap sayfasına yönlendirileceksiniz."></asp:Label>
                            <br />
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
