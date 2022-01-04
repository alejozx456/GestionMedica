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
    public static class DetalleExamenDatos
    {
        public static DetalleExamenEntidad GuardarExamenDatos(DetalleExamenEntidad detalleE)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO [Detalle_Examen]
                                   ([Id_Exa_per]
                                   ,[Id_Cit_per])
                             VALUES(@Id_Exa_per,@Id_Cit_per)
                                    SELECT SCOPE_IDENTITY() ";
                cmd.Parameters.AddWithValue("@Id_Exa_per", detalleE.Id_Exa_Per);
                cmd.Parameters.AddWithValue("@Id_Cit_per", detalleE.Id_Cit_Per);

                cmd.CommandType = CommandType.Text;
                var idDetalleExamen = Convert.ToInt32(cmd.ExecuteScalar());
                detalleE.ID = idDetalleExamen;

                conexion.Close();
                return detalleE;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static DetalleExamenEntidad DevolverDetalleExamenporIdDatos(int idExamen)
        {
            try
            {
                DetalleExamenEntidad examen = new DetalleExamenEntidad();
                List<DetalleExamenEntidad> ListaExamenes = new List<DetalleExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select [Id_Det_Exa]
                                     ,[Id_Exa_Per]
                                     ,[Id_Cit_Per]
                                    from Detalle_Examen  where Id_Det_Exa=@id";
                cmd.Parameters.AddWithValue("@id",idExamen);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        examen.ID = Convert.ToInt32(dr["Id_Det_Exa"].ToString());
                        examen.Id_Exa_Per = Convert.ToInt32(dr["Id_Exa_Per"].ToString());
                        examen.Id_Cit_Per = Convert.ToInt32(dr["Id_Cit_Per"].ToString());


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

        public static List<DetalleExamenEntidad> DevolverListaMedicinasDatos()
        {
            try
            {
                List<DetalleExamenEntidad> ListaDetalleExa = new List<DetalleExamenEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select m.Id_Det_Exa as Id,m.ID_Exa_Per as Id_Exa,m.Id_Cit_per as Id_Cit
                                   from Detalle_Examen m ";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DetalleExamenEntidad detalleExa = new DetalleExamenEntidad();
                        detalleExa.ID = Convert.ToInt32(dr["Id"].ToString());
                        detalleExa.Id_Cit_Per = Convert.ToInt32(dr["Id_Cit"].ToString());
                        detalleExa.Id_Exa_Per = Convert.ToInt32(dr["Id_Exa"].ToString());
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

        public static List<DetalleExamenEntidad> DevolverListaExamenFiltradaDatos(int dato)
        {

            List<DetalleExamenEntidad> ListaDetalleExa = new List<DetalleExamenEntidad>();
            SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"select m.Id_Det_Exa as Id,m.ID_Exa_Per as Id_Exa,m.Id_Cit_per as Id_Cit
                                   from Detalle_Examen m where Id_Cit_per in
                                   ( SELECT Id_Cita from [Cita Medica] where Id_Cita = " + dato + ")";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    DetalleExamenEntidad detalleExa = new DetalleExamenEntidad();
                    detalleExa.ID = Convert.ToInt32(dr["Id"].ToString());
                    detalleExa.Id_Cit_Per = Convert.ToInt32(dr["Id_Cit"].ToString());
                    detalleExa.Id_Exa_Per = Convert.ToInt32(dr["Id_Exa"].ToString());
                    ListaDetalleExa.Add(detalleExa);
                }
            }
            conexion.Close();
            return ListaDetalleExa;
        }
    }
}
