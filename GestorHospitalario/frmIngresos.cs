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
    public partial class frmIngresos : Form
    {
        //Guardamos el paciente actual para acceder a sus ingresos
        private Paciente paciente;

        //Constructor vacío (no se usa en este caso)
        public frmIngresos()
        {
            InitializeComponent();
        }

        //Constructor que recibe el paciente y muestra sus ingresos
        public frmIngresos(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            lblPaciente.Text = $"{paciente.Nombre} {paciente.Apellidos} - {paciente.Edad} años"; //Mostramos el nombre y edad
            //Cargamos los ingresos en la tabla
            if (paciente.Ingresos.Count > 0)
            {
                RefrescarIngresos();
            }
        }

        //RefrescarIngresos() --> Método para actualizar el DataGridView con los ingresos del paciente
        private void RefrescarIngresos()
        {
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = paciente.Ingresos;
        }


        //Lógica Separada
        //AgregarIngreso() --> Método para agregar un nuevo ingreso
        private void AgregarIngreso()
        {
            bool puedeAgregar = true;

            //Validación: evitar múltiples ingresos activos
            if (paciente.Ingresos.Any(i => !i.FechaAlta.HasValue))
            {
                MessageBox.Show("Este paciente ya tiene un ingreso activo. Debe darse de alta antes de agregar otro.");
                puedeAgregar = false;
            }

            if (puedeAgregar)
            {
                var form = new frmIngreso(); //Abrimos el formulario de ingreso
                if (form.ShowDialog() == DialogResult.OK)
                {
                    form.Ingreso.Id = paciente.Ingresos.Count + 1; //Asignamos ID
                    paciente.Ingresos.Add(form.Ingreso); //Lo añadimos a la lista
                    RefrescarIngresos(); //Actualizamos la tabla
                }
            }
        }

        //EditarIngreso() --> Método para editar un ingreso seleccionado
        private void EditarIngreso()
        {
            if (dgvIngresos.CurrentRow != null)
            {
                var ingreso = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                var form = new frmIngreso(ingreso,paciente); //Le pasamos el ingreso
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefrescarIngresos(); //Actualizamos la tabla
                }
            }
            else
            {
                MessageBox.Show("Selecciona un ingreso para editar.");
            }
        }

        //EliminarIngreso() --> Método para eliminar un ingreso
        private void EliminarIngreso()
        {
            if (dgvIngresos.CurrentRow != null)
            {
                var ingreso = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show("¿Eliminar ingreso?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    paciente.Ingresos.Remove(ingreso); //Lo quitamos de la lista
                    RefrescarIngresos(); //Actualizamos la tabla
                }
            }
            else
            {
                MessageBox.Show("Selecciona un ingreso para eliminar.");
            }
        }


        //Eventos del Formulario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarIngreso();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }


        //Eventos del MenuStrip
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarIngreso();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }


        //Eventos del ToolStrip
        private void btnAgregarToolStrip_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }

        private void btnEditarToolStrip_Click(object sender, EventArgs e)
        {
            EditarIngreso();
        }

        private void btnEliminarToolStrip_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }
    }
}
