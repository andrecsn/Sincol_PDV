namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos_Status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produto", "StatusId");
            AddForeignKey("dbo.Produto", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            DropColumn("dbo.Produto", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Status", c => c.String());
            DropForeignKey("dbo.Produto", "StatusId", "dbo.Status");
            DropIndex("dbo.Produto", new[] { "StatusId" });
            DropColumn("dbo.Produto", "StatusId");
        }
    }
}
