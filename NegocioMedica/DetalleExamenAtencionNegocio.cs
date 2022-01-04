using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
   public class DetalleExamenAtencionNegocio
    {
        

        public static DetalleExamenAtencionEntidad guardardeateleatencionExamen(DetalleExamenAtencionEntidad dato)
        {
            return DetalleExamenAtencionDatos.GuardarExamenDatos(dato);
        }

        public static List<DetalleExamenAtencionEntidad> DevolverListaFiltradaExamen(string dato)
        {
            return DetalleExamenAtencionDatos.DevolverExamenFiltradaDatos(dato);
        }
    }
}
