namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoStatus2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Marca", new[] { "Status_StatusId" });
            RenameColumn(table: "dbo.Marca", name: "Status_StatusId", newName: "StatusId");
            AlterColumn("dbo.Marca", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Marca", "StatusId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Marca", new[] { "StatusId" });
            AlterColumn("dbo.Marca", "StatusId", c => c.Int());
            RenameColumn(table: "dbo.Marca", name: "StatusId", newName: "Status_StatusId");
            CreateIndex("dbo.Marca", "Status_StatusId");
        }
    }
}
