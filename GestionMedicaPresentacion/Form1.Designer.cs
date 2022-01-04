namespace GestionMedicaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonUsuarioAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNuevo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNombres);
            this.panel1.Controls.Add(this.labelOcupacion);
            this.panel1.Controls.Add(this.buttonPerfil);
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonMedicos);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 596);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "Atenciones";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(90, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Agency FB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombres.Location = new System.Drawing.Point(90, 54);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 17);
            this.labelNombres.TabIndex = 7;
            this.labelNombres.Text = "Nombres";
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Font = new System.Drawing.Font("Agency FB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcupacion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOcupacion.Location = new System.Drawing.Point(86, 26);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(59, 17);
            this.labelOcupacion.TabIndex = 2;
            this.labelOcupacion.Text = "Ocupacion";
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerfil.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfil.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPerfil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPerfil.Image")));
            this.buttonPerfil.Location = new System.Drawing.Point(0, 4);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(74, 56);
            this.buttonPerfil.TabIndex = 6;
            this.buttonPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPerfil.UseVisualStyleBackColor = true;
            this.buttonPerfil.Click += new System.EventHandler(this.buttonPerfil_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.Image")));
            this.buttonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(3, 547);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(150, 46);
            this.buttonCerrarSesion.TabIndex = 5;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(5, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "Historial Medico";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(5, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Citas Medicas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicos.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicos.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMedicos.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedicos.Image")));
            this.buttonMedicos.Location = new System.Drawing.Point(3, 190);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Size = new System.Drawing.Size(245, 66);
            this.buttonMedicos.TabIndex = 2;
            this.buttonMedicos.Text = "Medicos";
            this.buttonMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedicos.UseVisualStyleBackColor = true;
            this.buttonMedicos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pacientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.buttonReportes);
            this.panel2.Controls.Add(this.buttonUsuarioAgregar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 36);
            this.panel2.TabIndex = 1;
            // 
            // buttonReportes
            // 
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportes.Location = new System.Drawing.Point(302, 3);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(143, 33);
            this.buttonReportes.TabIndex = 10;
            this.buttonReportes.Text = "Reporte General";
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonUsuarioAgregar
            // 
            this.buttonUsuarioAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarioAgregar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarioAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUsuarioAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsuarioAgregar.Image")));
            this.buttonUsuarioAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsuarioAgregar.Location = new System.Drawing.Point(20, 0);
            this.buttonUsuarioAgregar.Name = "buttonUsuarioAgregar";
            this.buttonUsuarioAgregar.Size = new System.Drawing.Size(143, 33);
            this.buttonUsuarioAgregar.TabIndex = 9;
            this.buttonUsuarioAgregar.Text = "Agregar usuario";
            this.buttonUsuarioAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuarioAgregar.UseVisualStyleBackColor = true;
            this.buttonUsuarioAgregar.Click += new System.EventHandler(this.buttonUsuarioAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(950, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelNuevo
            // 
            this.panelNuevo.BackColor = System.Drawing.Color.White;
            this.panelNuevo.Controls.Add(this.pictureBox2);
            this.panelNuevo.Controls.Add(this.panel4);
            this.panelNuevo.Controls.Add(this.panel3);
            this.panelNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNuevo.Location = new System.Drawing.Point(253, 36);
            this.panelNuevo.Name = "panelNuevo";
            this.panelNuevo.Size = new System.Drawing.Size(1024, 560);
            this.panelNuevo.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 542);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 18);
            this.panel3.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(489, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 33);
            this.button5.TabIndex = 11;
            this.button5.Text = "Reporte de Especialidades";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(716, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 33);
            this.button6.TabIndex = 12;
            this.button6.Text = "Reporte Generos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1277, 596);
            this.Controls.Add(this.panelNuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNuevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelNuevo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonPerfil;
        public System.Windows.Forms.Label labelNombres;
        public System.Windows.Forms.Label labelOcupacion;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonMedicos;
        public System.Windows.Forms.Button buttonUsuarioAgregar;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
    }
}

