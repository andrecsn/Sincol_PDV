using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;
using System.Web;

namespace SincolPDV.BLL
{
    public class Transacao
    {
        #region atributos
        int codigo;
        string descricao;

        #endregion

        #region Propriedades
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

        #endregion


        #region Metodos


        public DataTable Consulta()
        {
            TransacaoDAL trn = new TransacaoDAL();
            return trn.ConsultaTransacao("P_CONSULTAR_TRANSACAO", Descricao);
        }

        #endregion
    }
}
