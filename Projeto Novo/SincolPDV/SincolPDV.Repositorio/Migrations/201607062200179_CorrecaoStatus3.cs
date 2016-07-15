namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoStatus3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "StatusId", c => c.Int(nullable: false));
            AddColumn("dbo.Fabricante", "StatusId", c => c.Int(nullable: false));
            AddColumn("dbo.FuncaoUsuario", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Fornecedor", "StatusId");
            CreateIndex("dbo.Estoque", "StatusId");
            CreateIndex("dbo.Fabricante", "StatusId");
            CreateIndex("dbo.FuncaoUsuario", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FuncaoUsuario", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Fabricante", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Estoque", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Fornecedor", "StatusId", "dbo.Status");
            DropIndex("dbo.FuncaoUsuario", new[] { "StatusId" });
            DropIndex("dbo.Fabricante", new[] { "StatusId" });
            DropIndex("dbo.Estoque", new[] { "StatusId" });
            DropIndex("dbo.Fornecedor", new[] { "StatusId" });
            DropColumn("dbo.FuncaoUsuario", "StatusId");
            DropColumn("dbo.Fabricante", "StatusId");
            DropColumn("dbo.Fornecedor", "StatusId");
        }
    }
}
