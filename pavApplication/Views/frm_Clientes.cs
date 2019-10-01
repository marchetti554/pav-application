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
    public partial class frm_Clientes : Form
    {
        BDHelper bdHelper = BDHelper.getBDHelper();

        private Boolean estaActualizandoCliente = false;
        private Boolean estaActualizandoResponable = false;

        public frm_Clientes()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void btn_agregar_cliente_Click_1(object sender, EventArgs e)
        {
            String query = "";
            if (txt_razon_social.Text == string.Empty || txt_cliente_email.Text == string.Empty || txt_cliente_telefono.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (estaActualizandoCliente)
                {
                    query = "update Clientes set telefono = '"
                        + txt_cliente_telefono.Text
                        + "', email = '" + txt_cliente_email.Text
                        + "', razon_social = '" + txt_razon_social.Text + "'" 
                        + " WHERE id_cliente = " + Int32.Parse(dgv_clientes.SelectedRows[0].Cells["id_cliente"].Value.ToString()) + ";";
                }
                else
                {
                    query = "insert into Clientes (telefono, email, razon_social) values ("
                    + "'" + txt_cliente_telefono.Text + "',"
                    + "'" + txt_cliente_email.Text + "',"
                    + "'" + txt_razon_social.Text + "')";
                }

                bdHelper.actualizarBD(query);
                MessageBox.Show("Cliente agregado/actualizado correctamente.", "Cliente Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
                dgv_clientes.ClearSelection();
            }
            actualizarGrilla();
        }

        private void btn_eliminar_cliente_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este Cliente?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                String query = "update Clientes SET estaEliminado = 1 WHERE id_cliente = "
                    + Int32.Parse(dgv_clientes.SelectedRows[0].Cells["id_cliente"].Value.ToString()) + ";";
                bdHelper.actualizarBD(query);
                actualizarGrilla();
            }
        }

        private void actualizarGrilla()
        {
            dgv_clientes.Rows.Clear();
            string retrieveClientesQuery = "select * from Clientes WHERE estaEliminado = 0";
            DataTable tabla = bdHelper.consultarSQL(retrieveClientesQuery);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_clientes.Rows.Add(tabla.Rows[i]["id_cliente"],
                                    tabla.Rows[i]["razon_social"],
                                    tabla.Rows[i]["email"],
                                    tabla.Rows[i]["telefono"]);
                }
            }
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            estaActualizandoCliente = false;
            clearFields();
            dgv_clientes.ClearSelection();
        }

        private void clearFields()
        {
            txt_razon_social.Text = "";
            txt_cliente_email.Text = "";
            txt_cliente_telefono.Text = "";
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
                txt_empresa_pertenece.Text = dgv_clientes.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            estaActualizandoCliente = true;

            string id_cliente = dgv_clientes.SelectedRows[0].Cells["id_cliente"].Value.ToString();
            string razon_social = dgv_clientes.SelectedRows[0].Cells["razon_social"].Value.ToString();
            string email = dgv_clientes.SelectedRows[0].Cells["email"].Value.ToString();
            string telefono = dgv_clientes.SelectedRows[0].Cells["telefono"].Value.ToString();

            txt_razon_social.Text = razon_social;
            txt_cliente_email.Text = email;
            txt_cliente_telefono.Text = telefono;
            dgv_clientes.ClearSelection();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el menú de Clientes y Empresas?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_resp_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_empresa_pertenece_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
