using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;
using System.Web;

namespace SincolPDV.BLL
{
    public class Perfil_Acesso
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
            Perfil_AcessoDAL Pera = new Perfil_AcessoDAL();
            return Pera.ConsultaPerfilAcesso("P_CONSULTAR_PERFIL_ACESSO", Descricao);
        }

        #endregion
    }
}
