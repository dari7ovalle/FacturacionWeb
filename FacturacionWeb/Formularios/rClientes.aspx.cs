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
    public partial class WebForm1 : System.Web.UI.Page
    {

        #region metodos
        public void  CargarComboBox()
        {
            CiudadesIdDropDownList.DataMember = "CiudadId";
            CiudadesIdDropDownList.DataTextField = "Nombres";
            CiudadesIdDropDownList.DataSource = CiudadesBLL.ListarTodo();
            CiudadesIdDropDownList.DataValueField = "CiudadId";
            CiudadesIdDropDownList.DataTextField = "Nombres";
            CiudadesIdDropDownList.DataBind();
        }
        /*   public void LimpiarTextBox()
           {
               NombresTextBox.Clear();
               ApellidosTextBox.Clear();
               CedulaTextBox.Clear();
               CelularTextBox.Clear();
               TelefonoTextBox.Clear();
               CiudadIdTextBox.SelectedIndex = 0;
               DireccionTextBox.Clear();
           }*/
        Clientes llenarClase()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombresTextBox.Text;
            cliente.Apellidos = ApellidosTextBox.Text;
            cliente.Cedula = CelularTextBox.Text;
            cliente.Celular = CelularTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Telefono = TelefonoTextBox.Text;
           b
            cliente.ClienteId = id;
            cliente.CiudadId = int.Parse(CiudadesIdDropDownList.SelectedValue.ToString());

            return cliente;
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            int id = 0;
            int.TryParse(ClienteTextBox.Text, out id);
            if (id <= 0)
            {

                if (ClienteBLL.Guardar(llenarClase()))
                {
                    Response.Write("<script>alert('Guardado Correctamente');</script>");


                    // MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {

                if (ClienteBLL.Editar(llenarClase()))
                {
                    //MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            
                if (ClienteBLL.Eliminar(int.Parse(ClienteTextBox.Text)))
                {

                Response.Write("<script>alert('Eliminado Correctamente');</script>");
                // MessageBox.Show(" fue eliminado");

            }

                else
                {
                Response.Write("<script>alert('No Se Pudo Eliminado Correctamente');</script>");
              
            }
            
        }
    }
}