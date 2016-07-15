namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosBancarios : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DadosBancarios", "Descricao", c => c.String());
            AddColumn("dbo.DadosBancarios", "StatusId", c => c.Int(nullable: false));
            AddColumn("dbo.DadosBancarios", "UsuarioPaiID", c => c.Int());
            CreateIndex("dbo.DadosBancarios", "StatusId");
            AddForeignKey("dbo.DadosBancarios", "StatusId", "dbo.Status", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DadosBancarios", "StatusId", "dbo.Status");
            DropIndex("dbo.DadosBancarios", new[] { "StatusId" });
            DropColumn("dbo.DadosBancarios", "UsuarioPaiID");
            DropColumn("dbo.DadosBancarios", "StatusId");
            DropColumn("dbo.DadosBancarios", "Descricao");
        }
    }
}
