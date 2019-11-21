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
    public partial class frm_Controlar_OT : Form
    {

        int orden_trabajo_controlando;
        int cantidad_boletas = 0;

        private BDHelper bdHelper = BDHelper.getBDHelper();

        public frm_Controlar_OT()
        {
            InitializeComponent();
            updatearNombreEnTxtBox();
            cantidad_boletas = 0;
        }

        public frm_Controlar_OT(int id_orden_trabajo)
        {
            InitializeComponent();
            actualizarDetalles(id_orden_trabajo);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarDetalles(int orden_trabajo)
        {
            this.orden_trabajo_controlando = orden_trabajo;
            this.lbl_numero_ot.Text = orden_trabajo.ToString();
            dgv_detalles.Rows.Clear();
            string retrieveBoletasQuery = "select * from detalle_orden WHERE id_orden_trabajo = " + orden_trabajo;
            DataTable tabla = bdHelper.consultarSQL(retrieveBoletasQuery);
            cantidad_boletas = tabla.Rows.Count;
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_detalles.Rows.Add(tabla.Rows[i]["id_detalle"],
                                    tabla.Rows[i]["legajo_empleado"],
                                    tabla.Rows[i]["id_maquina"],
                                    tabla.Rows[i]["estado"],
                                    tabla.Rows[i]["fecha_hora_inicio"],
                                    Int32.Parse(tabla.Rows[i]["duracion_calibracion"].ToString()) + Int32.Parse(tabla.Rows[i]["duracion_trabajo"].ToString()),
                                    tabla.Rows[i]["duracion_real_trabajo"]);
                }
            }
        }

        private void dgv_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Controlar_OT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_pav_dbDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this._pav_dbDataSet.empleados);

        }

        /**
         * Completa la Boleta de Producción seleccionada, tiene que estar En Curso.
         * 
         * */
        private void btn_completar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles.SelectedRows[0].Cells["estado"].Value.ToString() == "En Curso")
            {
                panel1.Enabled = false;
                btn_completar.Enabled = false;
                string completarBoletaQuery = "Update detalle_orden SET estado = 'Completada', duracion_real_trabajo = " +
                    (DateTime.Now - Convert.ToDateTime(dgv_detalles.SelectedRows[0].Cells["fecha_hora_inicio"].Value.ToString())).Seconds + " " +
                    "WHERE (id_orden_trabajo = " + orden_trabajo_controlando + " AND id_detalle = " + Int32.Parse(dgv_detalles.SelectedRows[0].Cells["id_detalle"].Value.ToString()) + ");";
                bdHelper.actualizarBD(completarBoletaQuery);
                actualizarDetalles(orden_trabajo_controlando);
            } else
            {
                MessageBox.Show("Esta Boleta no posee el estado requerido, no se puede Completar.", "¡Atención!", MessageBoxButtons.OK);
            }
            string chequearQuedanBoletasPorCompletarQuery = "Select * FROM detalle_orden WHERE (id_orden_trabajo = " + orden_trabajo_controlando + " AND estado = 'Completada');";
            DataTable cantidadBoletasCompletadas = bdHelper.consultarSQL(chequearQuedanBoletasPorCompletarQuery);
            if(cantidad_boletas == cantidadBoletasCompletadas.Rows.Count)
            {
                btn_finalizar.Enabled = true;
            }
        }

        /**
         * Inicia la Boleta de Producción seleccionada, tiene que estar Generada.
         * 
         * */
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles.SelectedRows[0].Cells["estado"].Value.ToString() == "Generada")
            {
                panel1.Enabled = false;
                btn_completar.Enabled = true;


                DateTime time = DateTime.Now;             
                string format = "yyyy-MM-dd HH:mm:ss";

                String iniciarBoletaQuery = "update detalle_orden SET estado = 'En Curso', legajo_empleado = " + Int32.Parse(comboBox1.SelectedValue.ToString())
                    + ", fecha_hora_inicio = '" + time.ToString(format)
                    + "' WHERE (id_orden_trabajo = " + orden_trabajo_controlando + " AND id_detalle = "
                    + Int32.Parse(dgv_detalles.SelectedRows[0].Cells["id_detalle"].Value.ToString()) + ");";

                bdHelper.actualizarBD(iniciarBoletaQuery);
                actualizarDetalles(this.orden_trabajo_controlando);
            }
            else
            {
                MessageBox.Show("Esta Boleta no posee el estado requerido, no se puede Iniciar.", "¡Atención!", MessageBoxButtons.OK);
            }
        }

        private void dgv_detalles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgv_detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_detalles.SelectedRows[0].Cells["estado"].Value.ToString() == "Generada")
            {
                panel1.Enabled = true;
                btn_completar.Enabled = false;
            }
            if (dgv_detalles.SelectedRows[0].Cells["estado"].Value.ToString() == "En Curso")
            {
                panel1.Enabled = false;
                btn_completar.Enabled = true;
            }
            if (dgv_detalles.SelectedRows[0].Cells["estado"].Value.ToString() == "Completada")
            {
                panel1.Enabled = false;
                btn_completar.Enabled = false;
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar la Orden de Trabajo?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                DataTable detalles_orden_por_sumar = bdHelper.consultarSQL("SELECT duracion_real_trabajo FROM detalle_orden WHERE " +
                    "id_orden_trabajo = " + orden_trabajo_controlando);
                float total_tiempo = 0;
                foreach(DataRow detalle in detalles_orden_por_sumar.Rows)
                {
                    total_tiempo += Int32.Parse(detalle["duracion_real_trabajo"].ToString());
                }
                bdHelper.actualizarBD("UPDATE orden_trabajo SET id_estado = 2, tiempo_total_real = " + total_tiempo + " WHERE " +
                    "id_orden_trabajo = " + orden_trabajo_controlando + ";");
            }
        }

        private void lbl_numero_ot_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatearNombreEnTxtBox();
        }

        private void updatearNombreEnTxtBox()
        {
            int legajoEmpleado = Int32.Parse(comboBox1.SelectedValue.ToString());
            string retrieveNombreApellidoEmpleado = "SELECT * FROM empleados WHERE legajo_empleado = " + legajoEmpleado;
            DataTable legajoEmpleadoDataTable = bdHelper.consultarSQL(retrieveNombreApellidoEmpleado);
            textBox1.Text = legajoEmpleadoDataTable.Rows[0]["nombre"].ToString() + " " + legajoEmpleadoDataTable.Rows[0]["apellido"];
        }
    }
}
