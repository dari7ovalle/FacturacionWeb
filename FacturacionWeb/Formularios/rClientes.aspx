<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rClientes.aspx.cs" Inherits="FacturacionWeb.Formularios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Registro De Cliente</title>
    <style type="text/css">
        #form1 {
            height: 517px;
            width: 273px;
        }
    </style>
</head>
<body style="width: 267px; height: 556px;">
    <form id="form1" runat="server">
        <div>
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </div>
        <asp:TextBox ID="ClienteTextBox" runat="server"></asp:TextBox>
&nbsp;
        <br />
        CiudadId<br />
&nbsp;<asp:DropDownList ID="CiudadesIdDropDownList" runat="server">
        </asp:DropDownList>
 
        <br />
        Nombres&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:TextBox ID="NombresTextBox" runat="server" Width="113px"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        Apellido<br />

        <asp:TextBox ID="ApellidosTextBox" runat="server"></asp:TextBox>

        <br />
        <br />
&nbsp;Cedula<br />
        <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>

        <br />
        &nbsp;Direccion<br />
&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>

        <br />
        Celular<br />
        <asp:TextBox ID="CelularTextBox" runat="server"></asp:TextBox>

        <br />
        <br />
        Telefono<br />
        <asp:TextBox ID="TelefonoTextBox" runat="server"></asp:TextBox>

&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
    </form>
</body>
</html>
