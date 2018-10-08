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
using Naturistas.Modelado;

namespace Naturistas.Accesos
{
    public class AVentas : CadConexion
    {
        public ObjResult ConsultaArticulos()
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "ConsultaArticulos");
                Co_Conexion.OPR_COMMITTRANSACTION();

                if (Co_Resultado.Tabla.Rows.Count > 0)
                {
                    Co_Resultado.BooleanValue = true;
                }
                else
                {
                    Co_Resultado.BooleanValue = false;
                }
            }
            catch (SqlException exSql)
            {
                Co_Resultado.Mensaje = exSql.Message;
                Co_Resultado.BooleanValue = false;
            }
            catch (Exception ex)
            {
                Co_Resultado.Mensaje = ex.Message;
                Co_Resultado.BooleanValue = false;
            }
            finally
            {
                ConexionBd.CierraConexion(this.Co_Conexion);
            }
            return this.Co_Resultado;
        }
    }
}