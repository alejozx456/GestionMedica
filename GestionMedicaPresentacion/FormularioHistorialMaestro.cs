using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadMedica;
using NegocioMedica;

namespace GestionMedicaPresentacion
{
    public partial class FormularioHistorialMaestro : Form
    {
        public FormularioHistorialMaestro()
        {
            InitializeComponent();
        }

        private void FormularioHistorialMaestro_Load(object sender, EventArgs e)
        {
            CargarListadeHistorial();
            
           
            
            
        }

        private void CargarDetalleEnfermedadesPorIdHistorial()
        {
            var id = Convert.ToInt32(textBoxIdHistorial.Text);
            dataGridViewEnfermedades.DataSource = DetalleEnfermedadNegocio.DevolverListaEnfermedadesporId(id);
        }

        private void CargarListadeHistorial()
        {
            dataGridViewListaHistorial.DataSource = HistorialMedicoNegocio.DevolverListaHistorialNegocio();
        }

        private void dataGridViewListaHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewListaHistorial.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarHistorialPorId(id);
        }

        private void CargarHistorialPorId(int id)
        {
            var historialseleccionado = HistorialMedicoNegocio.DevolverHistorialId(id);
            textBoxIdHistorial.Text = historialseleccionado.Id.ToString();
            textBoxCedulaPaciente.Text = historialseleccionado.Cedula;
            textBoxNombrePaciente.Text = historialseleccionado.Nombre;
            textBoxApellidoPaciente.Text = historialseleccionado.Apellido;
            
        }

        private void buttonEnfermedadesdelPaciente_Click(object sender, EventArgs e)
        {
            if (textBoxIdHistorial.Text!="")
            {
                CargarDetalleEnfermedadesPorIdHistorial();
            }
            else
            {
                MessageBox.Show("Elija un Historial");
            }
           
        }

        private void buttonMedicinasPaciente_Click(object sender, EventArgs e)
        {
            if (textBoxIdHistorial.Text != "")
            {
                CargarDetalleMedicinasPorIdHistorial();
            }
            else
            {
                MessageBox.Show("Elija un Historial");
            }
            
        }

        private void CargarDetalleMedicinasPorIdHistorial()
        {
            var id = Convert.ToInt32(textBoxIdHistorial.Text);
            dataGridViewDetalleMedicinas.DataSource = DetalleMedcinaNegocio.DevolverMedicinaDetallePorIdNegocio(id);
        }

        private void buttonOperacionesPaciente_Click(object sender, EventArgs e)
        {
            if (textBoxIdHistorial.Text!="")
            {
                var id = Convert.ToInt32(textBoxIdHistorial.Text);
                dataGridViewOperacionesPaciente.DataSource = DetalleOperacionesNegocio.DevolverOperacionDetallePorIdNegocio(id);
            }
            else
            {
                MessageBox.Show("Elija un Historial");
            }
            
            
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }
        private void Imprimir(object sender,PrintPageEventArgs e)
        {
            //Font font = new Font("Arial",14,FontStyle.Regular,GraphicsUnit.Point);
            ////e.Graphics.DrawString(textBoxIdHistorial.Text, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            ////e.Graphics.DrawString(textBoxCedulaPaciente.Text, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            ////e.Graphics.DrawString(textBoxNombrePaciente.Text, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            //e.Graphics.DrawString(textBoxApellidoPaciente.Text, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            Font font = new Font("Arial",14);
            int ancho = 200;
            int y = 20;
            e.Graphics.DrawString("HISTORIA CLINICA", font, Brushes.SeaGreen, new RectangleF(300, y, ancho, 20));
            e.Graphics.DrawString("Numero de Historia Clinica: "+textBoxIdHistorial.Text, font, Brushes.Black, new RectangleF(10, y+40, ancho+300, 20));
            e.Graphics.DrawString("Cedula del Paciente: " + textBoxCedulaPaciente.Text, font, Brushes.Black, new RectangleF(10, y + 90, ancho + 300, 20));
            e.Graphics.DrawString("Nombre del Paciente: " + textBoxNombrePaciente.Text, font, Brushes.Black, new RectangleF(10, y + 120, ancho + 300, 20));
            e.Graphics.DrawString("Apellido del Paciente: " + textBoxApellidoPaciente.Text, font, Brushes.Black, new RectangleF(10, y + 150, ancho + 300, 20));
            e.Graphics.DrawString("Lista de Enfermedades del Paciente: " , font, Brushes.SeaGreen, new RectangleF(10, y + 180, ancho + 300, 20));
            Bitmap objBmp = new Bitmap(dataGridViewEnfermedades.Width, dataGridViewEnfermedades.Height);
            dataGridViewEnfermedades.DrawToBitmap(objBmp,new Rectangle(0,0,dataGridViewEnfermedades.Width,dataGridViewEnfermedades.Height));
            e.Graphics.DrawImage(objBmp, 10, y + 210);
            e.Graphics.DrawString("Lista de Operaciones del Paciente: ", font, Brushes.SeaGreen, new RectangleF(10, y + 320, ancho + 300, 20));
            Bitmap objBmp2 = new Bitmap(dataGridViewOperacionesPaciente.Width, dataGridViewOperacionesPaciente.Height);
            dataGridViewOperacionesPaciente.DrawToBitmap(objBmp2, new Rectangle(0, 0, dataGridViewOperacionesPaciente.Width, dataGridViewOperacionesPaciente.Height));
            e.Graphics.DrawImage(objBmp2, 10, y + 350);
            e.Graphics.DrawString("Lista de Medicinas del Paciente: ", font, Brushes.SeaGreen, new RectangleF(10, y + 470, ancho + 300, 20));
            Bitmap objBmp3 = new Bitmap(dataGridViewDetalleMedicinas.Width, dataGridViewDetalleMedicinas.Height);
            dataGridViewDetalleMedicinas.DrawToBitmap(objBmp3, new Rectangle(0, 0, dataGridViewDetalleMedicinas.Width, dataGridViewDetalleMedicinas.Height));
            e.Graphics.DrawImage(objBmp3, 10, y + 500);
        }
    }
}
