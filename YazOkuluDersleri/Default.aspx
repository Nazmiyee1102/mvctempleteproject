<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                <asp:Label for="txt_ad" runat="server" Text="Öğrenci Adı: "></asp:Label>
                </strong>
                <asp:TextBox ID="txt_ad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                &nbsp
            </div>
            <div>
                <strong>
                <asp:Label for="txt_soyad" runat="server" Text="Öğrenci Soyadı: "></asp:Label>
                </strong>
                <asp:TextBox ID="txt_soyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                &nbsp
            </div>
            <div>
                <strong>
                <asp:Label for="txt_numara" runat="server" Text="Öğrenci Numarası: "></asp:Label>
                </strong>
                <asp:TextBox ID="txt_numara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                &nbsp
            </div>
            <div>
                <strong>
                <asp:Label for="txt_sifre" runat="server" Text="Öğrenci Şifre: "></asp:Label>
                </strong>
                <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                &nbsp
            </div>
            <div>
                <strong>
                <asp:Label for="txt_foto" runat="server" Text="Öğrenci Fotoğraf: "></asp:Label>
                </strong>
                <asp:TextBox ID="txt_foto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <strong>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-primary" style="font-weight: bold"/>
        </strong>
    </form>
</asp:Content>

