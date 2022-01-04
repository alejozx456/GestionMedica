using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;
namespace NegocioMedica
{
    public static class DetalleMedcinaNegocio
    {
        public static DetalleMedicinaEntidad GuardarDetalleMedicinaNegocio(DetalleMedicinaEntidad detalleMedicina)
        {
            return DetalleMedicinaDatos.GuardarDetalleMedicinaNegocio(detalleMedicina);
        }

        public static List<DetalleMedicinaEntidad> DevolverMedicinaDetallePorIdNegocio(int id)
        {
            return DetalleMedicinaDatos.DevolverMedicinaDetallePorIdDatos(id);
        }
    }
}
