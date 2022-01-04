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
    public static class CitaMedicaDatos
    {
        public static CitaMedicaEntidad GuardarCitaDatos(CitaMedicaEntidad cita)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Cita Medica]
                                   ([Id_Pac_Per]
                                   ,[Id_Med_Per]
                                   ,[fecha])
                             VALUES(@Id_Pac_Per,@Id_Med_Per,@fecha)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Id_Pac_Per", cita.Id_Pac_Cita);
                cmd.Parameters.AddWithValue("@Id_Med_Per", cita.Id_Med_Cita);
                cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
                

                cmd.CommandType = CommandType.Text;
                var idCita = Convert.ToInt32(cmd.ExecuteScalar());
                cita.Id = idCita;

                conexion.Close();
                return cita;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<CitaMedicaEntidad> BuscarCita(String dato)
        {
            
            List<CitaMedicaEntidad> ListaEntidad = new List<CitaMedicaEntidad>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText =
                @"select m.Id_Cita as Id,m.Id_Pac_Per as Paciente,m.Id_Med_Per as  Medico,m.fecha as Fecha
                                   from [Cita Medica] m where Id_Pac_Per in 
                      (Select Id_Pac from Pacientes where Ced_Pac like '%" + dato + "%') ";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    CitaMedicaEntidad citas = new CitaMedicaEntidad();
                    citas.Id = Convert.ToInt32(dr["Id"].ToString());
                    citas.Id_Pac_Cita = Convert.ToInt32(dr["Paciente"].ToString());
                    citas.Id_Med_Cita = Convert.ToInt32(dr["Medico"].ToString());
                    citas.Fecha = dr["Fecha"].ToString();
                    ListaEntidad.Add(citas);

                }
            }
            conexion.Close();
            return ListaEntidad;
        }

        public static CitaMedicaEntidad DevolverPacientePorIdDatos(int cita)
        {
            try
            {
                CitaMedicaEntidad citaD = new CitaMedicaEntidad();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Cita]
      ,[Id_Pac_Per]
      ,[Id_Med_Per]
    
  FROM [Cita Medica] 
								   where Id_Cita=@id";
                cmd.Parameters.AddWithValue("@id", cita);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        citaD.Id = Convert.ToInt32(dr["Id_Cita"].ToString());
                        citaD.Id_Med_Cita = Convert.ToInt32(dr["Id_Med_Per"].ToString());
                        citaD.Id_Pac_Cita = Convert.ToInt32(dr["Id_Pac_Per"].ToString());


                    }

                }
                conexion.Close();
                return citaD;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
