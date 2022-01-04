namespace GestionMedicaPresentacion
{
    partial class FormularioCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCita));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNOmbreMedico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxApelidoCita = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombrePaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMedicoCita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPacienteCita = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicoCita = new System.Windows.Forms.DataGridView();
            this.dataGridViewPacientesCita = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerCita = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCita = new System.Windows.Forms.TextBox();
            this.textBoxBuscarPaciente = new System.Windows.Forms.TextBox();
            this.textBoxBuscarMedico = new System.Windows.Forms.TextBox();
            this.buttonBUscarPaciente = new System.Windows.Forms.Button();
            this.buttonBuscarMedico = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicoCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesCita)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.buttonBuscarMedico);
            this.groupBox1.Controls.Add(this.buttonBUscarPaciente);
            this.groupBox1.Controls.Add(this.textBoxBuscarMedico);
            this.groupBox1.Controls.Add(this.textBoxBuscarPaciente);
            this.groupBox1.Controls.Add(this.textBoxEspecialidadMedico);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNOmbreMedico);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxApelidoCita);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxNombrePaciente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMedicoCita);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPacienteCita);
            this.groupBox1.Controls.Add(this.dataGridViewMedicoCita);
            this.groupBox1.Controls.Add(this.dataGridViewPacientesCita);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateTimePickerCita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIdCita);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Cita Medica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxEspecialidadMedico
            // 
            this.textBoxEspecialidadMedico.Location = new System.Drawing.Point(517, 397);
            this.textBoxEspecialidadMedico.Name = "textBoxEspecialidadMedico";
            this.textBoxEspecialidadMedico.ReadOnly = true;
            this.textBoxEspecialidadMedico.Size = new System.Drawing.Size(133, 30);
            this.textBoxEspecialidadMedico.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Especialidad";
            // 
            // textBoxNOmbreMedico
            // 
            this.textBoxNOmbreMedico.Location = new System.Drawing.Point(517, 356);
            this.textBoxNOmbreMedico.Name = "textBoxNOmbreMedico";
            this.textBoxNOmbreMedico.ReadOnly = true;
            this.textBoxNOmbreMedico.Size = new System.Drawing.Size(133, 30);
            this.textBoxNOmbreMedico.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nombre";
            // 
            // textBoxApelidoCita
            // 
            this.textBoxApelidoCita.Location = new System.Drawing.Point(133, 397);
            this.textBoxApelidoCita.Name = "textBoxApelidoCita";
            this.textBoxApelidoCita.ReadOnly = true;
            this.textBoxApelidoCita.Size = new System.Drawing.Size(133, 30);
            this.textBoxApelidoCita.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Apellido";
            // 
            // textBoxNombrePaciente
            // 
            this.textBoxNombrePaciente.Location = new System.Drawing.Point(133, 356);
            this.textBoxNombrePaciente.Name = "textBoxNombrePaciente";
            this.textBoxNombrePaciente.ReadOnly = true;
            this.textBoxNombrePaciente.Size = new System.Drawing.Size(133, 30);
            this.textBoxNombrePaciente.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id del Medico";
            // 
            // textBoxMedicoCita
            // 
            this.textBoxMedicoCita.Location = new System.Drawing.Point(517, 317);
            this.textBoxMedicoCita.Name = "textBoxMedicoCita";
            this.textBoxMedicoCita.ReadOnly = true;
            this.textBoxMedicoCita.Size = new System.Drawing.Size(133, 30);
            this.textBoxMedicoCita.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id del Paciente";
            // 
            // textBoxPacienteCita
            // 
            this.textBoxPacienteCita.Location = new System.Drawing.Point(133, 320);
            this.textBoxPacienteCita.Name = "textBoxPacienteCita";
            this.textBoxPacienteCita.ReadOnly = true;
            this.textBoxPacienteCita.Size = new System.Drawing.Size(133, 30);
            this.textBoxPacienteCita.TabIndex = 14;
            // 
            // dataGridViewMedicoCita
            // 
            this.dataGridViewMedicoCita.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewMedicoCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedicoCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicoCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicoCita.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedicoCita.EnableHeadersVisualStyles = false;
            this.dataGridViewMedicoCita.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewMedicoCita.Location = new System.Drawing.Point(406, 126);
            this.dataGridViewMedicoCita.Name = "dataGridViewMedicoCita";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedicoCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMedicoCita.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMedicoCita.Size = new System.Drawing.Size(379, 189);
            this.dataGridViewMedicoCita.TabIndex = 13;
            this.dataGridViewMedicoCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicoCita_CellClick);
            // 
            // dataGridViewPacientesCita
            // 
            this.dataGridViewPacientesCita.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewPacientesCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientesCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPacientesCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacientesCita.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPacientesCita.EnableHeadersVisualStyles = false;
            this.dataGridViewPacientesCita.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewPacientesCita.Location = new System.Drawing.Point(21, 125);
            this.dataGridViewPacientesCita.Name = "dataGridViewPacientesCita";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacientesCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPacientesCita.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPacientesCita.Size = new System.Drawing.Size(379, 189);
            this.dataGridViewPacientesCita.TabIndex = 12;
            this.dataGridViewPacientesCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientesCita_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(27, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmar Cita";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(258, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Establecer Cita";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(756, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar Examen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Agrege un examen a la cita";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(264, 64);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(44, 24);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerCita
            // 
            this.dateTimePickerCita.Location = new System.Drawing.Point(335, 64);
            this.dateTimePickerCita.Name = "dateTimePickerCita";
            this.dateTimePickerCita.Size = new System.Drawing.Size(255, 30);
            this.dateTimePickerCita.TabIndex = 7;
            this.dateTimePickerCita.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calendarizar una cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paciente de la Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medico de la Cita";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de la cita";
            // 
            // textBoxIdCita
            // 
            this.textBoxIdCita.Location = new System.Drawing.Point(333, 20);
            this.textBoxIdCita.Name = "textBoxIdCita";
            this.textBoxIdCita.ReadOnly = true;
            this.textBoxIdCita.Size = new System.Drawing.Size(257, 30);
            this.textBoxIdCita.TabIndex = 0;
            // 
            // textBoxBuscarPaciente
            // 
            this.textBoxBuscarPaciente.Location = new System.Drawing.Point(139, 94);
            this.textBoxBuscarPaciente.Name = "textBoxBuscarPaciente";
            this.textBoxBuscarPaciente.Size = new System.Drawing.Size(100, 30);
            this.textBoxBuscarPaciente.TabIndex = 26;
            // 
            // textBoxBuscarMedico
            // 
            this.textBoxBuscarMedico.Location = new System.Drawing.Point(534, 95);
            this.textBoxBuscarMedico.Name = "textBoxBuscarMedico";
            this.textBoxBuscarMedico.Size = new System.Drawing.Size(100, 30);
            this.textBoxBuscarMedico.TabIndex = 27;
            // 
            // buttonBUscarPaciente
            // 
            this.buttonBUscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBUscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("buttonBUscarPaciente.Image")));
            this.buttonBUscarPaciente.Location = new System.Drawing.Point(255, 98);
            this.buttonBUscarPaciente.Name = "buttonBUscarPaciente";
            this.buttonBUscarPaciente.Size = new System.Drawing.Size(42, 22);
            this.buttonBUscarPaciente.TabIndex = 28;
            this.buttonBUscarPaciente.UseVisualStyleBackColor = true;
            this.buttonBUscarPaciente.Click += new System.EventHandler(this.buttonBUscarPaciente_Click);
            // 
            // buttonBuscarMedico
            // 
            this.buttonBuscarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarMedico.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMedico.Image")));
            this.buttonBuscarMedico.Location = new System.Drawing.Point(655, 98);
            this.buttonBuscarMedico.Name = "buttonBuscarMedico";
            this.buttonBuscarMedico.Size = new System.Drawing.Size(42, 22);
            this.buttonBuscarMedico.TabIndex = 29;
            this.buttonBuscarMedico.UseVisualStyleBackColor = true;
            this.buttonBuscarMedico.Click += new System.EventHandler(this.buttonBuscarMedico_Click);
            // 
            // FormularioCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioCita";
            this.Text = "FormularioCita";
            this.Load += new System.EventHandler(this.FormularioCita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicoCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesCita)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdCita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DataGridView dataGridViewPacientesCita;
        private System.Windows.Forms.DataGridView dataGridViewMedicoCita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPacienteCita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMedicoCita;
        private System.Windows.Forms.TextBox textBoxApelidoCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombrePaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEspecialidadMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNOmbreMedico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBuscarMedico;
        private System.Windows.Forms.Button buttonBUscarPaciente;
        private System.Windows.Forms.TextBox textBoxBuscarMedico;
        private System.Windows.Forms.TextBox textBoxBuscarPaciente;
    }
}