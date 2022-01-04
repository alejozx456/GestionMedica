namespace GestionMedicaPresentacion
{
    partial class ReportesA
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Gestion_MedicaDataSet = new GestionMedicaPresentacion.Gestion_MedicaDataSet();
            this.ExamenesvistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExamenesvistaTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.ExamenesvistaTableAdapter();
            this.PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacientesTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.PacientesTableAdapter();
            this.EnfermedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnfermedadesTableAdapter = new GestionMedicaPresentacion.Gestion_MedicaDataSetTableAdapters.EnfermedadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamenesvistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEXamenes";
            reportDataSource1.Value = this.ExamenesvistaBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PacientesBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.EnfermedadesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionMedicaPresentacion.Report1.rdlc";
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
            // ExamenesvistaBindingSource
            // 
            this.ExamenesvistaBindingSource.DataMember = "Examenesvista";
            this.ExamenesvistaBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // ExamenesvistaTableAdapter
            // 
            this.ExamenesvistaTableAdapter.ClearBeforeFill = true;
            // 
            // PacientesBindingSource
            // 
            this.PacientesBindingSource.DataMember = "Pacientes";
            this.PacientesBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // PacientesTableAdapter
            // 
            this.PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // EnfermedadesBindingSource
            // 
            this.EnfermedadesBindingSource.DataMember = "Enfermedades";
            this.EnfermedadesBindingSource.DataSource = this.Gestion_MedicaDataSet;
            // 
            // EnfermedadesTableAdapter
            // 
            this.EnfermedadesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesA";
            this.Text = "ReportesA";
            this.Load += new System.EventHandler(this.ReportesA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_MedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamenesvistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExamenesvistaBindingSource;
        private Gestion_MedicaDataSet Gestion_MedicaDataSet;
        private Gestion_MedicaDataSetTableAdapters.ExamenesvistaTableAdapter ExamenesvistaTableAdapter;
        private System.Windows.Forms.BindingSource PacientesBindingSource;
        private Gestion_MedicaDataSetTableAdapters.PacientesTableAdapter PacientesTableAdapter;
        private System.Windows.Forms.BindingSource EnfermedadesBindingSource;
        private Gestion_MedicaDataSetTableAdapters.EnfermedadesTableAdapter EnfermedadesTableAdapter;
    }
}