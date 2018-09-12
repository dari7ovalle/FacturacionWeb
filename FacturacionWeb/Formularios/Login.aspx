<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FacturacionWeb.Formularios.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | HandlingQuotas</title>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <link href="../Css/loginStyle.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-6 col-md-4 col-md-offset-4">
                <div class="account-wall">
                    <img class="profile-img" src="img/avatar_2x.png" alt=""/>
                    <form class="form-signin" id="form1" runat="server">
                        <asp:TextBox ID="UserNameTextBox" CssClass="form-control" placeholder="Username" required="required"  autofocus="autofocus" runat="server"></asp:TextBox>
                        <asp:TextBox ID="PasswordTextBox" CssClass="form-control" placeholder="Password" required="required" runat="server" TextMode="password"></asp:TextBox><br />
                        <asp:Button ID="IniciarSesionButton" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Sign in" OnClick="IniciarSesionButton_Click"  />
                        <label class="checkbox pull-left">
                            <asp:CheckBox ID="RememberCheckBox" runat="server" />Remember me
                        </label>
                        <a href="#" class="pull-right need-help">Need help? </a><span class="clearfix"></span>
                        <a href="Registrarse.aspx" class="text-center new-account">Create an account </a>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>