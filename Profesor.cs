using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public class Profesor : Persona
    {
        string id_profesor;
        string titulo_universitario;

        public string Id_profesor { get => id_profesor; set => id_profesor = value; }
        public string Titulo_universitario { get => titulo_universitario; set => titulo_universitario = value; }

        public Profesor()
        {

        }

        public Profesor(string nombre, string apellido, string direccion, DateTime fecha_de_nacimiento, string id_profesor, string titulo_universitario) : base(nombre, apellido, direccion, fecha_de_nacimiento)
        {
            Id_profesor = id_profesor;
            Titulo_universitario = titulo_universitario;
        }
    }
}