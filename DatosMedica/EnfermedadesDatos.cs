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
    public static class EnfermedadesDatos
    {
        public static List<EnfermedadEntidad> DevolverListaenfermedadesDatos()
        {
            try
            {
                List<EnfermedadEntidad> ListaEnfermedades = new List<EnfermedadEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select e.Id_Enf as Id,e.Nom_Enf as Nombre,e.Desc_Enf as Descripcion
                                    from Enfermedades e";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        EnfermedadEntidad enfermedad = new EnfermedadEntidad();
                        enfermedad.Id = Convert.ToInt32(dr["Id"].ToString());
                        enfermedad.Nombre = dr["Nombre"].ToString();
                        enfermedad.Descripcion = dr["Descripcion"].ToString();

                        ListaEnfermedades.Add(enfermedad);
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

        public static EnfermedadEntidad DevolverListaEnfermedadesporIdDatos(int idEnfermedad)
        {
            try
            {
                EnfermedadEntidad enfermedad = new EnfermedadEntidad();
                //List<ExamenEntidad> ListaExamenes = new List<ExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select Id_Enf,Nom_Enf,Desc_Enf
                                    from Enfermedades
                                    where Id_Enf=@id";
                cmd.Parameters.AddWithValue("@id", idEnfermedad);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        enfermedad.Id = Convert.ToInt32(dr["Id_Enf"].ToString());
                        enfermedad.Nombre = dr["Nom_Enf"].ToString();
                        enfermedad.Descripcion= dr["Desc_Enf"].ToString();

                    }

                }
                conexion.Close();
                return enfermedad;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
