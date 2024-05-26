using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmFechaSalida : Form
    {
        public FrmFechaSalida(string dni)
        {
            InitializeComponent();
            CargarRegistros(dni);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CargarRegistros(string dni)
        {
            using (var context = new ProyectoContextoDB())
            {
                var registros = context.EstudianteRegistro
                               .Where(r => r.DNI == dni)
                               .OrderByDescending(r => r.Fecha_Entrada) // Ordenar por fecha de entrada en orden descendente
                               .ThenByDescending(r => r.Hora_Entrada) // Luego, ordenar por hora de entrada en orden descendente
                               .Select(r => new
                               {
                                   r.DNI,
                                   r.Fecha_Entrada,
                                   r.Hora_Entrada
                               })
                               .ToList();
                dataGridView1.DataSource = registros;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}