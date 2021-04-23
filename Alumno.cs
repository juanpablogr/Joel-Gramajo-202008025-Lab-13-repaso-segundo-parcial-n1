using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public class Alumno : Persona
    {
        string carne;

        public string Carne { get => carne; set => carne = value; }

        public Alumno()
        {
            
        }

        public Alumno(string nombre, string apellido, string direccion, DateTime fecha_de_nacimiento, string carne) : base(nombre, apellido, direccion, fecha_de_nacimiento)
        {
            Carne = carne;
        }
    }
}