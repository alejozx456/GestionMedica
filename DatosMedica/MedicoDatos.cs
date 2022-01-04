using EntidadMedica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMedica
{
    public static class MedicoDatos
    {
        public static MedicoEntidad GuardarMedicoDatos(MedicoEntidad medicos)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Medicos]
                                   ([Ced_Med]
                                   ,[Nom_Med]
                                   ,[Ape_Med]
                                   ,[Fec_Nac_Med]
                                   ,[Sue_Med]
                                   ,[Esp_Per_Med])
                             VALUES(@Ced_Med,@Nom_Med,@Ape_Med,@Fec_Nac_Med,@Sue_Med,@Esp_Per_Med)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Ced_Med", medicos.Cedula);
                cmd.Parameters.AddWithValue("@Nom_Med", medicos.Nombre);
                cmd.Parameters.AddWithValue("@Ape_Med", medicos.Apellido);
                cmd.Parameters.AddWithValue("@Fec_Nac_Med", medicos.FechaNaci);
                cmd.Parameters.AddWithValue("@Sue_Med", medicos.Sueldo);
                cmd.Parameters.AddWithValue("@Esp_Per_Med", medicos.Id_Especialidad);
               

                cmd.CommandType = CommandType.Text;
                var idMedico = Convert.ToInt32(cmd.ExecuteScalar());
                medicos.Id = idMedico;

                conexion.Close();

                return medicos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static MedicoEntidad DevolverMedicoPorIdDatos(int idMedico)
        {
            try
            {
                MedicoEntidad medico = new MedicoEntidad();
                List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select m.Id_Med,m.Ced_Med,m.Nom_Med,m.Ape_Med,m.Sue_Med,m.Esp_Per_Med,e.Nom_Esp as Especialidad
                                    from Medicos m
                                    inner join dbo.Especialidades e on e.Id_Esp=M.Esp_Per_Med
									where m.Id_Med=@id";
                cmd.Parameters.AddWithValue("@id", idMedico);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        
                        medico.Id = Convert.ToInt32(dr["Id_Med"].ToString());
                        medico.Cedula = dr["Ced_Med"].ToString();
                        medico.Nombre = dr["Nom_Med"].ToString();
                        medico.Apellido = dr["Ape_Med"].ToString();
                        //medico.FechaNaci = DateTime.Parse(dr["Ape_Med"].ToString());
                        medico.Sueldo = Convert.ToInt32(dr["Sue_Med"].ToString());
                        medico.Id_Especialidad = Convert.ToInt32(dr["Esp_Per_Med"].ToString());
                        medico.Especialidad = dr["Especialidad"].ToString();

                    }

                }
                conexion.Close();
                return medico;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<MedicoEntidad> DevolverMedicosCitaDatos()
        {
            try
            {
                List<MedicoEntidad> ListaMedicos = new List<MedicoEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select m.Id_Med,m.Ced_Med,m.Nom_Med,m.Ape_Med,m.Fec_Nac_Med,m.Sue_Med,m.Esp_Per_Med,e.Nom_Esp as Especialidad
                                    from Medicos m
                                    inner join dbo.Especialidades e on e.Id_Esp=M.Esp_Per_Med";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        MedicoEntidad medico = new MedicoEntidad();
                        medico.Id = Convert.ToInt32(dr["Id_Med"].ToString());
                        medico.Cedula = dr["Ced_Med"].ToString();
                        medico.Nombre= dr["Nom_Med"].ToString();
                        medico.Apellido = dr["Ape_Med"].ToString();
                        medico.FechaNaci = (dr["Fec_Nac_Med"].ToString());
                        medico.Sueldo= Convert.ToInt32(dr["Sue_Med"].ToString());
                        medico.Id_Especialidad= Convert.ToInt32(dr["Esp_Per_Med"].ToString());
                        medico.Especialidad = dr["Especialidad"].ToString();
                        ListaMedicos.Add(medico);
                    }
                }
                conexion.Close();
                return ListaMedicos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<MedicoEntidad> BuscarMedico(String dato)
        {

            List<MedicoEntidad> ListaEntidad = new List<MedicoEntidad>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText =
                @"select m.Id_Med,m.Ced_Med,m.Nom_Med,m.Ape_Med,m.Sue_Med,m.Fec_Nac_Med
                     from Medicos m  where Ced_Med like '%" + dato + "%' OR Nom_Med like '%" + dato + "%' OR Ape_Med like '%" + dato + "%' ";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    MedicoEntidad medico = new MedicoEntidad();
                    medico.Id = Convert.ToInt32(dr["Id_Med"].ToString());
                    medico.Cedula = dr["Ced_Med"].ToString();
                    medico.Nombre = dr["Nom_Med"].ToString();
                    medico.Apellido = dr["Ape_Med"].ToString();
                    medico.FechaNaci = (dr["Fec_Nac_Med"].ToString());
                    medico.Sueldo = Convert.ToInt32(dr["Sue_Med"].ToString());
                    ListaEntidad.Add(medico);

                }
            }
            conexion.Close();
            return ListaEntidad;
        }

    }
}
