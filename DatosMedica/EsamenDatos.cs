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
    public static class EsamenDatos
    {
        public static List<ExamenEntidad> DevolverListaExamenesDatos()
        {
            try
            {
                List<ExamenEntidad> ListaExamenes = new List<ExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select e.Id_Exa as Id,e.Nom_Ex as Examen
                                   from Examenes e";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ExamenEntidad examen = new ExamenEntidad();
                        examen.Id = Convert.ToInt32(dr["Id"].ToString());
                        examen.Nombre = dr["Examen"].ToString();

                        ListaExamenes.Add(examen);
                    }
                }
                conexion.Close();
                return ListaExamenes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ExamenEntidad DevolverExamenporIdDatos(int idExamen)
        {
            try
            {
                ExamenEntidad examen = new ExamenEntidad();
                List<ExamenEntidad> ListaExamenes = new List<ExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select e.Id_Exa,e.Nom_Ex
                                    from Examenes e
                                    where e.Id_Exa=@id";
                cmd.Parameters.AddWithValue("@id", idExamen);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        examen.Id = Convert.ToInt32(dr["Id_Exa"].ToString());
                        examen.Nombre = dr["Nom_Ex"].ToString();

                    }

                }
                conexion.Close();
                return examen;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
