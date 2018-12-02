<%@ Page Title="Proyectos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proyectos.aspx.cs" Inherits="WEB_TLS.Proyectos" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <h1>Proyectos</h1>
</div>
<div class="row">
    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-dark"
            HeaderStyle-CssClass="thead-dark"
            >

            <Columns>
                <asp:BoundField DataField="idProyecto" HeaderText="ID" />
                <asp:BoundField DataField="nombreProyecto" HeaderText="Nombre Proyecto" />
                <asp:BoundField DataField="fechaCreacion" HeaderText="Creado" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="aliasCreador" HeaderText="Admin Proyecto" />
                <asp:TemplateField HeaderText="Activo">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbCheckBox" runat="server" Enabled="false" checked='<%# Eval("activo").ToString().Equals("True")  %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
  <div class="form-group">
    <asp:Label ID="lblIdMarca" runat="server" Text=""></asp:Label>
  </div>
  <div class="form-group">
    <label for="txtNombreProyecto">Nombre Proyecto</label>
    <asp:TextBox ID="txtNombreProyecto" class="form-control" runat="server" placeholder="Ingresar Nombre Proyecto"></asp:TextBox>
  </div>
  <div class="form-group">
    <asp:Button ID="btnConfirmar" class="btn btn-primary" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
      <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
  </div>
</asp:Content>