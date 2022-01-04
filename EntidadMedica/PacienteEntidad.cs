using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class PacienteEntidad
    {


        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoSangre { get; set; }

        public PacienteEntidad()
        {

        }

        public PacienteEntidad(int id, string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string direccion, string fechaNac, string telefono, string genero, string estadoCivil, string tipoSangre)
        {
            Id = id;
            Cedula = cedula;
            Nombre1 = nombre1;
            Nombre2 = nombre2;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Direccion = direccion;
            FechaNac = fechaNac;
            Telefono = telefono;
            Genero = genero;
            EstadoCivil = estadoCivil;
            TipoSangre = tipoSangre;
        }
    }
}

