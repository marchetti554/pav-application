using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace pavApplication.Utils
{
    class BDHelper
    {
        private static BDHelper instance;
        public static BDHelper getBDHelper()
        {
            if (instance == null)
                instance = new BDHelper();
            return instance;
        }

        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public BDHelper()
        {
            cadenaConexion = @"Data Source=DESKTOP-APONHGI;Initial Catalog=pav-db;Integrated Security=True";
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        public BDHelper(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        enum TransactionStatus
        {
            exito, fracaso, iniciada, desactivada
        }

        private TransactionStatus estadoTransaccion = TransactionStatus.desactivada;
        private SqlTransaction transaccion = null;
        public bool resultadoDeTrasaccion = true;

        private void conectarTransaction()
        {
            if (estadoTransaccion != TransactionStatus.exito)
            {
                transaccion = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = transaccion;
                estadoTransaccion = TransactionStatus.exito;
            }

        }

        private void desconectarTransacion()
        {
            if (estadoTransaccion == TransactionStatus.exito)
            {
                transaccion.Commit();
                resultadoDeTrasaccion = true;
            }
            else if (estadoTransaccion == TransactionStatus.fracaso)
            {
                transaccion.Rollback();
                resultadoDeTrasaccion = false;
            }
        }

        public void finalizarTransaction()
        {
            transaccion.Rollback();
        }

        public void startTransaction()
        {
            estadoTransaccion = TransactionStatus.iniciada;
        }

        public void endTransaction()
        {
            desconectarTransacion();
            estadoTransaccion = TransactionStatus.desactivada;
            desconectar();
        }

    
        private void conectar()
        {
            if (estadoTransaccion == TransactionStatus.desactivada)
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = this.cadenaConexion;
                conexion.Open();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
            }
            if (estadoTransaccion == TransactionStatus.iniciada)
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = this.cadenaConexion;
                conexion.Open();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                conectarTransaction();
            }

        }

        private void desconectar()
        {
            if (estadoTransaccion == TransactionStatus.desactivada)
            {
                conexion.Close();
            }
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = "Select * from " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultarSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void actualizarBD(string sql)
        {
            try
            {
                conectar();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                desconectar();
            }
            catch (Exception ex)
            {
                if (estadoTransaccion == TransactionStatus.exito)
                    estadoTransaccion = TransactionStatus.fracaso;
                throw ex;
            }

        }
    }
}
