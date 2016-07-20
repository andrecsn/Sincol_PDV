using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string Modelo { get; set; }

        public int? FabricanteID { get; set; }

        public Fabricante Fabricante { get; set; }

        public int? FornecedorID { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public int? MarcaID { get; set; }

        public Marca Marca { get; set; }

        public string Imagem { get; set; }

        public string unEntrada { get; set; }

        public int Fator { get; set; }

        public decimal precoUnitario { get; set; }

        public decimal ValorTabela { get; set; }

        public int EstoqueMinimo { get; set; }

        public int EstoqueMaximo { get; set; }

        public string Observacao { get; set; }

        public int EstoqueID { get; set; }

        public Estoque Estoque { get; set; }

        public string Peso { get; set; }

        public DateTime DataCadastro { get; set; }

        public int? UsuarioPaiID { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        [NotMapped]
        public bool StatusBool
        {
            get { return StatusId == 1; }
            set { StatusId = value ? 1 : 2; }
        }
    }

    public class pesquisaProduto
    {
        public string Nome { get; set; }
        public int FornecedorID { get; set; }
        public int FabricanteID { get; set; }
        public int MarcaID { get; set; }
    }
}
