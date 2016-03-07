using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Transferencia
    {
        public int TransferenciaID { get; set; }
        public string Descricao { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Lojas LojaSaida { get; set; }
        public Lojas LojaEntrada { get; set; }
        public DateTime DtTransferencia { get; set; }

        public enum Lojas
        {
            Fisica,
            Virtual
        }
    }
}
