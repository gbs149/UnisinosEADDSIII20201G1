using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ControleEquipamentos.Code.DAL
{
    public class AcessoBancoDados
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private String server = "localhost";
        private String user = "root";
        private String password = "1234";
        private String database = "teste";

        public void conectar()
        {   //ini metodo conectar              
            if (conn != null)
                conn.Close();

            string connStr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ToString());
            }

        }   //fim metodo conectar

        public void ExecutarComandoSQL(string comandoSql)
        {   //ini metodo ExecutaComandoSQL

            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            conn.Close();

        }   //fim metodo ExecutaComandoSQL

        public DataTable RetDataTable(string sql)
        {   //fim metodo RetDataTable

            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            return data;

        }	//fim metodo RetDataTable

        public MySqlDataReader RetDataReader(string sql)
        {   //fim metodo RetDataReader

            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;

        }   //fim metodo RetDataReader

    }
}
