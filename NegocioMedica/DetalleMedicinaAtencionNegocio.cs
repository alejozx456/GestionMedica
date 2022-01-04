using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
   public class DetalleMedicinaAtencionNegocio
    {
        public static DetalleMedicinaAtencionEntidad GuardarExamen(DetalleMedicinaAtencionEntidad detalleMedicinaAtencionNegocio)
        {
            return DetalleMedicinaAtencionDatos.GuardarMedicamentoAtencionDatos(detalleMedicinaAtencionNegocio);
        }
    }
}
