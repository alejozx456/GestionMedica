using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class MedicinaNegocio
    {
        public static List<MedicinaEntidad> DevolverListaMedicinasNegocio()
        {
            return MedicinaDatos.DevolverListaMedicinasDatos();
        }

        public static MedicinaEntidad DevolverMedicinaporId(int id)
        {
            return MedicinaDatos.DevolverMedicinaPorIdDatos(id);
        }

        public static List<MedicinaEntidad> BuscarMedicina(string dato)
        {
            return MedicinaDatos.BuscarListaMedicinasDatos(dato);
        }
        public static List<MedicinaEntidad> ListaMedicinaFiltrada(string dato)
        {
            return MedicinaDatos.DevolverMedicamentoFiltradaDatos(dato);
        }
    }
}
