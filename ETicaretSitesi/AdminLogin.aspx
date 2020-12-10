<%@ Page Title="Admin Giriş Yap" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ETicaretSitesi.AdminLogin" %>
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
                        <h2 class="girisyap">Admin Girişi Yapın</h2>
                        <asp:Label ID="lblLoginUyari" runat="server" Text="."
                            ForeColor="Transparent" Visible="false" Font-Size="13"></asp:Label>
                    </div>
                    <div class="col-lg-12">
                        <div class="form-group">
                            <asp:Label ID="lblLoginEposta" runat="server" Font-Size="13pt" Text="E-Posta Adresi"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtLoginAdminEposta" runat="server" placeholder="E-Posta Adresinizi Giriniz..." title="Sisteme kayıtlı olan mail adresinizi yazınız!" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblLoginAdminSifre" runat="server" Font-Size="13pt" Text="Şifre"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtLoginAdminSifre" runat="server"
                                placeholder="Şifrenizi giriniz..." title="Lütfen şifrenizi giriniz!" TextMode="Password" AutoCompleteType="Disabled">
                            </asp:TextBox>
                        </div>
                        <div class="row form-group mx-2">
                            <div class="mr-auto">
                                <p> 
                                </p>
                            </div>
                            <div class="ml-auto">
 
                            </div>
                        </div>
                        <div class="form-group clearfix">
                            <asp:Button CssClass="btn btn-lg btn-warning btn-block text-uppercase" ID="btnAdminLoginAdminGirisYap" runat="server" Text="GİRİŞ YAP" OnClick="btnAdminLoginAdminGirisYap_Click"/>
                            <asp:Label ID="lblULoginAdminGiris" runat="server" Text="." ForeColor="Transparent" Visible="false" Font-Size="10"></asp:Label>
                        </div>
                        <div class="clear"></div>
                      
                    </div>
                </div>
                <div class="col-md-2 shadow"></div>
                <div class="col-md-5  shadow">
                 
                </div>
            </div>
        </div>
    </section>
</asp:Content>
