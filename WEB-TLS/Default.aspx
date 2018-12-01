<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_TLS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Bienvenido! <asp:Label ID="lblUsuarioConectado" runat="server" Text=""></asp:Label></h1>
        <p class="lead">La Consultora Administradora Todos Los Santos, es una entidad dedicada al desarrollo de proyectos de toda índole informática. En la actualidad gestiona sus proyectos mediante planillas Excel, por lo que lo ha contratado para desarrollar un prototipo simple de administrador de proyectos. Este consiste en una aplicación desarrolla en .Net la cual mediante la exposición de un servicio web, donde los usuarios registrados, puedan crear proyectos, listarlos y agregar participantes.</p>
    </div>

</asp:Content>
