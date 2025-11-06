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
        //Propiedad pública para acceder al paciente creado o editado
        public Paciente Paciente { get; private set; }

        //Constructor para agregar un nuevo paciente
        public frmPaciente()
        {
            InitializeComponent();
            Paciente = new Paciente(); //Creamos un nuevo paciente vacío
        }

        //Constructor para editar un paciente existente
        public frmPaciente(Paciente paciente)
        {
            InitializeComponent();
            Paciente = paciente; //Guardamos el paciente recibido
            //Mostramos sus datos en los campos del formulario
            txtNombre.Text = paciente.Nombre;
            txtApellidos.Text = paciente.Apellidos;
            txtEdad.Text = paciente.Edad.ToString();
        }


        //Lógica Separada
        //GuardarPaciente() --> Método para guardar los datos del paciente
        private void GuardarPaciente()
        {
            //Validamos que los campos estén completos y que la edad sea válida
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellidos.Text) &&
                int.TryParse(txtEdad.Text, out int edad))
            {
                if (edad <= 0 || edad > 120)
                {
                    MessageBox.Show("La edad debe estar entre 0 y 120 años.");
                    return;
                }

                //Asignamos los valores al objeto paciente
                Paciente.Nombre = txtNombre.Text;
                Paciente.Apellidos = txtApellidos.Text;
                Paciente.Edad = edad;

                DialogResult = DialogResult.OK; //Indicamos que se guardó correctamente
                Close(); //Cerramos el formulario
            }
            else
            {
                MessageBox.Show("Completa todos los campos correctamente.");
            }
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
