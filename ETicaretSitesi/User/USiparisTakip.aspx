<%@ Page Title="Sipariş Sorgulama" Language="C#" MasterPageFile="~/User/Kullanici.Master" AutoEventWireup="true" CodeBehind="USiparisTakip.aspx.cs" Inherits="ETicaretSitesi.User.USiparisTakip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section>
        <div class="container">
            <div class="row mr-auto ml-auto col-md-5 m-4">
                <nav class="col-md-6 mr-auto ml-auto ">
                    <img src="../images/siparistakip2.png" class="d-inline-block align-content-center align-top" alt="">
                </nav>
            </div>
            <div class="row mr-auto ml-auto col-md-10 mt-4 mr-4 ml-4">
                <nav class="col-md-7 mr-auto ml-auto" style="font: bold 20px arial verdana;">
                    <h1>
                        <p>SİPARİŞ TAKİP SİSTEMİ</p>
                    </h1>

                </nav>
            </div>
            <div class="row mr-auto ml-auto col-md-12 text-center">
                <p style="font-family: 'Cabin', sans-serif; font-size: 15px;">
                    Müşterilerimizin sitemizde yapacakları alışverişleri sipariş sorgulama sayfası ile sipariş takip numaralarını kullanarak adım adım takip edebilmektedirler.
                    <br />
                    Siparişiniz sonrasında e-posta adresine gönderdiğimiz sipariş numarasını kullanarak siparişinizin kargo sürecini sorgulayabilirsiniz.
                    <br />
                    NOT: Ürünlerimiz, boyut ve ağırlıklarına göre farklı kargo firmaları ile gönderilmektedir..
                </p>
                <div class="row mr-auto ml-auto col-md-5" style="margin-top: 10px;">
                    <div class="input-group">
                        <asp:TextBox CssClass="form-control" ID="txtSiparisNumarası" runat="server" AutoCompleteType="Disabled" TextMode="Search" ></asp:TextBox>
                        <asp:Button CssClass="btn btn-success text-uppercase" ID="btnUSiparisSorgula" runat="server" Text="SORGULA" OnClick="btnUSiparisSorgula_Click"/>
                    </div>
                    <div class="input-group mt-1">
                        <asp:Label ID="lblSiparisTakipUyari" runat="server" Text="agasda" ForeColor="red" Visible="true" Font-Size="12"></asp:Label>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </section>
</asp:Content>
