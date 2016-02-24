using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SincolPDV.DAL
{
    public class SaidaDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public SaidaDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }


        public DataTable ConsultaVendaParcela(string procedure)
        {

            DataTable i = new DataTable();
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;
            oda.Fill(i);

            return i;
        }
    }
}
