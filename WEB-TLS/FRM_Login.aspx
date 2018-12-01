<%@ Page Title="TLS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FRM_Login.aspx.cs" Inherits="WEB_TLS.FRM_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" align="center">
        <h3>Login</h3>
    </div>
    <div class="row" align="center">
        <div class="col-md-12 center">
            <asp:Label runat="server" CssClass="form-label" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:Label runat="server" CssClass="form-label" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtClave" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnIngresar" CssClass="form-control" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
		</div>
	</div>
</asp:Content>

