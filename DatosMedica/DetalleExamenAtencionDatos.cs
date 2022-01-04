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
   public class DetalleExamenAtencionDatos
    {
        public static DetalleExamenAtencionEntidad GuardarExamenDatos(DetalleExamenAtencionEntidad detalleE)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Detalle_Atencion_Examen]
                                   ([Id_Det_Exa_Per]
           ,[Id_Ate_Per]
           ,[Des_Exa_Per])
                             VALUES(@Id_Det_Exa_Per,@Id_Ate_Per,@Des_Exa_Per)
                              
                                    ";
                cmd.Parameters.AddWithValue("@Id_Det_Exa_Per", detalleE.Id_Det_Exa_Per);
                cmd.Parameters.AddWithValue("@Id_Ate_Per", detalleE.Id_Ate_Per);
                cmd.Parameters.AddWithValue("@Des_Exa_Per", detalleE.Descripcion);

                cmd.CommandType = CommandType.Text;
                var IdExamen = Convert.ToInt32(cmd.ExecuteScalar());
                detalleE.Id_Det_Exa_Per = IdExamen;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return detalleE;
            }
            catch (Exception)
            {

                throw;
            }
        }
         
        public static List<DetalleExamenAtencionEntidad> DevolverExamenFiltradaDatos(String dato)
        {
            try
            {
                List<DetalleExamenAtencionEntidad> ListaDetalleExa = new List<DetalleExamenAtencionEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [Id_Det_Exa_Per],[Id_Ate_Per],[Des_Exa_Per]
                                     FROM [Detalle_Atencion_Examen] where Id_Ate_Per in (
                                        SELECT Id_Ate from [Atencion] where Id_Cita_Per in(
                                      Select Id_Cita from [Cita Medica] where Id_Pac_Per in (
                                       Select Id_Pac from [Pacientes] where Id_Pac like '%" + dato + "%' )))";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DetalleExamenAtencionEntidad detalleExa = new DetalleExamenAtencionEntidad();
                        detalleExa.Id_Det_Exa_Per = Convert.ToInt32(dr["Id_Det_Exa_Per"].ToString());
                        detalleExa.Id_Ate_Per = Convert.ToInt32(dr["Id_Ate_Per"].ToString());
                        detalleExa.Descripcion = dr["Des_Exa_Per"].ToString();
                        ListaDetalleExa.Add(detalleExa);
                    }
                }
                conexion.Close();
                return ListaDetalleExa;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
