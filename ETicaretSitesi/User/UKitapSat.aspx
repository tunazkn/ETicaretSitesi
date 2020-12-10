<%@ Page Title="" Language="C#" MasterPageFile="~/User/Kullanici.Master" AutoEventWireup="true" CodeBehind="UKitapSat.aspx.cs" Inherits="ETicaretSitesi.User.UKitapSat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <!-- kitabın karetorilerie giden yol-->
        <div class="container" style="z-index:1;">
            <div class="row shadow" style="z-index:1;">
                <div class="row navbar-expand-md m-1 justify-content-center col-md-12" style="border: 2px solid black; z-index:1;">
                    <div class="navbar-nav shadow col-md-5 m-2 py-2">
                        <table class="form-signin">
                            <tr>
                                <td style="text-align: right;">Kitabın Adı:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapadi" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın adı"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitapın Açıklaması:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapacıklama" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın açıklaması" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" ForeColor="Transparent" Text="."></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitapın Resmi:</td>
                                <td class="mt-2">
                                    <asp:FileUpload class="mt-2" ID="FileUpload1" runat="server" Width="250px" CssClass="tb5" /></td>
                            </tr>
                        </table>
                    </div>
                    <div class="navbar-nav shadow col-md-5 m-2 py-2">
                        <table class="form-signin">
                            <tr>
                                <td style="text-align: right;">Kitapın Fiyatı:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapfiyat" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın fiyatı"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitapın Kategorisi:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapkategori" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın kategorisi"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitabın Yazarı:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-1" ID="txtSatkitapyazar" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın yazarı"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitabın Yayınevi:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapyayınevi" runat="server" AutoCompleteType="Disabled" placeholder="Kitabın yayınevi"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" ForeColor="Transparent" Text="."></asp:Label>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" ForeColor="Transparent" Text="."></asp:Label>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" ForeColor="Transparent" Text="."></asp:Label>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" ForeColor="Transparent" Text="."></asp:Label>

                                </td>
                                <td>
                                    <asp:Button CssClass="btn btn-success btn-block text-uppercase" ID="btnUkitapgonder" runat="server" Text="GÖNDER" OnClick="btnUkitapgonder_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
