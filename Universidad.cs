using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public class Universidad
    {
        string nombre;
        List<Alumno> alumnos = new List<Alumno>();
        List<Profesor> profesores = new List<Profesor>();
        List<Administrativo> administrativos = new List<Administrativo>();

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public List<Profesor> Profesores { get => profesores; set => profesores = value; }
        public List<Administrativo> Administrativos { get => administrativos; set => administrativos = value; }

        public Universidad()
        {

        }

        public Universidad(string nombre)
        {
            Nombre = nombre;
        }
    }
}