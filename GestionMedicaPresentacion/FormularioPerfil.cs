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
    public partial class FormularioPerfil : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        public FormularioPerfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPerfil_Load(object sender, EventArgs e)
        {
            CargarPerfilUsuario();
        }

        private void CargarPerfilUsuario()
        {
            var id = Convert.ToInt32(labelIdPerfilAdmin.Text);
            CargarPerfilUsuarioId(id);
        }
       
        private void CargarPerfilUsuarioId(int id)
        {
            var perfilseleccionado = UsuarioNegocio.DevolverPerfilporid(id);
            textBoxIdPerfil.Text = perfilseleccionado.Id.ToString();
            textBoxNombrePerfil.Text = perfilseleccionado.Nombre;
            textBoxApellidoPerfil.Text = perfilseleccionado.Apellido;
            textBoxContraseñaPerfil.Text = DEsencriptar(perfilseleccionado.Password);
            textBoxContraseñaPerfilConfirmar.Text = DEsencriptar(perfilseleccionado.Password);
        }

        private void buttonModificarPaciente_Click(object sender, EventArgs e)
        {
            if (textBoxIdPerfil.Text!="")
            {
                if (textBoxNombrePerfil.Text!="")
                {
                    if (textBoxApellidoPerfil.Text!="")
                    {
                        if (textBoxContraseñaPerfil.Text!="" && textBoxContraseñaPerfilConfirmar.Text!="")
                        {
                            if (textBoxContraseñaPerfil.Text==textBoxContraseñaPerfilConfirmar.Text)
                            {
                                ModificarPerfil();
                            }
                            else
                            {
                                MessageBox.Show("Las Contraseñas no coinciden ");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No deje espacios vacios");
            }
           
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
                labelNombres.Text = usuario.Nombre + "  " + usuario.Apellido;
                


            }
            else
            {
                MessageBox.Show("Hubo un error ");
            }
        }
    }
}
