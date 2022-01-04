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
    public partial class Atencion : Form
    {
        AtencionEntidad atencion = new AtencionEntidad();

        public Atencion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GuardarAtencion()
        {
            atencion.Id = 0;
            atencion.Registro = textBox_Registro.Text;
            atencion.Diagnostico = textBox_Diagnostico.Text;
            atencion.Costo_Atencion = Convert.ToInt32(textBox_Costo.Text);
            atencion.Id_Cita = Convert.ToInt32(textBox_ID_Cita.Text);

            atencion = AtencionNegocio.GuardarAtencionNegocio(atencion);
            if (atencion != null)
            {
                Label_Id_Atencion.Text = atencion.Id.ToString();
                MessageBox.Show("La Atencion se inserto correctamente");
                //Cargar pacientes de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la Atencion");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Label_Id_Atencion.Text!="....")
            {
                Detalle_Medicinas_Atencion detalleM = new Detalle_Medicinas_Atencion();
                detalleM.textBox_ID_Atencion.Text = Label_Id_Atencion.Text;
                detalleM.Show();
            }
            else
            {
                MessageBox.Show("Establezca una atencion");
            }
           
        }

        private void Registrar_atencion_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Cita.Text!="")
            {
                
                    if (textBox_Costo.Text!="")
                    {
                        if (textBox_Registro.Text!="")
                        {
                            if (textBox_Diagnostico.Text!="")
                            {
                                GuardarAtencion();
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un diagnostico");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un registro");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el costo de la atencion");
                }
               
                
            }
            else
            {
                MessageBox.Show("Elija una cita");
            }
           
        }

        private void Atencion_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Label_Id_Atencion.Text!="....")
            {
                ExamenResultadocs detalleM = new ExamenResultadocs();
                detalleM.textBox_ID_Atencion_examen.Text = Label_Id_Atencion.Text;
                detalleM.label_Cita.Text = textBox_ID_Cita.Text;
                detalleM.Show();
            }
            else
            {
                MessageBox.Show("La atencion no esta establecida");
            }
           
        }
        private void CargarCitaPorIs(int id)
        {
            var seleccionado = CitaMedicaNegocio.CargarDatosCita(id);
            textBox_ID_Cita.Text = seleccionado.Id.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dato = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarCitaPorIs(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                dataGridView1.DataSource = CitaMedicaNegocio.listaDatosFiltrada(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Ingrese un numero de cedula");
            }
           

        }
    }
}
