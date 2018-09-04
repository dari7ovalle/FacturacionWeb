using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SisAgroVeterinaria.BLL;

namespace FacturacionWeb.Consultas
{
    public partial class cCiudades : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void CargarGridView()
        {
            CiudadGridView.DataSource = CiudadesBLL.ListarTodo();
            CiudadGridView.DataBind();
        }
    }
}