using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Naturistas.Modelado
{
    public class MdlEmpleados
    {
        private String s_Nombre;
        private int s_IdTienda;
        int s_Id;
        String s_NombreE;
        int s_Edad;
        String s_Direccion ;
        int s_Telefono;
        int s_SueldoHora;
        int s_IdPuesto;
        String s_Puesto;
        int s_HorasTrabajadas;
        String s_Tienda;
        Boolean s_Activo;

        public String Nombre
        {
            get { return s_Nombre; }
            set { s_Nombre = value; }
        }
        public int IdTienda
        {
            get { return s_IdTienda; }
            set { s_IdTienda = value; }
        }
        public int Id
        {
            get { return s_Id; }
            set { s_Id = value; }
        }
        public String NombreE
        {
            get { return s_NombreE; }
            set { s_NombreE = value; }
        }
        public int Edad
        {
            get { return s_Edad; }
            set { s_Edad= value; }
        }
        public String Direccion
        {
            get { return s_Direccion; }
            set { s_Direccion = value; }
        }
        public int Telefono
        {
            get { return s_Telefono; }
            set { s_Telefono = value; }
        }
        public int SueldoHora
        {
            get { return s_SueldoHora; }
            set { s_SueldoHora = value; }
        }
        public int IdPuesto
        {
            get { return s_IdPuesto; }
            set { s_IdPuesto = value; }
        }
        public String Puesto
        {
            get { return s_Puesto; }
            set { s_Puesto = value; }
        }
        public int HorasTrabajadas
        {
            get { return s_HorasTrabajadas; }
            set { s_HorasTrabajadas = value; }
        }
        public String Tienda
        {
            get { return s_Tienda; }
            set { s_Tienda = value; }
        }
        public Boolean Activo
        {
            get { return s_Activo; }
            set { s_Activo = value; }
        }
    }
}