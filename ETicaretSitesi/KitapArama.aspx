<%@ Page Title="Arama Sonuçları" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KitapArama.aspx.cs" Inherits="ETicaretSitesi.KitapArama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .labeltxtdropSize {
            font-size: 16px;
            Width: 150px;
            Height: 25px;
        }

        .labeldetailsize {
            width: 215px;
        }

        .divSize {
            font-size: 16px;
        }

        .Cercevelbltxt {
            border: 1px solid #a1a1a1;
            padding: 1px 1px 1px 1px;
            Width: 150px;
            Height: 30px;
            border-radius: 7px;
            margin: 1px;
            float: left;
        }

        .cercevecevre {
            border: 2px solid #a1a1a1;
            padding: 5px 2px 5px 2px;
            background: green;
            width: 13%;
            height: 500px;
            border-radius: 20px;
            color: white;
            margin: 5px;
            float: left;
        }

        .filtercerceve {
            border: 2px solid #a1a1a1;
            padding: 5px 2px 5px 2px;
            border-radius: 20px;
            color: white;
            margin: 5px;
            float: left;
        }

        .cerceve {
            margin: 5px;
            width: 2%;
            border: 2px solid #a1a1a1;
            padding: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-primary">
        <div class="row shadow p-2 mx-2">
            <!-- kitaplar solda filtrenin oldugu kısım, bası-->
            <div class="navbar-nav filtercerceve bg-secondary shadow col-md-2 m-2">
                <div style="float: left; margin: 1px; width: 210px; height: auto; background-color: transparent; word-break: break-word;">
                    <div class="row px-4">
                        <asp:Label CssClass="float-left labeltxtdropSize ml-3 mt-1 mb-1" ID="lblSearchSabit" runat="server" Text="Filter" Font-Bold="true" Font-Size="X-Large" Font-Italic="true"></asp:Label>
                        <br />
                        <table id="Table1" runat="server" class="m-2" cellpadding="6" horizontalalign="left">
                            <tr>
                                <td class="auto-style3" style="text-align: center;">
                                    <div class="labeltxtdropSize Cercevelbltxt" style="float: left; text-align: left; background-color: grey;">
                                        <asp:Label CssClass="float-left labeltxtdropSize shadow ml-1 " ID="lblMainGroup" runat="server" Text="Kitap"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3 pb-2">
                                    <asp:DropDownList CssClass="labeltxtdropSize Cercevelbltxt shadow" ID="DropDownMainGroup" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem Value="Null">--Select--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <div class="labeltxtdropSize Cercevelbltxt" style="float: left; text-align: left; background-color: grey;">
                                        <asp:Label CssClass="float-left labeltxtdropSize shadow ml-1" ID="lblSeries" runat="server" Text="Yazar"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3 pb-2">
                                    <asp:DropDownList CssClass="labeltxtdropSize Cercevelbltxt shadow" ID="DropDownSeries" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem Value="Null">--Select--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <div class="labeltxtdropSize Cercevelbltxt" style="float: left; text-align: left; background-color: grey;">
                                        <asp:Label CssClass="float-left labeltxtdropSize ml-1 shadow" ID="lblBrand" runat="server" Text="Kategori"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3 pb-2">
                                    <asp:DropDownList CssClass="labeltxtdropSize Cercevelbltxt shadow" ID="DropDownBrand" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem Value="Null">--Select--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <div class="labeltxtdropSize Cercevelbltxt" style="float: left; text-align: left; background-color: grey;">
                                        <asp:Label CssClass="float-left labeltxtdropSize ml-1 shadow" ID="lblQuality" runat="server" Text="Yayınevi"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:DropDownList CssClass="labeltxtdropSize Cercevelbltxt shadow" ID="DropDownQuality" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem Value="Null">--Select--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblProductFilterWarning" runat="server" Text="Warning" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <div class="ml-1">
                            <asp:Button CssClass="btncerceve shadow" ID="btnFilterProduct" runat="server" Style="width: 155px; text-align: center; background-color: dimgray" Text="Apply" />
                        </div>
                    </div>
                </div>
            </div>
            <!-- kitaplar solda filtrenin oldugu kısım, sonu-->

            <!-- kitaplar sağda kitapların listelendiği kısım, bası-->
            <div class="navbar-nav col-md-9 m-1">
                <div class="navbar navbar-expand-md navbar-dark mx-1 bg-light">
                    <div class="row shadow px-1" style="border: 1px solid black; float: left; word-break: break-all;">
                        <div class="container">
                            <div class="p-1 mr-auto golgeliKutu">
                                <asp:Label ID="lblArananKitaplarListesi" runat="server" Style="font-size: x-large; color: black;" Text="Kitapların Listesi"></asp:Label>
                            </div>
                            <div class="ml-auto">
                                <div class="container">
                                    <div class="p-1 ml-auto" style="float: right;">
                                        <asp:Label ID="lblAramaKitaplar" runat="server" Text="Kitapların Listesi"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row navbar-expand-md shadow m-2">
                            <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="4" ID="DataListArananKitaplar" runat="server">
                                <ItemTemplate>
                                    <div class="card m-3 shadow" style="width: 195px; height: 320px; text-align: center; align-content: center; word-break: break-word;">
                                        <div>
                                            <a href="KitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="width: 160px; height: 130px;" runat="server"/>
                                            </a><!--<a href="Kategoriler.aspx?Kategoriid=# Eval("Kategoriid") %>&islem=sil">-->
                                        </div>
                                        <div class="card-body" style="word-break: break-word;">
                                            <div class="collapse navbar-collapse bg-transparent" id="anaMenu">
                                                <table class="form-signin">
                                                    <tr>
                                                        <td>
                                                            <a class="bk" href="KitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title='<%# Eval("KitapAdi") %>'>
                                                                <asp:Label ID="lblAramaKitaplarKitapAdi" runat="server" Font-Bold="true" Font-Size="11" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                                            </a>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lblAramaKitaplarYazarAdi" runat="server" Font-Size="10" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lblAramaKitaplarKategoriAdi" runat="server" Font-Size="10" Text='<%# Eval("KategoriAdi") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lblAramaKitaplarKitapFiyati" runat="server" Font-Size="11" Text='<%# Eval("KitapFiyat") %>'></asp:Label>
                                                            <asp:Label ID="lblAramaKitaplarKitapFiyatTL" runat="server" Font-Size="11" Text="TL"></asp:Label>
                                                            | <span class="fas fa-star" style="color: yellow"></span>
                                                            <asp:Label ID="lblAramaKitaplarKitapPuani" runat="server" Text='<%# Eval("KitapOrtalamaPuani") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                        <table class="form-signin mt-1 mb-1">
                                            <tr>
                                                <td>
                                                    <div>
                                                        <a class="btn btn-primary p-1" href="KitapDetay.aspx?Kitapid=<%# Eval("Kitapid") %>" title="Detaylar">Detaylar</a>
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
            <!-- kitaplar sağda kitapların listelendiği kısım, sonu-->
        </div>
    </div>
</asp:Content>