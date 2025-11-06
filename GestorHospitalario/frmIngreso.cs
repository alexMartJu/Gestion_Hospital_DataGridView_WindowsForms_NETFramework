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
    public partial class frmIngreso : Form
    {
        //Propiedad pública para acceder al ingreso creado o editado
        public Ingreso Ingreso { get; private set; }
        private Paciente paciente;

        //Constructor para agregar un nuevo ingreso
        public frmIngreso()
        {
            InitializeComponent();
            Ingreso = new Ingreso(); //Creamos un ingreso vacío
        }

        //Constructor para editar un ingreso existente
        public frmIngreso(Ingreso ingreso, Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            Ingreso = ingreso; //Guardamos el ingreso recibido
            //Mostramos sus datos en los controles del formulario
            dtpIngreso.Value = ingreso.FechaIngreso;
            dtpAlta.Value = ingreso.FechaAlta ?? DateTime.Today;
            txtMotivo.Text = ingreso.Motivo;
            txtHabitacion.Text = ingreso.Habitacion;
            txtEspecialidad.Text = ingreso.Especialidad;
            chkAlta.Checked = ingreso.FechaAlta.HasValue;
            dtpAlta.Enabled = chkAlta.Checked;
        }


        //Lógica Separada
        //GuardarIngreso() --> Método para guardar los datos del ingreso
        private void GuardarIngreso()
        {
            //Variable de control para saber si los datos son válidos
            bool datosValidos = true;

            //Validación de campos obligatorios: motivo, habitación y especialidad
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtHabitacion.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                datosValidos = false;
            }

            //Validación de fechas: la fecha de alta no puede ser anterior a la de ingreso
            if (chkAlta.Checked && dtpAlta.Value.Date < dtpIngreso.Value.Date)
            {
                MessageBox.Show("La fecha de alta no puede ser anterior a la fecha de ingreso.");
                datosValidos = false;
            }

            //Validación de ingresos activos:
            //Si el paciente existe, el ingreso actual tiene fecha de alta,
            //pero el checkbox de alta está desmarcado (se quiere quitar la fecha),
            //y el paciente ya tiene otro ingreso sin fecha de alta (activo),
            //entonces no se permite quitar la fecha de alta del ingreso actual.
            if (paciente != null &&
                Ingreso.FechaAlta.HasValue &&
                !chkAlta.Checked &&
                paciente.Ingresos.Any(i => i != Ingreso && !i.FechaAlta.HasValue))
            {
                MessageBox.Show("Este paciente ya tiene otro ingreso activo. No puedes quitar la fecha de alta.");
                datosValidos = false;
            }

            //Si todas las validaciones pasaron, se guardan los datos en el objeto Ingreso
            if (datosValidos)
            {
                Ingreso.FechaIngreso = dtpIngreso.Value;
                Ingreso.FechaAlta = chkAlta.Checked ? dtpAlta.Value : (DateTime?)null;
                Ingreso.Motivo = txtMotivo.Text;
                Ingreso.Habitacion = txtHabitacion.Text;
                Ingreso.Especialidad = txtEspecialidad.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }


        //Eventos del Formulario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarIngreso();
        }

        private void chkAlta_CheckedChanged(object sender, EventArgs e)
        {
            dtpAlta.Enabled = chkAlta.Checked;
        }


        //Eventos del MenuStrip
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarIngreso();
        }


        //Eventos del ToolStrip
        private void btnGuardarToolStrip_Click(object sender, EventArgs e)
        {
            GuardarIngreso();
        }

        private void btnCerrarToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
