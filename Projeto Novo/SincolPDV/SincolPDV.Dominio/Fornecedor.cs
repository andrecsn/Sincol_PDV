using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public string Pessoa { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DadosBancarios dadosBancarios { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
    }
}
