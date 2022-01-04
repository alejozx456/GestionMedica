using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadMedica;
namespace DatosMedica
{
   public static  class UsuarioDatos
    {
       
        public static UsuarioEntidad Login(String usuario,string password)
        {
            try
            {
               
                UsuarioEntidad usuarioe = new UsuarioEntidad();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Usu]
                                  ,[Nom_Login]
                                  ,[Pass_Login]
                                  ,[Ocupacion]
                                  ,[Nombre]
                                  ,[Apellido]
                                    FROM [Usuarios]
                                    where Nom_Login=@usuario and Pass_Login=@password";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        
                           
                            usuarioe.Id = Convert.ToInt32(dr["Id_Usu"].ToString());
                            usuarioe.Login = dr["Nom_Login"].ToString();
                            usuarioe.Password= dr["Pass_Login"].ToString();
                            usuarioe.Ocupacion= dr["Ocupacion"].ToString();
                            usuarioe.Nombre= dr["Nombre"].ToString();
                            usuarioe.Apellido= dr["Apellido"].ToString();
                       



                    }
                }
                conexion.Close();
                return usuarioe;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidad EliminarUsuarioPorId(string idUsuario)
        {
            try
            {
               UsuarioEntidad usuario = new UsuarioEntidad();
                
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"delete from
                                    Usuarios
                                    where Id_Usu=@id;";
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        usuario.Id = Convert.ToInt32(dr["Id_Usu"].ToString());


                    }

                }
                conexion.Close();
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidad DevolverUsuarioPorIdDatos(int idUsuario)
        {
            try
            {
                UsuarioEntidad usuario = new UsuarioEntidad();
                
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Usu]
                                  ,[Nom_Login]
                                  ,[Pass_Login]
                                  ,[Ocupacion]
                                  ,[Nombre]
                                  ,[Apellido]
                                    FROM [Usuarios]
                                    where Id_Usu=@id";
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        usuario.Id = Convert.ToInt32(dr["Id_Usu"].ToString());
                        usuario.Login = dr["Nom_Login"].ToString();
                        usuario.Password = dr["Pass_Login"].ToString();
                        usuario.Ocupacion = dr["Ocupacion"].ToString();
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Apellido = dr["Apellido"].ToString();


                    }

                }
                conexion.Close();
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<UsuarioEntidad> DevolverListadeUsuarios()
        {
            try
            {
                List<UsuarioEntidad> ListaUsuarios = new List<UsuarioEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Usu]
                                  ,[Nom_Login]
                                  ,[Pass_Login]
                                  ,[Ocupacion]
                                  ,[Nombre]
                                  ,[Apellido]
                              FROM [Usuarios]";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        UsuarioEntidad usuario = new UsuarioEntidad();
                        usuario.Id = Convert.ToInt32(dr["Id_Usu"].ToString());
                        usuario.Login = dr["Nom_Login"].ToString();
                        usuario.Password = dr["Pass_Login"].ToString();
                        usuario.Ocupacion = dr["Ocupacion"].ToString();
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Apellido = dr["Apellido"].ToString();
                        ListaUsuarios.Add(usuario);

                    }
                }
                conexion.Close();
                return ListaUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidad GuardarUsuarioDatos(UsuarioEntidad usuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Usuarios]
                                   ([Nom_Login]
                                   ,[Pass_Login]
                                   ,[Ocupacion]
                                   ,[Nombre]
                                   ,[Apellido])
                             VALUES(@Nom_Login,@Pass_Login,@Ocupacion,@Nombre,@Apellido)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Nom_Login", usuario.Login);
                cmd.Parameters.AddWithValue("@Pass_Login", usuario.Password);
                cmd.Parameters.AddWithValue("@Ocupacion", usuario.Ocupacion);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);


                cmd.CommandType = CommandType.Text;
                var idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                usuario.Id = idUsuario;

                conexion.Close();
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidad ModificarUsuarioporId(UsuarioEntidad usuario, int idUsuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [Usuarios]
                                   SET [Pass_Login] = @password 
                                      ,[Nombre] = @nombre
                                      ,[Apellido] = @apellido
                                 where Id_Usu=@id
                                    ";
                cmd.Parameters.AddWithValue("@id", idUsuario);
                cmd.Parameters.AddWithValue("@password ", usuario.Password);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
               

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UsuarioEntidad DevolverPerfilid(int idPerfil)
        {
            try
            {
                UsuarioEntidad usuarioe = new UsuarioEntidad();
               
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Usu]
                                  ,[Nom_Login]
                                  ,[Pass_Login]
                                  ,[Ocupacion]
                                  ,[Nombre]
                                  ,[Apellido]
                                    FROM [Usuarios]
                                    where Id_Usu=@id";
                cmd.Parameters.AddWithValue("@id", idPerfil);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        usuarioe.Id = Convert.ToInt32(dr["Id_Usu"].ToString());
                        usuarioe.Login = dr["Nom_Login"].ToString();
                        usuarioe.Password = dr["Pass_Login"].ToString();
                        usuarioe.Ocupacion = dr["Ocupacion"].ToString();
                        usuarioe.Nombre = dr["Nombre"].ToString();
                        usuarioe.Apellido = dr["Apellido"].ToString();

                    }

                }
                conexion.Close();
                return usuarioe;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
