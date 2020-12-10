<%@ Page Title="Önerilen Onayla" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OnerilenOnayla.aspx.cs" Inherits="ETicaretSitesi.Admin.OnerilenOnayla" %>

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
        <div class="container">
            <div class="row shadow">
                <div class="row navbar-expand-md m-1 justify-content-center col-md-12" style="border: 2px solid black;">
                    <div class="navbar-nav shadow col-md-5 m-2 py-2">
                        <table class="form-signin">
                            <tr>
                                <td style="text-align: right;">Kitap ID:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtSatkitapid" runat="server" AutoCompleteType="Disabled" ReadOnly="true"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitabın Adı:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtsatkitapadi" runat="server" AutoCompleteType="Disabled" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitapın Açıklaması:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtsatkitapaciklama" runat="server" AutoCompleteType="Disabled"  ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Resim Yolu:</td>
                                <td class="mt-2">
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtkitapsatresimyolu" runat="server" AutoCompleteType="Disabled"  ></asp:TextBox>
                                </td>
                            </tr>
                        </table>

                    </div>
                    <div class="navbar-nav shadow col-md-5 m-2 py-2">
                        <table class="form-signin">
                            <tr>
                                <td style="text-align: right;">Kitap Fiyat:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtkitapsatfiyat" runat="server" AutoCompleteType="Disabled" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitap Kategorisi:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtkitapsatkategori" runat="server" AutoCompleteType="Disabled" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitap Yazarı:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtkitapsatyazar" runat="server" AutoCompleteType="Disabled" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right;">Kitap Yayınevi:</td>
                                <td>
                                    <asp:TextBox CssClass="form-control mt-2" ID="txtkitapsatyayınev" runat="server" AutoCompleteType="Disabled"  ></asp:TextBox>
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
                                <td style="text-align: right;">
                                    <asp:Label ID="Label8" runat="server" ForeColor="Transparent" Text=""></asp:Label>
                                </td>
                                <td>
                                    <asp:Button CssClass="btn btn-success btn-block text-uppercase" ID="btnUkitaponayla" runat="server" Text="ONAYLA" OnClick="btnUkitaponayla_Click"/>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
