using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadMedica
{
    public class UsuarioEntidad
    {
       

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Ocupacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id_Med { get; set; }
        public UsuarioEntidad()
        {

        }

        public UsuarioEntidad(int id, string login, string password, string ocupacion, string nombre, string apellido, int id_Med)
        {
            Id = id;
            Login = login;
            Password = password;
            Ocupacion = ocupacion;
            Nombre = nombre;
            Apellido = apellido;
            Id_Med = id_Med;
        }
    }
}
