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
    public partial class rProducto : System.Web.UI.Page
    {
        public bool Validar()
        {
            if (NombreTextBox.Text==String.Empty || TipoProductoIdDropDownList.SelectedValue!=null || double.Parse(CostoTextBox.Text )>0 || double.Parse(PrecioTextBox.Text)>0 )
            {
                if (NombreTextBox.Text == String.Empty)
                {
                    //NombreTextBox.

                }
                if (TipoProductoIdDropDownList.SelectedValue != null)
                {

                }
                if (double.Parse(CostoTextBox.Text) > 0)
                {

                }
                if (double.Parse(PrecioTextBox.Text) > 0)
                {



                }


                return false;
            }
            return true;
        }
        Productos llenarClase()
        {

            Productos producto = new Productos();
            producto.Nombre = NombreTextBox.Text;
            producto.Precio = int.Parse(PrecioTextBox.Text);
            producto.Costo = int.Parse(CostoTextBox.Text);
            producto.Activo = 0;
            producto.TipoProductoId = int.Parse(TipoProductoIdDropDownList.SelectedValue.ToString());
            int id = 0;
            int.TryParse(ProductoIdTextBox.Text, out id);
            producto.ProductoId = id;

            return producto;
        }

        public void CargarComboBox()
        {
            TipoProductoIdDropDownList.DataMember = "TipoProductoId";
            TipoProductoIdDropDownList.DataTextField = "Nombres";
            TipoProductoIdDropDownList.DataSource = TipoProductoBLL.ListarTodo();
            TipoProductoIdDropDownList.DataValueField = "TipoProductoId";
            TipoProductoIdDropDownList.DataTextField = "Nombres";
            TipoProductoIdDropDownList.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(ProductoIdTextBox.Text, out id);
            if (id <= 0)
            {

                if (ProductosBLL.Guardar(llenarClase()))
                {
                    Response.Write("<script>alert('Guardado Correctamente');</script>");
                    //  MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response.Write("<script>alert(' Error Guardado ');</script>");
                    // MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {

                if (ProductosBLL.Editar(llenarClase()))
                {

                    Response.Write("<script>alert('Modificado Correctamente');</script>");
                    //MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Response.Write("<script>alert('Error al modificar ');</script>");
                    //  MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }
    }
}