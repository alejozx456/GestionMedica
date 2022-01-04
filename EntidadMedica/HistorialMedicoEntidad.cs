using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class HistorialMedicoEntidad
    {
        public int Id { get; set; }
        public int Id_Pac_Per { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public HistorialMedicoEntidad()
        {

        }

        public HistorialMedicoEntidad(int id, int id_Pac_Per, string cedula, string nombre, string apellido)
        {
            Id = id;
            Id_Pac_Per = id_Pac_Per;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
