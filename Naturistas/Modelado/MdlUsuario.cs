using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aramark.Conexion;
using Aramark.Datos;
using Aramark.Resultados;


namespace Naturistas.Modelado
{
    public class MdlUsuario
    {
        private String s_Usuario;
        private String s_Clave;

        public String Usuario
        {
            get {return s_Usuario;}
            set { s_Usuario = value; }
        }
        public String Clave
        {
            get {return s_Clave;}
            set { s_Clave = value; }
        }
    }
}