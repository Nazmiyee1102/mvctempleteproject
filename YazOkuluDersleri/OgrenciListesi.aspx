<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th class="text-center">Öğrenci Id</th>
            <th class="text-center">Öğrenci Ad</th>
            <th class="text-center">Öğrenci Soyad</th>
            <th class="text-center">Öğrenci Numara</th>
            <th class="text-center">Öğrenci Şifre</th>
            <th class="text-center">Öğrenci Fotoğraf</th>
            <th class="text-center">Öğrenci Bakiye</th>
            <th class="text-center">İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("AD")%></td>
                        <td><%#Eval("SOYAD")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("SIFRE")%></td>
                        <td><%#Eval("Fotograf")%></td>
                        <td><%#Eval("BAKIYE")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?Ogrid=" + Eval("ID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?Ogrid=" + Eval("ID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-primary">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

