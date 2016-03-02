using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Saida
    {
        public int SaidaID { get; set; }
        public string Tabela { get; set; }
        public string ModoPagamento { get; set; }
        public string Vencimento { get; set; }
        public string GtdParcelas { get; set; }
        public string valor2 { get; set; }
        public string ParcelasFaltantes { get; set; }
    }
}
