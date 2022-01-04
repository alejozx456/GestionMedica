namespace GestionMedicaPresentacion
{
    partial class FormularioReporteGeneros
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Gestion_MedicaDataSet = new GestionMedicaPresentacion.Gestion_MedicaDataSet();
            this.GeneroMasculinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeneroMasculinoTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.GeneroMasculinoTableAdapter();
            this.GeneroFemeninoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeneroFemeninoTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.GeneroFemeninoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroMasculinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroFemeninoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMasculino";
            reportDataSource1.Value = this.GeneroMasculinoBindingSource;
            reportDataSource2.Name = "DataSetFemenino";
            reportDataSource2.Value = this.GeneroFemeninoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionMedicaPresentacion.Reporte Generos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Gestion_MedicaDataSet
            // 
            this.Gestion_MedicaDataSet.DataSetName = "Gestion_MedicaDataSet";
            this.Gestion_MedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GeneroMasculinoBindingSource
            // 
            this.GeneroMasculinoBindingSource.DataMember = "GeneroMasculino";
            this.GeneroMasculinoBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // GeneroMasculinoTableAdapter
            // 
            this.GeneroMasculinoTableAdapter.ClearBeforeFill = true;
            // 
            // GeneroFemeninoBindingSource
            // 
            this.GeneroFemeninoBindingSource.DataMember = "GeneroFemenino";
            this.GeneroFemeninoBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // GeneroFemeninoTableAdapter
            // 
            this.GeneroFemeninoTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioReporteGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormularioReporteGeneros";
            this.Text = "FormularioReporteGeneros";
            this.Load += new System.EventHandler(this.FormularioReporteGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroMasculinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroFemeninoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GeneroMasculinoBindingSource;
        private Gestion_MedicaDataSet Gestion_MedicaDataSet;
        private Gestion_MedicaDataSetTableAdapters.GeneroMasculinoTableAdapter GeneroMasculinoTableAdapter;
        private System.Windows.Forms.BindingSource GeneroFemeninoBindingSource;
        private Gestion_MedicaDataSetTableAdapters.GeneroFemeninoTableAdapter GeneroFemeninoTableAdapter;
    }
}