using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SincolPDV.DAL;


namespace SincolPDV.BLL
{
    
    public class MiniConsulta
    {

           MiniConsultaDAL acesso = new MiniConsultaDAL();
           public string Tabela;
           public string ColunaCod;
           public string ColunaDesc;
           public int Codigo;
           public string Descricao;
           private int retorno;

           public string Insere()
           {
                try 
            	{
                    retorno = acesso.Inserir(Tabela, ColunaDesc, Descricao);
                    return "Incluído com sucesso";
            		
	            }
	            catch (Exception e)
	            {
		            return e.Message;
	            }
           }

           public string Altera()
           {
               try
               {
                   retorno = acesso.Alterar(Tabela, ColunaCod, ColunaDesc, Codigo, Descricao);
                   return "Alterado com sucesso";

               }
               catch (Exception e)
               {
                   return e.Message;
               }
           }

           public string Exclui()
           {
               try
               {
                   retorno = acesso.Excluir(Tabela, ColunaCod, Codigo);
                   return "Excluído com sucesso";

               }
               catch (Exception e)
               {
                   return e.Message;
               }
           }

           public DataTable Lista()
           {
               try
               {
                   return acesso.Listar(Tabela, ColunaCod, ColunaDesc, Descricao);
               }
               catch (Exception)
               {
                   throw;
               }
           }

           public void VerificaBD()
           {
               acesso.VerificaBD(Tabela, ColunaCod, ColunaDesc);
           }

    }
}
