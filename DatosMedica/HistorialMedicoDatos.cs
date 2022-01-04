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
    public static class HistorialMedicoDatos
    {
        public static HistorialMedicoEntidad GuardarHistorialDatos(HistorialMedicoEntidad historial)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Historia Clinica]
                                    ([Id_Pac_Per])
                             VALUES(@Id_Pac_Per)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Id_Pac_Per", historial.Id_Pac_Per);
                

                cmd.CommandType = CommandType.Text;
                var idHistorial = Convert.ToInt32(cmd.ExecuteScalar());
                historial.Id = idHistorial;

                conexion.Close();
                return historial;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static HistorialMedicoEntidad DevolverHistorialIdDatos(int idHistorial)
        {
            try
            {
                HistorialMedicoEntidad historial = new HistorialMedicoEntidad();
                //List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select h.Id_Hist_Cli ,h.Id_Pac_Per  ,p.Ced_Pac ,p.Nom_Pac ,p.Ape_Pac 
                                    from [Historia Clinica] h
                                    inner join dbo.Pacientes p on p.Id_Pac=h.Id_Pac_Per
                                    where h.Id_Hist_Cli=@id";
                cmd.Parameters.AddWithValue("@id", idHistorial);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        historial.Id = Convert.ToInt32(dr["Id_Hist_Cli"].ToString());
                        historial.Id_Pac_Per = Convert.ToInt32(dr["Id_Pac_Per"].ToString());
                        historial.Cedula = dr["Ced_Pac"].ToString();
                        historial.Nombre = dr["Nom_Pac"].ToString();
                        historial.Apellido = dr["Ape_Pac"].ToString();


                    }

                }
                conexion.Close();
                return historial;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<HistorialMedicoEntidad> DevolverListaHistoriaDatos()
        {
            try
            {
                List<HistorialMedicoEntidad> ListaHistorial = new List<HistorialMedicoEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select h.Id_Hist_Cli as Id,h.Id_Pac_Per as IdPaciente ,p.Ced_Pac as Cedula,p.Nom_Pac as Nombre,p.Ape_Pac as Apellido
                                    from [Historia Clinica] h
                                    inner join dbo.Pacientes p on p.Id_Pac=h.Id_Pac_Per";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        HistorialMedicoEntidad historial = new HistorialMedicoEntidad();
                        historial.Id = Convert.ToInt32(dr["Id"].ToString());
                        historial.Id_Pac_Per = Convert.ToInt32(dr["IdPaciente"].ToString());
                        historial.Cedula = dr["Cedula"].ToString();
                        historial.Nombre = dr["Nombre"].ToString();
                        historial.Apellido = dr["Apellido"].ToString();

                        ListaHistorial.Add(historial);
                    }
                }
                conexion.Close();
                return ListaHistorial;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
