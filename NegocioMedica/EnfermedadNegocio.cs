using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosMedica;
using EntidadMedica;

namespace NegocioMedica
{
    public static class EnfermedadNegocio
    {
        public static List<EnfermedadEntidad> DevolverListadeEnfermedadesNegocio()
        {
            return EnfermedadesDatos.DevolverListaenfermedadesDatos();
        }

        public static EnfermedadEntidad DevolverListadeEnfermedadesporIdNegocio(int id)
        {
            return EnfermedadesDatos.DevolverListaEnfermedadesporIdDatos(id);
        }
    }
}
