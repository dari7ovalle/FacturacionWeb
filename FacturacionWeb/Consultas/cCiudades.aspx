<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cCiudades.aspx.cs" Inherits="FacturacionWeb.Consultas.cCiudades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta de Ciudades</title>
    <link href="../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/jquery-1.9.1.min.js" type="text/javascript"></script>
</head>
<body>
    <div class ="container col-md-12">
            <h2>Consultas de Ciudades</h2>
        <form action="/" runat="server" method="post">
             <div class="row">
                 <div class="form-group">
                    <div class="col-xs-3 col-md-3">
                         <asp:DropDownList ID="ConsultaDropDownList" CssClass="form-control " runat="server">
                             <asp:ListItem>CiudadId</asp:ListItem>
                             <asp:ListItem>Nombre</asp:ListItem>
                         </asp:DropDownList>
                     </div>
                      <div class="col-xs-6 col-md-6">
                        <asp:TextBox runat="server" ID="ConsultaTextBox" CssClass="form-control " placeholder="CiudadId"/>
                      </div>
                      <div class="col-xs-3 col-md-3">
                        <asp:Button Text="Buscar" runat="server" ID="BuscarButton" CssClass="btn btn-primary" />
                      </div>
                 </div>
                 <div class="table table-responsive col-md-12">
                     <asp:GridView ID="CiudadGridView" runat="server" CssClass="table table-bordered table-hover table-striped" AutoGenerateColumns="False">
                         <Columns>
                             <asp:BoundField DataField="CiudadId" HeaderText="CiudadId" />
                             <asp:BoundField DataField="Nombres" HeaderText="Nombre" />
                         </Columns>
                     </asp:GridView>
                 </div>
            </div>
            </form>
        </div>
    
</body>
</html>
