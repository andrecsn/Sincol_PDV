namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraçãoUsuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "Funcao_FuncaoUsuarioID", "dbo.FuncaoUsuario");
            DropForeignKey("dbo.Usuario", "PerfilAcesso_PerfilAcessoID", "dbo.PerfilAcesso");
            DropIndex("dbo.Usuario", new[] { "Funcao_FuncaoUsuarioID" });
            DropIndex("dbo.Usuario", new[] { "PerfilAcesso_PerfilAcessoID" });
            RenameColumn(table: "dbo.Usuario", name: "Funcao_FuncaoUsuarioID", newName: "FuncaoUsuarioID");
            RenameColumn(table: "dbo.Usuario", name: "PerfilAcesso_PerfilAcessoID", newName: "PerfilAcessoID");
            AlterColumn("dbo.Usuario", "FuncaoUsuarioID", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuario", "PerfilAcessoID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "PerfilAcessoID", "dbo.PerfilAcesso");
            DropForeignKey("dbo.Usuario", "FuncaoUsuarioID", "dbo.FuncaoUsuario");
            DropIndex("dbo.Usuario", new[] { "PerfilAcessoID" });
            DropIndex("dbo.Usuario", new[] { "FuncaoUsuarioID" });
            AlterColumn("dbo.Usuario", "PerfilAcessoID", c => c.Int());
            AlterColumn("dbo.Usuario", "FuncaoUsuarioID", c => c.Int());
            RenameColumn(table: "dbo.Usuario", name: "PerfilAcessoID", newName: "PerfilAcesso_PerfilAcessoID");
            RenameColumn(table: "dbo.Usuario", name: "FuncaoUsuarioID", newName: "Funcao_FuncaoUsuarioID");
            CreateIndex("dbo.Usuario", "PerfilAcesso_PerfilAcessoID");
            CreateIndex("dbo.Usuario", "Funcao_FuncaoUsuarioID");
            AddForeignKey("dbo.Usuario", "PerfilAcesso_PerfilAcessoID", "dbo.PerfilAcesso", "PerfilAcessoID");
            AddForeignKey("dbo.Usuario", "Funcao_FuncaoUsuarioID", "dbo.FuncaoUsuario", "FuncaoUsuarioID");
        }
    }
}
