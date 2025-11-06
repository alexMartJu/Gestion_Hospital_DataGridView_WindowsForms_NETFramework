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
        //Lista donde guardamos todos los pacientes
        private List<Paciente> pacientes = new List<Paciente>();
        //Contador para asignar un ID único a cada paciente
        private int contadorId = 1;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Cuando se carga el formulario, añadimos algunos pacientes de ejemplo
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pacientes.Add(new Paciente
            {
                Id = contadorId++,
                Nombre = "Alex",
                Apellidos = "Martinez Juan",
                Edad = 25,
                Ingresos = new List<Ingreso>
                {
                    new Ingreso { Id = 1, FechaIngreso = DateTime.Today.AddDays(-10), FechaAlta = DateTime.Today.AddDays(-5), Motivo = "Dolor abdominal", Habitacion = "101A", Especialidad = "Gastroenterología" },
                    new Ingreso { Id = 2, FechaIngreso = DateTime.Today.AddDays(-3), FechaAlta = null, Motivo = "Observación", Habitacion = "102B", Especialidad = "Medicina Interna" }
                }
            });

            pacientes.Add(new Paciente
            {
                Id = contadorId++,
                Nombre = "Juanjo",
                Apellidos = "Juan Mira",
                Edad = 26,
                Ingresos = new List<Ingreso>
                {
                    new Ingreso { Id = 1, FechaIngreso = DateTime.Today.AddDays(-7), FechaAlta = DateTime.Today.AddDays(-2), Motivo = "Fractura de tobillo", Habitacion = "201C", Especialidad = "Traumatología" }
                }
            });
            if (pacientes.Count > 0)
            {
                RefrescarPacientes(); //Actualizamos la tabla de pacientes
            }
            
        }

        //RefrescarPacientes() --> Método para actualizar el DataGridView con la lista de pacientes
        private void RefrescarPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes;
            ActualizarEstadisticas();
        }

        //ActualizarEstadisticas() --> Método para calcular y mostrar las estadísticas generales del hospital
        private void ActualizarEstadisticas()
        {
            int totalPacientes = pacientes.Count; //Cantidad total de pacientes registrados
            int sumaEdades = 0; //Suma de todas las edades para calcular la media
            int totalIngresos = 0; //Cantidad total de ingresos registrados
            int ingresosActivos = 0; //Cantidad de ingresos que aún no tienen fecha de alta

            //Recorremos todos los pacientes
            foreach (Paciente p in pacientes)
            {
                sumaEdades += p.Edad; //Sumamos la edad de cada paciente
                totalIngresos += p.Ingresos.Count; //Sumamos la cantidad de ingresos de cada paciente

                //Contamos cuántos ingresos están activos (sin fecha de alta)
                foreach (Ingreso i in p.Ingresos)
                {
                    if (!i.FechaAlta.HasValue)
                    {
                        ingresosActivos++;
                    }
                }
            }

            //Calculamos la edad media (evitamos división por cero)
            double edadMedia = totalPacientes > 0 ? (double)sumaEdades / totalPacientes : 0;
            //Mostramos los valores en los labels correspondientes
            lblValorPacientes.Text = totalPacientes.ToString();
            lblValorEdadMedia.Text = edadMedia.ToString("0.0");
            lblValorIngresos.Text = totalIngresos.ToString();
            lblValorActivos.Text = ingresosActivos.ToString();
        }

        //Lógica Separada
        //AgregarPaciente() --> Método para agregar un nuevo paciente
        private void AgregarPaciente()
        {
            var form = new frmPaciente(); //Abrimos el formulario de paciente
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Paciente.Id = contadorId++; //Asignamos un ID
                pacientes.Add(form.Paciente);    //Lo añadimos a la lista
                RefrescarPacientes();
            }
        }

        //EditarPaciente() --> Método para editar un paciente seleccionado
        private void EditarPaciente()
        {
            //Verificamos si hay una fila seleccionada en el DataGridView
            if (dgvPacientes.CurrentRow != null)
            {
                //Obtenemos el objeto Paciente que está vinculado a esa fila
                var paciente = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                var form = new frmPaciente(paciente); //Le pasamos el paciente
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

        //EliminarPaciente() --> Método para eliminar un paciente
        private void EliminarPaciente()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var paciente = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show("¿Eliminar paciente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    pacientes.Remove(paciente); //Lo quitamos de la lista
                    RefrescarPacientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para eliminar.");
            }
        }

        //VerIngresos() --> Método para ver los ingresos de un paciente
        private void VerIngresos()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var paciente = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                var form = new frmIngresos(paciente);
                form.ShowDialog();
                RefrescarPacientes();
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
