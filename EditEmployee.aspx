<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="CV.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <label>Editar Empleado</label>
    <br />
    <asp:TextBox ID="id" runat="server" Visible="true"></asp:TextBox>
    <br />
    <label>Tipo de Documento</label>
    <asp:DropDownList ID="documentType" runat="server" Class="form-control" DataSourceID="getDocumentType" DataTextField="DocumentType" DataValueField="Id"></asp:DropDownList>
    <asp:SqlDataSource ID="getDocumentType" runat="server" ConnectionString="<%$ ConnectionStrings:HumanResourcesConnectionString %>" SelectCommand="sp_getDocumentType" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <br />
    <label>Numero de documento</label>
    <asp:TextBox ID="documentNumber" runat="server" Class="form-control"></asp:TextBox>
    <br />
    <label>Primer Apellido</label>
    <asp:TextBox ID="surname" runat="server" Class="form-control"></asp:TextBox>
    <br />
    <label>Segundo Apellido</label>
    <asp:TextBox ID="secondSurname" runat="server" Class="form-control"></asp:TextBox>
    <br />
    <label>Nombres</label>
    <asp:TextBox ID="names" runat="server" Class="form-control"></asp:TextBox>
    <br />
    <label>Cargo del empleado</label>
    <asp:TextBox ID="jobFunction" runat="server" Class="form-control"></asp:TextBox>
    <br />
    <label>Fecha de ingreso</label>
    <asp:TextBox ID="startDate" runat="server" type="date" Class="form-control"></asp:TextBox>
    <br />
    <label>Fecha de retiro</label>
    <asp:TextBox ID="endDate" runat="server" type="date" CssClass="form-control" Class="form-control"></asp:TextBox>
    <br />
    <label>Compañia</label>
    <asp:DropDownList ID="company" runat="server" Class="form-control" DataSourceID="getCompany" DataTextField="Company" DataValueField="Id"></asp:DropDownList>
    <asp:SqlDataSource ID="getCompany" runat="server" ConnectionString="<%$ ConnectionStrings:HumanResourcesConnectionString %>" SelectCommand="sp_getCompany" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <br />
    <label>Estado</label>
    <asp:DropDownList ID="state" runat="server" Class="form-control">
        <asp:ListItem Value="1">ACTIVO</asp:ListItem>
        <asp:ListItem Value="0">INACTIVO</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="editEmployee" runat="server" Text="Guardar cambios" Class="btn btn-success" OnClick="editEmployee_Click" />
</asp:Content>
