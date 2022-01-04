namespace GestionMedicaPresentacion
{
    partial class ExamenResultadocs
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
            this.label_Cita = new System.Windows.Forms.Label();
            this.textBox_Registro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.textBox_ID_Atencion_examen = new System.Windows.Forms.TextBox();
            this.textBox_ID_Examen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label_Cita);
            this.groupBox1.Controls.Add(this.textBox_Registro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.textBox_ID_Atencion_examen);
            this.groupBox1.Controls.Add(this.textBox_ID_Examen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_Cita
            // 
            this.label_Cita.AutoSize = true;
            this.label_Cita.Location = new System.Drawing.Point(249, 27);
            this.label_Cita.Name = "label_Cita";
            this.label_Cita.Size = new System.Drawing.Size(25, 20);
            this.label_Cita.TabIndex = 20;
            this.label_Cita.Text = "....";
            this.label_Cita.Click += new System.EventHandler(this.label_Cita_Click);
            // 
            // textBox_Registro
            // 
            this.textBox_Registro.Location = new System.Drawing.Point(196, 273);
            this.textBox_Registro.Multiline = true;
            this.textBox_Registro.Name = "textBox_Registro";
            this.textBox_Registro.Size = new System.Drawing.Size(268, 60);
            this.textBox_Registro.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Resultado Del Examen ";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(196, 350);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(128, 29);
            this.Agregar.TabIndex = 17;
            this.Agregar.Text = "Registrar Resultado";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // textBox_ID_Atencion_examen
            // 
            this.textBox_ID_Atencion_examen.Location = new System.Drawing.Point(196, 236);
            this.textBox_ID_Atencion_examen.Name = "textBox_ID_Atencion_examen";
            this.textBox_ID_Atencion_examen.Size = new System.Drawing.Size(268, 26);
            this.textBox_ID_Atencion_examen.TabIndex = 16;
            // 
            // textBox_ID_Examen
            // 
            this.textBox_ID_Examen.Location = new System.Drawing.Point(196, 204);
            this.textBox_ID_Examen.Name = "textBox_ID_Examen";
            this.textBox_ID_Examen.Size = new System.Drawing.Size(268, 26);
            this.textBox_ID_Examen.TabIndex = 15;
            this.textBox_ID_Examen.TextChanged += new System.EventHandler(this.textBox_ID_Examen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id Atencion Examen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id del Examen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 95);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Examenes Solicitados en la Cita N°";
            // 
            // ExamenResultadocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(499, 406);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExamenResultadocs";
            this.Text = "ExamenResultadocs";
            this.Load += new System.EventHandler(this.ExamenResultadocs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregar;
        public System.Windows.Forms.TextBox textBox_ID_Examen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Registro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_ID_Atencion_examen;
        public System.Windows.Forms.Label label_Cita;
    }
}