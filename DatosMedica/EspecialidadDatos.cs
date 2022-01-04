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
    public static class EspecialidadDatos
    {
        public static List<EspecialidadEntidad> DevolverListaEspecialidadDatos()
        {
            try
            {
                List<EspecialidadEntidad> ListaEspecialidad = new List<EspecialidadEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select Id_Esp,Nom_Esp
                                   from Especialidades";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        EspecialidadEntidad especialidad = new EspecialidadEntidad();
                        especialidad.Id = Convert.ToInt32(dr["Id_Esp"].ToString());
                        especialidad.Nombre = dr["Nom_Esp"].ToString();
                        ListaEspecialidad.Add(especialidad);

                    }
                }
                conexion.Close();
                return ListaEspecialidad;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
