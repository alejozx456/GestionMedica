namespace GestionMedicaPresentacion
{
    partial class FormularioHistorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMedcinas = new System.Windows.Forms.Button();
            this.buttonOperaciones = new System.Windows.Forms.Button();
            this.buttonEnfermedades = new System.Windows.Forms.Button();
            this.buttonGuardarHistorial = new System.Windows.Forms.Button();
            this.textBoxIdHistorial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPacienteHistorial = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacienteHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar un Historial Medico";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonGuardarHistorial);
            this.groupBox1.Controls.Add(this.textBoxIdHistorial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxCedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewPacienteHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Pacientes";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(356, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ver Historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMedcinas);
            this.groupBox2.Controls.Add(this.buttonOperaciones);
            this.groupBox2.Controls.Add(this.buttonEnfermedades);
            this.groupBox2.Location = new System.Drawing.Point(515, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 187);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // buttonMedcinas
            // 
            this.buttonMedcinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedcinas.Location = new System.Drawing.Point(92, 122);
            this.buttonMedcinas.Name = "buttonMedcinas";
            this.buttonMedcinas.Size = new System.Drawing.Size(137, 40);
            this.buttonMedcinas.TabIndex = 16;
            this.buttonMedcinas.Text = "Medicinas";
            this.buttonMedcinas.UseVisualStyleBackColor = true;
            this.buttonMedcinas.Click += new System.EventHandler(this.buttonMedcinas_Click);
            // 
            // buttonOperaciones
            // 
            this.buttonOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperaciones.Location = new System.Drawing.Point(92, 75);
            this.buttonOperaciones.Name = "buttonOperaciones";
            this.buttonOperaciones.Size = new System.Drawing.Size(137, 40);
            this.buttonOperaciones.TabIndex = 15;
            this.buttonOperaciones.Text = "Operaciones";
            this.buttonOperaciones.UseVisualStyleBackColor = true;
            this.buttonOperaciones.Click += new System.EventHandler(this.buttonOperaciones_Click);
            // 
            // buttonEnfermedades
            // 
            this.buttonEnfermedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnfermedades.Location = new System.Drawing.Point(92, 30);
            this.buttonEnfermedades.Name = "buttonEnfermedades";
            this.buttonEnfermedades.Size = new System.Drawing.Size(137, 40);
            this.buttonEnfermedades.TabIndex = 14;
            this.buttonEnfermedades.Text = "Enfermedades";
            this.buttonEnfermedades.UseVisualStyleBackColor = true;
            this.buttonEnfermedades.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGuardarHistorial
            // 
            this.buttonGuardarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarHistorial.Location = new System.Drawing.Point(201, 334);
            this.buttonGuardarHistorial.Name = "buttonGuardarHistorial";
            this.buttonGuardarHistorial.Size = new System.Drawing.Size(137, 40);
            this.buttonGuardarHistorial.TabIndex = 13;
            this.buttonGuardarHistorial.Text = "Generar Historial";
            this.buttonGuardarHistorial.UseVisualStyleBackColor = true;
            this.buttonGuardarHistorial.Click += new System.EventHandler(this.buttonGuardarHistorial_Click);
            // 
            // textBoxIdHistorial
            // 
            this.textBoxIdHistorial.Location = new System.Drawing.Point(728, 61);
            this.textBoxIdHistorial.Name = "textBoxIdHistorial";
            this.textBoxIdHistorial.ReadOnly = true;
            this.textBoxIdHistorial.Size = new System.Drawing.Size(67, 30);
            this.textBoxIdHistorial.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id Historial";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(74, 232);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 30);
            this.textBoxId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(74, 344);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(100, 30);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(74, 308);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(100, 30);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(74, 272);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.ReadOnly = true;
            this.textBoxCedula.Size = new System.Drawing.Size(100, 30);
            this.textBoxCedula.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos Principales";
            // 
            // dataGridViewPacienteHistorial
            // 
            this.dataGridViewPacienteHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacienteHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPacienteHistorial.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewPacienteHistorial.Name = "dataGridViewPacienteHistorial";
            this.dataGridViewPacienteHistorial.Size = new System.Drawing.Size(712, 150);
            this.dataGridViewPacienteHistorial.TabIndex = 0;
            this.dataGridViewPacienteHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacienteHistorial_CellClick);
            // 
            // FormularioHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioHistorial";
            this.Text = "FormularioHistorial";
            this.Load += new System.EventHandler(this.FormularioHistorial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacienteHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPacienteHistorial;
        private System.Windows.Forms.TextBox textBoxIdHistorial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMedcinas;
        private System.Windows.Forms.Button buttonOperaciones;
        private System.Windows.Forms.Button buttonEnfermedades;
        private System.Windows.Forms.Button buttonGuardarHistorial;
        private System.Windows.Forms.Button button1;
    }
}