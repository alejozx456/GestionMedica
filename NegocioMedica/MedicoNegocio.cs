using EntidadMedica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosMedica;
namespace NegocioMedica
{
    public static class MedicoNegocio
    {
        public static MedicoEntidad GuardarMedico(MedicoEntidad medicos)
        {
            return MedicoDatos.GuardarMedicoDatos(medicos);
        }

        public static List<MedicoEntidad> DevolverMedicosCita()
        {
            return MedicoDatos.DevolverMedicosCitaDatos();
        }

        public static MedicoEntidad DevolverMedicoPorId(int id)
        {
            return MedicoDatos.DevolverMedicoPorIdDatos(id);
        }

        public static List<MedicoEntidad> BuscarMedico(string dato)
        {
            return MedicoDatos.BuscarMedico(dato);
        }
    }
}
