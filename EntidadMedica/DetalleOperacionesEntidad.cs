using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class DetalleOperacionesEntidad
    {
        public int Id_Oper_Per { get; set; }
        public int Id_Hist_Per { get; set; }
        public string Nombre { get; set; }

        public DetalleOperacionesEntidad()
        {

        }

        public DetalleOperacionesEntidad(int id_Oper_Per, int id_Hist_Per, string nombre)
        {
            Id_Oper_Per = id_Oper_Per;
            Id_Hist_Per = id_Hist_Per;
            Nombre = nombre;
        }
    }
}
