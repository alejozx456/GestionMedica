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
    public partial class DetalleAtencionF : Form
    {
        public DetalleAtencionF()
        {
            InitializeComponent();
        }

        private void DetalleAtencionF_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AtencionNegocio.buscarAtencion(Id_Paciente.Text);
            dataGridView2.DataSource = DetalleExamenAtencionNegocio.DevolverListaFiltradaExamen(Id_Paciente.Text);
            dataGridView3.DataSource = MedicinaNegocio.ListaMedicinaFiltrada(Id_Paciente.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
