using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
   public class AtencionNegocio
    {
        public static AtencionEntidad GuardarAtencionNegocio(AtencionEntidad atencion)
        {
            return AtencionDatos.GuardarAtencion(atencion);
        }

        public static List<AtencionEntidad> ListarAtencion()
        {
            return AtencionDatos.DevolverListaAtenciones();
        }

        public static List<AtencionEntidad> buscarAtencion(string dato)
        {
            return AtencionDatos.BuscarATencion(dato);
        }
    }
}
