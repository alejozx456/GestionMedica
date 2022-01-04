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
    public partial class ReporteEspecialidad : Form
    {
        public ReporteEspecialidad()
        {
            InitializeComponent();
        }

        private void ReporteEspecialidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoTraumatología' Puede moverla o quitarla según sea necesario.
            this.reportemedicoTraumatologíaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoTraumatología);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoPsiquiatría' Puede moverla o quitarla según sea necesario.
            this.reportemedicoPsiquiatríaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoPsiquiatría);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoPediatria' Puede moverla o quitarla según sea necesario.
            this.reportemedicoPediatriaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoPediatria);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoNeurología' Puede moverla o quitarla según sea necesario.
            this.reportemedicoNeurologíaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoNeurología);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoGeneticaMedica' Puede moverla o quitarla según sea necesario.
            this.reportemedicoGeneticaMedicaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoGeneticaMedica);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoDermatologia' Puede moverla o quitarla según sea necesario.
            this.reportemedicoDermatologiaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoDermatologia);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoCardiologia' Puede moverla o quitarla según sea necesario.
            this.reportemedicoCardiologiaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoCardiologia);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedicoAnestesologia' Puede moverla o quitarla según sea necesario.
            this.reportemedicoAnestesologiaTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedicoAnestesologia);
            // TODO: esta línea de código carga datos en la tabla 'Gestion_MedicaDataSet.reportemedico' Puede moverla o quitarla según sea necesario.
            this.reportemedicoTableAdapter.Fill(this.Gestion_MedicaDataSet.reportemedico);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
