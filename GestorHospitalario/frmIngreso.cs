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
        //Guardamos el id del paciente al que pertenece este ingreso
        private int pacienteId;
        //Guardamos el id del ingreso (puede ser nulo si es un ingreso nuevo)
        private int? ingresoId;
        //Objeto para hablar con la base de datos de ingresos
        private IngresoDAL ingresoDAL = new IngresoDAL();

        //Constructor del formulario
        //Si no se pasa ingresoId, se usa para crear un ingreso nuevo
        //Si se pasa ingresoId, se usa para editar un ingreso existente
        public frmIngreso(int pacienteId, int? ingresoId = null)
        {
            InitializeComponent();
            this.pacienteId = pacienteId;
            this.ingresoId = ingresoId;
            if (ingresoId.HasValue) //Si hay id, cargamos los datos
            {
                CargarIngreso(ingresoId.Value);
            }
            else
            {
                //Ingreso nuevo: el checkbox desmarcado y el DateTimePicker deshabilitado
                chkAlta.Checked = false;
                dtpAlta.Enabled = false;
            }

        }

        //CargarIngreso() --> Método para cargar los datos de un ingreso en los controles del formulario
        private void CargarIngreso(int id)
        {
            try
            {
                var dt = ingresoDAL.ObtenerPorPaciente(pacienteId); //Pedimos los ingresos del paciente a la DAL
                foreach (DataRow row in dt.Rows) //Recorremos cada fila
                {
                    if ((int)row["Id"] == id) //Si el id coincide con el que buscamos
                    {

                        //Mostramos la fecha de ingreso
                        dtpIngreso.Value = Convert.ToDateTime(row["FechaIngreso"]);
                        //Si tiene fecha de alta, la mostramos y habilitamos el control
                        if (row["FechaAlta"] != DBNull.Value)
                        {
                            chkAlta.Checked = true;
                            dtpAlta.Value = Convert.ToDateTime(row["FechaAlta"]);
                            dtpAlta.Enabled = true;
                        }
                        else
                        {
                            //Si no tiene fecha de alta, deshabilitamos el control
                            chkAlta.Checked = false;
                            dtpAlta.Enabled = false;
                        }
                        //Mostramos el resto de datos en los cuadros de texto
                        txtMotivo.Text = row["Motivo"].ToString();
                        txtHabitacion.Text = row["Habitacion"].ToString();
                        txtEspecialidad.Text = row["Especialidad"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingreso: " + ex.Message);
            }
        }


        //GuardarIngreso() --> Método para guardar los datos del ingreso
        private void GuardarIngreso()
        {
            bool esValido = Validar(); //Comprobamos que los datos sean correctos

            if (esValido)
            {
                try
                {
                    DateTime? fechaAlta = chkAlta.Checked ? dtpAlta.Value : (DateTime?)null;

                    if (ingresoId.HasValue) //Si existe id, actualizamos el ingreso
                    {
                        if (!chkAlta.Checked && ingresoDAL.ExisteIngresoActivo(pacienteId, ingresoId))
                        {
                            MessageBox.Show("Este paciente ya tiene otro ingreso activo. No puedes dejar este ingreso sin fecha de alta.");
                            return;
                        }
                        ingresoDAL.Actualizar(ingresoId.Value, dtpIngreso.Value, fechaAlta,
                                              txtMotivo.Text, txtHabitacion.Text, txtEspecialidad.Text);
                    }
                    else //Si no existe id, insertamos un ingreso nuevo
                    {
                        ingresoDAL.Insertar(dtpIngreso.Value, fechaAlta,
                                            txtMotivo.Text, txtHabitacion.Text, txtEspecialidad.Text, pacienteId);
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar ingreso: " + ex.Message);
                }
            }
        }

        //Validar() --> Método para comprobar que los datos introducidos son correctos
        private bool Validar()
        {
            //Comprobamos que motivo, habitación y especialidad no estén vacíos
            if (string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtHabitacion.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return false;
            }

            //Comprobamos que la fecha de alta no sea anterior a la fecha de ingreso
            if (chkAlta.Checked && dtpAlta.Value.Date < dtpIngreso.Value.Date)
            {
                MessageBox.Show("La fecha de alta no puede ser anterior a la fecha de ingreso.");
                return false;
            }

            return true; //Si todo está bien, devolvemos true
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
