<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TipoProducto.aspx.cs" Inherits="FacturacionWeb.Formularios.TipoProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 233px; height: 227px">
            ID<br />
            <asp:TextBox ID="TipoProductoIdTextbox" runat="server" Width="140px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="BuscarButton" runat="server" Text="Buscar" />
            <br />
            Nombres<br />
            <asp:TextBox ID="NombresTextBox" runat="server" Width="188px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="EliminarButton" runat="server" style="height: 26px" Text="Eliminar" />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
