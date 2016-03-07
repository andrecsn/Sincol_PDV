using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class CRM
    {
        public int CrmID { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public bool Resolvido { get; set; }
        public DateTime DtSolucao { get; set; }
        public string Solucao { get; set; }
    }
}
