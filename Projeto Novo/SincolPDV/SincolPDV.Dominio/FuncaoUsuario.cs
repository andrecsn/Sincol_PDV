using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Dominio
{
    public class FuncaoUsuario
    {
        public int FuncaoUsuarioID { get; set; }

        public string Descricao { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        public int? UsuarioPaiID { get; set; }
    }
}
