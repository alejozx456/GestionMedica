using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleExamenAtencionEntidad
    {
        public DetalleExamenAtencionEntidad(int id_Det_Exa_Per, int id_Ate_Per, string descripcion)
        {
            Id_Det_Exa_Per = id_Det_Exa_Per;
            Id_Ate_Per = id_Ate_Per;
            Descripcion = descripcion;
        }

        public int Id_Det_Exa_Per { get; set; }
        public int Id_Ate_Per { get; set; }
        public string Descripcion { get; set; }
        public DetalleExamenAtencionEntidad()
        {

        }
    }
}
