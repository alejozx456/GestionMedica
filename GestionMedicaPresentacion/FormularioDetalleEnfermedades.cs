using EntidadMedica;
using NegocioMedica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMedicaPresentacion
{
    public partial class FormularioDetalleEnfermedades : Form
    {
        DetalleEnfermedadEntidad enfermedadDetalle = new DetalleEnfermedadEntidad();
        public FormularioDetalleEnfermedades()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEnfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormularioDetalleEnfermedades_Load(object sender, EventArgs e)
        {
            ListadeEnfermedades();
        }

        private void ListadeEnfermedades()
        {
            dataGridViewEnfermedades.DataSource = EnfermedadNegocio.DevolverListadeEnfermedadesNegocio();
        }

        private void dataGridViewEnfermedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewEnfermedades.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarEnfermedadesPorId(id);
        }

        private void CargarEnfermedadesPorId(int id)
        {

            var enfermedadseleccionada = EnfermedadNegocio.DevolverListadeEnfermedadesporIdNegocio(id);
            textBoxIdEnfermedad.Text = enfermedadseleccionada.Id.ToString();

        }

        private void ButtonAgregarEnfermedades_Click(object sender, EventArgs e)
        {
            GuardarDetalleEnfermedades();
        }

        private void GuardarDetalleEnfermedades()
        {
            enfermedadDetalle.Id_Enf_Per = Convert.ToInt32(textBoxIdEnfermedad.Text);
            enfermedadDetalle.Id_His_Per = Convert.ToInt32(textBoxIdHistorialPertenece.Text);
            enfermedadDetalle = DetalleEnfermedadNegocio.GuardarEnfermedadDetalle(enfermedadDetalle);
            if (enfermedadDetalle != null)
            {

                MessageBox.Show("Se guardo la Enfermedad Correctamente");
                //Cargar Medicos de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
