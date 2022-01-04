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
    public partial class FormularioMedico : Form
    {
        MedicoEntidad medicos = new MedicoEntidad();
        
        public FormularioMedico()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            CargarEspecialidad();
        }

        private void CargarEspecialidad()
        {
            comboBoxEspecialidad.DataSource = EspecialidadNegocio.DevolverListaEspecialidad();
            comboBoxEspecialidad.DisplayMember = "Nombre";
            comboBoxEspecialidad.ValueMember= "Id";
        }

        private void FormularioMedico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text=="")
            {
                if (textBoxNombreM.Text!="")
                {
                    if (textBoxApellido.Text!="")
                    {
                        if (textBoxCedulaM.Text!="")
                        {
                            if (textBoxSueldo.Text!="")
                            {
                                if (comboBoxEspecialidad.SelectedItem!=null)
                                {
                                    GuardarMedico();
                                }
                                else
                                {
                                    MessageBox.Show("Falta la especialidad");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Falta el sueldo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta la cedula");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta el Apellido");
                    }
                }
                else
                {
                    MessageBox.Show("Falta el Nombre");
                }
            }
           
        }

        private void GuardarMedico()
        {
            medicos.Id = 0;
            medicos.Cedula = textBoxCedulaM.Text;
            medicos.Nombre = textBoxNombreM.Text;
            medicos.Apellido = textBoxApellido.Text;
            medicos.FechaNaci = dateTimePickerFechaNaci.Value.ToShortDateString();
            medicos.Sueldo = Convert.ToInt32(textBoxSueldo.Text);
            medicos.Id_Especialidad = (int)comboBoxEspecialidad.SelectedValue;

            medicos = MedicoNegocio.GuardarMedico(medicos);
            if (medicos != null)
            {
                 textBoxId.Text= medicos.Id.ToString();
                MessageBox.Show("El Medico se inserto correctamente");
                //Cargar Medicos de la base de datos
               

            }
            else
            {
                MessageBox.Show("Hubo un error al guardar el paciente");
            }
        }
    }
}
