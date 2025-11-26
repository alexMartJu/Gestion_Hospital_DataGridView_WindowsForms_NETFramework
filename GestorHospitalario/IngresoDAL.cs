using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorHospitalario
{
    internal class IngresoDAL
    {
        //Guardamos la cadena de conexión para hablar con la base de datos
        private string cadena = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        //ObtenerTodos --> Método para sacar todos los ingresos
        public DataTable ObtenerTodos()
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Ingresos";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //ObtenerPorPaciente --> Método para sacar los ingresos de un paciente concreto
        public DataTable ObtenerPorPaciente(int pacienteId)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Ingresos WHERE PacienteId=@id";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", pacienteId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Insertar --> Método para añadir un ingreso nuevo
        public void Insertar(DateTime fechaIngreso, DateTime? fechaAlta, string motivo, string habitacion, string especialidad, int pacienteId)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "INSERT INTO Ingresos (FechaIngreso, FechaAlta, Motivo, Habitacion, Especialidad, PacienteId) VALUES (@fi, @fa, @mot, @hab, @esp, @pid)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fi", fechaIngreso);
                cmd.Parameters.AddWithValue("@fa", fechaAlta.HasValue ? (object)fechaAlta.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@mot", motivo);
                cmd.Parameters.AddWithValue("@hab", habitacion);
                cmd.Parameters.AddWithValue("@esp", especialidad);
                cmd.Parameters.AddWithValue("@pid", pacienteId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Actualizar --> Método para actualizar un ingreso existente
        public void Actualizar(int id, DateTime fechaIngreso, DateTime? fechaAlta, string motivo, string habitacion, string especialidad)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "UPDATE Ingresos SET FechaIngreso=@fi, FechaAlta=@fa, Motivo=@mot, Habitacion=@hab, Especialidad=@esp WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fi", fechaIngreso);
                cmd.Parameters.AddWithValue("@fa", fechaAlta.HasValue ? (object)fechaAlta.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@mot", motivo);
                cmd.Parameters.AddWithValue("@hab", habitacion);
                cmd.Parameters.AddWithValue("@esp", especialidad);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Eliminar --> Método para borrar un ingreso
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "DELETE FROM Ingresos WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //ExisteIngresoActivo --> Método para comprobar si un paciente ya tiene un ingreso activo
        public bool ExisteIngresoActivo(int pacienteId, int? ingresoId = null)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Ingresos WHERE PacienteId=@pid AND FechaAlta IS NULL" +
                             (ingresoId.HasValue ? " AND Id<>@id" : "");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", pacienteId);
                if (ingresoId.HasValue) cmd.Parameters.AddWithValue("@id", ingresoId.Value);

                int activos = (int)cmd.ExecuteScalar();
                return activos > 0;
            }
        }
    }
}
