<%@ Page Language="C#" Title="Participantes" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Participantes.aspx.cs" Inherits="WEB_TLS.Participantes" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1>Proyectos</h1>
    </div>
    <div class="row">
        <div class="table-responsive">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-dark"
                HeaderStyle-CssClass="thead-dark" OnSelectedIndexChanging="GridView1_SelectedIndexChanging"
                >

                <Columns>
                    <asp:ButtonField DataTextField="idProyecto" CommandName="Select" ItemStyle-Width="30"  />
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
    <asp:Panel ID="Panel1" Visible="false" runat="server">
        <asp:Label ID="lblIdProyecto" Visible="false" runat="server" ></asp:Label>
        <div class="row">
            <div class="form-group">
                <label class="col-md-4" for="txtParticipantes">Participantes</label>
                <asp:DropDownList ID="cbParticipantes" class="form-control col-md-8" runat="server" >

                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="form-group">
                <label class="col-md-4" for="chkAdmin">Administrador</label>
                <asp:CheckBox ID="chkAdmin" runat="server" CssClass="form-check-input col-md-8" />
            </div>
        </div>
        <div class="row">
            <div class="form-group">
                <asp:Button ID="btnConfirmar" class="btn btn-primary" runat="server" Text="Asignar" OnClick="btnConfirmar_Click" />
                <br />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </asp:Panel>
</asp:Content>