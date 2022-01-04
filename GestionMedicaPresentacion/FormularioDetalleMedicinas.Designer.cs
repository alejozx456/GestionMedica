namespace GestionMedicaPresentacion
{
    partial class FormularioDetalleMedicinas
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
            this.dataGridViewListadeMedicinas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarMedicina = new System.Windows.Forms.Button();
            this.textBoxIdHistorial = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxIDMedicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadeMedicinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListadeMedicinas
            // 
            this.dataGridViewListadeMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListadeMedicinas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListadeMedicinas.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewListadeMedicinas.Name = "dataGridViewListadeMedicinas";
            this.dataGridViewListadeMedicinas.Size = new System.Drawing.Size(302, 141);
            this.dataGridViewListadeMedicinas.TabIndex = 0;
            this.dataGridViewListadeMedicinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadeMedicinas_CellClick);
            this.dataGridViewListadeMedicinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.buttonAgregarMedicina);
            this.groupBox1.Controls.Add(this.textBoxIdHistorial);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxIDMedicina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewListadeMedicinas);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Medicinas";
            // 
            // buttonAgregarMedicina
            // 
            this.buttonAgregarMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarMedicina.Location = new System.Drawing.Point(235, 249);
            this.buttonAgregarMedicina.Name = "buttonAgregarMedicina";
            this.buttonAgregarMedicina.Size = new System.Drawing.Size(138, 41);
            this.buttonAgregarMedicina.TabIndex = 7;
            this.buttonAgregarMedicina.Text = "Agregar Medicina";
            this.buttonAgregarMedicina.UseVisualStyleBackColor = true;
            this.buttonAgregarMedicina.Click += new System.EventHandler(this.buttonAgregarMedicina_Click);
            // 
            // textBoxIdHistorial
            // 
            this.textBoxIdHistorial.Location = new System.Drawing.Point(430, 147);
            this.textBoxIdHistorial.Name = "textBoxIdHistorial";
            this.textBoxIdHistorial.ReadOnly = true;
            this.textBoxIdHistorial.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdHistorial.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(430, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 30);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxIDMedicina
            // 
            this.textBoxIDMedicina.Location = new System.Drawing.Point(430, 29);
            this.textBoxIDMedicina.Name = "textBoxIDMedicina";
            this.textBoxIDMedicina.Size = new System.Drawing.Size(100, 30);
            this.textBoxIDMedicina.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id del Historial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de la Medicina";
            // 
            // FormularioDetalleMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 377);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormularioDetalleMedicinas";
            this.Text = "FormularioDetalleMedicinas";
            this.Load += new System.EventHandler(this.FormularioDetalleMedicinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadeMedicinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadeMedicinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxIDMedicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarMedicina;
        public System.Windows.Forms.TextBox textBoxIdHistorial;
    }
}