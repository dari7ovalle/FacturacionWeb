<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rUsuario.aspx.cs" Inherits="FacturacionWeb.Formularios.rUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 231px">
            ID<br />
            <asp:TextBox ID="UsuarioIdTextBox" runat="server"></asp:TextBox>
            <br />
            Nombres<br />
            <asp:TextBox ID="NombresTextBox" runat="server" Width="192px"></asp:TextBox>
            <br />
            Contracena<br />
            <asp:TextBox ID="ContracenaTextBox" runat="server" Width="180px"></asp:TextBox>
            <br />
            TipoUsuario<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="178px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
&nbsp;
            <asp:Button ID="GuardarButton" runat="server" OnClick="Button2_Click" Text="Guardar" />
&nbsp;&nbsp;
            <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" />
        </div>
    </form>
</body>
</html>
