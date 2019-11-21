using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pavApplication.Vistas
{
    public partial class frm_SeleccionarReporte : Form
    {
        public frm_SeleccionarReporte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form reporteForm = new reporteFinalDif();
            reporteForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reporteForm = new reporteFinalMaq();
            reporteForm.ShowDialog();
        }
    }
}
