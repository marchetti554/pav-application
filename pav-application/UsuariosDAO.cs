using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pav_application
{ 
    class UsuariosDAO
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();

        private void Si()
        {
            cnn.ConnectionString = "Data Source=DESKTOP-APONHGI;Initial Catalog=pav-db;Integrated Security=True";
            cnn.Open();
        }
    }

    class Usuario
    {
        String nombre_usuario;
        String password;
    }
}
