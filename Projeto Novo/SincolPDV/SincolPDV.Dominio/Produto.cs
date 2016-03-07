using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Referencia { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Fabricante Fabricante { get; set; }
        public string Imagem { get; set; }
        public string unEntrada { get; set; }
        public int Fator { get; set; }
        public string unSaida { get; set; }
        public decimal precoUnitario { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public decimal ValorTabela { get; set; }
        public string Observacao { get; set; }
        public int TipoSaida { get; set; }
        public string Origem { get; set; }
        public string Peso { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFinal { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string Emprestimo { get; set; }
    }
}
