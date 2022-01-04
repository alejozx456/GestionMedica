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
    public partial class FormularioDetalleCita : Form
    {
        DetalleExamenEntidad detalleE = new DetalleExamenEntidad();
        public FormularioDetalleCita()
        {
            InitializeComponent();
        }

        private void FormularioDetalleCita_Load(object sender, EventArgs e)
        {
            CargarListaExamenes();
        }

        private void CargarListaExamenes()
        {

            dataGridViewExamenesDetalle.DataSource = ExamenNegocio.DevolverListaExamenesNegocio();
        }

        private void textBoxCitaPertenece_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewExamenesDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewExamenesDetalle.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarExamenesPorId(id);
        }

        private void CargarExamenesPorId(int id)
        {
            var examenseleccionado = ExamenNegocio.DevolverExamenporId(id);
            textBoxExamenCita.Text = examenseleccionado.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarDetalleExamen();
        }

        private void GuardarDetalleExamen()
        {
            detalleE.ID = 0;
            detalleE.Id_Exa_Per = Convert.ToInt32(textBoxExamenCita.Text);
            detalleE.Id_Cit_Per = Convert.ToInt32(textBoxCitaPertenece.Text);
            detalleE = DetalleExamenNegocio.GuardarExamen(detalleE);
            if (detalleE != null)
            {
                labelId.Text = detalleE.ID.ToString(); 
                MessageBox.Show("Se guardo El Examen  correctamente");
                //Cargar Medicos de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el paciente");
            }
        }
    }
}
