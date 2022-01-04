using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleMedicinaEntidad
    {
        public int Id_Med_Per { get; set; }
        public int Id_Hist_Per { get; set; }
        public string Nombre { get; set; }

        public DetalleMedicinaEntidad()
        {

        }

        public DetalleMedicinaEntidad(int id_Med_Per, int id_Hist_Per, string nombre)
        {
            Id_Med_Per = id_Med_Per;
            Id_Hist_Per = id_Hist_Per;
            Nombre = nombre;
        }
    }
}
