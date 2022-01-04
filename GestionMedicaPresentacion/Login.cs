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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private string Encriptar(string cadenaencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text!= "USUARIO")
            {
                if (textBoxContraseña.Text!= "CONTRASEÑA")
                {
                    var encriptado = Encriptar(textBoxContraseña.Text);
                    var loginverdadero = UsuarioNegocio.LoginNegocio(textBoxUsuario.Text, encriptado);
                    if (textBoxUsuario.Text==loginverdadero.Login && encriptado==loginverdadero.Password)
                    {
                       
                        Form1 principal = new Form1();
                        MessageBox.Show("Bienvenido " + loginverdadero.Nombre + "  " + loginverdadero.Apellido);
                        labelOcupacion.Text = loginverdadero.Ocupacion;
                        principal.Show();
                        if (labelOcupacion.Text=="medico")
                        {
                            principal.buttonMedicos.Enabled = false;
                            principal.buttonUsuarioAgregar.Enabled = false;
                            principal.label1.Text = loginverdadero.Id.ToString();
                            principal.labelOcupacion.Text = loginverdadero.Ocupacion;
                            principal.labelNombres.Text = loginverdadero.Nombre + "  " + loginverdadero.Apellido;
                            principal.FormClosed += logout;

                            this.Hide();
                        }
                        else
                        {
                            
                            principal.label1.Text = loginverdadero.Id.ToString();
                            principal.labelOcupacion.Text = loginverdadero.Ocupacion;
                            principal.labelNombres.Text = loginverdadero.Nombre + "  " + loginverdadero.Apellido;
                            principal.FormClosed += logout;

                            this.Hide();
                        }
                        

                    }
                    //else if (loginverdadero.Ocupacion == "medico")
                    //{
                    //    if (textBoxUsuario.Text == loginverdadero.Login && textBoxContraseña.Text == loginverdadero.Password)
                    //    {
                    //        Form1 principal = new Form1();
                            
                    //        MessageBox.Show("Bienvenido " + loginverdadero.Nombre + "  " + loginverdadero.Apellido);
                    //        principal.Show();
                    //        principal.buttonMedicos.Enabled = false;
                    //        principal.label1.Text = loginverdadero.Id.ToString();
                    //        principal.labelOcupacion.Text = loginverdadero.Ocupacion;
                    //        principal.labelNombres.Text = loginverdadero.Nombre + "  " + loginverdadero.Apellido;
                    //        principal.FormClosed += logout;

                    //        this.Hide();
                    //    }
                    //}
                    else
                    {
                        error("Datos Erroneos en el usuario o contraseña");
                        textBoxUsuario.Clear();
                        textBoxContraseña.Clear();
                    }
                        
                        
                   
                }
                else
                {
                    error("Contraseña incorrecta");
                }
            }
            else
            {
                error("Usuario incorrecto");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void error(string mensaje)
        {
            labelError.Text =" "+ mensaje;
            labelError.Visible = true;
        }
        private void logout(object sender,FormClosedEventArgs e)
        {
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
            labelError.Visible = false;
            this.Show();
        }
    }
}
