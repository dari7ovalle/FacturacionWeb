using SisAgroVeterinaria.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionWeb.Formularios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IniciarSesionButton_Click(object sender, EventArgs e)
        {

            if (UsuariosBLL.Login(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                
                Response.Write("<script>alert('Inicio sesion ');</script>");
                Response.Redirect("\\");
            }
            else
            {
                Response.Write("<script>alert('no Inicio sesion ');</script>");
                // MessageBox.Show("Error");
            }
        }


    }
    }
