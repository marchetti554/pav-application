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
        Int32 id_orden_por_controlar;

        public frm_Dashboard()
        {
            InitializeComponent();
            actualizarGrillaOT();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            btn_nueva_ot.Focus();
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
                    int orden_trabajo_cargando = Int32.Parse(tabla.Rows[i]["id_orden_trabajo"].ToString());
                    DataTable estado = bdHelper.consultarSQL("Select * from Estado where id_estado = "
                        + tabla.Rows[i]["id_estado"]);
                    DataTable boletasEnCurso = bdHelper.consultarSQL("Select * From detalle_orden WHERE (id_orden_trabajo = " + orden_trabajo_cargando +
                        " AND estado = 'En Curso');");
                    int cantidadBoletasEnCurso = boletasEnCurso.Rows.Count;

                    dataGridView1.Rows.Add(tabla.Rows[i]["id_orden_trabajo"],
                                    cantidadBoletasEnCurso == 0 ? traducirEstado(tabla.Rows[i]["id_estado"]) : "En Curso",
                                    tabla.Rows[i]["fecha_estimada_entrega"],
                                    tabla.Rows[i]["dni_responsable_cliente"],
                                    tabla.Rows[i]["precio_total"]);

                    if (Int32.Parse(tabla.Rows[i]["id_estado"].ToString()) == 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    if (Int32.Parse(tabla.Rows[i]["id_estado"].ToString()) == 2)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Int32.Parse(tabla.Rows[i]["id_estado"].ToString()) == 4)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    if (Int32.Parse(tabla.Rows[i]["id_estado"].ToString()) == 5)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private object traducirEstado(object estado)
        {
            if((int) estado == 5)
            {
                return "Confirmada";
            }
            if ((int)estado == 1)
            {
                return "Generada";
            }
            if ((int)estado == 2)
            {
                return "Completada";
            }
            return "En Curso";
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
            if(dataGridView1.SelectedRows[0].Cells["id_estado"].Value.ToString() == "Generada")
            {
                if (MessageBox.Show("Esta Orden de Trabajo está Generada, para controlarla deberá Confirmarla.", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    String query = "update orden_trabajo SET id_estado = 5 WHERE id_orden_trabajo = "
                        + Int32.Parse(dataGridView1.SelectedRows[0].Cells["id_orden_trabajo"].Value.ToString()) + ";";
                    bdHelper.actualizarBD(query);
                    actualizarGrillaOT();
                    Form controlarOT = new frm_Controlar_OT(id_orden_por_controlar);
                    controlarOT.ShowDialog();
                }
            } 
            if (dataGridView1.SelectedRows[0].Cells["id_estado"].Value.ToString() == "Completada")
            {
                MessageBox.Show("Esta OT ya está Completada, no se puede controlar.", "¡Atención!", MessageBoxButtons.OK);
            }
            if (dataGridView1.SelectedRows[0].Cells["id_estado"].Value.ToString() == "En Curso" ||
                dataGridView1.SelectedRows[0].Cells["id_estado"].Value.ToString() == "Confirmada" ||
                dataGridView1.SelectedRows[0].Cells["id_estado"].Value.ToString() == "Cotizada")
            {
                Form controlarOT = new frm_Controlar_OT(id_orden_por_controlar);
                controlarOT.ShowDialog();
            }
            actualizarGrillaOT();
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
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_orden_por_controlar = Int32.Parse(dataGridView1.SelectedRows[0].Cells["id_orden_trabajo"].Value.ToString());     
            btn_controlar.Enabled = true;
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
