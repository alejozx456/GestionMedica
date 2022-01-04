using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleMedicinaAtencionEntidad
    {
        public DetalleMedicinaAtencionEntidad(int id_Med_Per, int id_Ate_Per)
        {
            Id_Med_Per = id_Med_Per;
            Id_Ate_Per = id_Ate_Per;
        }

        public DetalleMedicinaAtencionEntidad(){}

        public int Id_Med_Per { get; set; }
        public int Id_Ate_Per { get; set; }

    }
}
