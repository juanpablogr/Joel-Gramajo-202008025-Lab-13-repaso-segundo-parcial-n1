using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1
{
    public class Administrativo : Persona
    {
        string numero_IGSS;
        string profesion;
        DateTime fecha_inicio_de_labores;
        DateTime fecha_fin_de_labores;

        public string Numero_IGSS { get => numero_IGSS; set => numero_IGSS = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public DateTime Fecha_inicio_de_labores { get => fecha_inicio_de_labores; set => fecha_inicio_de_labores = value; }
        public DateTime Fecha_fin_de_labores { get => fecha_fin_de_labores; set => fecha_fin_de_labores = value; }

        public Administrativo()
        {
            
        }

        public Administrativo(string nombre, string apellido, string direccion, DateTime fecha_de_nacimiento, string numero_IGSS, string profesion, DateTime fecha_inicio_de_labores, DateTime fecha_fin_de_labores) : base(nombre, apellido, direccion, fecha_de_nacimiento)
        {
            Numero_IGSS = numero_IGSS;
            Profesion = profesion;
            Fecha_inicio_de_labores = fecha_inicio_de_labores;
            Fecha_fin_de_labores = fecha_fin_de_labores;
        }
    }
}