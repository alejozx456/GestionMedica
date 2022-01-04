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
    public static class OperacionesDatos
    {
        public static List<OperacionesEntidad> DevolverListaOperacionesDatos()
        {
            try
            {
                List<OperacionesEntidad> ListaOperaciones = new List<OperacionesEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select o.Id_Op as Id,o.Nom_Op as Nombre,o.Desc_Op as Descripcion
                                    from Operaciones o";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        OperacionesEntidad operaciones = new OperacionesEntidad();
                        operaciones.Id = Convert.ToInt32(dr["Id"].ToString());
                        operaciones.Nombre = dr["Nombre"].ToString();
                        operaciones.Descripcion = dr["Descripcion"].ToString();

                        ListaOperaciones.Add(operaciones);
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

        public static OperacionesEntidad DevolverOperacionesPorIdDatos(int idOperacion)
        {
            try
            {
                OperacionesEntidad operaciones = new OperacionesEntidad();
                //List<ExamenEntidad> ListaExamenes = new List<ExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select Id_Op,Nom_Op,Desc_Op
                                    from Operaciones
                                    where Id_Op=@id";
                cmd.Parameters.AddWithValue("@id", idOperacion);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        operaciones.Id = Convert.ToInt32(dr["Id_Op"].ToString());
                        operaciones.Nombre = dr["Nom_Op"].ToString();
                        operaciones.Descripcion = dr["Desc_Op"].ToString();

                    }

                }
                conexion.Close();
                return operaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
