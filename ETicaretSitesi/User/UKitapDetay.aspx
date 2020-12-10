﻿<%@ Page Title="Kitap Detayları" Language="C#" MasterPageFile="~/User/Kullanici.Master" AutoEventWireup="true" CodeBehind="UKitapDetay.aspx.cs" Inherits="ETicaretSitesi.User.UKitapDetay" %>

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
                                            <a class="bk" href="UHome.aspx" title="Anasayfa ">
                                                <asp:Label ID="Labelanasayfa" runat="server" Font-Bold="true" Font-Size="Medium" Text="Anasayfa"></asp:Label>
                                                >
                                            </a>
                                        </td>
                                        <td><a class="bk" href="UKitaplar.aspx?liste=0&sira=0" title="Kitaplar">
                                            <asp:Label ID="Labelkitaplar" runat="server" Font-Bold="true" Font-Size="Medium" Text=" Kitaplar "></asp:Label>
                                            >
                                        </a>
                                        </td>
                                        <td>
                                            <a class="bk" href="UKategoriler.aspx?kat=<%# Eval("KitapKategoriid") %> ">
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
                                                    <asp:Label ID="lblTumKitapAdi" runat="server" Font-Bold="true" Font-Size="40" Text='<%# Eval("KitapAdi") %>'></asp:Label>
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
                                                            <td>
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
                                                        <a class="btn btn-outline-success btn-block p-3" href="UKitapSatinal.aspx?Kitapid=<%# Eval("Kitapid") %>&islem=0" title="SATIN AL">SATIN AL</a>
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
    <a href="#" id="yorumyap"></a>
    <!--yorum yapma bölümü-->
    <section>
        <div class="container">
            <div class="row  bg-primary" style="border: 1px solid black;">
                <div class="navbar-nav shadow bg-transparent col-md-12 m-1 mr-4">
                    <section>
                        <table>
                            <tr>
                                <td style="width:325px;">
                                    <div class="col-md-4">
                                        <table style="border:1px solid black; min-width: 300px; min-height: 150px; background-color: white">
                                            <tr>
                                                <td>
                                                    <table style="text-align: center;">
                                                        <tr>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn0" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/bosyildiz.png" title="0" OnClick="btn0_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn01" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/yarimyildiz.png" title="0.5" OnClick="btn01_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn1" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/tamyildiz.png" title="1" OnClick="btn1_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn12" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/yarimyildiz.png" title="1.5" OnClick="btn12_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn2" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/tamyildiz.png" title="2" OnClick="btn2_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn23" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/yarimyildiz.png" title="2.5" OnClick="btn23_Click"/>
                                                                </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn3" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/tamyildiz.png" title="3" OnClick="btn3_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn34" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/yarimyildiz.png" title="3.5" OnClick="btn34_Click"/>
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgbtn4" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/tamyildiz.png" title="4" OnClick="btn4_Click"/>
                                                            </td>
                                                            <td>
                                                                 <asp:ImageButton ID="imgbtn45" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/yarimyildiz.png" title="4.5" OnClick="btn45_Click"/>
                                                            </td>
                                                            <td>
                                                                 <asp:ImageButton ID="imgbtn5" runat="server" Width="25" Height="25" ForeColor="black" BackColor="Red" ImageUrl="~/images/tamyildiz.png" title="5" OnClick="btn5_Click"/>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>0</td>
                                                            <td>0.5</td>
                                                            <td>1</td>
                                                            <td>1.5</td>
                                                            <td>2</td>
                                                            <td>2.5</td>
                                                            <td>3</td>
                                                            <td>3.5</td>
                                                            <td>4</td>
                                                            <td>4.5</td>
                                                            <td>5</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td style="text-align: center; font-size:large; align-content: center">Yukarıda bilgileri görüntülenen kitap için değerlendirmenizi yapabilirsiniz.</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                                <td style="min-width:300px;">
                                    <div class="container col-md-12">
                                        <table style="border:1px solid black; background-color:white; min-width: 400px;">
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:TextBox CssClass="form-control m-1" ID="txtyorumicerik" runat="server" BorderStyle="Solid" BorderWidth="2" BorderColor="LimeGreen" Height="135" Width="650" AutoCompleteType="Disabled" Text ="" placeholder="Yorumunuzu buraya yazınız..." TextMode="MultiLine"></asp:TextBox>
                                                            </td>
                                                            <td style="width:100px;">
                                                                <asp:Button CssClass="btn btn-success shadow mr-1" ID="btnyorumyap" runat="server" Style="width:100px; text-align: center;" title="Yorum Yap" Text="Yorum Yap" OnClick="btnyorumyap_Click" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </section>
                    <section>
                        <div class="row navbar-expand-md m-1 bg-light justify-content-center" style="border: 1px solid black; ">
                            <asp:DataList RepeatDirection="Horizontal" RepeatColumns="1" ID="DataListYorumlar" runat="server">
                                <ItemTemplate>
                                    <div class="row m-2" style="border:1px solid black; text-align: center; align-content: center; word-break: break-word;">
                                        <table class="form-signin">
                                            <tr>
                                                <td>
                                                    Yorum Yapan:&nbsp;<asp:Label ID="LabelkullaniciadiY" runat="server" Font-Bold="true" Font-Size="Large" Text='<%# Eval("adsoyad") %>'></asp:Label>
                                                </td>&nbsp;&nbsp;&nbsp;
                                                <td>
                                                    <td>
                                                        Yorum Tarihi:&nbsp;<asp:Label ID="labelyorumtarih" runat="server" Text='<%# Eval("YorumTarihi") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                            <tr>
                                                <td>
                                                    Yorum İçerik: &nbsp;<asp:Label ID="Labelkategoriad" runat="server" Text='<%# Eval("Yorumicerik") %>' Font-Bold="true" Font-Size="Medium"></asp:Label>
                                                    </a>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </section>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
