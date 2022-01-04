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
    public partial class FormularioPaciente : Form
    {
        PacienteEntidad pacientes = new PacienteEntidad();
        public FormularioPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text=="")
            {
                if (textBoxNombre1.Text!="")
                {
                    if (textBoxNombre2.Text!="")
                    {
                        if (textBoxCedula.Text!="")
                        {
                            if (textBoxDireccion.Text!="")
                            {
                                    if (textBoxApellido1.Text!="")
                                    {
                                        if (textBoxApellido2.Text!="")
                                        {
                                            if (textBoxTelefono.Text!="")
                                            {
                                                if (comboBoxEstadoCivil.SelectedItem!=null)
                                                {
                                                    if (comboBoxGenero.SelectedItem!=null)
                                                    {
                                                        if (comboBoxTipodeSangre.SelectedItem!=null)
                                                        {
                                                            GuardarPaciente();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("seleccione un tipo de sangre");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("seleccione un genero");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("seleccione un estado civil");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Falta el telefono");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falta el segundo apellido");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Falta el primer apellido");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Falta la Direccion");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta la cedula");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta el segundo nombre");
                    }
                }
                else
                {
                    MessageBox.Show("Falta el primer nombre");
                }
                
            }
            else
            {
                MessageBox.Show("El paciente ya existe");
            }
           
        }

        private void GuardarPaciente()
        {
            pacientes.Id = 0;
            pacientes.Cedula = textBoxCedula.Text;
            pacientes.Nombre1 = textBoxNombre1.Text;
            pacientes.Nombre2 = textBoxNombre2.Text;
            pacientes.Apellido1 = textBoxApellido1.Text;
            pacientes.Apellido2 = textBoxApellido2.Text;
            pacientes.Direccion = textBoxDireccion.Text;
            string date = dateTimePickerFechaNaci.Value.ToShortDateString();
            pacientes.FechaNac = date;
            pacientes.Telefono = textBoxTelefono.Text;
            pacientes.Genero = comboBoxGenero.SelectedItem.ToString();
            pacientes.EstadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            pacientes.TipoSangre = comboBoxTipodeSangre.SelectedItem.ToString();

            pacientes = PacienteNegocio.GuardarPacienteNegocio(pacientes);
            if (pacientes != null)
            {
                textBoxId.Text = pacientes.Id.ToString();
                MessageBox.Show("El paciente se inserto correctamente");
                //Cargar pacientes de la base de datos
                

            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el paciente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioListaPacientes lpacientes = new FormularioListaPacientes();
            lpacientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarPacientes();
        }

        private void BuscarPacientes()
        {
            if (textBoxApellido1.Text=="" && textBoxCedula.Text=="")
            {
                var nombre = textBoxNombre1.Text;
                BuscarPacienteporNombre(nombre);
            }
            if (textBoxNombre1.Text=="" && textBoxCedula.Text == "")
            {
                var apellido = textBoxApellido1.Text;
                BuscarPacienteporApellido(apellido);
            }
            if (textBoxApellido1.Text=="" && textBoxNombre1.Text=="")
            {
                var cedula = textBoxCedula.Text;
                BuscarPacienteporCedula(cedula);
            }
            
           
            
        }

        private void BuscarPacienteporCedula(string cedula)
        {
            var pacientebuscadoporcedula = PacienteNegocio.DevolverPacienteporCedula(cedula);
            textBoxId.Text = pacientebuscadoporcedula.Id.ToString();
            textBoxCedula.Text = pacientebuscadoporcedula.Cedula;
            textBoxNombre1.Text = pacientebuscadoporcedula.Nombre1;
            textBoxNombre2.Text = pacientebuscadoporcedula.Nombre2;
            textBoxApellido1.Text = pacientebuscadoporcedula.Apellido1;
            textBoxApellido2.Text = pacientebuscadoporcedula.Apellido2;
            textBoxDireccion.Text = pacientebuscadoporcedula.Direccion;
            textBoxTelefono.Text = pacientebuscadoporcedula.Telefono;
            comboBoxGenero.SelectedItem = pacientebuscadoporcedula.Genero;
            comboBoxEstadoCivil.SelectedItem = pacientebuscadoporcedula.EstadoCivil;
            comboBoxTipodeSangre.SelectedItem = pacientebuscadoporcedula.TipoSangre;
        }

        private void BuscarPacienteporApellido(string apellido)
        {
            var pacientebuscadoapellido = PacienteNegocio.DevolverPacienteporApellido(apellido);
            textBoxId.Text = pacientebuscadoapellido.Id.ToString();
            textBoxCedula.Text = pacientebuscadoapellido.Cedula;
            textBoxNombre1.Text = pacientebuscadoapellido.Nombre1;
            textBoxNombre2.Text = pacientebuscadoapellido.Nombre2;
            textBoxApellido1.Text = pacientebuscadoapellido.Apellido1;
            textBoxApellido2.Text = pacientebuscadoapellido.Apellido2;
            textBoxDireccion.Text = pacientebuscadoapellido.Direccion;
            textBoxTelefono.Text = pacientebuscadoapellido.Telefono;
            comboBoxGenero.SelectedItem = pacientebuscadoapellido.Genero;
            comboBoxEstadoCivil.SelectedItem = pacientebuscadoapellido.EstadoCivil;
            comboBoxTipodeSangre.SelectedItem = pacientebuscadoapellido.TipoSangre;
        }

        private void BuscarPacienteporNombre(string nombre)
        {
            var pacientebuscadonombre = PacienteNegocio.DevolverPacientePorNombre(nombre);
            textBoxId.Text = pacientebuscadonombre.Id.ToString();
            textBoxCedula.Text = pacientebuscadonombre.Cedula;
            textBoxNombre1.Text = pacientebuscadonombre.Nombre1;
            textBoxNombre2.Text = pacientebuscadonombre.Nombre2;
            textBoxApellido1.Text = pacientebuscadonombre.Apellido1;
            textBoxApellido2.Text = pacientebuscadonombre.Apellido2;
            textBoxDireccion.Text = pacientebuscadonombre.Direccion;
            textBoxTelefono.Text = pacientebuscadonombre.Telefono;
            comboBoxGenero.SelectedItem = pacientebuscadonombre.Genero;
            comboBoxEstadoCivil.SelectedItem = pacientebuscadonombre.EstadoCivil;
            comboBoxTipodeSangre.SelectedItem = pacientebuscadonombre.TipoSangre;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text=="")
            {
                MessageBox.Show("Error NO EXISTE EL PACIENTE");
            }
            else
            {
                ModificarPaciente();
            }
           
        }

        private void ModificarPaciente()
        {
            pacientes.Cedula = textBoxCedula.Text;
            pacientes.Nombre1 = textBoxNombre1.Text;
            pacientes.Nombre2 = textBoxNombre2.Text;
            pacientes.Apellido1 = textBoxApellido1.Text;
            pacientes.Apellido2 = textBoxApellido2.Text;
            pacientes.Direccion = textBoxDireccion.Text;
            pacientes.FechaNac = dateTimePickerFechaNaci.Value.ToShortDateString();
            pacientes.Telefono = textBoxTelefono.Text;
            pacientes.Genero = comboBoxGenero.SelectedItem.ToString();
            pacientes.EstadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            pacientes.TipoSangre = comboBoxTipodeSangre.SelectedItem.ToString();
            pacientes = PacienteNegocio.ModificarPacienteNegocio(pacientes);
            if (pacientes != null)
            {
                //textBoxId.Text = pacientes.Id.ToString();
                MessageBox.Show("Datos Modificados Correctamente");
                //Cargar pacientes de la base de datos


            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el paciente");
            }
        }
    }
}
