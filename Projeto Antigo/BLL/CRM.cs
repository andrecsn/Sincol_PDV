using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;
using System.Web;

namespace SincolPDV.BLL
{
    public class CRM
    {
        #region atributos

        int codigo;
        string descricao;
        string select_clie_forn;
        int clie_forn_codigo;
        string clie_forn_nome;
        string assunto;
        string texto;
        string status_resposta;
        string data_resposta;
        string resposta;
        string data;

        string table_codigo;
        string table_descricao;
        string table_select_clie_forn;
        string table_clie_forn_nome;
        string table_data;

        #endregion

        #region propriedades

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Select_Clie_Forn
        {
            get { return select_clie_forn; }
            set { select_clie_forn = value; }
        }

        public int Clie_Forn_Codigo
        {
            get { return clie_forn_codigo; }
            set { clie_forn_codigo = value; }
        }

        public string Clie_Forn_Nome
        {
            get { return clie_forn_nome; }
            set { clie_forn_nome = value; }
        }

        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public string Status_resposta
        {
            get { return status_resposta; }
            set { status_resposta = value; }
        }

        public string Data_resposta
        {
            get { return data_resposta; }
            set { data_resposta = value; }
        }

        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }


        public string Table_Codigo
        {
            get { return table_codigo; }
            set { table_codigo = value; }
        }

        public string Table_Descricao
        {
            get { return table_descricao; }
            set { table_descricao = value; }
        }

        public string Table_Select_Clie_Forn
        {
            get { return table_select_clie_forn; }
            set { table_select_clie_forn = value; }
        }

        public string Table_Clie_Forn_Nome
        {
            get { return table_clie_forn_nome; }
            set { table_clie_forn_nome = value; }
        }

        public string Table_Data
        {
            get { return table_data; }
            set { table_data = value; }
        }

        #endregion

        #region metodos

        CrmDAL crm = new CrmDAL();
        Acesso exe = new Acesso();
        int result;

        public int CadastrarCRM()
        {
            return result = crm.InserirCRM("P_CADASTRAR_CRM", Descricao, Select_Clie_Forn, Clie_Forn_Codigo, Clie_Forn_Nome, Assunto, Texto, Status_resposta, Data_resposta, Resposta, Data);
        }


        public void CódigoCRM()
        {
            DataTable dt = exe.Consultar("Select Max(crm_Codigo)+1 from CRM");
            Codigo = Codigo = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
        }


        public DataTable ListarCRM()
        {
            return crm.ListarCRM("P_CONSULTAR_CRM", Codigo, Descricao, Select_Clie_Forn, Clie_Forn_Nome);

        }

        #endregion
    }
}
