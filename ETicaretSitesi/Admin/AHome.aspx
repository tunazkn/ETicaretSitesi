<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AHome.aspx.cs" Inherits="ETicaretSitesi.Admin.AHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 150px; width: 700px; margin-left: 300px; background-color: #ce7171;">
        <asp:Image ID="Image1" runat="server" Height="149px" ImageUrl="~/images/login-banner.png" Width="699px" />
    </div>
    <br />
    <br />
    <div class="justify-content-center text-center">
        <asp:Label ID="Label1" runat="server" ForeColor="Black" Font-Bold="true" Font-Size="30" Text="Admin Sayfasına Hoş Geldiniz..."></asp:Label>
        
    </div>
</asp:Content>
