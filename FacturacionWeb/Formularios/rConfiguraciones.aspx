<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rConfiguraciones.aspx.cs" Inherits="FacturacionWeb.Formularios.rConfiguraciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 183px;
            height: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID</div>
        <asp:TextBox ID="ConfiguracionId" runat="server"></asp:TextBox>
        <br />
        <br />
        NCF<br />
        <br />
        <asp:TextBox ID="NCFTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
    &nbsp;
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" />
    </form>
</body>
</html>
