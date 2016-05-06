using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class PerfilAcesso
    {
        public int PerfilAcessoID { get; set; }
        public string Descricao { get; set; }
        public virtual PerfilTransacao PerfilTransacao { get; set; }
    }
}
