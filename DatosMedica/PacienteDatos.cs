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
    public static class PacienteDatos
    {
        public static PacienteEntidad GuardarPacienteDatos(PacienteEntidad pacientes)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Pacientes]
                                   ([Ced_Pac]
                                   ,[Nom_Pac]
                                   ,[Nom2_Pac]
                                   ,[Ape_Pac]
                                   ,[Ape2_Pac]
                                   ,[Dir_Pac]
                                   ,[Fec_Nac_Pac]
                                   ,[Tel_Pac]
                                   ,[Gen_Pac]
                                   ,[Est_Civ_Pac]
                                   ,[Tip_San_Pac])
                             VALUES(@Ced_Pac,@Nom_Pac,@Nom2_Pac,@Ape_Pac,@Ape2_Pac,@Dir_Pac,@Fec_Nac_Pac,@Tel_Pac,@Gen_Pac,@Est_Civ_Pac,@Tip_San_Pac)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Ced_Pac", pacientes.Cedula);
                cmd.Parameters.AddWithValue("@Nom_Pac", pacientes.Nombre1);
                cmd.Parameters.AddWithValue("@Nom2_Pac", pacientes.Nombre2);
                cmd.Parameters.AddWithValue("@Ape_Pac", pacientes.Apellido1);
                cmd.Parameters.AddWithValue("@Ape2_Pac", pacientes.Apellido2);
                cmd.Parameters.AddWithValue("@Dir_Pac", pacientes.Direccion);
                cmd.Parameters.AddWithValue("@Fec_Nac_Pac", pacientes.FechaNac);
                cmd.Parameters.AddWithValue("@Tel_Pac", pacientes.Telefono);
                cmd.Parameters.AddWithValue("@Gen_Pac", pacientes.Genero);
                cmd.Parameters.AddWithValue("@Est_Civ_Pac", pacientes.EstadoCivil);
                cmd.Parameters.AddWithValue("@Tip_San_Pac", pacientes.TipoSangre);

                cmd.CommandType = CommandType.Text;
                var idPaciente = Convert.ToInt32(cmd.ExecuteScalar());
                pacientes.Id = idPaciente;

                conexion.Close();
                return pacientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PacienteEntidad ModificarPacienteDatos(PacienteEntidad pacientes)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"UPDATE [Pacientes]
                                   SET [Ced_Pac]= @Ced_Pac
                                      ,[Nom_Pac]= @Nom_Pac
                                      ,[Nom2_Pac]= @Nom2_Pac
                                      ,[Ape_Pac]= @Ape_Pac
                                      ,[Ape2_Pac]=@Ape2_Pac
                                      ,[Dir_Pac]= @Dir_Pac
                                      ,[Fec_Nac_Pac]= @Fec_Nac_Pac 
                                      ,[Tel_Pac]= @Tel_Pac
                                      ,[Gen_Pac]= @Gen_Pac 
                                      ,[Est_Civ_Pac]= @Est_Civ_Pac
                                      ,[Tip_San_Pac]= @Tip_San_Pac 
                                 WHERE Ced_Pac=@Ced_Pac
                                    ";
                cmd.Parameters.AddWithValue("@Ced_Pac", pacientes.Cedula);
                cmd.Parameters.AddWithValue("@Nom_Pac", pacientes.Nombre1);
                cmd.Parameters.AddWithValue("@Nom2_Pac", pacientes.Nombre2);
                cmd.Parameters.AddWithValue("@Ape_Pac", pacientes.Apellido1);
                cmd.Parameters.AddWithValue("@Ape2_Pac", pacientes.Apellido2);
                cmd.Parameters.AddWithValue("@Dir_Pac", pacientes.Direccion);
                cmd.Parameters.AddWithValue("@Fec_Nac_Pac", pacientes.FechaNac);
                cmd.Parameters.AddWithValue("@Tel_Pac", pacientes.Telefono);
                cmd.Parameters.AddWithValue("@Gen_Pac", pacientes.Genero);
                cmd.Parameters.AddWithValue("@Est_Civ_Pac", pacientes.EstadoCivil);
                cmd.Parameters.AddWithValue("@Tip_San_Pac", pacientes.TipoSangre);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();
                return pacientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PacienteEntidad DevolverPacientePorCedula(string cedulaPaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Pac]
                                  ,[Ced_Pac]
                                  ,[Nom_Pac]
                                  ,[Nom2_Pac]
                                  ,[Ape_Pac]
                                  ,[Ape2_Pac]
                                  ,[Dir_Pac]
                                  ,[Tel_Pac]
                                  ,[Gen_Pac]
                                  ,[Est_Civ_Pac]
                                  ,[Tip_San_Pac]
                              FROM [Pacientes]
                              where Ced_Pac=@cedula";
                cmd.Parameters.AddWithValue("@cedula", cedulaPaciente);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                        paciente.Cedula = dr["Ced_Pac"].ToString();
                        paciente.Nombre1 = dr["Nom_Pac"].ToString();
                        paciente.Nombre2 = dr["Nom2_Pac"].ToString();
                        paciente.Apellido1 = dr["Ape_Pac"].ToString();
                        paciente.Apellido2 = dr["Ape2_Pac"].ToString();
                        paciente.Direccion = dr["Dir_Pac"].ToString();
                        paciente.Telefono = dr["Tel_Pac"].ToString();
                        paciente.Genero = dr["Gen_Pac"].ToString();
                        paciente.EstadoCivil = dr["Est_Civ_Pac"].ToString();
                        paciente.TipoSangre = dr["Tip_San_Pac"].ToString();


                    }

                }
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PacienteEntidad DevolverPacientePorApellido(string apellidoPaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Pac]
                                  ,[Ced_Pac]
                                  ,[Nom_Pac]
                                  ,[Nom2_Pac]
                                  ,[Ape_Pac]
                                  ,[Ape2_Pac]
                                  ,[Dir_Pac]
                                  ,[Tel_Pac]
                                  ,[Gen_Pac]
                                  ,[Est_Civ_Pac]
                                  ,[Tip_San_Pac]
                              FROM [Pacientes]
                              where Ape_Pac=@apellido";
                cmd.Parameters.AddWithValue("@apellido", apellidoPaciente);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                        paciente.Cedula = dr["Ced_Pac"].ToString();
                        paciente.Nombre1 = dr["Nom_Pac"].ToString();
                        paciente.Nombre2 = dr["Nom2_Pac"].ToString();
                        paciente.Apellido1 = dr["Ape_Pac"].ToString();
                        paciente.Apellido2 = dr["Ape2_Pac"].ToString();
                        paciente.Direccion = dr["Dir_Pac"].ToString();
                        paciente.Telefono = dr["Tel_Pac"].ToString();
                        paciente.Genero = dr["Gen_Pac"].ToString();
                        paciente.EstadoCivil = dr["Est_Civ_Pac"].ToString();
                        paciente.TipoSangre = dr["Tip_San_Pac"].ToString();


                    }

                }
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PacienteEntidad DevolverPacientePorNombreDatos(string nombrePaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Pac]
                                  ,[Ced_Pac]
                                  ,[Nom_Pac]
                                  ,[Nom2_Pac]
                                  ,[Ape_Pac]
                                  ,[Ape2_Pac]
                                  ,[Dir_Pac]
                                  ,[Tel_Pac]
                                  ,[Gen_Pac]
                                  ,[Est_Civ_Pac]
                                  ,[Tip_San_Pac]
                              FROM [Pacientes]
                              where Nom_Pac=@nombre";
                cmd.Parameters.AddWithValue("@nombre", nombrePaciente);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                        paciente.Cedula = dr["Ced_Pac"].ToString();
                        paciente.Nombre1 = dr["Nom_Pac"].ToString();
                        paciente.Nombre2 = dr["Nom2_Pac"].ToString();
                        paciente.Apellido1 = dr["Ape_Pac"].ToString();
                        paciente.Apellido2 = dr["Ape2_Pac"].ToString();
                        paciente.Direccion= dr["Dir_Pac"].ToString();
                        paciente.Telefono= dr["Tel_Pac"].ToString();
                        paciente.Genero= dr["Gen_Pac"].ToString();
                        paciente.EstadoCivil= dr["Est_Civ_Pac"].ToString();
                        paciente.TipoSangre= dr["Tip_San_Pac"].ToString();


                    }

                }
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PacienteEntidad EliminarPacientePorId(string idPaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"delete from Pacientes
                                  where Id_Pac=@id";
                cmd.Parameters.AddWithValue("@id", idPaciente);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                       

                    }

                }
                conexion.Close();
                return paciente;
            }
            catch (Exception e)
            {
                throw;
                
            }
        }

        public static PacienteEntidad DevolverPacientePorIdDatos(int idPaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select p.Id_Pac,p.Ced_Pac,p.Nom_Pac,p.Ape_Pac
                                   from Pacientes p
								   where p.Id_Pac=@id";
                cmd.Parameters.AddWithValue("@id", idPaciente);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                       
                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                        paciente.Cedula = dr["Ced_Pac"].ToString();
                        paciente.Nombre1 = dr["Nom_Pac"].ToString();
                        paciente.Apellido1 = dr["Ape_Pac"].ToString();
                        
                    }

                }
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<PacienteEntidad> DevolverListaPacientesCitaDatos()
        {
            try
            {
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Pac]
                                  ,[Ced_Pac]
                                  ,[Nom_Pac]
                                  ,[Nom2_Pac]
                                  ,[Ape_Pac]
                                  ,[Ape2_Pac]
                                  ,[Dir_Pac]
                                  ,[Fec_Nac_Pac]
                                  ,[Tel_Pac]
                                  ,[Gen_Pac]
                                  ,[Est_Civ_Pac]
                                  ,[Tip_San_Pac]
                              FROM [Pacientes]";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PacienteEntidad paciente = new PacienteEntidad();
                        paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                        paciente.Cedula = dr["Ced_Pac"].ToString();
                        paciente.Nombre1 = dr["Nom_Pac"].ToString();
                        paciente.Nombre2= dr["Nom2_Pac"].ToString();
                        paciente.Direccion= dr["Dir_Pac"].ToString();
                        paciente.FechaNac= dr["Fec_Nac_Pac"].ToString();
                        paciente.Apellido1 = dr["Ape_Pac"].ToString();
                        paciente.Apellido2= dr["Ape2_Pac"].ToString();
                        paciente.Telefono= dr["Tel_Pac"].ToString();
                        paciente.Genero= dr["Gen_Pac"].ToString();
                        paciente.EstadoCivil= dr["Est_Civ_Pac"].ToString();
                        paciente.TipoSangre= dr["Tip_San_Pac"].ToString();

                        ListaPacientes.Add(paciente);

                    }
                }
                conexion.Close();
                return ListaPacientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<PacienteEntidad> BuscarPaciente(String dato)
        {

            List<PacienteEntidad> ListaEntidad = new List<PacienteEntidad>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText =
                @"SELECT [Id_Pac],[Ced_Pac],[Nom_Pac],[Nom2_Pac],[Ape_Pac] ,[Ape2_Pac],[Dir_Pac]
                        ,[Fec_Nac_Pac],[Tel_Pac],[Gen_Pac],[Est_Civ_Pac],[Tip_San_Pac]
                 FROM [Pacientes]  where Ced_Pac like '%" + dato + "%' OR Nom_Pac like '%" + dato + "%' OR Ape_Pac like '%" + dato + "%' OR Id_Pac in (Select Id_Pac_Per from [Cita Medica ]where fecha like '%" + dato + "%')";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    PacienteEntidad paciente = new PacienteEntidad();
                    paciente.Id = Convert.ToInt32(dr["Id_Pac"].ToString());
                    paciente.Cedula = dr["Ced_Pac"].ToString();
                    paciente.Nombre1 = dr["Nom_Pac"].ToString();
                    paciente.Nombre2 = dr["Nom2_Pac"].ToString();
                    paciente.Direccion = dr["Dir_Pac"].ToString();
                    paciente.FechaNac = dr["Fec_Nac_Pac"].ToString();
                    paciente.Apellido1 = dr["Ape_Pac"].ToString();
                    paciente.Apellido2 = dr["Ape2_Pac"].ToString();
                    paciente.Telefono = dr["Tel_Pac"].ToString();
                    paciente.Genero = dr["Gen_Pac"].ToString();
                    paciente.EstadoCivil = dr["Est_Civ_Pac"].ToString();
                    paciente.TipoSangre = dr["Tip_San_Pac"].ToString();

                    ListaEntidad.Add(paciente);

                }
            }
            conexion.Close();
            return ListaEntidad;
        }
        
    }
}
