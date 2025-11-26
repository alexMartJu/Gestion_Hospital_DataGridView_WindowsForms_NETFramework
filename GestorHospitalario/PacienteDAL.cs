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
    internal class PacienteDAL
    {
        //Guardamos la cadena de conexión para hablar con la base de datos
        private string cadena = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        //ObtenerTodos --> Método para sacar todos los pacientes de la tabla
        public DataTable ObtenerTodos()
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Pacientes";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //Insertar --> Método para añadir un paciente nuevo
        public void Insertar(string nombre, string apellidos, int edad)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "INSERT INTO Pacientes (Nombre, Apellidos, Edad) VALUES (@nom, @ape, @edad)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@ape", apellidos);
                cmd.Parameters.AddWithValue("@edad", edad);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Actualizar --> Método para actualizar los datos de un paciente
        public void Actualizar(int id, string nombre, string apellidos, int edad)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                string sql = "UPDATE Pacientes SET Nombre=@nom, Apellidos=@ape, Edad=@edad WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@ape", apellidos);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Eliminar --> Método para borrar un paciente y sus ingresos usando una transacción
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //1. Eliminar ingresos del paciente
                    SqlCommand cmdIngresos = new SqlCommand("DELETE FROM Ingresos WHERE PacienteId=@id", conn, transaction);
                    cmdIngresos.Parameters.AddWithValue("@id", id);
                    cmdIngresos.ExecuteNonQuery();

                    //2. Eliminar paciente
                    SqlCommand cmdPaciente = new SqlCommand("DELETE FROM Pacientes WHERE Id=@id", conn, transaction);
                    cmdPaciente.Parameters.AddWithValue("@id", id);
                    cmdPaciente.ExecuteNonQuery();

                    //Confirmar transacción
                    transaction.Commit();
                }
                catch
                {
                    //Revertir todo si falla
                    transaction.Rollback();
                    throw; //Propagamos el error para que el formulario lo gestione
                }
            }
        }
    }
}
