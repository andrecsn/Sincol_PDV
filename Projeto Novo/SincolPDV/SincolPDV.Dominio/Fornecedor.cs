using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }

        public string Nome { get; set; }

        public string Pessoa { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public int DadosBancariosID { get; set; }

        public virtual DadosBancarios dadosBancarios { get; set; }

        public string Email { get; set; }

        public string Observacao { get; set; }

        public DateTime DtCadastro { get; set; }

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

    public class pesquisaFornecedor
    {
        public string Nome { get; set; }
        public string Pessoa { get; set; }
        public int StatusId { get; set; }
    }
}
