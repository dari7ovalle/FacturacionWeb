<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rCiudad.aspx.cs" Inherits="FacturacionWeb.Formularios.rCiudad" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro de Ciudades</title>
    <link href="../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/jquery-1.9.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="container ">
                    <div class="row">
                        <div class="form-group">
                            <div class="col-sm-2 col-md-2">
                                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                            </div>

                            <div class="col-sm-7 col-md-7">
                                <asp:TextBox ID="IdciudadTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class=" col-sm-3 col-md-3">
                                <asp:Button ID="buscarButton" CssClass="btn btn-primary" Text="Buscar" runat="server" OnClick="buscarButton_Click" />

                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>

                            <asp:TextBox ID="NombreTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="El Nombre es un campo requerido" ControlToValidate="NombreTextBox"></asp:RequiredFieldValidator>

                            <asp:Button ID="Nuevobutton" CssClass="btn btn-info" runat="server" Text="Nuevo" OnClick="Nuevo_OnClick" />
                            <asp:Button ID="GuardarButton" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="Guardarbutton_OnClick" />
                            <asp:Button ID="EliminarButton" runat="server" CssClass="btn btn-danger" Text="Eliminar" OnClick="EliminarButton_OnClick" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
