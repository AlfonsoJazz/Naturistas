using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aramark.Datos;
using Aramark.Resultados;
using Naturistas.Modelado;
using Naturistas.Manejador;

namespace Naturistas.Presentacion
{
    public partial class Ventas : System.Web.UI.Page
    {
        ObjResult Lo_Resultado;
        MVentas Lo_MVentas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaArticulos();
            }
        }
        public void CargaArticulos()
        {
            Lo_Resultado = new ObjResult();
            Lo_MVentas = new MVentas();

            Lo_Resultado = Lo_MVentas.ConsultaArticulos();

            gvArticulos.DataSource = Lo_Resultado.Tabla;
            gvArticulos.DataBind();
        }
        protected void gvArticulos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);
                int Fila = 0;

                // Retrieve the row that contains the button 
                // from the Rows collection.
                GridViewRow row = gvArticulos.Rows[index];
                String Nombre = gvArticulos.Rows[index].Cells[1].Text;
                String UnidadMedida= gvArticulos.Rows[index].Cells[2].Text;
                String CostoActual = gvArticulos.Rows[index].Cells[3].Text;
                String Tipo = gvArticulos.Rows[index].Cells[4].Text;
                String Marca = gvArticulos.Rows[index].Cells[5].Text;
                String IdArticulo= gvArticulos.Rows[index].Cells[6].Text;
                String EnExistencia= gvArticulos.Rows[index].Cells[7].Text;

                int Contador = Fila + 1;

                int Costo = Convert.ToInt32(CostoActual);

                int TotalAcumulado = Costo;

                gvVenta.Rows[Fila].Cells[1].Text = Nombre;
                gvVenta.Rows[Fila].Cells[2].Text = CostoActual;
                Fila++;
                
            }
        }
    }
}