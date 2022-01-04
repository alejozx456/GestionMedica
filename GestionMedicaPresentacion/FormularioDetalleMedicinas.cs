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
    public partial class FormularioDetalleMedicinas : Form
    {
        DetalleMedicinaEntidad detalleMedicina = new DetalleMedicinaEntidad();
        public FormularioDetalleMedicinas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormularioDetalleMedicinas_Load(object sender, EventArgs e)
        {
            CargarListaMedicinas();
        }

        private void CargarListaMedicinas()
        {
            dataGridViewListadeMedicinas.DataSource = MedicinaNegocio.DevolverListaMedicinasNegocio();
        }

        private void dataGridViewListadeMedicinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewListadeMedicinas.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarMedicinaPorId(id);
        }

        private void CargarMedicinaPorId(int id)
        {
            var medicinaseleccionada = MedicinaNegocio.DevolverMedicinaporId(id);
            textBoxIDMedicina.Text = medicinaseleccionada.Id.ToString();
            textBoxNombre.Text = medicinaseleccionada.Nombre;
            
        }

        private void buttonAgregarMedicina_Click(object sender, EventArgs e)
        {
            GuardarDetalleMedicina();
        }

        private void GuardarDetalleMedicina()
        {
            detalleMedicina.Id_Hist_Per = Convert.ToInt32(textBoxIdHistorial.Text);
            detalleMedicina.Id_Med_Per = Convert.ToInt32(textBoxIDMedicina.Text);
            detalleMedicina = DetalleMedcinaNegocio.GuardarDetalleMedicinaNegocio(detalleMedicina);
            if (detalleMedicina != null)
            {

                MessageBox.Show("Se agrego la Medicina Correctamente");
                //Cargar Medicos de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
