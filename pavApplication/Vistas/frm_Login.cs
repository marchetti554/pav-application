using pavApplication.Datos;
using pavApplication.Utils;
using pavApplication.Views;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        BDHelper bdHelper = BDHelper.getBDHelper();

        private void button3_Click(object sender, EventArgs e)
        {
            String query = "";
            if (txt_pass.Text == string.Empty || txt_user.Text == string.Empty)
            {
                MessageBox.Show("Complete ambos campos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    query = "select * from usuarios where nombre_usuario = '" + txt_user.Text + "'";
                    DataTable tablaUsuario = bdHelper.consultarSQL(query);
                    if (tablaUsuario.Rows[0]["password"].ToString() == txt_pass.Text)
                    {
                        Constants.UsuarioLogueado = txt_user.Text;
                     Form dashboard = new frm_Dashboard();
                    dashboard.FormClosed += new FormClosedEventHandler(dashboard_FormClosed);
                    dashboard.Show();
                    this.Hide();
                }
                    else
                    {
                        MessageBox.Show("El usuario no existe o la contraseña no es la correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                          
            }
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
