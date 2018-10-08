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
    public class AEmpleados : CadConexion
    {
        public ObjResult ConsultaEmpleados(MdlEmpleados Empleados)
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                this.Co_Conexion.OPR_ADDPARAMETER("@Nombre", DbType.String, Empleados.Nombre);
                this.Co_Conexion.OPR_ADDPARAMETER("@Tienda", DbType.Int16, Empleados.IdTienda);
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "ConsultaEmpleados");
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
        public ObjResult EditaEmpleado(MdlEmpleados Empleados)
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                this.Co_Conexion.OPR_ADDPARAMETER("@Id", DbType.Int32, Empleados.Id);
                this.Co_Conexion.OPR_ADDPARAMETER("@Nombre", DbType.String, Empleados.NombreE);
                this.Co_Conexion.OPR_ADDPARAMETER("@Edad", DbType.Int32, Empleados.Edad);
                this.Co_Conexion.OPR_ADDPARAMETER("@Direccion", DbType.String, Empleados.Direccion);
                this.Co_Conexion.OPR_ADDPARAMETER("@Telefono", DbType.Int32, Empleados.Telefono);
                this.Co_Conexion.OPR_ADDPARAMETER("@SueldoHora", DbType.Int32, Empleados.SueldoHora);
                this.Co_Conexion.OPR_ADDPARAMETER("@IdPuesto", DbType.Int32, Empleados.IdPuesto);
                this.Co_Conexion.OPR_ADDPARAMETER("@HorasTrabajadas", DbType.Int32, Empleados.HorasTrabajadas);
                this.Co_Conexion.OPR_ADDPARAMETER("@IdTienda", DbType.Int32, Empleados.IdTienda);
                this.Co_Conexion.OPR_ADDPARAMETER("@Activo", DbType.Boolean, Empleados.Activo);
                Co_Resultado.Id = Co_Conexion.OPR_EXECUTENONOQUERY (ConexionBd.commandTypeEnum.StoredProcedure, "EditaEmpleado");
                Co_Conexion.OPR_COMMITTRANSACTION();

                if (Co_Resultado.Id > 0)
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
        public ObjResult CargaDDLTienda()
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "CargaDDLTienda");
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
        public ObjResult CargaTiendaEmpleados()
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "ConsultaTiendasEmpleados");
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
        public ObjResult CargaDDLTiendaE()
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "CargaDDLTiendaE");
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
        public ObjResult CargaDDLPuesto()
        {
            try
            {
                this.Co_Conexion.OPR_BEGINTRANSACTION();
                this.Co_Conexion.OPR_CLEARPARAMETERS();
                Co_Resultado.Tabla = Co_Conexion.OPR_EXECUTEDATATABLE(ConexionBd.commandTypeEnum.StoredProcedure, "CargaDDLPuesto");
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