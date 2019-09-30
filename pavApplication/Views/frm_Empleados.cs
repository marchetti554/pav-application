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

        BDHelper bdHelper = BDHelper.getBDHelper();

        private Boolean estaActualizando = false;

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
            String query = "";
            if (txt_nombre.Text == string.Empty || txt_apellido.Text == string.Empty || txt_domicilio.Text == string.Empty
                || txt_telefono.Text == string.Empty || txt_email.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if(estaActualizando)
                {
                    query = "update Empleados set nombre = '"
                        + txt_nombre.Text
                        + "', apellido = '" + txt_apellido.Text
                        + "', email = '" + txt_email.Text
                        + "', telefono = '" + txt_telefono.Text
                        + "', domicilio = '" + txt_domicilio.Text + "'" +
                        "WHERE legajo_empleado = " + Int32.Parse(dgv_empleados.SelectedRows[0].Cells["legajo_empleado"].Value.ToString()) + ";";
                } else
                {
                    query = "insert into Empleados (nombre, apellido, email, telefono, domicilio) values ("
                    + "'" + txt_nombre.Text + "',"
                    + "'" + txt_apellido.Text + "',"
                    + "'" + txt_email.Text + "',"
                    + "'" + txt_telefono.Text + "',"
                    + "'" + txt_domicilio.Text + "')";
                }

                bdHelper.actualizarBD(query);
                MessageBox.Show("Empleado agregado/actualizado correctamente.", "Empleado Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
            }
            actualizarGrilla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            String query = "update Empleados SET estaEliminado = 1";
            bdHelper.actualizarBD(query);
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            dgv_empleados.Rows.Clear();
            string retrieveEmpleadosQuery = "select * from Empleados WHERE estaEliminado = 0";
            DataTable tabla = bdHelper.consultarSQL(retrieveEmpleadosQuery);
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            estaActualizando = true;

            string legajo = dgv_empleados.SelectedRows[0].Cells["legajo_empleado"].Value.ToString();
            string nombre = dgv_empleados.SelectedRows[0].Cells["nombre"].Value.ToString();
            string apellido = dgv_empleados.SelectedRows[0].Cells["apellido"].Value.ToString();
            string email = dgv_empleados.SelectedRows[0].Cells["email"].Value.ToString();
            string telefono = dgv_empleados.SelectedRows[0].Cells["telefono"].Value.ToString();
            string domicilio = dgv_empleados.SelectedRows[0].Cells["domicilio"].Value.ToString();

            txt_nombre.Text = nombre;
            txt_apellido.Text = apellido;
            txt_email.Text = email;
            txt_telefono.Text = telefono;
            txt_domicilio.Text = domicilio;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            estaActualizando = false;
            clearFields();
        }

        private void clearFields()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_telefono.Text = "";
            txt_domicilio.Text = "";
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
