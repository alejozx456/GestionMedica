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
    public partial class FormularioReporteGeneros : Form
    {
        public FormularioReporteGeneros()
        {
            InitializeComponent();
        }

        private void FormularioReporteGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.GeneroFemenino' Puede moverla o quitarla según sea necesario.
            this.GeneroFemeninoTableAdapter.Fill(this.Gestion_MedicaDataSet.GeneroFemenino);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.GeneroMasculino' Puede moverla o quitarla según sea necesario.
            this.GeneroMasculinoTableAdapter.Fill(this.Gestion_MedicaDataSet.GeneroMasculino);

            this.reportViewer1.RefreshReport();
        }
    }
}
