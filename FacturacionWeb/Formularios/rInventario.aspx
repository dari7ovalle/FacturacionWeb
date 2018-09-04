<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rInventario.aspx.cs" Inherits="FacturacionWeb.Formularios.rInventario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 285px; width: 246px">
            ID<br />
            <asp:TextBox ID="InventarioIdTextBox" runat="server"></asp:TextBox>
            <br />
            ProductoId<br />
            <asp:TextBox ID="ProductoIdTextBox" runat="server" Width="185px"></asp:TextBox>
            <br />
            Cantidad<br />
            <asp:TextBox ID="CantidadTextBox" runat="server" Width="185px"></asp:TextBox>
            <br />
            Fecha<br />
            <asp:TextBox ID="FechaTextBox" runat="server" Width="192px"></asp:TextBox>
            <br />
            Nombre<br />
            <asp:TextBox ID="NombreTextBox" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar" />
&nbsp;&nbsp;
            <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" />
        </div>
    </form>
</body>
</html>
