using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMedicaPresentacion
{
    public partial class Form1 : Form
    {
        Form formularioh;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AbrirVentana(Form formulario)
        {
            if (formularioh !=null)
            {
                formularioh.Close();
            }
            formularioh = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelNuevo.Controls.Add(formulario);
            panelNuevo.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FormularioPaciente());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FormularioMedico());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FormularioCita());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FormularioHistorial());
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Esta seguro que desea salir","Salir",MessageBoxButtons.YesNoCancel)==)
            //{

            //}
            this.Close();
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            FormularioPerfil perfil = new FormularioPerfil();
            perfil.labelIdPerfilAdmin.Text = label1.Text;
            perfil.labelPosicionPerfil.Text = labelOcupacion.Text;
            perfil.labelNombres.Text = labelNombres.Text;
            perfil.Show();
        }

        private void buttonUsuarioAgregar_Click(object sender, EventArgs e)
        {
            FormularioAgregarUsuarioOcupacion usuario = new FormularioAgregarUsuarioOcupacion();
            usuario.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirVentana( new BuscarAtencioncs());
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            ReportesA reportes = new ReportesA();
            reportes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteEspecialidad especialidad = new ReporteEspecialidad();
            especialidad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormularioReporteGeneros generos = new FormularioReporteGeneros();
            generos.Show();
        }
    }
}
