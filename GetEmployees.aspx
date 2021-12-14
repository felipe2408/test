<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetEmployees.aspx.cs" Inherits="CV.GetEmployees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Empleados</h1>
    <div>
         <h3>Buscar Empleado</h3>
        <div class="form-group">
            <select class="form-control" id="options" name="options">
                <option value="1">Número de documento</option>
                <option value="2">Primer Apellido</option>
                <option value="3">Segundo Apellido</option>
                <option value="4">Nombres</option>
            </select>
        </div>
        <div class="form-group">
            <input  type="text"  placeholder="Introduce tu dato de búsqueda" id="information" name="information" class="form-control"/>
        </div>
        <input type="button" class="btn btn-info" onclick="search()" value="Buscar" />
    </div>
    <br />
    <asp:GridView ID="employeesTable" Class="table table-bordered table-condensed table-responsive table-hover" runat="server"  DataKeyNames="Id" OnSelectedIndexChanged="employeesTable_SelectedIndexChanged" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="getEmployee">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="true" />
            <asp:BoundField DataField="Tipo de Documento" HeaderText="Tipo de Documento" SortExpression="Tipo de Documento" />
            <asp:BoundField DataField="Numero de Documento" HeaderText="Numero de Documento" SortExpression="Numero de Documento" />
            <asp:BoundField DataField="Primer Apellido" HeaderText="Primer Apellido" SortExpression="Primer Apellido" />
            <asp:BoundField DataField="Segundo Apellido" HeaderText="Segundo Apellido" SortExpression="Segundo Apellido" />
            <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
            <asp:BoundField DataField="Cargo Empleado" HeaderText="Cargo Empleado" SortExpression="Cargo Empleado" />
            <asp:BoundField DataField="Fecha de Ingresp" HeaderText="Fecha de Ingresp" SortExpression="Fecha de Ingresp" />
            <asp:BoundField DataField="Fecha de Retiro" HeaderText="Fecha de Retiro" SortExpression="Fecha de Retiro" />
            <asp:BoundField DataField="Compañia" HeaderText="Compañia" SortExpression="Compañia" />
            <asp:CheckBoxField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
           
    </asp:GridView>
     <asp:SqlDataSource ID="getEmployee" runat="server" ConnectionString="<%$ ConnectionStrings:HumanResourcesConnectionString %>" SelectCommand="sp_getEmployee" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
     <asp:ScriptManagerProxy runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/CV/SearchEmployee.js" />
        </Scripts>
    </asp:ScriptManagerProxy>
    
</asp:Content>
 
