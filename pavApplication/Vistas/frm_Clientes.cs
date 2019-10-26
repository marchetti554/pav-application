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
            actualizarResponsablesGrilla();
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
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el menú de Clientes y Empresas?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // RESPONSABLES

        private void btn_agregar_resp_Click(object sender, EventArgs e)
        {
            String query = "";
            if (txt_resp_nombre.Text == string.Empty || txt_resp_apellido.Text == string.Empty || txt_resp_dni.Text == string.Empty
                 || txt_resp_email.Text == string.Empty || txt_resp_telefono.Text == string.Empty || txt_empresa_pertenece.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (estaActualizandoResponable)
                {
                    query = "update responsable_empresa set telefono = '"
                        + txt_resp_telefono.Text
                        + "', email = '" + txt_resp_email.Text
                        + "', nombre = '" + txt_resp_nombre.Text + "'"
                        + "', apellido = '" + txt_resp_apellido.Text + "'"
                        + "', id_cliente = '" + dgv_clientes.SelectedRows[0].Cells["id_cliente"] + "'"
                        + " WHERE dni = " + Int32.Parse(dgv_responsables.SelectedRows[0].Cells["dni"].Value.ToString()) + ";";
                }
                else
                {
                    query = "insert into responsable_empresa (telefono, email, nombre, apellido, dni, id_cliente) values ("
                    + "'" + txt_resp_telefono.Text + "',"
                    + "'" + txt_resp_email.Text + "',"
                    + "'" + txt_resp_nombre.Text + "',"
                    + "'" + txt_resp_apellido.Text + "',"
                    + "'" + txt_resp_dni.Text + "',"
                    + "'" + Int32.Parse(dgv_clientes.SelectedRows[0].Cells["id_cliente"].Value.ToString()) + "')";
                }

                bdHelper.actualizarBD(query);
                MessageBox.Show("Responsable agregado/actualizado correctamente.", "Responsable Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
            }
            actualizarResponsablesGrilla();
        }

        private void btn_eliminar_resp_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este Responsable?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                String query = "update responsable_empresa SET estaEliminado = 1 WHERE dni = "
                    + dgv_responsables.SelectedRows[0].Cells["dni"].Value.ToString() + ";";
                bdHelper.actualizarBD(query);
                actualizarResponsablesGrilla();
            }
        }

        private void btn_nuevo_responsable_Click(object sender, EventArgs e)
        {
            estaActualizandoResponable = false;
            clearResponsableFields();
        }

        private void clearResponsableFields()
        {
            txt_resp_nombre.Text = "";
            txt_resp_apellido.Text = "";
            txt_resp_email.Text = "";
            txt_resp_telefono.Text = "";
            txt_resp_dni.Text = "";
        }


        private void btn_modificar_resp_Click(object sender, EventArgs e)
        {
            estaActualizandoResponable = true;

            string id_cliente = dgv_responsables.SelectedRows[0].Cells["id_cliente_1"].Value.ToString();
            string dni = dgv_responsables.SelectedRows[0].Cells["dni"].Value.ToString();
            string email = dgv_responsables.SelectedRows[0].Cells["email_1"].Value.ToString();
            string telefono = dgv_responsables.SelectedRows[0].Cells["telefono_1"].Value.ToString();
            string apellido = dgv_responsables.SelectedRows[0].Cells["apellido"].Value.ToString();
            string nombre = dgv_responsables.SelectedRows[0].Cells["nombre"].Value.ToString();

            txt_resp_nombre.Text = nombre;
            txt_resp_apellido.Text = apellido;
            txt_resp_email.Text = email;
            txt_resp_telefono.Text = telefono;
            txt_resp_dni.Text = dni;
        }

    
        private void actualizarResponsablesGrilla()
        {
            dgv_responsables.Rows.Clear();
            string retrieveResponsablesQuery = "select * from responsable_empresa";
            DataTable tabla = bdHelper.consultarSQL(retrieveResponsablesQuery);
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgv_responsables.Rows.Add(tabla.Rows[i]["dni"],
                                    tabla.Rows[i]["nombre"],
                                    tabla.Rows[i]["apellido"],
                                    tabla.Rows[i]["telefono"],
                                    tabla.Rows[i]["email"],
                                    tabla.Rows[i]["id_cliente"]);
                }
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

        private void dgv_responsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
