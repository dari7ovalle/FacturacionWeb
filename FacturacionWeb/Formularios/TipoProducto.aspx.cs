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
    public partial class TipoProducto : System.Web.UI.Page
    {

        TipoProductos llenarClase()
        {

            TipoProductos tipos = new TipoProductos();
            tipos.Nombres = NombresTextBox.Text;
            return tipos;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (TipoProductoIdTextbox.Text.Length == 0)
            {
                if (TipoProductoBLL.Guardar(llenarClase()))
                {
                    Response.Write("<script>alert('Guardado Correctamente');</script>");
                    //MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('Error al guardar');</script>");
                    // MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (TipoProductoBLL.Editar(llenarClase()))
                {
                    Response.Write("<script>alert('Modificado  Correctamente');</script>");
                    //  MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert('Error al modificar');</script>");
                    // MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}