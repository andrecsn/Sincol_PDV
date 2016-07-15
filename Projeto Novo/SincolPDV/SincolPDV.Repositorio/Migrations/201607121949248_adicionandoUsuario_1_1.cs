namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoUsuario_1_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FuncaoUsuario", "UsuarioPaiID", c => c.Int());
            AlterColumn("dbo.PerfilAcesso", "UsuarioPaiID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PerfilAcesso", "UsuarioPaiID", c => c.Int(nullable: false));
            AlterColumn("dbo.FuncaoUsuario", "UsuarioPaiID", c => c.Int(nullable: false));
        }
    }
}
