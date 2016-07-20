namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acertoCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "DtNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "DtNascimento", c => c.DateTime(nullable: false));
        }
    }
}
