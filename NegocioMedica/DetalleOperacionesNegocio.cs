using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class DetalleOperacionesNegocio
    {
        public static DetalleOperacionesEntidad GuardarDetalleOperacionNegocio(DetalleOperacionesEntidad detalleO)
        {
            return DetalleOperacionesDatos.GuardarDetalleOperacionDatos(detalleO);
        }

        public static List<DetalleOperacionesEntidad> DevolverOperacionDetallePorIdNegocio(int id)
        {
            return DetalleOperacionesDatos.DevolverOperacionesDetallePorIdDatos(id);
        }
    }
}
