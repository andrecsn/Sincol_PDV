using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;
using System.Web;

namespace SincolPDV.BLL
{
    public class Perfil_Transacao
    {
        #region atributos
        int codigo_transacao;
        int codigo_perfil_acesso;
        int consultar;
        int visualizar;
        int excluir;
        int alterar;
        int incluir;
        int imprimir;
        int processar;
        int liberar;

        #endregion


        #region Propriedades
        
        public int Codigo_transacao
        {
            get { return codigo_transacao; }
            set { codigo_transacao = value; }
        }

        public int Codigo_perfil_acesso
        {
            get { return codigo_perfil_acesso; }
            set { codigo_perfil_acesso = value; }
        }

        public int Consultar
        {
            get { return consultar; }
            set { consultar = value; }
        }

        public int Visualizar
        {
            get { return visualizar; }
            set { visualizar = value; }
        }

        public int Excluir
        {
            get { return excluir; }
            set { excluir = value; }
        }

        public int Alterar
        {
            get { return alterar; }
            set { alterar = value; }
        }

        public int Incluir
        {
            get { return incluir; }
            set { incluir = value; }
        }

        public int Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }

        public int Processar
        {
            get { return processar; }
            set { processar = value; }
        }
        public int Liberar
        {
            get { return liberar; }
            set { liberar = value; }
        }

        #endregion


        #region Metodos

        Perfil_AcessoDAL pera = new Perfil_AcessoDAL();

        int result;

        public string CadastrarPerfilTransacao()
        { 
            
            result = pera.CadastrarPerfilTransacao("P_CADASTRAR_PERFIL_TRANSACAO", Codigo_transacao, Codigo_perfil_acesso, Consultar, Visualizar, Excluir, Alterar, Incluir, Imprimir, Processar, Liberar);

            if (result == 1)
            {
                return "Cadastro Realizado com sucesso!!";

            }
            else
            {
                return "Erro ao cadastrar perfil";
            }
        }

        public DataTable ConsultarPerfilTransacao()
        {
            return pera.ConsultaPerfilTransacao("P_CONSULTAR_PERFIL_TRANSACAO");
        }

        #endregion
    }
}
