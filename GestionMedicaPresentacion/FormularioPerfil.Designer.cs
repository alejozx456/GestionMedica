namespace GestionMedicaPresentacion
{
    partial class FormularioPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPerfil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIdPerfilAdmin = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelPosicionPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdPerfil = new System.Windows.Forms.TextBox();
            this.textBoxNombrePerfil = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPerfil = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaPerfil = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaPerfilConfirmar = new System.Windows.Forms.TextBox();
            this.buttonModificarPaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.labelPosicionPerfil);
            this.groupBox1.Controls.Add(this.labelNombres);
            this.groupBox1.Controls.Add(this.labelIdPerfilAdmin);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos principales";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.buttonModificarPaciente);
            this.groupBox2.Controls.Add(this.textBoxContraseñaPerfilConfirmar);
            this.groupBox2.Controls.Add(this.textBoxContraseñaPerfil);
            this.groupBox2.Controls.Add(this.textBoxApellidoPerfil);
            this.groupBox2.Controls.Add(this.textBoxNombrePerfil);
            this.groupBox2.Controls.Add(this.textBoxIdPerfil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(427, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelIdPerfilAdmin
            // 
            this.labelIdPerfilAdmin.AutoSize = true;
            this.labelIdPerfilAdmin.Location = new System.Drawing.Point(178, 88);
            this.labelIdPerfilAdmin.Name = "labelIdPerfilAdmin";
            this.labelIdPerfilAdmin.Size = new System.Drawing.Size(20, 24);
            this.labelIdPerfilAdmin.TabIndex = 1;
            this.labelIdPerfilAdmin.Text = "Id";
            this.labelIdPerfilAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(178, 168);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(63, 24);
            this.labelNombres.TabIndex = 2;
            this.labelNombres.Text = "Nombres";
            // 
            // labelPosicionPerfil
            // 
            this.labelPosicionPerfil.AutoSize = true;
            this.labelPosicionPerfil.Location = new System.Drawing.Point(178, 129);
            this.labelPosicionPerfil.Name = "labelPosicionPerfil";
            this.labelPosicionPerfil.Size = new System.Drawing.Size(59, 24);
            this.labelPosicionPerfil.TabIndex = 4;
            this.labelPosicionPerfil.Text = "Posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // textBoxIdPerfil
            // 
            this.textBoxIdPerfil.Location = new System.Drawing.Point(161, 35);
            this.textBoxIdPerfil.Name = "textBoxIdPerfil";
            this.textBoxIdPerfil.ReadOnly = true;
            this.textBoxIdPerfil.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdPerfil.TabIndex = 9;
            // 
            // textBoxNombrePerfil
            // 
            this.textBoxNombrePerfil.Location = new System.Drawing.Point(161, 97);
            this.textBoxNombrePerfil.Name = "textBoxNombrePerfil";
            this.textBoxNombrePerfil.Size = new System.Drawing.Size(100, 30);
            this.textBoxNombrePerfil.TabIndex = 10;
            // 
            // textBoxApellidoPerfil
            // 
            this.textBoxApellidoPerfil.Location = new System.Drawing.Point(161, 149);
            this.textBoxApellidoPerfil.Name = "textBoxApellidoPerfil";
            this.textBoxApellidoPerfil.Size = new System.Drawing.Size(100, 30);
            this.textBoxApellidoPerfil.TabIndex = 11;
            // 
            // textBoxContraseñaPerfil
            // 
            this.textBoxContraseñaPerfil.Location = new System.Drawing.Point(161, 205);
            this.textBoxContraseñaPerfil.Name = "textBoxContraseñaPerfil";
            this.textBoxContraseñaPerfil.Size = new System.Drawing.Size(100, 30);
            this.textBoxContraseñaPerfil.TabIndex = 12;
            // 
            // textBoxContraseñaPerfilConfirmar
            // 
            this.textBoxContraseñaPerfilConfirmar.Location = new System.Drawing.Point(161, 252);
            this.textBoxContraseñaPerfilConfirmar.Name = "textBoxContraseñaPerfilConfirmar";
            this.textBoxContraseñaPerfilConfirmar.Size = new System.Drawing.Size(100, 30);
            this.textBoxContraseñaPerfilConfirmar.TabIndex = 13;
            // 
            // buttonModificarPaciente
            // 
            this.buttonModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarPaciente.Location = new System.Drawing.Point(21, 324);
            this.buttonModificarPaciente.Name = "buttonModificarPaciente";
            this.buttonModificarPaciente.Size = new System.Drawing.Size(119, 40);
            this.buttonModificarPaciente.TabIndex = 14;
            this.buttonModificarPaciente.Text = "Modificar";
            this.buttonModificarPaciente.UseVisualStyleBackColor = true;
            this.buttonModificarPaciente.Click += new System.EventHandler(this.buttonModificarPaciente_Click);
            // 
            // FormularioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioPerfil";
            this.Text = "FormularioPerfil";
            this.Load += new System.EventHandler(this.FormularioPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelIdPerfilAdmin;
        private System.Windows.Forms.TextBox textBoxContraseñaPerfilConfirmar;
        private System.Windows.Forms.TextBox textBoxContraseñaPerfil;
        private System.Windows.Forms.TextBox textBoxApellidoPerfil;
        private System.Windows.Forms.TextBox textBoxNombrePerfil;
        private System.Windows.Forms.TextBox textBoxIdPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelPosicionPerfil;
        public System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Button buttonModificarPaciente;
    }
}