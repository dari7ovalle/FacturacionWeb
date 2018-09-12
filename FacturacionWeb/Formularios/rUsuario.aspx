<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rUsuario.aspx.cs" Inherits="FacturacionWeb.Formularios.rUsuario" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="author" content="Kodinger">
    <title>Registro</title>
    <link href="../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/bootstrap.min.js"></script>
</head>
<body class="my-login-page">
   
        <div class="container ">
            <div class="row cmd-8">
                <div class="card-wrapper">
                    <div class="brand">
                        <img src="img/logo.jpg">
                    </div>
                    <div class="card fat">
                        <div class="card-body">
                            <h4 class="card-title">Register</h4>
                            <form method="POST"  runat="server">

                                <div class="form-group">
                                    <label for="name">Name</label>
                                    <asp:TextBox ID="nameTextbox" runat="server" class="form-control" name="name" required autofocus></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="password">Password</label>
                                    <asp:TextBox ID="PasswordTextBox" runat="server" class="form-control" name="name" type="password" required autofocus></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label>
                                        <asp:CheckBox ID="ValidarCheckBox" runat="server" />
                                        I agree to the Terms and Conditions
								
                                    </label>
                                </div>

                                <div class="form-group no-margin">

                                    <asp:Button ID="RegistrarButton" runat="server" Text="REGISTRAR" class="btn btn-primary btn-block" OnClick="RegistrarButton_Click" />
                                    Register
								
                                  
                                </div>
                                <div class="margin-top20 text-center">
                                    Already have an account? <a href="index.html">Login</a>
                                </div>
                            </form>
                        </div>
                    </div>
                    <div class="footer">
                        Copyright &copy; Your Company 2017
				
                    </div>
                </div>
            </div>
        </div>
 

    <script src="js/jquery.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/my-login.js"></script>
</body>
</html>
