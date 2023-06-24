<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersler.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>ÖĞRENCİ ID</th>
            <th>ÖĞRENCİ Ad</th>
            <th>ÖĞRENCİ Soyad</th>
            <th>ÖĞRENCİ Numara</th>
            <th>ÖĞRENCİ Fotograf</th>
            <th>ÖĞRENCİ Sifre</th>            
            <th>ÖĞRENCİ Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRID")%></td>
                        <td><%#Eval("AD")%></td>
                        <td><%#Eval("SOYAD")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("FOTOGRAF")%></td>
                        <td><%#Eval("SİFRE")%></td>
                        <td><%#Eval("BAKİYE")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.Aspx?OGRID=" + Eval("OGRID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.Aspx?OGRID=" + Eval("OGRID")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
