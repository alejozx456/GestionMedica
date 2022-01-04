namespace GestionMedicaPresentacion
{
    partial class FormularioAgregarUsuarioOcupacion
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
            this.buttonUcupacionAdministrador = new System.Windows.Forms.Button();
            this.buttonOcupacionMedico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonUcupacionAdministrador);
            this.groupBox1.Controls.Add(this.buttonOcupacionMedico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(5, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonUcupacionAdministrador
            // 
            this.buttonUcupacionAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUcupacionAdministrador.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUcupacionAdministrador.Location = new System.Drawing.Point(130, 112);
            this.buttonUcupacionAdministrador.Name = "buttonUcupacionAdministrador";
            this.buttonUcupacionAdministrador.Size = new System.Drawing.Size(122, 36);
            this.buttonUcupacionAdministrador.TabIndex = 2;
            this.buttonUcupacionAdministrador.Text = "administrador";
            this.buttonUcupacionAdministrador.UseVisualStyleBackColor = true;
            this.buttonUcupacionAdministrador.Click += new System.EventHandler(this.buttonUcupacionAdministrador_Click);
            // 
            // buttonOcupacionMedico
            // 
            this.buttonOcupacionMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOcupacionMedico.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcupacionMedico.Location = new System.Drawing.Point(130, 61);
            this.buttonOcupacionMedico.Name = "buttonOcupacionMedico";
            this.buttonOcupacionMedico.Size = new System.Drawing.Size(122, 36);
            this.buttonOcupacionMedico.TabIndex = 1;
            this.buttonOcupacionMedico.Text = "medico";
            this.buttonOcupacionMedico.UseVisualStyleBackColor = true;
            this.buttonOcupacionMedico.Click += new System.EventHandler(this.buttonOcupacionMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocupacion del Usuario";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(130, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista de Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioAgregarUsuarioOcupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioAgregarUsuarioOcupacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAgregarUsuarioOcupacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUcupacionAdministrador;
        private System.Windows.Forms.Button buttonOcupacionMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}