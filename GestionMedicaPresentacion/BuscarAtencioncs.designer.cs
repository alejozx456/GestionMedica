namespace GestionMedicaPresentacion
{
    partial class BuscarAtencioncs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_prueba = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nueva_atencion = new System.Windows.Forms.Button();
            this.Limpir_busqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBox_Busqueda = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.label_prueba);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Nueva_atencion);
            this.groupBox1.Controls.Add(this.Limpir_busqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.textBox_Busqueda);
            this.groupBox1.Location = new System.Drawing.Point(95, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 398);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_prueba
            // 
            this.label_prueba.AutoSize = true;
            this.label_prueba.Location = new System.Drawing.Point(246, 363);
            this.label_prueba.Name = "label_prueba";
            this.label_prueba.Size = new System.Drawing.Size(19, 13);
            this.label_prueba.TabIndex = 7;
            this.label_prueba.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle de la Atencion al Paciente ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nueva_atencion
            // 
            this.Nueva_atencion.BackColor = System.Drawing.Color.LightGreen;
            this.Nueva_atencion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nueva_atencion.Location = new System.Drawing.Point(601, 44);
            this.Nueva_atencion.Name = "Nueva_atencion";
            this.Nueva_atencion.Size = new System.Drawing.Size(126, 37);
            this.Nueva_atencion.TabIndex = 3;
            this.Nueva_atencion.Text = "Nueva Atencion";
            this.Nueva_atencion.UseVisualStyleBackColor = false;
            this.Nueva_atencion.Click += new System.EventHandler(this.Nueva_atencion_Click);
            // 
            // Limpir_busqueda
            // 
            this.Limpir_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpir_busqueda.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpir_busqueda.Location = new System.Drawing.Point(462, 44);
            this.Limpir_busqueda.Name = "Limpir_busqueda";
            this.Limpir_busqueda.Size = new System.Drawing.Size(118, 39);
            this.Limpir_busqueda.TabIndex = 2;
            this.Limpir_busqueda.Text = "Limpiar Busqueda";
            this.Limpir_busqueda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atencion a Pacientes";
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.LightGreen;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Buscar.Location = new System.Drawing.Point(349, 46);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 37);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBox_Busqueda
            // 
            this.textBox_Busqueda.Location = new System.Drawing.Point(192, 55);
            this.textBox_Busqueda.Name = "textBox_Busqueda";
            this.textBox_Busqueda.Size = new System.Drawing.Size(151, 20);
            this.textBox_Busqueda.TabIndex = 0;
            // 
            // BuscarAtencioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarAtencioncs";
            this.Text = "BuscarAtencioncs";
            this.Load += new System.EventHandler(this.BuscarAtencioncs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Nueva_atencion;
        private System.Windows.Forms.Button Limpir_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        public System.Windows.Forms.TextBox textBox_Busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_prueba;
    }
}