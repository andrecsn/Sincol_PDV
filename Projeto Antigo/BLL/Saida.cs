using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;

namespace SincolPDV.BLL
{
    public class Saida
    {
        #region atributos

        public string tabela;
        public string modo_pagamento;
        public string vencimento;
        public string quant_parcelas;
        public string valor2;
        public string parcelas_faltantes;

        #endregion


        #region Propriedades

        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }
        
        public string Modo_Pagamento
        {
            get { return modo_pagamento; }
            set { modo_pagamento = value; }
        }

        public string Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }

        public string Quant_Parcelas
        {
            get { return quant_parcelas; }
            set { quant_parcelas = value; }
        }

        public string Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public string Parcelas_faltantes
        {
            get { return parcelas_faltantes; }
            set { parcelas_faltantes = value; }
        }
        #endregion



        #region Metodos

        SaidaDAL saida = new SaidaDAL();
        Acesso exe = new Acesso();


        public DataTable Lista()
        {
            return saida.ConsultaVendaParcela("P_CONSULTA_VENDA_PARCELA");
        }


        #endregion
    }
}
