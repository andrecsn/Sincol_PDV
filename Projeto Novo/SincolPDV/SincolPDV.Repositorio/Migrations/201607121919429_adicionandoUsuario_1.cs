namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoUsuario_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FuncaoUsuario", "UsuarioPaiID", c => c.Int(nullable: false));
            AddColumn("dbo.PerfilAcesso", "UsuarioPaiID", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "UsuarioPaiID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "UsuarioPaiID");
            DropColumn("dbo.PerfilAcesso", "UsuarioPaiID");
            DropColumn("dbo.FuncaoUsuario", "UsuarioPaiID");
        }
    }
}
