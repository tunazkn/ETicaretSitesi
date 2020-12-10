<%@ Page Title="Anasayfa | Kullanıcı" Language="C#" MasterPageFile="~/User/Kullanici.Master" AutoEventWireup="true" CodeBehind="UHome.aspx.cs" Inherits="ETicaretSitesi.User.UHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .shadow {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        }

        .golgeliKutu {
            box-shadow: 0px 0px 15px #c2c2c2;
            width: 200px;
            padding: 5px;
            font: 12px Arial, Helvetica, sans-serif;
        }

        .golgeliKutu2 {
            box-shadow: 0px 0px 15px #c2c2c2;
            width: 300px;
            padding: 5px;
            font: 12px Arial, Helvetica, sans-serif;
        }
    </style>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--Javascipts-->
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js" defer></script>
    <script src="bootstrap/js/solid.min.js" defer></script>
    <script src="bootstrap/js/fontawesome.min.js" defer></script>
    <!--CSS-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="bootstrap/css/fontawesome.min.css" rel="stylesheet" />
    <link href="bootstrap/css/solid.min.css" rel="stylesheet" />
    <!--<link href="bootstrap/css/style.css" rel="stylesheet" />-->
    <!--<link href="Styles.css" rel="stylesheet" />-->
    <link href="Styles2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container navbar navbar-expand-md navbar-dark bg-transparent" style="z-index:5;">
        <div class="row bg-light" style="z-index:5;">
            <!--veri puani yüksek olanlar listelenen card divi üstte, bası-->
            <div class="navbar navbar-expand-md navbar-dark mx-1 bg-light" style="z-index:5;">
                <div class="row shadow px-1" style="border: 1px solid black; float: left; word-break: break-all;" style="z-index:5;">
                    <div class="container bg-light" style="z-index:5;">
                        <div class="p-1 mr-auto golgeliKutu2">
                            <asp:Label ID="LblYuksekPuanli" runat="server" Style="font-size: x-large; color: black;" Text="Puanı Yüksek Olanlar"></asp:Label>
                        </div>
                        <div class="ml-auto">
                            <div class="container">
                                <div class="p-1 ml-auto" style="float: right;">
                                    <asp:LinkButton CssClass="page-link shadow" ID="LinkbtnYuksekPuanli" runat="server" Text="Tümünü Göster >>" Font-Bold="true"   />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row navbar-expand-md shadow m-2" style="z-index:5;">
                        <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="5" ID="DataListYuksekPuanli" runat="server">
                            <ItemTemplate>
                                <div class="card m-3 shadow" style="width: 190px; height: 320px; text-align: center; align-content: center; word-break: break-word;">
                                    <div>
                                        <a href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                            <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="width: 160px; height: 130px;" runat="server" />
                                        </a>
                                    </div>
                                    <div class="card-body" style="word-break: break-word;">
                                        <div class="collapse navbar-collapse bg-transparent" id="anaMenu">
                                            <table class="form-signin">
                                                <tr>
                                                    <td>
                                                        <a class="bk" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                            <asp:Label ID="lblYuksekPuanKitapAdi" runat="server" Font-Bold="true" Font-Size="11" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                                        </a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblYuksekPuanliYazarAdi" runat="server" Font-Size="10" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblYuksekPuanliYayineviAdi" runat="server" Font-Size="10" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblYuksekPuanliKitapFiyati" runat="server" Font-Size="11" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                        <asp:Label ID="lblYuksekKitapFiyatTL" runat="server" Font-Size="11" Text="TL"></asp:Label>
                                                        | <span class="fas fa-star" style="color: yellow"></span>
                                                        <asp:Label ID="lblYuksekPuanliKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <table class="form-signin mt-1 mb-1">
                                        <tr>
                                            <td>
                                                <div>
                                                    <a class="btn btn-primary p-1" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title="Detaylar">Detaylar</a>
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
            <!--veri puani yüksek olanlar listelenen card divi üstte, sonu-->
            <br />
            <!--veri son eklenenler listelenen card divi üstten 2., bası-->
            <div class="navbar navbar-expand-md navbar-dark mx-1 bg-light">
                <div class="row shadow px-1" style="border: 1px solid black; float: left; word-break: break-all;">
                    <div class="container bg-light">
                        <div class="p-1 mr-auto golgeliKutu">
                            <asp:Label ID="LblSonEklenenler" runat="server" Style="font-size: x-large; color: black;" Text="Son Eklenenler"></asp:Label>
                        </div>
                        <div class="ml-auto">
                            <div class="container">
                                <div class="p-1 ml-auto" style="float: right;">
                                    <asp:LinkButton CssClass="page-link shadow" ID="LinkbtnSonEklenenlerTumu" runat="server" Text="Tümünü Göster >>" Font-Bold="true"  />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row navbar-expand-md shadow m-2">
                        <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="5" ID="DataListSonEklenen" runat="server">
                            <ItemTemplate>
                                <div class="card m-3 shadow" style="width: 190px; height: 320px; text-align: center; align-content: center; word-break: break-word;">
                                    <div>
                                        <a href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                            <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="width: 160px; height: 130px;" runat="server" />
                                        </a>
                                    </div>
                                    <div class="card-body" style="word-break: break-word;">
                                        <div class="collapse navbar-collapse bg-transparent" id="anaMenu">
                                            <table class="form-signin">
                                                <tr>
                                                    <td>
                                                        <a class="bk" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                            <asp:Label ID="lblSonKitapAdi" runat="server" Font-Bold="true" Font-Size="11" Text='<%# Eval("KitapAdi") %>'></asp:Label></a></td>

                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblSonYazarAdi" runat="server" Font-Size="10" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblSonYayineviAdi" runat="server" Font-Size="10" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblSonKitapFiyati" runat="server" Font-Size="11" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                        <asp:Label ID="lblSonKitapFiyatTL" runat="server" Font-Size="11" Text="TL"></asp:Label>
                                                        | <span class="fas fa-star" style="color: yellow"></span>
                                                        <asp:Label ID="lblSonKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <table class="form-signin mt-1 mb-1">
                                        <tr>
                                            <td>
                                                <div>
                                                    <a class="btn btn-primary p-1" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title="Detaylar">Detaylar</a>
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
            <!--veri son eklenenler listelenen card divi üstten 2., sonu-->
            <br />
            <!--veri puani düşük olanlar listelenen card divi alttan 2., bası-->
            <div class="navbar navbar-expand-md navbar-dark mx-1 bg-light">
                <div class="row shadow px-1" style="border: 1px solid black; float: left; word-break: break-all;">
                    <div class="container bg-light">
                        <div class="p-1 mr-auto golgeliKutu2">
                            <asp:Label ID="LblDusukPuanli" runat="server" Style="font-size: x-large; color: black;" Text="Puanı Düşük Olanlar"></asp:Label>
                        </div>
                        <div class="ml-auto">
                            <div class="container">
                                <div class="p-1 ml-auto" style="float: right;">
                                    <asp:LinkButton CssClass="page-link shadow" ID="LinkbtnDusukPuanli" runat="server" Text="Tümünü Göster >>" Font-Bold="true" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row navbar-expand-md shadow m-2">
                        <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="5" ID="DataListDusukPuanli" runat="server">
                            <ItemTemplate>
                                <div class="card m-3 shadow" style="width: 190px; height: 320px; text-align: center; align-content: center; word-break: break-word;">
                                    <div>
                                        <a href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                            <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="width: 160px; height: 130px;" runat="server" />
                                        </a>
                                    </div>
                                    <div class="card-body" style="word-break: break-word;">
                                        <div class="collapse navbar-collapse bg-transparent" id="anaMenu">
                                            <table class="form-signin">
                                                <tr>
                                                    <td>
                                                        <a class="bk" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                            <asp:Label ID="lblDusukPuanKitapAdi" runat="server" Font-Bold="true" Font-Size="11" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                                        </a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblDusukPuanliYazarAdi" runat="server" Font-Size="10" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblDusukPuanliYayineviAdi" runat="server" Font-Size="10" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblDusukPuanliKitapFiyati" runat="server" Font-Size="11" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                        <asp:Label ID="lblDusukPuanliKitapFiyatTL" runat="server" Font-Size="11" Text="TL"></asp:Label>
                                                        | <span class="fas fa-star" style="color: yellow"></span>
                                                        <asp:Label ID="lblDusukPuanliKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <table class="form-signin mt-1 mb-1">
                                        <tr>
                                            <td>
                                                <div>
                                                    <a class="btn btn-primary p-1" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title="Detaylar">Detaylar</a>
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
            <!--veri puani düşük olanlar listelenen card divi alttan 2., sonu-->
            <br />
            <!--veri ilk eklenenler listelenen card divi altta, bası-->
            <div class="navbar navbar-expand-md navbar-dark mx-1 bg-light">
                <div class="row shadow px-1" style="border: 1px solid black; float: left; word-break: break-all;">
                    <div class="container bg-light">
                        <div class="p-1 mr-auto golgeliKutu">
                            <asp:Label ID="LblilkEklenenler" runat="server" Style="font-size: x-large; color: black;" Text="İlk Eklenenler"></asp:Label>
                        </div>
                        <div class="ml-auto">
                            <div class="container">
                                <div class="p-1 ml-auto" style="float: right;">
                                    <asp:LinkButton CssClass="page-link shadow" ID="LinkbtnilkEklenenlerTumu" runat="server" Text="Tümünü Göster >>" Font-Bold="true"  />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row navbar-expand-md shadow m-2">
                        <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="5" ID="DataListilkEklenen" runat="server">
                            <ItemTemplate>
                                <div class="card m-3 shadow" style="width: 190px; height: 320px; text-align: center; align-content: center; word-break: break-word;">
                                    <div>
                                        <a href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                            <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="width: 160px; height: 130px;" runat="server" />
                                        </a>
                                    </div>
                                    <div class="card-body" style="word-break: break-word;">
                                        <div class="collapse navbar-collapse bg-transparent" id="anaMenu">
                                            <table class="form-signin">
                                                <tr>
                                                    <td>
                                                        <a class="bk" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                            <asp:Label ID="lblilkKitapAdi" runat="server" Font-Bold="true" Font-Size="11" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                                        </a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblilkYazarAdi" runat="server" Font-Size="10" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblilkYayineviAdi" runat="server" Font-Size="10" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblilkKitapFiyati" runat="server" Font-Size="11" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                        <asp:Label ID="lblilkKitapFiyatTL" runat="server" Font-Size="11" Text="TL"></asp:Label>
                                                        | <span class="fas fa-star" style="color: yellow"></span>
                                                        <asp:Label ID="lblilkKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <table class="form-signin mt-1 mb-1">
                                        <tr>
                                            <td>
                                                <div>
                                                    <a class="btn btn-primary p-1" href="UKitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title="Detaylar">Detaylar</a>
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
            <!--veri ilk eklenenler listelenen card divi altta, sonu-->

            <!--2 veri arasındaki boşluk alttakiyle saglanıyordu, bası--
            <div class="nav bg-light ml-auto mr-auto" style="width: 900px; height: 5px;">
                <asp:Label ID="Label4d" runat="server" Text="." ForeColor="White"></asp:Label>
            </div>
            <!--2 veri arasındaki boşluk alttakiyle saglanıyordu, sonu-->
        </div>
    </div>
</asp:Content>
