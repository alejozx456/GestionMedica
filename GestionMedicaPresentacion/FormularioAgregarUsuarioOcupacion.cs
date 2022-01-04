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
    public partial class FormularioAgregarUsuarioOcupacion : Form
    {
        public FormularioAgregarUsuarioOcupacion()
        {
            InitializeComponent();
        }

        private void buttonOcupacionMedico_Click(object sender, EventArgs e)
        {
            FormularioMedicoOcupacionUsuario medico = new FormularioMedicoOcupacionUsuario();
            medico.labelOcupacion.Text = buttonOcupacionMedico.Text;
            medico.Show();
        }

        private void buttonUcupacionAdministrador_Click(object sender, EventArgs e)
        {
            FormularioAdministradorUsuario admin = new FormularioAdministradorUsuario();
            admin.labelOcupacion.Text = buttonUcupacionAdministrador.Text;
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioListadeUsuarios listadeUsuarios = new FormularioListadeUsuarios();
            listadeUsuarios.Show();
        }
    }
}
