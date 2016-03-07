using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Inventario
    {
        public int InventarioID { get; set; }
        public string Descricao { get; set; }
        public List<InventarioProduto> Produtos { get; set; }
    }
}
