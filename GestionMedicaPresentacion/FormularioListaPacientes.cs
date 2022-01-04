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
    public partial class FormularioListaPacientes : Form
    {
        public FormularioListaPacientes()
        {
            InitializeComponent();
        }

        private void FormularioListaPacientes_Load(object sender, EventArgs e)
        {
            CargarListaPacientes();
        }

        private void CargarListaPacientes()
        {
            dataGridViewListaPacientes.DataSource = PacienteNegocio.DevolverListaPacientesCita();
        }

        private void dataGridViewListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id= Convert.ToInt32(dataGridViewListaPacientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarPacientePorId(id);
        }

        private void CargarPacientePorId(int id)
        {
            var pacienteseleccionado = PacienteNegocio.DevolverPacientePorId(id);
            textBoxIdPaciente.Text = pacienteseleccionado.Id.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = textBoxIdPaciente.Text;
            EliminarPacientePorId(id);
        }

        private void EliminarPacientePorId(string id)
        {
            var pacienteeliminado = PacienteNegocio.EliminarPacientePorId(id);
            CargarListaPacientes();
            
        }

        private void dataGridViewListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
