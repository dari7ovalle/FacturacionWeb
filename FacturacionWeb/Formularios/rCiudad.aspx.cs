using SisAgroVeterinaria.BLL;
using SisAgroVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionWeb.Formularios
{
    public partial class rCiudad : System.Web.UI.Page
    {

        #region Metodos

        void LimpiarTextBox()
        {
            IdciudadTextBox.Text = "";
            NombreTextBox.Text = "";
        }

        Ciudades llenarClase()
        {

            Ciudades ciudades = new Ciudades();
            ciudades.Nombres = NombreTextBox.Text;
            //ciudades.CiudadId = int.Parse(IdtextBox.Text);
            return ciudades;

        }
        #endregion

        #region Eventos
        protected void Guardarbutton_OnClick(object sender, EventArgs e)
        {


            if (IdciudadTextBox.Text.Length == 0)
            {
                if (CiudadesBLL.Guardar(llenarClase()))
                {
                    Response.Write("<script>alert('Guardado Correctamente');</script>");

                    // MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('Error al Guardar');</script>");
                    //  MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {


                if (CiudadesBLL.Editar(llenarClase()))
                {
                    Response.Write("<script>alert('Modificado Correctamente');</script>");
                    //  MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('Error al Modificar');</script>");

                    //  MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nuevo_OnClick(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }


        protected void EliminarButton_OnClick(object sender, EventArgs e)
        {
            if (CiudadesBLL.Eliminar(int.Parse(IdciudadTextBox.Text)))
            {
                Response.Write("<script>alert('fue eliminado');</script>");
                //  MessageBox.Show(" fue eliminado");

            }

            else
            {
                Response.Write("<script>alert('no se pudo eliminar');</script>");
                //  MessageBox.Show(" no se pudo eliminar");
            }

        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudades = CiudadesBLL.Buscar(int.Parse(IdciudadTextBox.Text));
            if (ciudades != null)
            {
                NombreTextBox.Text = ciudades.Nombres;
            }
            else
            {
                Response.Write("<script>alert('ciudad no existe');</script>");
               // MessageBox.Show(" ciudad no existe ");
            }

        }
    }

    #endregion

}
