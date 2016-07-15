using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class PerfilTransacao
    {
        public int PerfilTransacaoID { get; set; }

        public bool Consultar { get; set; }

        public bool Visualizar { get; set; }

        public bool Excluir { get; set; }

        public bool Alterar { get; set; }

        public bool Incluir { get; set; }

        public bool Imprimir { get; set; }

        public bool Processar { get; set; }

        public bool Liberar { get; set; }
    }
}
