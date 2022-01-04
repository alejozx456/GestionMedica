namespace GestionMedicaPresentacion
{
    partial class ReporteEspecialidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Gestion_MedicaDataSet = new GestionMedicaPresentacion.Gestion_MedicaDataSet();
            this.reportemedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoTableAdapter();
            this.reportemedicoAnestesologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoAnestesologiaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoAnestesologiaTableAdapter();
            this.reportemedicoCardiologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoCardiologiaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoCardiologiaTableAdapter();
            this.reportemedicoDermatologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoDermatologiaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoDermatologiaTableAdapter();
            this.reportemedicoGeneticaMedicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoGeneticaMedicaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoGeneticaMedicaTableAdapter();
            this.reportemedicoNeurologíaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoNeurologíaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoNeurologíaTableAdapter();
            this.reportemedicoPediatriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoPediatriaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoPediatriaTableAdapter();
            this.reportemedicoPsiquiatríaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoPsiquiatríaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoPsiquiatríaTableAdapter();
            this.reportemedicoTraumatologíaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportemedicoTraumatologíaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.reportemedicoTraumatologíaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoAnestesologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoCardiologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoDermatologiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoGeneticaMedicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoNeurologíaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoPediatriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoPsiquiatríaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoTraumatologíaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGenereal";
            reportDataSource1.Value = this.reportemedicoBindingSource;
            reportDataSource2.Name = "DataSetAnestesiologia";
            reportDataSource2.Value = this.reportemedicoAnestesologiaBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.reportemedicoCardiologiaBindingSource;
            reportDataSource4.Name = "DataSetDermatologia";
            reportDataSource4.Value = this.reportemedicoDermatologiaBindingSource;
            reportDataSource5.Name = "DataSetGeneticaMedica";
            reportDataSource5.Value = this.reportemedicoGeneticaMedicaBindingSource;
            reportDataSource6.Name = "DataSetNeurologia";
            reportDataSource6.Value = this.reportemedicoNeurologíaBindingSource;
            reportDataSource7.Name = "DataSetPediatria";
            reportDataSource7.Value = this.reportemedicoPediatriaBindingSource;
            reportDataSource8.Name = "DataSetPsiquiatria";
            reportDataSource8.Value = this.reportemedicoPsiquiatríaBindingSource;
            reportDataSource9.Name = "DataSetTrauma";
            reportDataSource9.Value = this.reportemedicoTraumatologíaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionMedicaPresentacion.ReporteEspecialidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // Gestion_MedicaDataSet
            // 
            this.Gestion_MedicaDataSet.DataSetName = "Gestion_MedicaDataSet";
            this.Gestion_MedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportemedicoBindingSource
            // 
            this.reportemedicoBindingSource.DataMember = "reportemedico";
            this.reportemedicoBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoTableAdapter
            // 
            this.reportemedicoTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoAnestesologiaBindingSource
            // 
            this.reportemedicoAnestesologiaBindingSource.DataMember = "reportemedicoAnestesologia";
            this.reportemedicoAnestesologiaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoAnestesologiaTableAdapter
            // 
            this.reportemedicoAnestesologiaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoCardiologiaBindingSource
            // 
            this.reportemedicoCardiologiaBindingSource.DataMember = "reportemedicoCardiologia";
            this.reportemedicoCardiologiaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoCardiologiaTableAdapter
            // 
            this.reportemedicoCardiologiaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoDermatologiaBindingSource
            // 
            this.reportemedicoDermatologiaBindingSource.DataMember = "reportemedicoDermatologia";
            this.reportemedicoDermatologiaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoDermatologiaTableAdapter
            // 
            this.reportemedicoDermatologiaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoGeneticaMedicaBindingSource
            // 
            this.reportemedicoGeneticaMedicaBindingSource.DataMember = "reportemedicoGeneticaMedica";
            this.reportemedicoGeneticaMedicaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoGeneticaMedicaTableAdapter
            // 
            this.reportemedicoGeneticaMedicaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoNeurologíaBindingSource
            // 
            this.reportemedicoNeurologíaBindingSource.DataMember = "reportemedicoNeurología";
            this.reportemedicoNeurologíaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoNeurologíaTableAdapter
            // 
            this.reportemedicoNeurologíaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoPediatriaBindingSource
            // 
            this.reportemedicoPediatriaBindingSource.DataMember = "reportemedicoPediatria";
            this.reportemedicoPediatriaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoPediatriaTableAdapter
            // 
            this.reportemedicoPediatriaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoPsiquiatríaBindingSource
            // 
            this.reportemedicoPsiquiatríaBindingSource.DataMember = "reportemedicoPsiquiatría";
            this.reportemedicoPsiquiatríaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoPsiquiatríaTableAdapter
            // 
            this.reportemedicoPsiquiatríaTableAdapter.ClearBeforeFill = true;
            // 
            // reportemedicoTraumatologíaBindingSource
            // 
            this.reportemedicoTraumatologíaBindingSource.DataMember = "reportemedicoTraumatología";
            this.reportemedicoTraumatologíaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // reportemedicoTraumatologíaTableAdapter
            // 
            this.reportemedicoTraumatologíaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEspecialidad";
            this.Text = "ReporteEspecialidad";
            this.Load += new System.EventHandler(this.ReporteEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoAnestesologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoCardiologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoDermatologiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoGeneticaMedicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoNeurologíaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoPediatriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoPsiquiatríaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoTraumatologíaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportemedicoBindingSource;
        private Gestion_MedicaDataSet Gestion_MedicaDataSet;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoTableAdapter reportemedicoTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoAnestesologiaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoAnestesologiaTableAdapter reportemedicoAnestesologiaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoCardiologiaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoCardiologiaTableAdapter reportemedicoCardiologiaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoDermatologiaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoDermatologiaTableAdapter reportemedicoDermatologiaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoGeneticaMedicaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoGeneticaMedicaTableAdapter reportemedicoGeneticaMedicaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoNeurologíaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoNeurologíaTableAdapter reportemedicoNeurologíaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoPediatriaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoPediatriaTableAdapter reportemedicoPediatriaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoPsiquiatríaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoPsiquiatríaTableAdapter reportemedicoPsiquiatríaTableAdapter;
        private System.Windows.Forms.BindingSource reportemedicoTraumatologíaBindingSource;
        private Gestion_MedicaDataSetTableAdapters.reportemedicoTraumatologíaTableAdapter reportemedicoTraumatologíaTableAdapter;
    }
}