using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class InventarioProduto
    {
        public int InventarioProdutoID { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
