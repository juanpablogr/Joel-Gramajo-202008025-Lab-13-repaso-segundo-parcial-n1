using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fecha_de_nacimiento;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_de_nacimiento { get => fecha_de_nacimiento; set => fecha_de_nacimiento = value; }
        public int Edad { get => this.CalcularEdad(); set => edad = this.CalcularEdad(); }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, string direccion, DateTime fecha_de_nacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Fecha_de_nacimiento = fecha_de_nacimiento;
        }

        public int CalcularEdad()
        {
            return DateTime.Now.AddTicks(-this.Fecha_de_nacimiento.Ticks).Year;
        }
    }
}