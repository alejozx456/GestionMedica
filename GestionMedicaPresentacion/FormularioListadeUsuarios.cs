using NegocioMedica;
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
    public partial class FormularioListadeUsuarios : Form
    {
        public FormularioListadeUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioListadeUsuarios_Load(object sender, EventArgs e)
        {
            CargarListadeUsuarios();
        }

        private void CargarListadeUsuarios()
        {
            dataGridViewListadeUsuarios.DataSource = UsuarioNegocio.DevolverListadeUsuarios();
        }

        private void dataGridViewListadeUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewListadeUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarUsuarioPorId(id);
        }

        private void CargarUsuarioPorId(int id)
        {
            var usuarioseleccionado = UsuarioNegocio.DevolverUsuarioPorId(id);
            textBoxUsuario.Text = usuarioseleccionado.Id.ToString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var id = textBoxUsuario.Text;
            EliminarUsuarioPorId(id);
        }

        private void EliminarUsuarioPorId(string id)
        {
            var usuarioEliminado = UsuarioNegocio.EliminarUsuarioPorId(id);
            CargarListadeUsuarios();
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            FormularioModificarUsuario modi = new FormularioModificarUsuario();
            modi.textBoxIdPerfil.Text = textBoxUsuario.Text;
            modi.Show();
        }
    }
}
