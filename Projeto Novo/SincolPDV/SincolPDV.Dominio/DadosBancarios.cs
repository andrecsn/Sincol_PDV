using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class DadosBancarios
    {
        public int DadosBancariosID { get; set; }

        public string Descricao { get; set; }

        public string Banco { get; set; }

        public int Agencia { get; set; }

        public int Conta { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        public int? UsuarioPaiID { get; set; }
    }
}
