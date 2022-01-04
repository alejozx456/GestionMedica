using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class ExamenNegocio
    {
        public static List<ExamenEntidad> DevolverListaExamenesNegocio()
        {
            return EsamenDatos.DevolverListaExamenesDatos();


        }

        public static ExamenEntidad DevolverExamenporId(int id)
        {
            return EsamenDatos.DevolverExamenporIdDatos(id);
        }

       
    }
}
