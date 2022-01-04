namespace GestionMedicaPresentacion
{
    partial class Detalle_Medicinas_Atencion
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
            this.Buscar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.textBox_ID_Medicamento = new System.Windows.Forms.TextBox();
            this.textBox_ID_Atencion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.Borrar);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.textBox_buscar);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.textBox_ID_Medicamento);
            this.groupBox1.Controls.Add(this.textBox_ID_Atencion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(262, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(63, 27);
            this.Buscar.TabIndex = 19;
            this.Buscar.Text = "Buscar ";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(103, 25);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(153, 26);
            this.textBox_buscar.TabIndex = 18;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(194, 260);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 29);
            this.Agregar.TabIndex = 17;
            this.Agregar.Text = "Agregar ";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // textBox_ID_Medicamento
            // 
            this.textBox_ID_Medicamento.Location = new System.Drawing.Point(156, 217);
            this.textBox_ID_Medicamento.Name = "textBox_ID_Medicamento";
            this.textBox_ID_Medicamento.Size = new System.Drawing.Size(100, 26);
            this.textBox_ID_Medicamento.TabIndex = 16;
            // 
            // textBox_ID_Atencion
            // 
            this.textBox_ID_Atencion.Location = new System.Drawing.Point(156, 185);
            this.textBox_ID_Atencion.Name = "textBox_ID_Atencion";
            this.textBox_ID_Atencion.Size = new System.Drawing.Size(100, 26);
            this.textBox_ID_Atencion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id del Medicamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id de la Atencion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 95);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medicinas";
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.Firebrick;
            this.Borrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Borrar.Location = new System.Drawing.Point(331, 25);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(124, 27);
            this.Borrar.TabIndex = 20;
            this.Borrar.Text = "Borrar Busqueda";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Detalle_Medicinas_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(473, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "Detalle_Medicinas_Atencion";
            this.Text = "Detalle_Medicinas_Atencion";
            this.Load += new System.EventHandler(this.Detalle_Medicinas_Atencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox textBox_ID_Medicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_ID_Atencion;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button Borrar;
    }
}