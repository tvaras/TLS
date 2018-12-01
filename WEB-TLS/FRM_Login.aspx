<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRM_Login.aspx.cs" Inherits="WEB_TLS.FRM_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <h1>Login simple</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
     </div>
        <div>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    </div>
        <div>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
        </div>
    </form>
</body>
</html>
