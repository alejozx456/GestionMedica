using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class EspecialidadNegocio
    {
        public static List<EspecialidadEntidad> DevolverListaEspecialidad()
        {
            return EspecialidadDatos.DevolverListaEspecialidadDatos();
        }
    }
}
