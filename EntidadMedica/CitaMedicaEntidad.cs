using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class CitaMedicaEntidad
    {
        public int Id { get; set; }
        public int Id_Med_Cita { get; set; }
        public int Id_Pac_Cita { get; set; }
        public string Fecha { get; set; }
        public CitaMedicaEntidad()
        {

        }

        public CitaMedicaEntidad(int id, int id_Med_Cita, int id_Pac_Cita, string fecha)
        {
            Id = id;
            Id_Med_Cita = id_Med_Cita;
            Id_Pac_Cita = id_Pac_Cita;
            Fecha = fecha;
        }
    }
}
