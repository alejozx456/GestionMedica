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
    public partial class FormularioDetalleOperaciones : Form
    {
        DetalleOperacionesEntidad detalleO = new DetalleOperacionesEntidad();
        public FormularioDetalleOperaciones()
        {
            InitializeComponent();
        }

        private void FormularioDetalleOperaciones_Load(object sender, EventArgs e)
        {
            CargarListaOperaciones();
        }

        private void CargarListaOperaciones()
        {
            dataGridViewOperaciones.DataSource = OperacionesNegocio.DevolverListaOPeracionesNegocio();
        }

        private void dataGridViewOperaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewOperaciones.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarOperacionesPorId(id);
        }

        private void CargarOperacionesPorId(int id)
        {
            var operacionseleccionada = OperacionesNegocio.DevolverOperacionPorIdNegocio(id);
            textBoxIDOperacion.Text = operacionseleccionada.Id.ToString();
            textBoxNOmbreOperacion.Text = operacionseleccionada.Nombre;
        }

        private void buttonAgregarOperacion_Click(object sender, EventArgs e)
        {
            GuardarDetalleOperacion();
        }

        private void GuardarDetalleOperacion()
        {
            detalleO.Id_Hist_Per = Convert.ToInt32(textBoxIdHistorial.Text);
            detalleO.Id_Oper_Per = Convert.ToInt32(textBoxIDOperacion.Text);
            detalleO = DetalleOperacionesNegocio.GuardarDetalleOperacionNegocio(detalleO);
            if (detalleO != null)
            {

                MessageBox.Show("Se guardo la Operacion Correctamente");
                //Cargar Medicos de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
