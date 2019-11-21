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
    public partial class frm_Maquinas : Form
    {

        private BDHelper bdHelper = BDHelper.getBDHelper();
        private Boolean estaActualizando = false;

        public frm_Maquinas()
        {
            InitializeComponent();
        }

        private void frm_Maquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_pav_dbDataComboTipoMaq.tipos_maquina' Puede moverla o quitarla según sea necesario.
            this.tipos_maquinaTableAdapter.Fill(this._pav_dbDataComboTipoMaq.tipos_maquina);
            actualizarGrillaMaquinas();

        }

        private void actualizarGrillaMaquinas()
        {
            dgv_maquinas.Rows.Clear();
            string retrieveMaquinasQuery = "SELECT tipos_maquina.*, maquinas.* FROM tipos_maquina INNER JOIN maquinas ON tipos_maquina.id_tipo_maquina = maquinas.id_tipo_maquina WHERE estaEliminado = 0";
            DataTable tablaMaquinas = bdHelper.consultarSQL(retrieveMaquinasQuery);
            if (tablaMaquinas.Rows.Count > 0)
            {
                for (int i = 0; i < tablaMaquinas.Rows.Count; i++)
                {
                    dgv_maquinas.Rows.Add(tablaMaquinas.Rows[i]["id_maquina"],
                                    tablaMaquinas.Rows[i]["nombre_maquina"],
                                    tablaMaquinas.Rows[i]["nombre"]);
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el menú de Máquinas?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            String query = "";
            if (txt_nombre_maq.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (estaActualizando)
                {
                    query = "";
                }
                else
                {
                    query = "insert into Maquinas (nombre_maquina, descripcion_maquina, id_tipo_maquina) values ("
                    + "'" + txt_nombre_maq.Text + "',"
                    + "'" + "Descripcion predeterminada de máquina." + "',"
                    + "'" + cmb_tipo_maq.SelectedValue + "')";
                }

                bdHelper.actualizarBD(query);
                MessageBox.Show("Máquina agregada correctamente.", "Máquina Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_maquinas.ClearSelection();
                clearFields();
            }
            actualizarGrillaMaquinas();
        }

        /**
         * Elimina una máquina.
         **/
        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta Máquina?", "¡Atención!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                String query = "update Maquinas SET estaEliminado = 1 WHERE id_maquina = "
                    + Int32.Parse(dgv_maquinas.SelectedRows[0].Cells["id_maquina"].Value.ToString()) + ";";
                bdHelper.actualizarBD(query);
                actualizarGrillaMaquinas();
            }
        }

        private void clearFields()
        {
            txt_nombre_maq.Text = "";
        }
    }
}
