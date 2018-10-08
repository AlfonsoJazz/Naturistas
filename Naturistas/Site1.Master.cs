using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Naturistas
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("././Bienvenida.aspx");
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("././Ventas.aspx");
        }

        protected void btnArticulos_Click(object sender, EventArgs e)
        {
            Response.Redirect("././Articulos.aspx");
        }

        protected void btnTrabajadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("././Trabajadores.aspx");
        }
    }
}