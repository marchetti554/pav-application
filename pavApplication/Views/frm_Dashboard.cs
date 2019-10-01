using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pavApplication.Views
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeTrabajoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form empleadosForm = new frm_Empleados();
            empleadosForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form clientesForm = new frm_Clientes();
            clientesForm.ShowDialog();
        }
    }
}
