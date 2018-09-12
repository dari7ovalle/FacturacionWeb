﻿using SisAgroVeterinaria.BLL;
using SisAgroVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionWeb.Formularios
{
    public partial class rUsuario : System.Web.UI.Page
    {

        Usuarios llenarClase()
        {

            Usuarios usuario = new Usuarios();
            usuario.Nombres = nameTextbox.Text;
            usuario.Contracena = PasswordTextBox.Text;
            usuario.TipoUsuario = 0;
            return usuario;


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistrarButton_Click(object sender, EventArgs e)
        {

            if (nameTextbox.Text.Length > 0 && ValidarCheckBox.Checked)
            {
                if (UsuariosBLL.Guardar(llenarClase()))
                {
                    Response.Redirect("/Formularios/Login.aspx");
                    Response.Write("<script>alert('Guardado Correctamente');</script>");
                    // MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('Error al Guardar');</script>");
                    // MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                Response.Write("<script>alert('favor acepte las condiciones para continuar ');</script>");
            }
            //else
            //{
            //    if (UsuariosBLL.Editar(llenarClase()))
            //    {
            //        Response.Write("<script>alert('Modificado Correctamente');</script>");
            //        // MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Error al Modificar');</script>");
            //        //  MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }
    }
}