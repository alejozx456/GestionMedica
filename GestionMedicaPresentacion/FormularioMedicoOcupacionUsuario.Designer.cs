namespace GestionMedicaPresentacion
{
    partial class FormularioMedicoOcupacionUsuario
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
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGenerarUsuario = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxNOmbre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMedicos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.textBoxIdUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonGenerarUsuario);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.textBoxNOmbre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelOcupacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewMedicos);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Medicos";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(520, 21);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(54, 30);
            this.textBoxIdUsuario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id Usuario";
            // 
            // buttonGenerarUsuario
            // 
            this.buttonGenerarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarUsuario.Location = new System.Drawing.Point(253, 326);
            this.buttonGenerarUsuario.Name = "buttonGenerarUsuario";
            this.buttonGenerarUsuario.Size = new System.Drawing.Size(156, 43);
            this.buttonGenerarUsuario.TabIndex = 12;
            this.buttonGenerarUsuario.Text = "Generar Usuario";
            this.buttonGenerarUsuario.UseVisualStyleBackColor = true;
            this.buttonGenerarUsuario.Click += new System.EventHandler(this.buttonGenerarUsuario_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(474, 283);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 30);
            this.textBoxPassword.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(474, 239);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 30);
            this.textBoxUsuario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Establecer Usuario y Contraseña";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(106, 283);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 30);
            this.textBoxApellido.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 289);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 24);
            this.label.TabIndex = 5;
            this.label.Text = "Apellido";
            // 
            // textBoxNOmbre
            // 
            this.textBoxNOmbre.Location = new System.Drawing.Point(106, 239);
            this.textBoxNOmbre.Name = "textBoxNOmbre";
            this.textBoxNOmbre.Size = new System.Drawing.Size(100, 30);
            this.textBoxNOmbre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Location = new System.Drawing.Point(106, 212);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(69, 24);
            this.labelOcupacion.TabIndex = 2;
            this.labelOcupacion.Text = "ocupacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ocupacion: ";
            // 
            // dataGridViewMedicos
            // 
            this.dataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicos.Location = new System.Drawing.Point(17, 57);
            this.dataGridViewMedicos.Name = "dataGridViewMedicos";
            this.dataGridViewMedicos.Size = new System.Drawing.Size(557, 136);
            this.dataGridViewMedicos.TabIndex = 0;
            this.dataGridViewMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicos_CellClick);
            // 
            // FormularioMedicoOcupacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioMedicoOcupacionUsuario";
            this.Text = "FormularioMedicoOcupacionUsuario";
            this.Load += new System.EventHandler(this.FormularioMedicoOcupacionUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMedicos;
        public System.Windows.Forms.Label labelOcupacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerarUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxNOmbre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label6;
    }
}