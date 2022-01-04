using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadMedica;
using NegocioMedica;

namespace GestionMedicaPresentacion
{
    public partial class FormularioCita : Form
    {
        CitaMedicaEntidad cita = new CitaMedicaEntidad();
        public FormularioCita()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormularioCita_Load(object sender, EventArgs e)
        {
            //CargarCombos();
            CargarListaPacienteCitas();
            CargarListaMedicoCitas();
        }

        private void CargarListaMedicoCitas()
        {
            dataGridViewMedicoCita.DataSource = MedicoNegocio.DevolverMedicosCita();
        }

        private void CargarListaPacienteCitas()
        {
            dataGridViewPacientesCita.DataSource = PacienteNegocio.DevolverListaPacientesCita();
        }

        private void CargarCombos()
        {
            //CargarPacientesCita();
        }

        //private void CargarPacientesCita()
        //{
        //    comboBoxPacienteCita.DataSource = PacienteNegocio.DevolverListaPacientesCita();
        //    comboBoxPacienteCita.DisplayMember = "";
        //    comboBoxPacienteCita.ValueMember = "";
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPacienteCita.Text!="")
            {
                if (textBoxMedicoCita.Text!="")
                {
                    GuardarCita();
                }
                else
                {
                    MessageBox.Show("Eliga un medico");
                }
            }
            else
            {
                MessageBox.Show("Eliga un paciente");
            }
            
        }

        private void GuardarCita()
        {
            cita.Id = 0;
            cita.Id_Pac_Cita = Convert.ToInt32(textBoxPacienteCita.Text);
            cita.Id_Med_Cita = Convert.ToInt32(textBoxMedicoCita.Text);
            cita.Fecha = dateTimePickerCita.Value.ToShortDateString();
            cita = CitaMedicaNegocio.GuardarCitaNegocio(cita);
            if (cita != null)
            {
                textBoxIdCita.Text = cita.Id.ToString();
                MessageBox.Show("la cita se ingreso correctamente");
                //Cargar pacientes de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la cita");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewPacientesCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id= Convert.ToInt32(dataGridViewPacientesCita.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarPacientePorIs(id);
        }

        private void CargarPacientePorIs(int id)
        {
            var pacienteseleccionado = PacienteNegocio.DevolverPacientePorId(id);
            textBoxPacienteCita.Text = pacienteseleccionado.Id.ToString();
            textBoxNombrePaciente.Text = pacienteseleccionado.Nombre1;
            textBoxApelidoCita.Text = pacienteseleccionado.Apellido1;
        }

        private void dataGridViewMedicoCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewMedicoCita.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarMedicoPorId(id);
        }

        private void CargarMedicoPorId(int id)
        {
            var medicoseleccionado = MedicoNegocio.DevolverMedicoPorId(id);
            textBoxMedicoCita.Text = medicoseleccionado.Id.ToString();
            textBoxNOmbreMedico.Text = medicoseleccionado.Nombre;
            textBoxEspecialidadMedico.Text = medicoseleccionado.Especialidad;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIdCita.Text !="")
            {
                FormularioDetalleCita detalle = new FormularioDetalleCita();
                detalle.textBoxCitaPertenece.Text = textBoxIdCita.Text;
                detalle.Show();
            }
            else
            {
                MessageBox.Show("No existe la Cita");
            }
           

        }

        private void buttonBUscarPaciente_Click(object sender, EventArgs e)
        {
            dataGridViewPacientesCita.DataSource = PacienteNegocio.BuscarPaciente(textBoxBuscarPaciente.Text);

        }

        private void buttonBuscarMedico_Click(object sender, EventArgs e)
        {
            dataGridViewMedicoCita.DataSource = MedicoNegocio.BuscarMedico(textBoxBuscarMedico.Text);
        }
    }
}
