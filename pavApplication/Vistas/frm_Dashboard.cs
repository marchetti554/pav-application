using pavApplication.Datos;
using pavApplication.Utils;
using pavApplication.Vistas;
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

        private BDHelper bdHelper = BDHelper.getBDHelper();

        public frm_Dashboard()
        {
            InitializeComponent();
            actualizarGrillaOT();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            lbl_nmb_usuario.Text = Constants.UsuarioLogueado;
        }

        private void actualizarGrillaOT()
        {
            dataGridView1.Rows.Clear();
            DataTable tabla = bdHelper.consultarTabla("orden_trabajo");
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataTable estado = bdHelper.consultarSQL("Select * from Estado where id_estado = "
                        + tabla.Rows[i]["id_estado"]);

                    dataGridView1.Rows.Add(tabla.Rows[i]["id_orden_trabajo"],
                                    traducirEstado(tabla.Rows[i]["id_estado"]),
                                    tabla.Rows[i]["fecha_estimada_entrega"],
                                    tabla.Rows[i]["dni_responsable_cliente"],
                                    tabla.Rows[i]["precio_total"]);
                }
            }
        }

        private object traducirEstado(object estado)
        {
            if((int) estado == 5)
            {
                return "Cotizada";
            }
            if ((int)estado == 1)
            {
                return "Confirmada";
            }
            return "Generada";
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_controlar_Click(object sender, EventArgs e)
        {
            Form controlarOT = new frm_Controlar_OT();
            controlarOT.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nuevaOT = new frm_Nueva_OT();
            nuevaOT.ShowDialog();
        }

        private void lbl_ot_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form empleadosForm = new frm_Empleados();
            empleadosForm.ShowDialog();
        }

        private void btn_clientes_responsables_Click(object sender, EventArgs e)
        {
            Form clientesForm = new frm_Clientes();
            clientesForm.ShowDialog();
        }

        private void lbl_nmb_usuario_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Dashboard_Enter(object sender, EventArgs e)
        {
            actualizarGrillaOT();
        }

        private void a(object sender, EventArgs e)
        {
            
            actualizarGrillaOT();
        }

        private void frm_Dashboard_Activated(object sender, EventArgs e)
        {
            actualizarGrillaOT();
        }
    }
}
