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
   
           
        <asp:TextBox ID="ClienteTextBox" runat="server"></asp:TextBox>
        <br />
        CiudadId<br />
<asp:DropDownList ID="CiudadesIdDropDownList" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="NombresTextBox" runat="server" Width="113px"></asp:TextBox>
        Apellido<br />

        <asp:TextBox ID="ApellidosTextBox" runat="server"></asp:TextBox>

        <br />
        <br />
Cedula<br />
        <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>

        <br />
        Celular<br />
        <asp:TextBox ID="CelularTextBox" runat="server"></asp:TextBox>

        Telefono<br />
        <asp:TextBox ID="TelefonoTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />

        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
    </form>
</body>
</html>
