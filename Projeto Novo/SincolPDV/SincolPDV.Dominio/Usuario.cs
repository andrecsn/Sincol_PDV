using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        public int FuncaoUsuarioID { get; set; }

        [ForeignKey("FuncaoUsuarioID")]
        public virtual FuncaoUsuario Funcao { get; set; }

        public int PerfilAcessoID { get; set; }

        [ForeignKey("PerfilAcessoID")]
        public virtual PerfilAcesso PerfilAcesso { get; set; }

        public DateTime DataCadastro { get; set; }

        public int? UsuarioPaiID { get; set; }

        [NotMapped]
        public bool StatusBool
        {
            get { return StatusId == 1; }
            set { StatusId = value ? 1 : 2; }
        }
    }

    public class pesquisaUsuario
    {
        public string Nome { get; set; }
        public int FuncaoUsuarioID { get; set; }
        public int PerfilAcessoID { get; set; }
        public int StatusId { get; set; }
    }
}
