using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aramark.Datos;
using Aramark.Resultados;
using Naturistas.Modelado;
using Naturistas.Manejador;

namespace Naturistas
{
    public partial class Login : System.Web.UI.Page
    {
        ObjResult Lo_Resultado;
        MLogin Lo_MUsuario;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Entrar_Click(object sender, EventArgs e)
        {
            if (IsPostBack)            
            {
                Lo_Resultado = new ObjResult();
                Lo_MUsuario = new MLogin();

                Lo_Resultado = Lo_MUsuario.ConsultaUsuario(txtUsuario.Text.Trim(), txtClave.Text.Trim());

                if (Lo_Resultado.BooleanValue)
                {
                    Response.Redirect("././Presentacion/Bienvenida.aspx");
                }
                else
                {
                    Mensaje("Usuario no Encontrado");
                }
            }
        }
        public void Mensaje(String Mensaje)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alerta", "alert('"+Mensaje+"')", true);
        }
    }
}