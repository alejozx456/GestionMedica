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
    public static class DetalleMedicinaDatos
    {
        public static DetalleMedicinaEntidad GuardarDetalleMedicinaNegocio(DetalleMedicinaEntidad detalleMedicina)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Detallle_Medicinas]
                                   ([Id_Med_Per]
                                   ,[Id_Hist_Per])
                             VALUES(@Id_Med_Per,@Id_Hist_Per)
                                    ";
                cmd.Parameters.AddWithValue("@Id_Med_Per", detalleMedicina.Id_Med_Per);
                cmd.Parameters.AddWithValue("@Id_Hist_Per", detalleMedicina.Id_Hist_Per);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return detalleMedicina;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<DetalleMedicinaEntidad> DevolverMedicinaDetallePorIdDatos(int idDetalleMedici)
        {
            try
            {
                List<DetalleMedicinaEntidad> ListaMedicinas = new List<DetalleMedicinaEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select d.Id_Hist_Per as Id,d.Id_Med_Per as IDMedicina,m.Nom_Med as Nombre 
                                    from Detallle_Medicinas d
                                    inner join dbo.Medicinas m on m.Id_Med=d.Id_Med_Per
                                    where Id_Hist_Per=@id";
                cmd.Parameters.AddWithValue("@id", idDetalleMedici);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DetalleMedicinaEntidad detalleMedici = new DetalleMedicinaEntidad();
                        detalleMedici.Id_Hist_Per = Convert.ToInt32(dr["Id"].ToString());
                        detalleMedici.Id_Med_Per = Convert.ToInt32(dr["IDMedicina"].ToString());
                        detalleMedici.Nombre = dr["Nombre"].ToString();

                        ListaMedicinas.Add(detalleMedici);
                    }
                }
                conexion.Close();
                return ListaMedicinas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
