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
            // TODO: esta línea de código carga datos en la tabla '_pav_dbDataSet.orden_trabajo' Puede moverla o quitarla según sea necesario.
            this.orden_trabajoTableAdapter.Fill(this._pav_dbDataSet.orden_trabajo);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeTrabajoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
