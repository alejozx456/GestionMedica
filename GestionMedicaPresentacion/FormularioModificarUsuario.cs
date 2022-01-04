using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadMedica;
using NegocioMedica;

namespace GestionMedicaPresentacion
{
    public partial class FormularioModificarUsuario : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        public FormularioModificarUsuario()
        {
            InitializeComponent();
        }

        private void FormularioModificarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }
        private void CargarUsuario()
        {
            var id = Convert.ToInt32(textBoxIdPerfil.Text);
            CargarUsuarioId(id);
        }

        private void CargarUsuarioId(int id)
        {
            var perfilseleccionado = UsuarioNegocio.DevolverPerfilporid(id);
            textBoxIdPerfil.Text = perfilseleccionado.Id.ToString();
            textBoxNombrePerfil.Text = perfilseleccionado.Nombre;
            textBoxApellidoPerfil.Text = perfilseleccionado.Apellido;
            textBoxContraseñaPerfil.Text = DEsencriptar(perfilseleccionado.Password);
            textBoxContraseñaPerfilConfirmar.Text = DEsencriptar(perfilseleccionado.Password);
        }
        private string Encriptar(string cadenaencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        private string DEsencriptar(string cadenaencriptar)
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaencriptar);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarPerfil();
        }
        private void ModificarPerfil()
        {
            var id = Convert.ToInt32(textBoxIdPerfil.Text);
            ModificarPerfilporId(id);
        }

        private void ModificarPerfilporId(int id)
        {
            usuario.Nombre = textBoxNombrePerfil.Text;
            usuario.Apellido = textBoxApellidoPerfil.Text;
            usuario.Password = Encriptar(textBoxContraseñaPerfilConfirmar.Text);
            usuario = UsuarioNegocio.ModificarUsuarioporId(usuario, id);
            if (usuario != null)
            {
                //textBoxId.Text = pacientes.Id.ToString();
                MessageBox.Show("Datos Modificados Correctamente");
                //Cargar pacientes de la base de datos
                



            }
            else
            {
                MessageBox.Show("Hubo un error ");
            }
        }
    }
}

