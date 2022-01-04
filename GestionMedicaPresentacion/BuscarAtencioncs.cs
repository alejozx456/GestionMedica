using EntidadMedica;
using NegocioMedica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMedicaPresentacion
{
    public partial class BuscarAtencioncs : Form
    {
        public BuscarAtencioncs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (textBox_Busqueda.Text!="")
            {
                dataGridView1.DataSource = PacienteNegocio.BuscarPaciente(textBox_Busqueda.Text);
               // dataGridView1.DataSource = PacienteNegocio.BuscarPacienteFecha(textBox_Busqueda.Text);

            }
            else
            {
                MessageBox.Show("Ingrese un dato");
            }
           
        }

        private void BuscarAtencioncs_Load(object sender, EventArgs e)
        {

        }

        private void Nueva_atencion_Click(object sender, EventArgs e)
        {
            Atencion atencion = new Atencion();
            
            atencion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label_prueba.Text!= "....")
            {
                DetalleAtencionF final = new DetalleAtencionF();
                final.Id_Paciente.Text = label_prueba.Text;
                final.Show();
            }
            else
            {
                MessageBox.Show("Elija un paciente");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dato = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarAtencionPorIs(dato);
        }
        private void CargarAtencionPorIs(int id)
        {
            
            DetalleAtencionF x = new DetalleAtencionF();
            var pacienteseleccionado = PacienteNegocio.DevolverPacientePorId(id);
            x.Id_Paciente.Text = pacienteseleccionado.Id.ToString();
            label_prueba.Text = pacienteseleccionado.Id.ToString();
        }
    }
}
