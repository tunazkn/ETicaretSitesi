<%@ Page Title="Sipariş Kodu" Language="C#" MasterPageFile="~/User/Kullanici.Master" AutoEventWireup="true" CodeBehind="UKitapSatinOnayla.aspx.cs" Inherits="ETicaretSitesi.User.UKitapSatinOnayla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <!-- kitabın karetorilerie giden yol-->
        <div class="container">
            <div class="row">
                <div class="row navbar-expand-md shadow m-2">
                    <asp:Label ID="LabelSiparisKodu" runat="server" Font-Bold="true" ForeColor="Red" Font-Size="XX-Large" Text="."></asp:Label>
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
                            <asp:DataList RepeatDirection="Horizontal" RepeatColumns="1" ID="DataListKitapResimonay" runat="server">
                                <ItemTemplate>
                                    <div class="row m-1" style="text-align: center; align-content: center; word-break: break-word;">
                                        <img class="card-img-top" src='<%# Eval("KitapResim") %>' alt="Card image" style="max-width: 280px; max-height: 300px;" runat="server" />
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
                <div class="navbar-nav shadow bg-transparent col-md-6 m-1">
                    <div class=" container-fluid navbar-expand-md m-1 justify-content-center bg-light" style="border: 1px solid black;">
                        <div class="row navbar-expand-md shadow bg-danger" style="width: 550px;">
                            <asp:DataList CssClass="shadow" RepeatDirection="Horizontal" RepeatColumns="4" ID="DataListKitapDetayonay" runat="server">
                                <ItemTemplate>
                                    <div class="card bg-light shadow m-1" style="min-height: 400px; width: 535px; word-break: break-word;">
                                        <table class="form-signin ml-2 bg-transparent">
                                            <tr>
                                                <td style="word-break: break-word;">
                                                    <asp:Label ID="lblTumKitapAdi" runat="server" Font-Bold="true" Font-Size="30" Text='<%# Eval("KitapAdi") %>'></asp:Label>
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <asp:Label ID="Label1" runat="server" Font-Size="13" Text="Yazar: "></asp:Label>
                                                    <a class="bk" href="UYazarlar.aspx?yaz=<%# Eval("KitapYazarid") %>">
                                                        <asp:Label ID="lblTumYazarAdi" runat="server" Font-Bold="true" Font-Size="15" Text='<%# Eval("YazarAdiSoyadi") %>'></asp:Label>
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="word-break: break-all; height: 35px;">
                                                    <asp:Label ID="Label2" runat="server" Font-Size="13" Text="Yayınevi: "></asp:Label>
                                                    <a class="bk" href="UYayinevleri.aspx?yev=<%# Eval("KitapYayineviid") %>">
                                                        <asp:Label ID="lblTumYayineviAdi" runat="server" Font-Bold="true" Font-Size="15" Text='<%# Eval("YayineviAdi") %>'></asp:Label>
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
                                                        <a class="btn btn-outline-success btn-block p-3" href="UKitapSatinOnayla.aspx?Kitapid=<%# Eval("Kitapid") %>&islem=1" title="ONAYLA">ONAYLA</a>
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
</asp:Content>
