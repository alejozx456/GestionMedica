using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class HistorialMedicoNegocio
    {
        public static HistorialMedicoEntidad GuardarHistorialNegocio(HistorialMedicoEntidad historial)
        {
            return HistorialMedicoDatos.GuardarHistorialDatos(historial);
        }

        public static List<HistorialMedicoEntidad> DevolverListaHistorialNegocio()
        {
            return HistorialMedicoDatos.DevolverListaHistoriaDatos();
        }

        public static HistorialMedicoEntidad DevolverHistorialId(int id)
        {
            return HistorialMedicoDatos.DevolverHistorialIdDatos(id);
        }
    }
}
