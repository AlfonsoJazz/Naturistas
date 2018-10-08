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
    public class MEmpleados
    {
        private ObjResult Lo_Resultado;
        private MdlEmpleados Lo_MdlEmpleados;
        private AEmpleados Lo_AEmpleados;

        public ObjResult ConsultaUsuario(string Nombre, int IdTienda)
        {
            Lo_Resultado = new ObjResult();
            Lo_MdlEmpleados = new MdlEmpleados();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_MdlEmpleados.Nombre = Nombre;
                Lo_MdlEmpleados.IdTienda = IdTienda;
                Lo_Resultado = Lo_AEmpleados.ConsultaEmpleados(Lo_MdlEmpleados);
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
        public ObjResult EditaEmpleado(int Id, String Nombre, int Edad, String Direccion, int Telefono, int SueldoHora, int IdPuesto, int HorasTrabajadas, int IdTienda, Boolean Check)
        {
            Lo_Resultado = new ObjResult();
            Lo_MdlEmpleados = new MdlEmpleados();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_MdlEmpleados.Id = Id;
                Lo_MdlEmpleados.NombreE = Nombre;
                Lo_MdlEmpleados.Edad = Edad;
                Lo_MdlEmpleados.Direccion = Direccion;
                Lo_MdlEmpleados.Telefono = Telefono;
                Lo_MdlEmpleados.SueldoHora = SueldoHora;
                Lo_MdlEmpleados.IdPuesto = IdPuesto;
                Lo_MdlEmpleados.HorasTrabajadas = HorasTrabajadas;
                Lo_MdlEmpleados.IdTienda = IdTienda;
                Lo_MdlEmpleados.Activo = Check;

                Lo_Resultado = Lo_AEmpleados.EditaEmpleado(Lo_MdlEmpleados);
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
        public ObjResult CargaDDLTienda()
        {
            Lo_Resultado = new ObjResult();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_Resultado = Lo_AEmpleados.CargaDDLTienda();
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
        public ObjResult CargaTiendaEmpleados()
        {
            Lo_Resultado = new ObjResult();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_Resultado = Lo_AEmpleados.CargaTiendaEmpleados();
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
        public ObjResult CargaDDLTiendaE()
        {
            Lo_Resultado = new ObjResult();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_Resultado = Lo_AEmpleados.CargaDDLTiendaE();
            }
            catch (Exception ex)
            {
                Lo_Resultado.Mensaje = ex.Message;
                Lo_Resultado.BooleanValue = false;
            }
            return Lo_Resultado;
        }
        public ObjResult CargaDDLPuesto()
        {
            Lo_Resultado = new ObjResult();
            Lo_AEmpleados = new AEmpleados();

            try
            {
                Lo_Resultado = Lo_AEmpleados.CargaDDLPuesto();
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