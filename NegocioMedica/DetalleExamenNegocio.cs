using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;


namespace NegocioMedica
{
    public static class DetalleExamenNegocio
    {
        public static DetalleExamenEntidad GuardarExamen(DetalleExamenEntidad detalleE)
        {
            return DetalleExamenDatos.GuardarExamenDatos(detalleE);
        }

        public static DetalleExamenEntidad DevolverExamenDetalleporId(int id)
        {
            return DetalleExamenDatos.DevolverDetalleExamenporIdDatos(id);
        }

        public static List<DetalleExamenEntidad> DevolverListaDetalleExaNegocio()
        {
            return DetalleExamenDatos.DevolverListaMedicinasDatos();
        }

        public static List<DetalleExamenEntidad> DelverListarFiltardaNegocio(int dato)
        {
            return DetalleExamenDatos.DevolverListaExamenFiltradaDatos(dato);
        }
    }
}
