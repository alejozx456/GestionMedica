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
    public static class MedicinaDatos
    {
        public static List<MedicinaEntidad> DevolverListaMedicinasDatos()
        {
            try
            {
                List<MedicinaEntidad> ListaMedicinas = new List<MedicinaEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select m.Id_Med as Id,m.Nom_Med as Nombre,m.Desc_Med as Descripcion
                                   from Medicinas m";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        MedicinaEntidad medicina = new MedicinaEntidad();
                        medicina.Id = Convert.ToInt32(dr["Id"].ToString());
                        medicina.Nombre = dr["Nombre"].ToString();
                        medicina.Descripcion = dr["Descripcion"].ToString();

                        ListaMedicinas.Add(medicina);
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

        public static MedicinaEntidad DevolverMedicinaPorIdDatos(int idMedicina)
        {
            try
            {
                MedicinaEntidad medicina = new MedicinaEntidad();
                //List<PacienteEntidad> ListaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select Id_Med,Nom_Med,Desc_Med 
                                    from Medicinas
                                    where Id_Med=@id";
                cmd.Parameters.AddWithValue("@id", idMedicina);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {

                        medicina.Id = Convert.ToInt32(dr["Id_Med"].ToString());
                        medicina.Nombre = dr["Nom_Med"].ToString();
                        medicina.Descripcion = dr["Desc_Med"].ToString();
                       

                    }

                }
                conexion.Close();
                return medicina;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<MedicinaEntidad> BuscarListaMedicinasDatos(string dato)
        {
            try
            {
                List<MedicinaEntidad> ListaMedicinas = new List<MedicinaEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select m.Id_Med as Id,m.Nom_Med as Nombre,m.Desc_Med as Descripcion
                                   from Medicinas m where Nom_Med like '%" + dato + "%' ";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        MedicinaEntidad medicina = new MedicinaEntidad();
                        medicina.Id = Convert.ToInt32(dr["Id"].ToString());
                        medicina.Nombre = dr["Nombre"].ToString();
                        medicina.Descripcion = dr["Descripcion"].ToString();

                        ListaMedicinas.Add(medicina);
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

        public static List<MedicinaEntidad> DevolverMedicamentoFiltradaDatos(String dato)
        {
            
                List<MedicinaEntidad> ListaDetalleExa = new List<MedicinaEntidad>();
                SqlConnection conexion = new SqlConnection(Configuracion.Default.ConexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"select [Id_Med]
      ,[Nom_Med]
      ,[Desc_Med]  from Medicinas  where Id_Med in
                                   ( SELECT Id_Med_Per from [DetalleMedicamentoAtencion] where Id_Ate_Per in ( 
                                      SELECT Id_Ate from [Atencion] where Id_Cita_Per  in(
                                      Select Id_Cita from [Cita Medica] where Id_Pac_Per in (
                                       Select Id_Pac from [Pacientes] where Id_Pac like '%" + dato + "%'))))";
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        MedicinaEntidad medicamento = new MedicinaEntidad();
                        medicamento.Id = Convert.ToInt32(dr["Id_Med"].ToString());
                        medicamento.Nombre = dr["Nom_Med"].ToString();
                        medicamento.Descripcion = dr["Desc_Med"].ToString();

                        ListaDetalleExa.Add(medicamento);
                    }
                }
                conexion.Close();
                return ListaDetalleExa;
            
           
        }

    }
}
