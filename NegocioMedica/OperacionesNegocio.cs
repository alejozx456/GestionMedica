using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class OperacionesNegocio
    {
        public static List<OperacionesEntidad> DevolverListaOPeracionesNegocio()
        {
            return OperacionesDatos.DevolverListaOperacionesDatos();
        }

        public static OperacionesEntidad DevolverOperacionPorIdNegocio(int id)
        {
            return OperacionesDatos.DevolverOperacionesPorIdDatos(id);
        }
    }
}
