using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
   public  class Acesso
    {
            string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
            private SqlConnection _conn;
            private SqlCommand comando;
            private SqlDataAdapter oda;


            public Acesso()
            {
                _conn = new SqlConnection(conexao);
                _conn.Open();

            }

            public int Executar(string pSQL)
            {
                comando = new SqlCommand(pSQL, _conn);
                return comando.ExecuteNonQuery();
            }

            public DataTable Consultar(string pSQL)
            {
                DataTable i = new DataTable();
                oda = new SqlDataAdapter(pSQL, _conn);
                oda.Fill(i);

                return i;


            }

        }
    }

