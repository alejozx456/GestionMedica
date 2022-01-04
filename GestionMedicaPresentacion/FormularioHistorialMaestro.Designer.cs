namespace GestionMedicaPresentacion
{
    partial class FormularioHistorialMaestro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListaHistorial = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxApellidoPaciente = new System.Windows.Forms.TextBox();
            this.textBoxNombrePaciente = new System.Windows.Forms.TextBox();
            this.textBoxCedulaPaciente = new System.Windows.Forms.TextBox();
            this.textBoxIdHistorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEnfermedades = new System.Windows.Forms.DataGridView();
            this.buttonEnfermedadesdelPaciente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOperacionesPaciente = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetalleMedicinas = new System.Windows.Forms.DataGridView();
            this.buttonOperacionesPaciente = new System.Windows.Forms.Button();
            this.buttonMedicinasPaciente = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnfermedades)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperacionesPaciente)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleMedicinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaHistorial
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListaHistorial.Location = new System.Drawing.Point(16, 30);
            this.dataGridViewListaHistorial.Name = "dataGridViewListaHistorial";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListaHistorial.Size = new System.Drawing.Size(460, 166);
            this.dataGridViewListaHistorial.TabIndex = 0;
            this.dataGridViewListaHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaHistorial_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.textBoxApellidoPaciente);
            this.groupBox1.Controls.Add(this.textBoxNombrePaciente);
            this.groupBox1.Controls.Add(this.textBoxCedulaPaciente);
            this.groupBox1.Controls.Add(this.textBoxIdHistorial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewListaHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Historiales";
            // 
            // textBoxApellidoPaciente
            // 
            this.textBoxApellidoPaciente.Location = new System.Drawing.Point(629, 166);
            this.textBoxApellidoPaciente.Name = "textBoxApellidoPaciente";
            this.textBoxApellidoPaciente.ReadOnly = true;
            this.textBoxApellidoPaciente.Size = new System.Drawing.Size(100, 30);
            this.textBoxApellidoPaciente.TabIndex = 8;
            // 
            // textBoxNombrePaciente
            // 
            this.textBoxNombrePaciente.Location = new System.Drawing.Point(629, 120);
            this.textBoxNombrePaciente.Name = "textBoxNombrePaciente";
            this.textBoxNombrePaciente.ReadOnly = true;
            this.textBoxNombrePaciente.Size = new System.Drawing.Size(100, 30);
            this.textBoxNombrePaciente.TabIndex = 7;
            // 
            // textBoxCedulaPaciente
            // 
            this.textBoxCedulaPaciente.Location = new System.Drawing.Point(629, 75);
            this.textBoxCedulaPaciente.Name = "textBoxCedulaPaciente";
            this.textBoxCedulaPaciente.ReadOnly = true;
            this.textBoxCedulaPaciente.Size = new System.Drawing.Size(100, 30);
            this.textBoxCedulaPaciente.TabIndex = 6;
            // 
            // textBoxIdHistorial
            // 
            this.textBoxIdHistorial.Location = new System.Drawing.Point(629, 24);
            this.textBoxIdHistorial.Name = "textBoxIdHistorial";
            this.textBoxIdHistorial.ReadOnly = true;
            this.textBoxIdHistorial.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdHistorial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apelllido del Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula del Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del Historial";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.dataGridViewEnfermedades);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(23, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enfermedades del Paciente";
            // 
            // dataGridViewEnfermedades
            // 
            this.dataGridViewEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnfermedades.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEnfermedades.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewEnfermedades.Name = "dataGridViewEnfermedades";
            this.dataGridViewEnfermedades.Size = new System.Drawing.Size(345, 94);
            this.dataGridViewEnfermedades.TabIndex = 0;
            // 
            // buttonEnfermedadesdelPaciente
            // 
            this.buttonEnfermedadesdelPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnfermedadesdelPaciente.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnfermedadesdelPaciente.Location = new System.Drawing.Point(490, 440);
            this.buttonEnfermedadesdelPaciente.Name = "buttonEnfermedadesdelPaciente";
            this.buttonEnfermedadesdelPaciente.Size = new System.Drawing.Size(234, 37);
            this.buttonEnfermedadesdelPaciente.TabIndex = 3;
            this.buttonEnfermedadesdelPaciente.Text = "Ver Enfermedades del paciente";
            this.buttonEnfermedadesdelPaciente.UseVisualStyleBackColor = true;
            this.buttonEnfermedadesdelPaciente.Click += new System.EventHandler(this.buttonEnfermedadesdelPaciente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.dataGridViewOperacionesPaciente);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(482, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones del Paciente";
            // 
            // dataGridViewOperacionesPaciente
            // 
            this.dataGridViewOperacionesPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOperacionesPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOperacionesPaciente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOperacionesPaciente.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewOperacionesPaciente.Name = "dataGridViewOperacionesPaciente";
            this.dataGridViewOperacionesPaciente.Size = new System.Drawing.Size(328, 106);
            this.dataGridViewOperacionesPaciente.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Controls.Add(this.dataGridViewDetalleMedicinas);
            this.groupBox4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(23, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 146);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Medicinas del Paciente";
            // 
            // dataGridViewDetalleMedicinas
            // 
            this.dataGridViewDetalleMedicinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetalleMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalleMedicinas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDetalleMedicinas.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewDetalleMedicinas.Name = "dataGridViewDetalleMedicinas";
            this.dataGridViewDetalleMedicinas.Size = new System.Drawing.Size(415, 106);
            this.dataGridViewDetalleMedicinas.TabIndex = 0;
            // 
            // buttonOperacionesPaciente
            // 
            this.buttonOperacionesPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperacionesPaciente.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperacionesPaciente.Location = new System.Drawing.Point(490, 526);
            this.buttonOperacionesPaciente.Name = "buttonOperacionesPaciente";
            this.buttonOperacionesPaciente.Size = new System.Drawing.Size(234, 37);
            this.buttonOperacionesPaciente.TabIndex = 5;
            this.buttonOperacionesPaciente.Text = "Ver Operaciones del Paciente";
            this.buttonOperacionesPaciente.UseVisualStyleBackColor = true;
            this.buttonOperacionesPaciente.Click += new System.EventHandler(this.buttonOperacionesPaciente_Click);
            // 
            // buttonMedicinasPaciente
            // 
            this.buttonMedicinasPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicinasPaciente.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicinasPaciente.Location = new System.Drawing.Point(490, 483);
            this.buttonMedicinasPaciente.Name = "buttonMedicinasPaciente";
            this.buttonMedicinasPaciente.Size = new System.Drawing.Size(234, 37);
            this.buttonMedicinasPaciente.TabIndex = 6;
            this.buttonMedicinasPaciente.Text = "Ver Medicinas del paciente";
            this.buttonMedicinasPaciente.UseVisualStyleBackColor = true;
            this.buttonMedicinasPaciente.Click += new System.EventHandler(this.buttonMedicinasPaciente_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.Olive;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(733, 483);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(175, 37);
            this.buttonImprimir.TabIndex = 7;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // FormularioHistorialMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 599);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonMedicinasPaciente);
            this.Controls.Add(this.buttonOperacionesPaciente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonEnfermedadesdelPaciente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioHistorialMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioHistorialMaestro";
            this.Load += new System.EventHandler(this.FormularioHistorialMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnfermedades)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperacionesPaciente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleMedicinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxApellidoPaciente;
        private System.Windows.Forms.TextBox textBoxNombrePaciente;
        private System.Windows.Forms.TextBox textBoxCedulaPaciente;
        private System.Windows.Forms.TextBox textBoxIdHistorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewEnfermedades;
        private System.Windows.Forms.Button buttonEnfermedadesdelPaciente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewOperacionesPaciente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewDetalleMedicinas;
        private System.Windows.Forms.Button buttonOperacionesPaciente;
        private System.Windows.Forms.Button buttonMedicinasPaciente;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}