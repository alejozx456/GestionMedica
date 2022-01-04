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
    public class DetalleMedicinaAtencionDatos
    {
        public static DetalleMedicinaAtencionEntidad GuardarMedicamentoAtencionDatos(DetalleMedicinaAtencionEntidad detalleE)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [DetalleMedicamentoAtencion]
           ([Id_Med_Per]
           ,[Id_Ate_Per]) VALUES(@Id_Med_Per,@Id_Ate_Per)
                                    ";
                cmd.Parameters.AddWithValue("@Id_Med_Per", detalleE.Id_Med_Per);
                cmd.Parameters.AddWithValue("@Id_Ate_Per", detalleE.Id_Ate_Per);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conexion.Close();

                return detalleE;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
