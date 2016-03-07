using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
        public PerfilAcesso PerfilAcesso { get; set; }
    }
}
