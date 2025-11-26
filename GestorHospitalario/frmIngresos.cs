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
        //Guardamos el id del paciente al que pertenecen los ingresos
        private int pacienteId;
        //Objeto para hablar con la base de datos de ingresos
        private IngresoDAL ingresoDAL = new IngresoDAL();

        //Constructor del formulario
        //Recibe el id del paciente y carga sus ingresos
        public frmIngresos(int id)
        {
            InitializeComponent();
            pacienteId = id;
            RefrescarIngresos();
        }

        //RefrescarIngresos() --> Método para actualizar el DataGridView con los ingresos del paciente
        private void RefrescarIngresos()
        {
            try
            {
                dgvIngresos.DataSource = ingresoDAL.ObtenerPorPaciente(pacienteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar ingresos: " + ex.Message);
            }
        }


        //AgregarIngreso() --> Método para agregar un nuevo ingreso
        private void AgregarIngreso()
        {
            bool puedeAgregar = true;

            try
            {
                //Validación: evitar múltiples ingresos activos
                if (ingresoDAL.ExisteIngresoActivo(pacienteId))
                {
                    MessageBox.Show("Este paciente ya tiene un ingreso activo. Debe darse de alta antes de agregar otro.");
                    puedeAgregar = false;
                }

                if (puedeAgregar)
                {
                    var form = new frmIngreso(pacienteId); //Abrimos el formulario de ingreso
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarIngresos(); //Actualizamos la tabla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar ingreso: " + ex.Message);
            }
        }

        //EditarIngreso() --> Método para editar un ingreso seleccionado
        private void EditarIngreso()
        {
            if (dgvIngresos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvIngresos.CurrentRow.Cells["Id"].Value);
                try
                {
                    var form = new frmIngreso(pacienteId, id);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarIngresos(); //Actualizamos la tabla
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar ingreso: " + ex.Message);
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
                int id = Convert.ToInt32(dgvIngresos.CurrentRow.Cells["Id"].Value);
                var confirm = MessageBox.Show("¿Eliminar ingreso?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ingresoDAL.Eliminar(id); //Llamamos a la DAL para borrar el ingreso
                        RefrescarIngresos(); //Actualizamos la tabla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar ingreso: " + ex.Message);
                    }
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
