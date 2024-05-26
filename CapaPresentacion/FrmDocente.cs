using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
        }
        DocenteNegocio objNegocioD = new DocenteNegocio();
        Docente objDocente = new Docente();

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

        bool Validar(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            if (p1.Length == 0 || p2.Length == 0 || p3.Length == 0 || p4.Length == 0 || p5.Length == 0 || p6.Length == 0)
                return false;
            else
                return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Validar(txtNum_Doc.Text, txtNombre.Text, txtApellidoPaterno.Text, textApellidoMaterno.Text, txtEmail.Text, txtTelefono.Text) == true)
            {
                objDocente = objNegocioD.Buscar(Convert.ToInt32(txtId.Text));
                objDocente.Num_doc = txtNum_Doc.Text;
                objDocente.Nombre = txtNombre.Text;
                objDocente.Apellido_Paterno = txtApellidoPaterno.Text;
                objDocente.Apellido_Materno = textApellidoMaterno.Text;
                objDocente.Email = txtEmail.Text;
                objDocente.Telefono = txtTelefono.Text;
                objDocente.Estado = (this.checkEstado.Checked == true) ? true : false;
                try
                {
                    objNegocioD.Actualizar(objDocente);
                    MessageBox.Show("Se ha actualizado el Docente");
                    Control1.SelectedTab = tabPage2;
                    btnListar_Click(sender, e);
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                dataDocente.DataSource = objNegocioD.ListarDocente();
            }
            else
            {
                dataDocente.DataSource = objNegocioD.ListarDocenteXNombre(txtBuscar.Text);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Validar(txtNum_Doc.Text, txtNombre.Text, txtApellidoPaterno.Text, textApellidoMaterno.Text, txtEmail.Text, txtTelefono.Text) == true)
            {
                objDocente.Num_doc = txtNum_Doc.Text;
                objDocente.Nombre = txtNombre.Text;
                objDocente.Apellido_Paterno = txtApellidoPaterno.Text;
                objDocente.Apellido_Materno = textApellidoMaterno.Text;
                objDocente.Email = txtEmail.Text;
                objDocente.Telefono = txtTelefono.Text;
                objDocente.Estado = (this.checkEstado.Checked == true) ? true : false;
                try
                {
                    objNegocioD.Agregar(objDocente);
                    MessageBox.Show("Se ha registrado un nuevo Docente");


                    Control1.SelectedTab = tabPage2;
                    btnListar_Click(sender, e);
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

        private void dataEstudiante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Control1.SelectedTab = Mantenimiento;
            txtId.Text = dataDocente.CurrentRow.Cells[0].Value.ToString();
            txtNum_Doc.Text = dataDocente.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataDocente.CurrentRow.Cells[2].Value.ToString();
            txtApellidoPaterno.Text = dataDocente.CurrentRow.Cells[3].Value.ToString();
            textApellidoMaterno.Text = dataDocente.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataDocente.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dataDocente.CurrentRow.Cells[6].Value.ToString();
            if (dataDocente.CurrentRow.Cells[7].Value is true)
            {
                this.checkEstado.Checked = true;
            }
            else
            {
                this.checkEstado.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }
    }
}
