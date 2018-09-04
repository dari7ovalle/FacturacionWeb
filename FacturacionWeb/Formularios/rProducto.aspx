<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rProducto.aspx.cs" Inherits="FacturacionWeb.Formularios.rProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 326px; width: 783px">
            ID<br />
            <asp:TextBox ID="ProductoIdTextBox" runat="server"></asp:TextBox>
            <br />
            Nombre<br />
            <asp:TextBox ID="NombreTextBox" runat="server" Width="249px"></asp:TextBox> 
         <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red"runat="server" ErrorMessage="El Nombre es un campo requerido" ControlToValidate="NombreTextBox"></asp:RequiredFieldValidator>
            <br />
            TipoProductoId<br />
            <asp:DropDownList ID="TipoProductoIdDropDownList" runat="server">
            </asp:DropDownList> <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"ForeColor="Red" runat="server" ErrorMessage="El TipoProducto es un campo requerido" ControlToValidate="TipoProductoIdDropDownList"></asp:RequiredFieldValidator>
            <br />
            Costo<br />
            <asp:TextBox ID="CostoTextBox" runat="server" Width="265px"></asp:TextBox> <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red"runat="server" ErrorMessage="El Costo es un campo requerido" ControlToValidate="CostoTextBox"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="CostoTextBox" ErrorMessage="* Solo valores numerico" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            <br />
            Precio<br />
            <asp:TextBox ID="PrecioTextBox" runat="server" Width="267px"></asp:TextBox> <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ErrorMessage="El Precio es un campo requerido" ControlToValidate="PrecioTextBox"></asp:RequiredFieldValidator>
            <br />
            Activo<br />
            <asp:TextBox ID="ActivoTextBox" runat="server" Width="263px"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Eliminar" />
            
        </div>
    </form>
</body>
</html>
