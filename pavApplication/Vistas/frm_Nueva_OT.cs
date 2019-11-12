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

        Int32 id_orden_trabajo_creando;
        Decimal precioHoraTrabajo;
        Decimal precioHoraCalibracion;
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
            if (MessageBox.Show("¿Seguro que quiere cancelar la nueva Orden de Trabajo? Se perderan " +
                "todos sus datos.", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                panel3.Enabled = true;
                limpiarCamposBoleta();
                bdHelper.finalizarTransaction();
                dgv_detalles.Rows.Clear();          //TODO: Eliminar esto
                actualizarPrecioTotal();
                this.Close();
            }
        }

        private void desecharCambiosOT()
        {
            throw new NotImplementedException();
        }

        private void btn_crear_ot_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Quiere crear la Orden de Trabajo con las boletas de producción añadidas? Luego " +
                "no podrá cambiarlas, deberá crear una nueva.", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                bdHelper.actualizarBD("UPDATE orden_trabajo SET precio_total = " + textBox1.Text + ", " +
                    "precio_hora_calibracion = " + numericUpDown4.Value + " , " +
                    "precio_hora_trabajo = " + numericUpDown5.Value + " , " +
                    "cantidad_piezas = " + nmr_cant_piezas.Value + 
                    " WHERE id_orden_trabajo = " + id_orden_trabajo_creando + " ; ");
                limpiarCamposBoleta();
                bdHelper.endTransaction();
                this.Close();
            }
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
            DateTime time = DateTime.Now.AddDays(10);
            string format = "yyyy-MM-dd HH:mm:ss";
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
                    //Reinicia el seed para el auto increment de la primary key de detalles
                    bdHelper.consultarSQL("DBCC CHECKIDENT('detalle_orden', RESEED, 0)"); 
                    query = "insert into orden_trabajo (id_estado, precio_total, cantidad_piezas, precio_hora_trabajo, precio_hora_calibracion, " +
                    "fecha_estimada_entrega , dni_responsable_cliente , descripcion_pieza) values ("
                    + "'" + 5 + "',"
                    + "'" + actualizarPrecioTotal() + "',"
                    + "'" + nmr_cant_piezas.Value + "',"
                    + "'" + numericUpDown4.Value + "',"
                    + "'" + numericUpDown5.Value + "',"
                    + "'" + time.ToString(format) + "'," 
                    + "'" + "39419585" + "',"       //TODO: FIXEAR ESTO - Ver por qué no funciona
                    + "'" + textBox2.Text + "')";
                    bdHelper.consultarSQL(query);
                    precioHoraTrabajo = numericUpDown4.Value;
                    precioHoraCalibracion = numericUpDown5.Value;
                    id_orden_trabajo_creando = Int32.Parse(bdHelper.consultarSQL("select SCOPE_IDENTITY()").Rows[0][0].ToString());
                    lbl_next_ot.Text = id_orden_trabajo_creando.ToString();
                    textBox1.Text = actualizarPrecioTotal().ToString();
                }
                query = "insert into detalle_orden (id_orden_trabajo, descripcion_actividad, duracion_calibracion, duracion_trabajo, estado," +
                       "id_maquina) values ("
                       + "'" + id_orden_trabajo_creando + "',"
                       + "'" + txt_observaciones.Text + "',"
                       + "'" + numericUpDown2.Text + "',"
                       + "'" + numericUpDown3.Text + "',"
                       + "'" + "Generada" + "',"
                       + "'" + cmb_maquina.SelectedValue + "')";
                limpiarCamposBoleta();
                bdHelper.consultarSQL(query);
                actualizarTablaBoleta();
                panel3.Enabled = false;
                panel1.Enabled = true;
                actualizarPrecioTotal();
                textBox1.Text = actualizarPrecioTotal().ToString();
            }
        }

        private Decimal actualizarPrecioTotal()
        {
            Decimal precioTotal = 0;
            Decimal cantidadHorasTrabajoTotal = 0;
            Decimal cantidadHorasCalibracionTotal = 0;
            foreach (DataGridViewRow row in dgv_detalles.Rows)
            {
                cantidadHorasTrabajoTotal += Int32.Parse(row.Cells[2].Value.ToString());
                cantidadHorasCalibracionTotal += Int32.Parse(row.Cells[1].Value.ToString());
            }
            precioTotal += precioHoraTrabajo * cantidadHorasTrabajoTotal;
            precioTotal += precioHoraCalibracion * cantidadHorasCalibracionTotal;
            textBox1.Text = precioTotal.ToString();
            return precioTotal;
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
            actualizarPrecioTotal();
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

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar la nueva Orden de Trabajo? Se perderan " +
                "todos sus datos.", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                panel3.Enabled = true;
                limpiarCamposBoleta();
                bdHelper.finalizarTransaction();
                dgv_detalles.Rows.Clear();
                actualizarPrecioTotal();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            actualizarPrecioTotal();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            actualizarPrecioTotal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
