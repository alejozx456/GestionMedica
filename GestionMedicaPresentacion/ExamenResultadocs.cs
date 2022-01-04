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
    public partial class ExamenResultadocs : Form
    {
        DetalleExamenAtencionEntidad examen = new DetalleExamenAtencionEntidad();
        public ExamenResultadocs()
        {
            InitializeComponent();
        }
        private void CargarExamenesDetallePorId(int id)
        {
            var seleccionado = DetalleExamenNegocio.DevolverExamenDetalleporId(id);
            textBox_ID_Examen.Text = seleccionado.ID.ToString();
        }
        private void ExamenResultadocs_Load(object sender, EventArgs e)
        {
            CargarListaDetalleExamen();
        }

       
        private void CargarListaDetalleExamen()
        {
            var id = Convert.ToInt32(label_Cita.Text);
            dataGridView1.DataSource = DetalleExamenNegocio.DelverListarFiltardaNegocio(id);
        }
        private void GuardarRegistroExamen()
        {
            examen.Id_Det_Exa_Per = Convert.ToInt32(textBox_ID_Examen.Text);
            examen.Id_Ate_Per = Convert.ToInt32(textBox_ID_Atencion_examen.Text);
            examen.Descripcion = textBox_Registro.Text;


            examen = DetalleExamenAtencionNegocio.guardardeateleatencionExamen(examen);
            if (examen != null)
            {
                MessageBox.Show("Los Resultados se almacenaron exitosamente");
                //Cargar pacientes de la base de datos

            }
            else
            {
                MessageBox.Show("Hubo un error al almacenar los Resultados ");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            GuardarRegistroExamen();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_Cita_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarExamenesDetallePorId(id);
        }

        private void textBox_ID_Examen_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    }
