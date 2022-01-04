using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleEnfermedadEntidad
    {
        public int Id_Enf_Per { get; set; }
        public int Id_His_Per { get; set; }
        public string NombreEnf { get; set; }

        public DetalleEnfermedadEntidad()
        {

        }

        public DetalleEnfermedadEntidad(int id_Enf_Per, int id_His_Per, string nombreEnf)
        {
            Id_Enf_Per = id_Enf_Per;
            Id_His_Per = id_His_Per;
            NombreEnf = nombreEnf;
        }
    }
}
