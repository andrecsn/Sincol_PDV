using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;
using System.Web;

namespace SincolPDV.BLL
{
    public class Fabricante
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

            FabricanteDAL Fab = new FabricanteDAL();
            return Fab.ConsultaFabricante("P_CONSULTAR_LISTA_FABRICANTE", Descricao);

        }

        public void Inserir(string Descricao)
        {

            FabricanteDAL Fab = new FabricanteDAL();
            Fab.InserirFabricante("P_INSERIR_FABRICANTE", Descricao);

        }

       #endregion
        
    }
}
