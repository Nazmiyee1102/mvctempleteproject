<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <strong>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin" style="font-size: 18pt"></asp:Label>
            </strong>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <strong>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID" style="font-size: 18pt" ></asp:Label>
            </strong>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click"/>
    </form>
</asp:Content>

