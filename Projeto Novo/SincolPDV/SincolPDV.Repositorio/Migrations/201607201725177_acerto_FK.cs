namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acerto_FK : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Fornecedor", new[] { "DadosBancariosID" });
            AlterColumn("dbo.Fornecedor", "DadosBancariosID", c => c.Int());
            CreateIndex("dbo.Fornecedor", "DadosBancariosID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Fornecedor", new[] { "DadosBancariosID" });
            AlterColumn("dbo.Fornecedor", "DadosBancariosID", c => c.Int(nullable: false));
            CreateIndex("dbo.Fornecedor", "DadosBancariosID");
        }
    }
}
