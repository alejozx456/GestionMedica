using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadMedica;
using NegocioMedica;


namespace GestionMedicaPresentacion
{
    public partial class Detalle_Medicinas_Atencion : Form
    {
        DetalleMedicinaAtencionEntidad detalle = new DetalleMedicinaAtencionEntidad();
        public Detalle_Medicinas_Atencion()
        {
            InitializeComponent();
        }
        private void CargarListaMedicamentos()
        {

            dataGridView1.DataSource = MedicinaNegocio.DevolverListaMedicinasNegocio();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void CargarMedicinasPorId(int id)
        {
            var Medicnaseleccionado = MedicinaNegocio.DevolverMedicinaporId(id);
            textBox_ID_Medicamento.Text = Medicnaseleccionado.Id.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarMedicinasPorId(id);
        }

        private void Detalle_Medicinas_Atencion_Load(object sender, EventArgs e)
        {
            CargarListaMedicamentos();
        }
        private void GuardarDetalleMedicamentoAtencion()
        {
            detalle.Id_Ate_Per = Convert.ToInt32(textBox_ID_Atencion.Text);
            detalle.Id_Med_Per = Convert.ToInt32(textBox_ID_Medicamento.Text);
            detalle = DetalleMedicinaAtencionNegocio.GuardarExamen(detalle);
            if (detalle != null)
            {

                MessageBox.Show("Se guardo El Examen  correctamente");
                //Cargar Medicos de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el paciente");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            GuardarDetalleMedicamentoAtencion();
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MedicinaNegocio.BuscarMedicina(textBox_buscar.Text);

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MedicinaNegocio.DevolverListaMedicinasNegocio();
            textBox_buscar.Text = "";
        }
    }
}
