using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using SincolPDV.Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SincolPDV.Repositorio.Compartilhado
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
            Database.SetInitializer(new ModelDbInitializer());
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CRM> CRM { get; set; }
        public DbSet<DadosBancarios> DadosBancarios { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<EntradaProduto> EntradaProduto { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<InventarioProduto> InventarioProduto { get; set; }
        public DbSet<PerfilAcesso> PerfilAcesso { get; set; }
        public DbSet<PerfilTransacao> PerfilTransacao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
