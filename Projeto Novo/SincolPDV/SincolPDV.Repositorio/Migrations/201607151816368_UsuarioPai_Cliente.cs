namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioPai_Cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "UsuarioPaiID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "UsuarioPaiID");
        }
    }
}
