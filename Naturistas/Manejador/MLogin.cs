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
using Naturistas.Accesos;


namespace Naturistas.Manejador
{
    public class MLogin
    {
        private ObjResult Lo_Resultado;
        private MdlUsuario Lo_MdlUsuario;
        private ALogin Lo_ALogin;

        public ObjResult ConsultaUsuario(string Usuario, string Clave)
        {
            Lo_Resultado = new ObjResult();
            Lo_MdlUsuario = new MdlUsuario();
            Lo_ALogin = new ALogin();

            try
            {
                Lo_MdlUsuario.Usuario = Usuario;
                Lo_MdlUsuario.Clave = Clave;
                Lo_Resultado = Lo_ALogin.ConsultaUsuario(Lo_MdlUsuario);
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
    }
}