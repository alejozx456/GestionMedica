using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleExamenEntidad
    {
        public int ID { get; set; }
        public int Id_Exa_Per { get; set; }
        public int Id_Cit_Per { get; set; }

        public DetalleExamenEntidad()
        {

        }

        public DetalleExamenEntidad(int iD, int id_Exa_Per, int id_Cit_Per)
        {
            ID = iD;
            Id_Exa_Per = id_Exa_Per;
            Id_Cit_Per = id_Cit_Per;
        }
    }
}
