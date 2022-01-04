namespace GestionMedicaPresentacion
{
    partial class FormularioDetalleEnfermedades
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonAgregarEnfermedades = new System.Windows.Forms.Button();
            this.textBoxIdEnfermedad = new System.Windows.Forms.TextBox();
            this.textBoxIdHistorialPertenece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEnfermedades = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnfermedades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.ButtonAgregarEnfermedades);
            this.groupBox1.Controls.Add(this.textBoxIdEnfermedad);
            this.groupBox1.Controls.Add(this.textBoxIdHistorialPertenece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewEnfermedades);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Enfermedades";
            // 
            // ButtonAgregarEnfermedades
            // 
            this.ButtonAgregarEnfermedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarEnfermedades.Location = new System.Drawing.Point(230, 246);
            this.ButtonAgregarEnfermedades.Name = "ButtonAgregarEnfermedades";
            this.ButtonAgregarEnfermedades.Size = new System.Drawing.Size(115, 36);
            this.ButtonAgregarEnfermedades.TabIndex = 5;
            this.ButtonAgregarEnfermedades.Text = "Agregar";
            this.ButtonAgregarEnfermedades.UseVisualStyleBackColor = true;
            this.ButtonAgregarEnfermedades.Click += new System.EventHandler(this.ButtonAgregarEnfermedades_Click);
            // 
            // textBoxIdEnfermedad
            // 
            this.textBoxIdEnfermedad.Location = new System.Drawing.Point(445, 149);
            this.textBoxIdEnfermedad.Name = "textBoxIdEnfermedad";
            this.textBoxIdEnfermedad.ReadOnly = true;
            this.textBoxIdEnfermedad.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdEnfermedad.TabIndex = 4;
            // 
            // textBoxIdHistorialPertenece
            // 
            this.textBoxIdHistorialPertenece.Location = new System.Drawing.Point(445, 23);
            this.textBoxIdHistorialPertenece.Name = "textBoxIdHistorialPertenece";
            this.textBoxIdHistorialPertenece.ReadOnly = true;
            this.textBoxIdHistorialPertenece.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdHistorialPertenece.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id de la Enfermedad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del Historial";
            // 
            // dataGridViewEnfermedades
            // 
            this.dataGridViewEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEnfermedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnfermedades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEnfermedades.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewEnfermedades.Name = "dataGridViewEnfermedades";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEnfermedades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEnfermedades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEnfermedades.Size = new System.Drawing.Size(273, 150);
            this.dataGridViewEnfermedades.TabIndex = 0;
            this.dataGridViewEnfermedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnfermedades_CellClick);
            this.dataGridViewEnfermedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnfermedades_CellContentClick);
            // 
            // FormularioDetalleEnfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 374);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioDetalleEnfermedades";
            this.Text = "FormularioDetalleEnfermedades";
            this.Load += new System.EventHandler(this.FormularioDetalleEnfermedades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnfermedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEnfermedades;
        private System.Windows.Forms.TextBox textBoxIdEnfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAgregarEnfermedades;
        public System.Windows.Forms.TextBox textBoxIdHistorialPertenece;
    }
}