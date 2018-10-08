using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aramark.Datos;
using Aramark.Resultados;
using Naturistas.Modelado;
using Naturistas.Accesos;

namespace Naturistas.Manejador
{
    public class MVentas
    {
        private ObjResult Lo_Resultado;
        private MdlVentas Lo_MdlVentas;
        private AVentas Lo_AVentas;

        public ObjResult ConsultaArticulos()
        {
            Lo_Resultado = new ObjResult();
            Lo_AVentas = new AVentas();

            try
            {
                Lo_Resultado = Lo_AVentas.ConsultaArticulos();
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