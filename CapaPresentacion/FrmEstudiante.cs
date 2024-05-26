using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();

        }

        EstudianteNegocio objNegocio = new EstudianteNegocio();
        Estudiante objEstudiante = new Estudiante();

        void Limpiar(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Si el control actual es un TextBox, establece su texto en una cadena vacía.
                if (c is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (c is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                // Si el control actual es un panel u otro contenedor, llama recursivamente a Limpiar().
                else if (c.HasChildren)
                {
                    Limpiar(c);
                }
            }
        }

        bool Validar (string p1, string p2, string p3, string p4, string p5, string p6)
        {
            if (p1.Length == 0 || p2.Length == 0 || p3.Length == 0 || p4.Length == 0 || p5.Length == 0 || p6.Length == 0)
                return false;
            else
                return true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar(txtNum_Doc.Text, txtNombre.Text, txtApellidoPaterno.Text, textApellidoMaterno.Text, txtEmail.Text, txtTelefono.Text) == true)
            {
                objEstudiante = objNegocio.Buscar(Convert.ToInt32(txtId.Text));
                objEstudiante.Num_doc = txtNum_Doc.Text;
                objEstudiante.Nombre = txtNombre.Text;
                objEstudiante.Apellido_Paterno = txtApellidoPaterno.Text;
                objEstudiante.Apellido_Materno = textApellidoMaterno.Text;
                objEstudiante.Email = txtEmail.Text;
                objEstudiante.Telefono = txtTelefono.Text;
                objEstudiante.Estado = (this.checkEstado.Checked == true) ? true : false;
                try
                {
                    objNegocio.Actualizar(objEstudiante);
                    MessageBox.Show("Se ha actualizado el Estudiante");
                    Control1.SelectedTab = tabPage2;
                    BtnListar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Primero Selecione el registro que desee Actulaizar");
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                dataEstudiante.DataSource = objNegocio.ListarEstudiante();
            }
            else
            {
                dataEstudiante.DataSource = objNegocio.ListarEstudianteXNombre(txtBuscar.Text);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (Validar(txtNum_Doc.Text, txtNombre.Text, txtApellidoPaterno.Text, textApellidoMaterno.Text, txtEmail.Text, txtTelefono.Text) == true)
            {
            objEstudiante.Num_doc = txtNum_Doc.Text;
            objEstudiante.Nombre = txtNombre.Text;
            objEstudiante.Apellido_Paterno = txtApellidoPaterno.Text;
            objEstudiante.Apellido_Materno = textApellidoMaterno.Text;
            objEstudiante.Email = txtEmail.Text;
            objEstudiante.Telefono = txtTelefono.Text;
            objEstudiante.Estado = (this.checkEstado.Checked == true) ? true : false;
                try
                {
                    objNegocio.Agregar(objEstudiante);
                    MessageBox.Show("Se ha registrado un nuevo estudiante");

                  
                    Control1.SelectedTab = tabPage2;
                    BtnListar_Click(sender, e); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los Datos");
            }
        }

        private void DataEstudiante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Control1.SelectedTab = Mantenimiento;
            txtId.Text = dataEstudiante.CurrentRow.Cells[0].Value.ToString();
            txtNum_Doc.Text = dataEstudiante.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataEstudiante.CurrentRow.Cells[2].Value.ToString();
            txtApellidoPaterno.Text = dataEstudiante.CurrentRow.Cells[3].Value.ToString();
            textApellidoMaterno.Text = dataEstudiante.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataEstudiante.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dataEstudiante.CurrentRow.Cells[6].Value.ToString();
            if (dataEstudiante.CurrentRow.Cells[7].Value is true)
            {
                this.checkEstado.Checked = true;
            }
            else
            {
                this.checkEstado.Checked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInforme frmInforme = new FrmInforme();
            frmInforme.Show();
        }
    }
}
