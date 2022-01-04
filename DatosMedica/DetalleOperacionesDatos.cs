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
    public static class DetalleOperacionesDatos
    {
        public static DetalleOperacionesEntidad GuardarDetalleOperacionDatos(DetalleOperacionesEntidad detalleO)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Detalle_Operaciones]
                                   ([Id_Op_Per]
                                   ,[Id_Hist_Per])
                             VALUES(@Id_Op_Per,@Id_Hist_Per)
                                    ";
                cmd.Parameters.AddWithValue("@Id_Op_Per", detalleO.Id_Oper_Per);
                cmd.Parameters.AddWithValue("@Id_Hist_Per", detalleO.Id_Hist_Per);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return detalleO;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<DetalleOperacionesEntidad> DevolverOperacionesDetallePorIdDatos(int idDetalleOperaciones)
        {
            try
            {
                List<DetalleOperacionesEntidad> ListaOperaciones = new List<DetalleOperacionesEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select d.Id_Hist_Per as Id,d.Id_Op_Per as IDOperacion,o.Nom_Op as Nombre
                                    from Detalle_Operaciones d
                                    inner join dbo.Operaciones o on o.Id_Op=d.Id_Op_Per
                                    where Id_Hist_Per=@id";
                cmd.Parameters.AddWithValue("@id", idDetalleOperaciones);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DetalleOperacionesEntidad detalleoperaciones = new DetalleOperacionesEntidad();
                        detalleoperaciones.Id_Hist_Per = Convert.ToInt32(dr["Id"].ToString());
                        detalleoperaciones.Id_Oper_Per = Convert.ToInt32(dr["IDOperacion"].ToString());
                        detalleoperaciones.Nombre = dr["Nombre"].ToString();

                        ListaOperaciones.Add(detalleoperaciones);
                    }
                }
                conexion.Close();
                return ListaOperaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
