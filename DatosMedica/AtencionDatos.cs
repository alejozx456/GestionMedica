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
    public class AtencionDatos
    {
        public static AtencionEntidad GuardarAtencion(AtencionEntidad atencion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Atencion]
           ([Res_Ate]
           ,[Dia_Pac_Ate]
           ,[Id_Cita_Per]
           ,[Cost_Ate])
                             VALUES(@Res_Ate,@Dia_Pac_Ate,@Id_Cita_Per,@Cost_Aten)
                               SELECT SCOPE_IDENTITY()
                                    ";
                cmd.Parameters.AddWithValue("@Res_Ate", atencion.Registro);

                cmd.Parameters.AddWithValue("@Dia_Pac_Ate", atencion.Diagnostico);
                cmd.Parameters.AddWithValue("@Id_Cita_Per", atencion.Id_Cita);

                cmd.Parameters.AddWithValue("@Cost_Aten", atencion.Costo_Atencion);

                cmd.CommandType = CommandType.Text;
                var idPaciente = Convert.ToInt32(cmd.ExecuteScalar());
                atencion.Id = idPaciente;

                conexion.Close();
                return atencion;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<AtencionEntidad> DevolverListaAtenciones()
        {
            try
            {
                List<AtencionEntidad> ListaEntidad = new List<AtencionEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select p.Id_Atencion_Paciente,p.Res_Ate,p.Dia_Pac_aten,p.Id_Cita_Per,
                                   p.Cost_Aten_Med
                                    
                                   from Atencion p";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        AtencionEntidad atencion = new AtencionEntidad();
                        atencion.Id = Convert.ToInt32(dr["Id_Atencion_Paciente"].ToString());
                        atencion.Registro = dr["Res_Ate"].ToString();
                        atencion.Diagnostico = dr["Dia_Pac_aten"].ToString();
                        atencion.Id_Cita = Convert.ToInt32(dr["Id_Cita_Per"].ToString());
                        atencion.Costo_Atencion = Convert.ToInt32(dr["Cost_Aten_Med"].ToString());


                        ListaEntidad.Add(atencion);

                    }
                }
                conexion.Close();
                return ListaEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<AtencionEntidad> BuscarATencion(String dato)
        {

            List<AtencionEntidad> ListaEntidad = new List<AtencionEntidad>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
            conexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText =
                @"SELECT [Id_Ate]
      ,[Res_Ate]
      ,[Dia_Pac_Ate]
      ,[Id_Cita_Per]
      ,[Cost_Ate]
  FROM [Atencion] where Id_Cita_Per in 
                    (Select Id_Cita from [Cita Medica] where Id_Pac_Per in 
                    (Select Id_Pac from Pacientes where Id_Pac like '%" + dato + "%')) ";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    AtencionEntidad atencion = new AtencionEntidad();
                    atencion.Id = Convert.ToInt32(dr["Id_Ate"].ToString());
                    atencion.Registro = dr["Res_Ate"].ToString();
                    atencion.Diagnostico = dr["Dia_Pac_Ate"].ToString();
                    atencion.Id_Cita = Convert.ToInt32(dr["Id_Cita_Per"].ToString());
                    atencion.Costo_Atencion = Convert.ToInt32(dr["Cost_Ate"].ToString());


                    ListaEntidad.Add(atencion);

                }
            }
            conexion.Close();
            return ListaEntidad;
        }
    }   
}

