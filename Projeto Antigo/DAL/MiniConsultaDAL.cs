using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class MiniConsultaDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public MiniConsultaDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable Listar(string Tabela, string ColunaCod, string ColunaDesc, string descricao)
        {
            DataTable i = new DataTable();
            oda = new SqlDataAdapter("select " + ColunaCod + " as Codigo, " + ColunaDesc + " as Descricao from " + Tabela + " where " + ColunaDesc + " like '%" + descricao + "%' order by " + ColunaDesc, _conn);
            oda.Fill(i);
            return i;
        }

        public int Inserir(string Tabela, string ColunaDesc, string descricao)
        {
            comando = new SqlCommand("insert into " + Tabela + " (" + ColunaDesc + " ) values ('" + descricao + "')", _conn);
            return comando.ExecuteNonQuery();
        }

        public int Alterar(string Tabela, string ColunaCod, string ColunaDesc, int codigo, string descricao)
        {
            comando = new SqlCommand("update " + Tabela + " set " + ColunaDesc + " = '" + descricao + "' where " + ColunaCod + " = 0" + codigo.ToString() , _conn);
            return comando.ExecuteNonQuery();
        }

        public int Excluir(string Tabela, string ColunaCod, int codigo)
        {
            comando = new SqlCommand("delete from " + Tabela + " where " + ColunaCod +  " = 0" + codigo.ToString(), _conn);
            return comando.ExecuteNonQuery();
        }

        public void VerificaBD(string Tabela, string ColunaCod, string ColunaDesc)
        {
            try
            {
                comando = new SqlCommand("create table " + Tabela + " ( " + ColunaCod +  " integer identity, " + ColunaDesc + " varchar(50))", _conn);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                               
            }
        }

    }
}
