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
    public partial class Principal : Form
    {
        bool SliderExpande;
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void SlideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SliderExpande)
            {
                SlideBar.Width -= 10;

                if (SlideBar.Width == SlideBar.MinimumSize.Width) 
                {
                    SliderExpande = false;
                    SlideBarTimer.Stop();
                }
            }
            else
            {
                SlideBar.Width += 10;
                if  (SlideBar.Width == SlideBar.MaximumSize.Width)
                {
                    SliderExpande = true;
                    SlideBarTimer.Stop();
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            SlideBarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Estudiante_Click(object sender, EventArgs e)
        {
            CargarFrm(new FrmEstudiante());
        }

        public void CargarFrm(object form)
        {
            if (this.Escritorio.Controls.Count > 0)
                this.Escritorio.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Escritorio.Controls.Add(f);
            this.Escritorio.Tag = f;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarFrm(new FrmAsistencia());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarFrm(new FrmDocente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Escritorio.Controls)
            {
                if (control is Form)
                {
                    ((Form)control).Close();
                }
            }

            // Restaurar el PictureBox "upla" en el panel Escritorio
            Escritorio.Controls.Clear();
            Escritorio.Controls.Add(upla);
            upla.Visible = true;
        }
    }
}
