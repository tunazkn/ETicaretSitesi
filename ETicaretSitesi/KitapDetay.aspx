<%@ Page Title="Kitap Detayları" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KitapDetay.aspx.cs" Inherits="ETicaretSitesi.KitapDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: right;
            width: 350px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <!-- kitabın karetorilerie giden yol-->
        <div class="container">
            <div class="row">
                <div class="row navbar-expand-md shadow m-2">
                    <asp:DataList RepeatDirection="Horizontal" RepeatColumns="1" ID="DataListyolu" runat="server">
                        <ItemTemplate>
                            <div class="row m-2" style="text-align: center; align-content: center; word-break: break-word;">
                                <table class="form-signin">
                                    <tr>
                                        <td>
                                            <a class="bk" href="Home.aspx" title="Anasayfa ">
                                                <asp:Label ID="Labelanasayfa" runat="server" Font-Bold="true" Font-Size="Medium" Text="Anasayfa"></asp:Label>
                                                >
                                            </a>
                                        </td>
                                        <td><a class="bk" href="Kitaplar.aspx?liste=0&sira=0" title="Kitaplar">
                                            <asp:Label ID="Labelkitaplar" runat="server" Font-Bold="true" Font-Size="Medium" Text=" Kitaplar "></asp:Label>
                                            >
                                        </a>
                                        </td>
                                        <td>
                                            <a class="bk" href="Kategoriler.aspx?kat=<%# Eval("KitapKategoriid") %> ">
                                                <asp:Label ID="Labelkategoriad" runat="server" Text='<%# Eval("KategoriAdi") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                                            </a>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row  bg-transparent">
                <div class="navbar-nav shadow bg-transparent col-md-5 m-1 mr-4">
                    <div class="row navbar-expand-md m-1 justify-content-center" style="border: 1px solid black;">
                        <div class="row navbar-expand-md shadow m-1">
                            <asp:DataList RepeatDirection="Horizontal" RepeatColumns="1" ID="DataListKitapResim" runat="server">
                                <ItemTemplate>
                                    <div class="row m-1" style="text-align: center; align-content: center; word-break: break-word;">
                                        <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="max-width: 380px; max-height: 400px;" runat="server" />
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
                <div class="navbar-nav shadow bg-transparent col-md-6 m-1">
                    <div class=" container-fluid navbar-expand-md m-1 justify-content-center bg-light" style="border: 1px solid black;">
                        <div class="row navbar-expand-md shadow bg-danger" style="width: 550px;">
                            <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="4" ID="DataListKitapDetay" runat="server">
                                <ItemTemplate>
                                    <div class="card bg-light shadow m-1" style="min-height: 400px; width: 535px; word-break: break-word;">
                                        <table class="form-signin ml-2 bg-transparent">
                                            <tr>
                                                <td style="word-break: break-word;">
                                                    <asp:Label ID="lblTumKitapAdi" runat="server" Font-Bold="true" Font-Size="40" Text='<%# Eval("KitapAdi") %>'></asp:Label></a></td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <asp:Label ID="Label1" runat="server" Font-Size="13" Text="Yazar: "></asp:Label>
                                                    <a class="bk" href="Yazarlar.aspx?yaz=<%# Eval("KitapYazarid") %>">
                                                        <asp:Label ID="lblTumYazarAdi" runat="server" Font-Bold="true" Font-Size="15" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label></a></td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <asp:Label ID="Label2" runat="server" Font-Size="13" Text="Yayınevi: "></asp:Label>
                                                    <a class="bk" href="Yayinevleri.aspx?yev=<%# Eval("KitapYayineviid") %>">
                                                        <asp:Label ID="lblTumYayineviAdi" runat="server" Font-Bold="true" Font-Size="15" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <asp:Label ID="Label8" runat="server" Font-Size="13" Text="Açıklama: "></asp:Label>
                                                    <asp:Label ID="Label9" runat="server" Font-Size="11" Text='<%# Eval("KitapAciklama") %>'></asp:Label>
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <table>
                                                        <tr style="text-align: right;">
                                                            <td>
                                                                <span class="fas fa-star" style="color: yellow"></span>
                                                                <asp:Label ID="lblTumKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                                <asp:Label ID="Label4" runat="server" Text="/ 5 "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <a class="btn btn-link" href="#yorumyap">Yorum Yap
                                                                </a>
                                                                <a class="btn btn-link" href="#yorumyap">Puan Ver
                                                                </a>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr class="ml-4">
                                                <td style="word-break: break-all;">
                                                    <table>
                                                        <tr>
                                                            <td style="text-align: ">
                                                                <table>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label6" CssClass="ml-auto" runat="server" ForeColor="Transparent" Text="..."></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:Label ID="Label3" CssClass="ml-auto" runat="server" Font-Size="10" Text=" 1 Adet "></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label7" CssClass="ml-auto" runat="server" ForeColor="Transparent" Text="..."></asp:Label></td>
                                                            <td class="auto-style2">
                                                                <asp:Label ID="lblTumKitapFiyati" runat="server" Font-Size="30" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                                <asp:Label ID="lblTumKitapFiyatTL" runat="server" Text="TL"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" ForeColor="Transparent" Text="....."></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 20px;">
                                                    <div class="navbar navbar-nav navbar-expand-md navbar-dark">
                                                        <a class="btn btn-outline-success btn-block p-3" href="User/UKitapSatinal.aspx?Kitapid=<%# Eval("Kitapid") %>&islem=0" title="SATIN AL">SATIN AL</a>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row  bg-transparent">
                <div class="navbar-nav shadow bg-transparent col-md-12 m-1 mr-4">
                    <div class="row navbar-expand-md m-1 justify-content-center" style="border: 1px solid black;">
                        <div class="row navbar-expand-md shadow m-1">
                            <div class="col-lg-12">
                                <a href="#" id="yorumyap"></a>
                                <div class="row ml-2" id="girisyapin">
                                    <div class="row col-md-8">
                                        Yorum yapmak için önce giriş yapmanız gerekiyor. Lütfen Giriş yaptıktan sonra tekrar gelin.<br />
                                        <br />
                                    </div>
                                    <div style="clear: both"></div>
                                    <div class="row col-md-6">
                                        Hesabınız varsa &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="~/Login.aspx" class="nav-item nav-link" runat="server" style="font: bold 20px arial, verdana; font-style: italic;">Girş Yapın</a>&nbsp;&nbsp;,&nbsp;&nbsp;&nbsp;&nbsp;
                                    
                                    Hesabınız yoksa &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="~/Register.aspx" class="nav-item nav-link" runat="server" style="font: bold 20px arial, verdana; font-style: italic;">Üye Olun</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
