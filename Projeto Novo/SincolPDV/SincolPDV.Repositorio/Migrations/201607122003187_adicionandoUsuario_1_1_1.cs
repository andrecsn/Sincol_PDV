namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoUsuario_1_1_1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PerfilAcesso", name: "PerfilTransacao_PerfilTransacaoID", newName: "PerfilTransacaoID");
            RenameIndex(table: "dbo.PerfilAcesso", name: "IX_PerfilTransacao_PerfilTransacaoID", newName: "IX_PerfilTransacaoID");
            AddColumn("dbo.PerfilAcesso", "StatusId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PerfilAcesso", "StatusId", "dbo.Status");
            DropIndex("dbo.PerfilAcesso", new[] { "StatusId" });
            DropColumn("dbo.PerfilAcesso", "StatusId");
            RenameIndex(table: "dbo.PerfilAcesso", name: "IX_PerfilTransacaoID", newName: "IX_PerfilTransacao_PerfilTransacaoID");
            RenameColumn(table: "dbo.PerfilAcesso", name: "PerfilTransacaoID", newName: "PerfilTransacao_PerfilTransacaoID");
        }
    }
}
