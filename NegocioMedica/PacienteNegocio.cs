using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
    public static class PacienteNegocio
    {
        public static PacienteEntidad GuardarPacienteNegocio(PacienteEntidad pacientes)
        {
            return PacienteDatos.GuardarPacienteDatos(pacientes);
        }

        public static List<PacienteEntidad> DevolverListaPacientesCita()
        {
            return PacienteDatos.DevolverListaPacientesCitaDatos();
        }

        public static PacienteEntidad DevolverPacientePorId(int id)
        {
            return PacienteDatos.DevolverPacientePorIdDatos(id);
        }

        public static PacienteEntidad EliminarPacientePorId(string id)
        {
            return PacienteDatos.EliminarPacientePorId(id);
        }

        public static PacienteEntidad DevolverPacientePorNombre(string nombre)
        {
            return PacienteDatos.DevolverPacientePorNombreDatos(nombre);
        }

        public static PacienteEntidad DevolverPacienteporApellido(string apellido)
        {
            return PacienteDatos.DevolverPacientePorApellido(apellido);
        }

        public static PacienteEntidad DevolverPacienteporCedula(string cedula)
        {
            return PacienteDatos.DevolverPacientePorCedula(cedula);
        }

        public static PacienteEntidad ModificarPacienteNegocio(PacienteEntidad pacientes)
        {
            return PacienteDatos.ModificarPacienteDatos(pacientes);
        }

        public static List<PacienteEntidad> BuscarPaciente(string dato)
        {
            return PacienteDatos.BuscarPaciente(dato);
        }
        
    }
}
