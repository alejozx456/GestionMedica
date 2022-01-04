namespace GestionMedicaPresentacion
{
    partial class FormularioDetalleOperaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNOmbreOperacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAgregarOperacion = new System.Windows.Forms.Button();
            this.textBoxIdHistorial = new System.Windows.Forms.TextBox();
            this.textBoxIDOperacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOperaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.textBoxNOmbreOperacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAgregarOperacion);
            this.groupBox1.Controls.Add(this.textBoxIdHistorial);
            this.groupBox1.Controls.Add(this.textBoxIDOperacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewOperaciones);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Operaciones";
            // 
            // textBoxNOmbreOperacion
            // 
            this.textBoxNOmbreOperacion.Location = new System.Drawing.Point(485, 75);
            this.textBoxNOmbreOperacion.Name = "textBoxNOmbreOperacion";
            this.textBoxNOmbreOperacion.Size = new System.Drawing.Size(100, 30);
            this.textBoxNOmbreOperacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // buttonAgregarOperacion
            // 
            this.buttonAgregarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarOperacion.Location = new System.Drawing.Point(257, 251);
            this.buttonAgregarOperacion.Name = "buttonAgregarOperacion";
            this.buttonAgregarOperacion.Size = new System.Drawing.Size(173, 40);
            this.buttonAgregarOperacion.TabIndex = 5;
            this.buttonAgregarOperacion.Text = "Agregar Operacion";
            this.buttonAgregarOperacion.UseVisualStyleBackColor = true;
            this.buttonAgregarOperacion.Click += new System.EventHandler(this.buttonAgregarOperacion_Click);
            // 
            // textBoxIdHistorial
            // 
            this.textBoxIdHistorial.Location = new System.Drawing.Point(485, 149);
            this.textBoxIdHistorial.Name = "textBoxIdHistorial";
            this.textBoxIdHistorial.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdHistorial.TabIndex = 4;
            // 
            // textBoxIDOperacion
            // 
            this.textBoxIDOperacion.Location = new System.Drawing.Point(485, 23);
            this.textBoxIDOperacion.Name = "textBoxIDOperacion";
            this.textBoxIDOperacion.Size = new System.Drawing.Size(100, 30);
            this.textBoxIDOperacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID del Historial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID de la Operacion";
            // 
            // dataGridViewOperaciones
            // 
            this.dataGridViewOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOperaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOperaciones.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewOperaciones.Name = "dataGridViewOperaciones";
            this.dataGridViewOperaciones.Size = new System.Drawing.Size(326, 171);
            this.dataGridViewOperaciones.TabIndex = 0;
            this.dataGridViewOperaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOperaciones_CellClick);
            // 
            // FormularioDetalleOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 387);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioDetalleOperaciones";
            this.Text = "FormularioDetalleOperaciones";
            this.Load += new System.EventHandler(this.FormularioDetalleOperaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAgregarOperacion;
        private System.Windows.Forms.TextBox textBoxIDOperacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOperaciones;
        private System.Windows.Forms.TextBox textBoxNOmbreOperacion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxIdHistorial;
    }
}