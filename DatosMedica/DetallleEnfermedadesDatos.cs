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
    public static class DetallleEnfermedadesDatos
    {
        public static DetalleEnfermedadEntidad GuardarEnfermedadDetalleDatos(DetalleEnfermedadEntidad enfermedadDetalle)
        {
           
                try
                {
                    SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @"INSERT INTO [Detalle_Enfermedades]
                                   ([Id_Enf_Per]
                                   ,[Id_Hist_Per])
                             VALUES(@Id_Enf_Per,@Id_Hist_Per)
                                    ";
                    cmd.Parameters.AddWithValue("@Id_Enf_Per", enfermedadDetalle.Id_Enf_Per);
                    cmd.Parameters.AddWithValue("@Id_Hist_Per", enfermedadDetalle.Id_His_Per);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    conexion.Close();

                    return enfermedadDetalle;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        public static List<DetalleEnfermedadEntidad> DevolverListaEnfermedadesporIdDatos(int idDetalleEnfer)
        {
            try
            {
                List<DetalleEnfermedadEntidad> ListaEnfermedades = new List<DetalleEnfermedadEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select d.Id_Enf_Per,d.Id_Hist_Per,e.Nom_Enf
                                    from Detalle_Enfermedades d
                                    inner join dbo.Enfermedades e on e.Id_Enf=d.Id_Enf_Per
                                    where Id_Hist_Per=@id";
                cmd.Parameters.AddWithValue("@id", idDetalleEnfer);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DetalleEnfermedadEntidad detalleEnf = new DetalleEnfermedadEntidad();
                        detalleEnf.Id_Enf_Per = Convert.ToInt32(dr["Id_Enf_Per"].ToString());
                        detalleEnf.Id_His_Per= Convert.ToInt32(dr["Id_Hist_Per"].ToString());
                        detalleEnf.NombreEnf = dr["Nom_Enf"].ToString();

                        ListaEnfermedades.Add(detalleEnf);
                    }
                }
                conexion.Close();
                return ListaEnfermedades;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


