using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string tp_pessoa { get; set; }
        public int Status { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public decimal LimiteCredito { get; set; }
        public int LimiteDias { get; set; }
        public string Observacao { get; set; }
    }
}
