namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoUsuario_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "UsuarioPaiID", c => c.Int());
            AddColumn("dbo.Produto", "UsuarioPaiID", c => c.Int());
            AddColumn("dbo.Estoque", "UsuarioPaiID", c => c.Int());
            AddColumn("dbo.Fabricante", "UsuarioPaiID", c => c.Int());
            AddColumn("dbo.Marca", "UsuarioPaiID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marca", "UsuarioPaiID");
            DropColumn("dbo.Fabricante", "UsuarioPaiID");
            DropColumn("dbo.Estoque", "UsuarioPaiID");
            DropColumn("dbo.Produto", "UsuarioPaiID");
            DropColumn("dbo.Fornecedor", "UsuarioPaiID");
        }
    }
}
