using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Entrada
    {
        public int EntradaID { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<EntradaProduto> Produto { get; set; }
        public FormasPagamento FormaPagamento { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DtEntrada { get; set; }


        public enum FormasPagamento
        {
            AVista,
            Parcelado
        }
    }
}
