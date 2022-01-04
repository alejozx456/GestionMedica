using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class DetalleEnfermedadNegocio
    {
        public static DetalleEnfermedadEntidad GuardarEnfermedadDetalle(DetalleEnfermedadEntidad enfermedadDetalle)
        {
            return DetallleEnfermedadesDatos.GuardarEnfermedadDetalleDatos(enfermedadDetalle);
        }

        public static List<DetalleEnfermedadEntidad> DevolverListaEnfermedadesporId(int id)
        {
            return DetallleEnfermedadesDatos.DevolverListaEnfermedadesporIdDatos(id);
        }
    }
}
