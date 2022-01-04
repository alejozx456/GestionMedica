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
    public partial class FormularioMedicoOcupacionUsuario : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        public FormularioMedicoOcupacionUsuario()
        {
            InitializeComponent();
        }

        private void FormularioMedicoOcupacionUsuario_Load(object sender, EventArgs e)
        {
            CargarListaMedicos();
        }

        private void CargarListaMedicos()
        {
            dataGridViewMedicos.DataSource = MedicoNegocio.DevolverMedicosCita();
        }

        private void dataGridViewMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewMedicos.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarMedicoPorId(id);
        }

        private void CargarMedicoPorId(int id)
        {
            var medicoseleccionado = MedicoNegocio.DevolverMedicoPorId(id);
            textBoxNOmbre.Text = medicoseleccionado.Nombre;
            textBoxApellido.Text = medicoseleccionado.Apellido;
        }
        private string Encriptar(string cadenaencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        private void buttonGenerarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxIdUsuario.Text=="")
            {
                if (textBoxUsuario.Text!="")
                {
                    if (textBoxPassword.Text!="")
                    {
                        usuario.Id = 0;
                        usuario.Nombre = textBoxNOmbre.Text;
                        usuario.Apellido = textBoxApellido.Text;
                        usuario.Ocupacion = labelOcupacion.Text;
                        usuario.Login = textBoxUsuario.Text;
                        usuario.Password = Encriptar(textBoxPassword.Text);
                        usuario = UsuarioNegocio.GuardarUsuario(usuario);
                        if (usuario != null)
                        {
                            textBoxIdUsuario.Text = usuario.Id.ToString();
                            MessageBox.Show("Se genero el usuario correctamente");
                            //Cargar pacientes de la base de datos


                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al guardar la cita");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el usuario");
                }
            }
            else
            {
                MessageBox.Show("Elija un medico de la lista");
            }
           
           
        }
    }
}
