using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorHospitalario
{
    public partial class frmPaciente : Form
    {
        //Variable para guardar el id del paciente (puede ser nulo si es nuevo)
        private int? pacienteId;
        //Objeto para hablar con la base de datos de pacientes
        private PacienteDAL pacienteDAL = new PacienteDAL();

        //Constructor del formulario
        //Si no se pasa id, se usa para crear un paciente nuevo
        //Si se pasa id, se usa para editar un paciente existente
        public frmPaciente(int? id = null)
        {
            InitializeComponent();
            pacienteId = id;
            if (id.HasValue) //Si hay id, cargamos los datos del paciente
            {
                CargarPaciente(id.Value);
            }
            
                
        }

        //CargarPaciente() --> Método para cargar los datos de un paciente en los cuadros de texto
        private void CargarPaciente(int id)
        {
            try
            {
                var dt = pacienteDAL.ObtenerTodos(); //Pedimos todos los pacientes a la DAL
                foreach (DataRow row in dt.Rows) //Recorremos cada fila
                {
                    if ((int)row["Id"] == id) //Si el id coincide con el que buscamos
                    {
                        txtNombre.Text = row["Nombre"].ToString();
                        txtApellidos.Text = row["Apellidos"].ToString();
                        txtEdad.Text = row["Edad"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paciente: " + ex.Message);
            }
        }

        //GuardarPaciente() --> Método para guardar los datos del paciente
        private void GuardarPaciente()
        {
            bool esValido = Validar(); //Comprobamos que los datos sean correctos

            if (esValido)
            {
                try
                {
                    if (pacienteId.HasValue) //Si existe id, actualizamos el paciente
                    {
                        pacienteDAL.Actualizar(pacienteId.Value, txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text));
                    }
                    else //Si no existe id, insertamos un paciente nuevo
                    {
                        pacienteDAL.Insertar(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text));
                    }

                    //Cerramos el formulario indicando que todo salió bien
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar paciente: " + ex.Message);
                }
            }
        }

        //Validar() --> Método para comprobar que los datos introducidos son correctos
        private bool Validar()
        {
            //Comprobamos que nombre y apellidos no estén vacíos y que edad sea un número
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                !int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Completa todos los campos correctamente.");
                return false;
            }

            //Comprobamos que la edad esté en un rango lógico (0 a 120 años)
            if (edad <= 0 || edad > 120)
            {
                MessageBox.Show("La edad debe estar entre 0 y 120 años.");
                return false;
            }

            return true; //Si todo está bien, devolvemos true
        }


        //Eventos del Formulario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }


        //Eventos del MenuStrip
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }


        //Eventos del ToolStrip
        private void btnGuardarToolStrip_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }

        private void btnCerrarToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
