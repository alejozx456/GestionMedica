using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class CitaMedicaNegocio
    {
        public static CitaMedicaEntidad GuardarCitaNegocio(CitaMedicaEntidad cita)
        {
            return CitaMedicaDatos.GuardarCitaDatos(cita);
        }
        public static List<CitaMedicaEntidad> listaDatosFiltrada(string cita)
        {
            return CitaMedicaDatos.BuscarCita(cita);
        }

        public static CitaMedicaEntidad CargarDatosCita(int id)
        {
            return CitaMedicaDatos.DevolverPacientePorIdDatos(id);
        }
    }
}
