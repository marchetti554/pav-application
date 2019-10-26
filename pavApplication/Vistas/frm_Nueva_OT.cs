using pavApplication.Utils;
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
    public partial class frm_Nueva_OT : Form
    {

        Int32 id_orden_trabajo_creando = 11;
        private BDHelper bdHelper = BDHelper.getBDHelper();

        public frm_Nueva_OT()
        {
            InitializeComponent();
            cargarComboTipoMaquina();
            cargarComboMaquina();
            cargarComboCliente();
            cargarComboResponsable();
            empezarTransactionNuevaOT();
        }

        private void empezarTransactionNuevaOT()
        {

        }

        private void buscarEmpresasComboCliente()
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_ot_Click(object sender, EventArgs e)
        {
            limpiarCamposBoleta();
            bdHelper.endTransaction();
        }

        private void deshabilitarPanelOT()
        {
            panel3.Enabled = false;
        }

        private void limpiarCamposBoleta()
        {
            txt_observaciones.Text = "";
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        private void frm_Nueva_OT_Load(object sender, EventArgs e)
        {

        }

        private void cargarComboMaquina()
        {
            cmb_maquina.DataSource = bdHelper.consultarSQL("select * from maquinas where id_tipo_maquina = " + cmb_tipo_maquina.SelectedValue);
            cmb_maquina.ValueMember = "id_maquina";
            cmb_maquina.DisplayMember = "nombre_maquina";
        }

        private void cargarComboCliente()
        {
            cmb_cliente.DataSource = bdHelper.consultarSQL("select * from clientes");
            cmb_cliente.ValueMember = "id_cliente";
            cmb_cliente.DisplayMember = "razon_social";
        }

        private void cargarComboResponsable()
        {
            cmb_responsable.DataSource = bdHelper.consultarSQL("select * from responsable_empresa where id_cliente = " + cmb_cliente.SelectedValue);
            cmb_responsable.ValueMember = "dni";
            cmb_responsable.DisplayMember = "dni";
        }

        private void cargarComboTipoMaquina()
        {
            cmb_tipo_maquina.DataSource = bdHelper.consultarSQL("select * from tipos_maquina");
            cmb_tipo_maquina.ValueMember = "id_tipo_maquina";
            cmb_tipo_maquina.DisplayMember = "nombre";
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_responsable.Enabled = true;
            cargarComboResponsable();
            if (cmb_responsable.Items.Count == 0)
            {
                cmb_responsable.Text = "No hay responsables.";
                cmb_responsable.Enabled = false;
            }
        }

        private void btn_agregar_detalle_Click(object sender, EventArgs e)
        {
            actualizarTablaBoleta();
                String query = "";
                if (nmr_cant_piezas.Value == 0 || numericUpDown4.Value == 0 || numericUpDown5.Value == 0 || numericUpDown1.Value == 0 ||
                    numericUpDown2.Value == 0 || numericUpDown3.Value == 0)
                {
                    MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                if (dgv_detalles.Rows.Count == 0)
                {
                    bdHelper.startTransaction();
                    query = "insert into orden_trabajo (id_orden_trabajo, id_estado, precio_total, cantidad_piezas, " +
                    "descripcion_pieza) values ("
                    + "'" + id_orden_trabajo_creando + "',"
                    + "'" + 5 + "',"
                    + "'" + calcularPrecioTotal() + "',"
                    + "'" + nmr_cant_piezas.Value + "',"
                    + "'" + textBox2.Text + "')";
                    bdHelper.consultarSQL(query);
                }
                       query = "insert into detalle_orden (id_orden_trabajo, descripcion_actividad, duracion_calibracion, duracion_trabajo, " +
                       "id_maquina) values ("
                       + "'" + id_orden_trabajo_creando + "',"
                       + "'" + txt_observaciones.Text + "',"
                       + "'" + numericUpDown2.Text + "',"
                       + "'" + numericUpDown3.Text + "',"
                       + "'" + cmb_maquina.SelectedValue + "')";
                limpiarCamposBoleta();
                bdHelper.consultarSQL(query);
                actualizarTablaBoleta();
            }
        }

        private string calcularPrecioTotal()
        {
            return "1000";
        }

        private void actualizarTablaBoleta()
        {
            dgv_detalles.Rows.Clear();
            string retrieveDetallesQuery = "select * from detalle_orden WHERE id_orden_trabajo = " + id_orden_trabajo_creando;
            DataTable tabla = bdHelper.consultarSQL(retrieveDetallesQuery);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_detalles.Rows.Add(tabla.Rows[i]["id_detalle"],
                                    tabla.Rows[i]["duracion_calibracion"],
                                    tabla.Rows[i]["duracion_trabajo"],
                                    tabla.Rows[i]["id_maquina"]);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboMaquina();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
