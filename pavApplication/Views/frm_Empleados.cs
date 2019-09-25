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

namespace pavApplication.Views
{
    public partial class frm_Empleados : Form
    {

        BDHelper oDatos = BDHelper.getBDHelper();

        public frm_Empleados()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_pav_dbDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this._pav_dbDataSet.empleados);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == string.Empty || txt_apellido.Text == string.Empty || txt_domicilio.Text == string.Empty
                || txt_telefono.Text == string.Empty || txt_email.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                    string insertQuery = "insert into Empleados (nombre, apellido, email, telefono, domicilio) values ("
                    + "'" + txt_nombre.Text + "',"
                    + "'" + txt_apellido.Text + "',"
                    + "'" + txt_email.Text + "',"
                    + "'" + txt_telefono.Text + "',"
                    + "'" + txt_domicilio.Text + "')";

                    oDatos.actualizarBD(insertQuery);
                    MessageBox.Show("Empleado agregado correctamente.", "Empleado Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            dgv_empleados.Rows.Clear();
            string retrieveEmpleadosQuery = "select * from Empleados";
            DataTable tabla = oDatos.consultarSQL(retrieveEmpleadosQuery);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_empleados.Rows.Add(tabla.Rows[i]["legajo_empleado"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["apellido"],
                                    tabla.Rows[i]["email"],
                                    tabla.Rows[i]["telefono"],
                                    tabla.Rows[i]["domicilio"]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
