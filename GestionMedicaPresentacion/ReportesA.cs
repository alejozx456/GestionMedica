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
    public partial class ReportesA : Form
    {
        public ReportesA()
        {
            InitializeComponent();
        }

        private void ReportesA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.Enfermedades' Puede moverla o quitarla según sea necesario.
            this.EnfermedadesTableAdapter.Fill(this.Gestion_MedicaDataSet.Enfermedades);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.PacientesTableAdapter.Fill(this.Gestion_MedicaDataSet.Pacientes);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.Examenesvista' Puede moverla o quitarla según sea necesario.
            this.ExamenesvistaTableAdapter.Fill(this.Gestion_MedicaDataSet.Examenesvista);

            this.reportViewer1.RefreshReport();
        }
    }
}
