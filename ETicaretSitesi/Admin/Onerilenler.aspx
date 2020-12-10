<%@ Page Title="Önerilen Kitaplar" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Onerilenler.aspx.cs" Inherits="ETicaretSitesi.Admin.Onerilenler" %>

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
                    <asp:DataList RepeatDirection="Horizontal" RepeatColumns="3" ID="DataListoner" runat="server">
                        <ItemTemplate>
                            <div class="row m-2 shadow" style="text-align: center; align-content: center; word-break: break-word;">
                                <table class="form-signin">
                                    <tr>
                                        <td style="text-align: right;">Kitap ID:</td>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Font-Bold="true" Text='<%# Eval("OKitapid") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitabın Adı:</td>
                                        <td>
                                            <asp:Label ID="lblKitapAdi" runat="server" Font-Bold="true" Text='<%# Eval("OKitapAdi") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitapın Açıklaması:</td>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Font-Bold="true" Text='<%# Eval("OKitapAciklama") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitap Fiyat:</td>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Font-Bold="true" Text='<%# Eval("OKitapFiyat") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Resim Yolu:</td>
                                        <td class="mt-2">
                                            <asp:Label ID="Label4" runat="server" Font-Bold="true" Text='<%# Eval("OKitapResim") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitap Kategorisi:</td>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" Font-Bold="true" Text='<%# Eval("OKitapKategoriAdi") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitap Yazarı:</td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" Font-Bold="true" Text='<%# Eval("OKitapYazarAdi") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">Kitap Yayınevi:</td>
                                        <td>
                                            <asp:Label ID="Label7" runat="server" Font-Bold="true" Text='<%# Eval("OKitapYayineviAdi") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right;">
                                            <asp:Label ID="Label8" runat="server" ForeColor="Transparent" Text=""></asp:Label></td>
                                        <td>
                                            <a class="bk btn btn-success" href="OnerilenOnayla.aspx?Kitid=<%# Eval("OKitapid") %>" title="Kontrol Et">
                                                <asp:Label ID="lblKitapAdi2" runat="server" Font-Bold="true" Font-Size="11" Text="Kontrol Et"></asp:Label></a></td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
