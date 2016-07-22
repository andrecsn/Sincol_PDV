using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class EntradaProdutos
    {
        [Key]
        public int EntradaID { get; set; }

        public int CodigoBarras { get; set; }

        public int ProdutoID { get; set; }

        public virtual Produto Produto { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }
        
        public DateTime DtEntrada { get; set; }
    }
}
