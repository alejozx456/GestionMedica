using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
using DatosMedica;

namespace NegocioMedica
{
   public static class UsuarioNegocio
    {
        public static UsuarioEntidad LoginNegocio(string usuario,string password)
        {
            return UsuarioDatos.Login(usuario, password);
        }

        public static UsuarioEntidad DevolverPerfilporid(int id)
        {
            return UsuarioDatos.DevolverPerfilid(id);
        }

        public static UsuarioEntidad ModificarUsuarioporId(UsuarioEntidad usuario, int id)
        {
            return UsuarioDatos.ModificarUsuarioporId(usuario, id);
        }

        public static UsuarioEntidad GuardarUsuario(UsuarioEntidad usuario)
        {
            return UsuarioDatos.GuardarUsuarioDatos(usuario);
        }

        public static List<UsuarioEntidad> DevolverListadeUsuarios()
        {
            return UsuarioDatos.DevolverListadeUsuarios();
        }

        public static UsuarioEntidad DevolverUsuarioPorId(int id)
        {
            return UsuarioDatos.DevolverUsuarioPorIdDatos(id);
        }

        public static UsuarioEntidad EliminarUsuarioPorId(string id)
        {
            return UsuarioDatos.EliminarUsuarioPorId(id);
        }
    }
}
