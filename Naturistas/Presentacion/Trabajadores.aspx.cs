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
    public partial class Trabajadores : System.Web.UI.Page
    {
        ObjResult Lo_Resultado;
        MEmpleados Lo_MEmpleados;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDDLTienda();
                CargaTiendaEmpleados();
                CargarEmpleados();
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        public void CargarEmpleados()
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.ConsultaUsuario(txtNombre.Text.Trim(), Convert.ToInt16(ddlTienda.SelectedValue.ToString()));

            gvTrabajadores.DataSource = Lo_Resultado.Tabla;
            gvTrabajadores.DataBind();
        }
        public void CargaTiendaEmpleados()
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.CargaTiendaEmpleados();

            gvTiendasEmpleados.DataSource = Lo_Resultado.Tabla;
            gvTiendasEmpleados.DataBind();
        }
        public void EditaEmpleado(int Id, String Nombre, int Edad, String Direccion, int Telefono, int SueldoHora, int IdPuesto, int HorasTrabajadas, int IdTienda, Boolean Check)
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.EditaEmpleado(Id, Nombre, Edad, Direccion, Telefono, SueldoHora, IdPuesto, HorasTrabajadas, IdTienda, Check);
        }
        protected void gvTrabajadores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                DivTabla.Visible = false;
                DivEdicion.Visible = true;

                CargaDDLTiendaE();
                CargaDDLPuesto();

                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button 
                // from the Rows collection.
                GridViewRow row = gvTrabajadores.Rows[index];
                String Id = gvTrabajadores.Rows[index].Cells[1].Text;
                String Nombre = gvTrabajadores.Rows[index].Cells[2].Text;
                String Edad = gvTrabajadores.Rows[index].Cells[3].Text;
                String Direccion = gvTrabajadores.Rows[index].Cells[4].Text;
                String Telefono = gvTrabajadores.Rows[index].Cells[5].Text;
                String SueldoHora = gvTrabajadores.Rows[index].Cells[6].Text;
                String IdPuesto = gvTrabajadores.Rows[index].Cells[7].Text;
                String Puesto = gvTrabajadores.Rows[index].Cells[8].Text;
                String HorasTrabajadas = gvTrabajadores.Rows[index].Cells[9].Text;
                String IdTienda = gvTrabajadores.Rows[index].Cells[10].Text;
                String Tienda = gvTrabajadores.Rows[index].Cells[11].Text;
                String Activo = gvTrabajadores.Rows[index].Cells[12].Text;

                int Check = 0;

                if (Activo == "True")
                {
                    Check = 1;
                }
                else if (Activo == "False")
                {
                    Check = 0;
                }

                txtId.Text = Id;
                txtNombreE.Text = Nombre;
                txtEdad.Text = Edad;
                txtDireccion.Text = Direccion;
                txtTelefono.Text = Telefono;
                txtSueldo.Text = SueldoHora;
                ddlPuesto.SelectedValue = IdPuesto;
                txtHorasTrabajadas.Text = HorasTrabajadas;
                ddlTiendaE.SelectedValue = IdTienda;
                chkActivo.Checked = Convert.ToBoolean(Check);
            }
        }
        public void Mensaje(String Mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alerta", "alert('" + Mensaje + "')", true);
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EditaEmpleado(Convert.ToInt32(txtId.Text.Trim()), txtNombreE.Text.Trim(), Convert.ToInt32(txtEdad.Text.Trim()), txtDireccion.Text.Trim(), Convert.ToInt32(txtTelefono.Text.Trim()), Convert.ToInt32(txtSueldo.Text.Trim()), Convert.ToInt32(ddlPuesto.SelectedValue), Convert.ToInt32(txtHorasTrabajadas.Text.Trim()), Convert.ToInt32(ddlTiendaE.SelectedValue), chkActivo.Checked);
            Mensaje("La edicion ha sido realizada.");
            LimpiaTablaEdicion();
            CargarEmpleados();
            DivTabla.Visible = true;
            DivEdicion.Visible = false;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Mensaje("La edicion ha sido cancelada.");
            LimpiaTablaEdicion();
            DivTabla.Visible = true;
            DivEdicion.Visible = false;
        }
        public void LimpiaTablaEdicion()
        {
            txtId.Text = "";
            txtNombreE.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtSueldo.Text = "";
            ddlPuesto.SelectedValue = "1";
            txtHorasTrabajadas.Text = "";
            ddlTiendaE.SelectedValue = "2";
        }
        public void CargaDDLTienda()
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.CargaDDLTienda();

            ddlTienda.DataSource = Lo_Resultado.Tabla;
            ddlTienda.DataTextField = "Nombre";
            ddlTienda.DataValueField = "Id";
            ddlTienda.DataBind();
        }
        public void CargaDDLPuesto()
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.CargaDDLPuesto();

            ddlPuesto.DataSource = Lo_Resultado.Tabla;
            ddlPuesto.DataTextField = "Nombre";
            ddlPuesto.DataValueField = "Id";
            ddlPuesto.DataBind();
        }
        public void CargaDDLTiendaE()
        {
            Lo_Resultado = new ObjResult();
            Lo_MEmpleados = new MEmpleados();

            Lo_Resultado = Lo_MEmpleados.CargaDDLTiendaE();

            ddlTiendaE.DataSource = Lo_Resultado.Tabla;
            ddlTiendaE.DataTextField = "Nombre";
            ddlTiendaE.DataValueField = "Id";
            ddlTiendaE.DataBind();
        }
        public void OcultarColumnas()
        {
            for (int i = 0; i < gvTrabajadores.Columns.Count; i++)
            {
                if (gvTrabajadores.Columns[i].HeaderText.Trim() == "IdPuesto")
                {
                    gvTrabajadores.Columns[i].Visible = false;
                }

                if (gvTrabajadores.Columns[i].HeaderText.Trim() == "IdTienda")
                {
                    gvTrabajadores.Columns[i].Visible = false;
                }
            }
        }
    }
}