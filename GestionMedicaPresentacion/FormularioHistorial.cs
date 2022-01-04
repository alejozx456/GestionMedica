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
    public partial class FormularioHistorial : Form
    {
        HistorialMedicoEntidad historial = new HistorialMedicoEntidad();
        public FormularioHistorial()
        {
            InitializeComponent();
        }

        private void dataGridViewPacienteHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewPacienteHistorial.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarPacientePorId(id);
        }

        private void CargarPacientePorId(int id)
        {
            var pacienteseleccionado = PacienteNegocio.DevolverPacientePorId(id);
            textBoxId.Text = pacienteseleccionado.Id.ToString();
            textBoxNombre.Text = pacienteseleccionado.Nombre1;
            textBoxApellido.Text = pacienteseleccionado.Apellido1;
            textBoxCedula.Text = pacienteseleccionado.Cedula;
        }

        private void FormularioHistorial_Load(object sender, EventArgs e)
        {
            CargarListaPacientes();
        }

        private void CargarListaPacientes()
        {
            dataGridViewPacienteHistorial.DataSource = PacienteNegocio.DevolverListaPacientesCita();
        }

        private void buttonGuardarHistorial_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!="")
            {
                GuardarHistorial();
            }
            else
            {
                MessageBox.Show("Elija un Paciente");
            }
            
        }

        private void GuardarHistorial()
        {

            historial.Id = 0;
            historial.Id_Pac_Per = Convert.ToInt32(textBoxId.Text);
            historial = HistorialMedicoNegocio.GuardarHistorialNegocio(historial);
            if (historial != null)
            {
                textBoxIdHistorial.Text = historial.Id.ToString();
                MessageBox.Show("El historial se genero correctamente");
                //Cargar pacientes de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error algun error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!="")
            {
                FormularioDetalleEnfermedades detalleE = new FormularioDetalleEnfermedades();
                detalleE.textBoxIdHistorialPertenece.Text = textBoxIdHistorial.Text;

                detalleE.Show();
            }
            else
            {
                MessageBox.Show("Genere un Historial Primero");
            }
            
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!="")
            {
                FormularioDetalleOperaciones detalleO = new FormularioDetalleOperaciones();
                detalleO.textBoxIdHistorial.Text = textBoxIdHistorial.Text;
                detalleO.Show();
            }
            else
            {
                MessageBox.Show("Genere un Historial Primero");
            }
            
        }

        private void buttonMedcinas_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text!="")
            {
                FormularioDetalleMedicinas detalleMedicinas = new FormularioDetalleMedicinas();
                detalleMedicinas.textBoxIdHistorial.Text = textBoxIdHistorial.Text;
                detalleMedicinas.Show();
            }
            else
            {
                MessageBox.Show("Genere un Historial Primero");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioHistorialMaestro maestroH = new FormularioHistorialMaestro();
            maestroH.Show();
        }
    }
}
