using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SincolPDV.DAL
{
    public class FabricanteDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public FabricanteDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable ConsultaFabricante(string procedure, string descricao)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@descricao", SqlDbType.Text);
            pfiltro.Value = descricao;
            oda.Fill(i);



            return i;
        }

        public void InserirFabricante(string procedure, string descricao)
        {
            try
            {

                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;
                SqlParameter pfiltro = new SqlParameter("@descricao", SqlDbType.Text);
                pfiltro.Value = descricao;
                comando.Parameters.Add(pfiltro);
                comando.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Fabricante:" + ex.Number);
            }


            
        }

    }
}