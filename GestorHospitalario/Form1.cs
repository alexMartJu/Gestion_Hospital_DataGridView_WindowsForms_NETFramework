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
    public partial class frmPrincipal : Form
    {
        //Creamos los objetos que nos permiten hablar con la base de datos
        private PacienteDAL pacienteDAL = new PacienteDAL();
        private IngresoDAL ingresoDAL = new IngresoDAL();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Cuando se abre el formulario principal, cargamos la lista de pacientes
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            RefrescarPacientes();
        }

        //RefrescarPacientes() --> Método para actualizar el DataGridView con los pacientes de la base de datos
        private void RefrescarPacientes()
        {
            try
            {
                dgvPacientes.DataSource = pacienteDAL.ObtenerTodos(); //Pedimos todos los pacientes a la DAL
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar pacientes: " + ex.Message);
            }
        }

        //ActualizarEstadisticas() --> Método para calcular y mostrar las estadísticas generales del hospital
        private void ActualizarEstadisticas()
        {
            try
            {
                var pacientes = pacienteDAL.ObtenerTodos();
                var ingresos = ingresoDAL.ObtenerTodos();

                int totalPacientes = pacientes.Rows.Count;
                double edadMedia = totalPacientes > 0 ? Convert.ToDouble(pacientes.Compute("AVG(Edad)", "")) : 0;
                int totalIngresos = ingresos.Rows.Count;
                int ingresosActivos = ingresos.Select("FechaAlta IS NULL").Length;

                lblValorPacientes.Text = totalPacientes.ToString();
                lblValorEdadMedia.Text = edadMedia.ToString("0.0");
                lblValorIngresos.Text = totalIngresos.ToString();
                lblValorActivos.Text = ingresosActivos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular estadísticas: " + ex.Message);
            }
        }

        //AgregarPaciente() --> Método para abrir el formulario de paciente para añadir uno nuevo
        private void AgregarPaciente()
        {
            var form = new frmPaciente();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefrescarPacientes(); //Actualizamos la lista después de añadir
            }
        }

        //EditarPaciente() --> Método para abrir el formulario de paciente para modificar uno existente
        private void EditarPaciente()
        {
            //Verificamos si hay una fila seleccionada en el DataGridView
            if (dgvPacientes.CurrentRow != null)
            {
                //Obtenemos el Id del paciente que el usuario ha seleccionado en el DataGridView
                int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
                var form = new frmPaciente(id); //Le pasamos el paciente
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefrescarPacientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para editar.");
            }
        }

        //EliminarPaciente() --> Método para eliminar un paciente y sus ingresos asociados
        private void EliminarPaciente()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
                var confirm = MessageBox.Show("¿Eliminar paciente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        pacienteDAL.Eliminar(id); //Llamamos a la DAL para borrar
                        RefrescarPacientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para eliminar.");
            }
        }

        //VerIngresos() --> Método para abrir el formulario de ingresos para ver los ingresos de un paciente
        private void VerIngresos()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
                try
                {
                    var form = new frmIngresos(id);
                    form.ShowDialog();
                    RefrescarPacientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir ingresos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para ver sus ingresos.");
            }
        }


        //Eventos del Formulario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPaciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            VerIngresos();
        }


        //Eventos del MenuStrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPaciente();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void verIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerIngresos();
        }


        //Eventos del ToolStrip
        private void btnAgregarToolStrip_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        private void btnEditarToolStrip_Click(object sender, EventArgs e)
        {
            EditarPaciente();
        }

        private void btnEliminarToolStrip_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void btnVerIngresosToolStrip_Click(object sender, EventArgs e)
        {
            VerIngresos();
        }
    }
}
