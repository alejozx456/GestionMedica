using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
   public class AtencionEntidad
    {
        public int Id { get; set; }
        public string Registro { get; set; }
        public string Diagnostico { get; set; }
        public int Id_Cita { get; set; }

        public int Costo_Atencion { get; set; }

        public AtencionEntidad()
        {

        }

        public AtencionEntidad(int id, string registro, string diagnostico, int id_Cita, int costo_Atencion)
        {
            Id = id;
            Registro = registro;
            Diagnostico = diagnostico;
            Id_Cita = id_Cita;
            Costo_Atencion = costo_Atencion;
        }
    }

}
