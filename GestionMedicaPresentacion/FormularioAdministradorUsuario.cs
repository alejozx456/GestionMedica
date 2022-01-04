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
    public partial class FormularioAdministradorUsuario : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        public FormularioAdministradorUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarOcupacionAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxIDUsuario.Text=="")
            {
                if (textBoxNOmbre.Text!="")
                {
                    if (textBoxApellido.Text!="")
                    {
                        if (textBoxUser.Text!="")
                        {
                            if (textBoxPassword.Text!="")
                            {
                                GenerarUsuarioAdmin();
                            }
                            else
                            {
                                MessageBox.Show("Ingrese una contraseña para el usuario");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un nombre de Usuario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta el Apellido");
                    }
                }
                else
                {
                    MessageBox.Show("Falta el Nombre del Usuario");
                }
            }
            else
            {
                MessageBox.Show("NO existe el Id");
            }
           
        }
        private string Encriptar(string cadenaencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private void GenerarUsuarioAdmin()
        {
            usuario.Id = 0;
            usuario.Ocupacion = labelOcupacion.Text;
            usuario.Nombre = textBoxNOmbre.Text;
            usuario.Apellido = textBoxApellido.Text;
            usuario.Login = textBoxUser.Text;
            usuario.Password = Encriptar(textBoxPassword.Text);
            
            usuario = UsuarioNegocio.GuardarUsuario(usuario);
            if (usuario != null)
            {
                textBoxIDUsuario.Text = usuario.Id.ToString();
                MessageBox.Show("Se genero el usuario correctamente");
                //Cargar pacientes de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la cita");
            }
        }
    }
}
