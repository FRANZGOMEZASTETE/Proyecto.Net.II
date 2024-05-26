using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAsistencia : Form
    {
        private readonly EstudianteRegistroNegocio _registroNegocio;
        public FrmAsistencia()
        {
            InitializeComponent();
            _registroNegocio = new EstudianteRegistroNegocio();
            pnlResultados.Visible = false;
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {

        }



        private void MostrarRegistros(string dni, bool esEntrada)
        {
            Form form;
            if (esEntrada)
            {
                form = new FrmFechaRegistro(dni);
            }
            else
            {
                form = new FrmFechaSalida(dni);
            }
            form.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string numDoc = txtNumDoc.Text;
            if (string.IsNullOrWhiteSpace(numDoc))
            {
                MessageBox.Show("Por favor, ingrese el número de documento.");
                return;
            }

   
            pnlResultados.Visible = false; // Ocultar el Panel de resultados al iniciar la búsqueda
            this.Refresh(); // Actualizar el formulario para mostrar el Label inmediatamente

            if (CheckDocente.Checked)
            {
                BuscarDocente(numDoc);
            }
            else if (CheckEstudiante.Checked)
            {
                BuscarEstudiante(numDoc);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione si es Docente o Estudiante.");
     
            }
        }

        private void BuscarDocente(string numDoc)
        {
            using (var context = new ProyectoContextoDB())
            {
                var docente = context.Docente.SingleOrDefault(d => d.Num_doc == numDoc);
                if (docente != null)
                {
                    lblNombre.Text = docente.Nombre;
                    lblApellidoPaterno.Text = docente.Apellido_Paterno;
                    lblApellidoMaterno.Text = docente.Apellido_Materno;
                    lblEmail.Text = docente.Email;
                    lblTelefono.Text = docente.Telefono;
                    lblEstado.Text = docente.Estado ? "Activo" : "Inactivo";
                    lblCargo.Text = "Docente"; 

                    // Mostrar el Panel de resultados
                    pnlResultados.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontró un docente con ese número de documento.");
                }
            }
        }


        private void BuscarEstudiante(string numDoc)
        {
            using (var context = new ProyectoContextoDB())
            {
                var estudiante = context.Estudiante.SingleOrDefault(e => e.Num_doc == numDoc);
                if (estudiante != null)
                {
                    lblNombre.Text = estudiante.Nombre;
                    lblApellidoPaterno.Text = estudiante.Apellido_Paterno;
                    lblApellidoMaterno.Text = estudiante.Apellido_Materno;
                    lblEmail.Text = estudiante.Email;
                    lblTelefono.Text = estudiante.Telefono;
                    lblEstado.Text = estudiante.Estado ? "Activo" : "Inactivo";
                    lblCargo.Text = "Estudiante"; 

                    // Mostrar el Panel de resultados
                    pnlResultados.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontró un estudiante con ese número de documento.");
                }
            }
          
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            string dni = txtNumDoc.Text;
            _registroNegocio.RegistrarEntradaEstudiante(dni);
            MessageBox.Show("Entrada registrada exitosamente.");
            MostrarRegistros(dni, true);
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            string dni = txtNumDoc.Text;
            _registroNegocio.RegistrarSalidaEstudiante(dni);
            MessageBox.Show("Salida registrada exitosamente.");
            MostrarRegistros(dni, false);
        }

        private void CheckDocente_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDocente.Checked)
            {
                CheckEstudiante.Checked = false; // Desactivar el CheckBox de Estudiante si el de Docente se activa
            }
        }

        private void CheckEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEstudiante.Checked)
            {
                CheckDocente.Checked = false; // Desactivar el CheckBox de Docente si el de Estudiante se activa
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
