namespace GestionMedicaPresentacion
{
    partial class FormularioListaPacientes
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
            this.dataGridViewListaPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaPacientes
            // 
            this.dataGridViewListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPacientes.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewListaPacientes.Name = "dataGridViewListaPacientes";
            this.dataGridViewListaPacientes.Size = new System.Drawing.Size(865, 371);
            this.dataGridViewListaPacientes.TabIndex = 0;
            this.dataGridViewListaPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaPacientes_CellClick);
            this.dataGridViewListaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaPacientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del Paciente";
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPaciente.Location = new System.Drawing.Point(150, 445);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(79, 30);
            this.textBoxIdPaciente.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(276, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar Paciente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormularioListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(920, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxIdPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListaPacientes);
            this.Name = "FormularioListaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioListaPacientes";
            this.Load += new System.EventHandler(this.FormularioListaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPaciente;
        private System.Windows.Forms.Button button2;
    }
}