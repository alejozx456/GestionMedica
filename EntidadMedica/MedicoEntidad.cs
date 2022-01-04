using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class MedicoEntidad
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNaci { get; set; }
        public int Sueldo { get; set; }
        public int Id_Especialidad { get; set; }
        public string Especialidad { get; set; }

        public MedicoEntidad()
        {

        }

        public MedicoEntidad(int id, string cedula, string nombre, string apellido, string fechaNaci, int sueldo, int id_Especialidad, string especialidad)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNaci = fechaNaci;
            Sueldo = sueldo;
            Id_Especialidad = id_Especialidad;
            Especialidad = especialidad;
        }
    }
}
