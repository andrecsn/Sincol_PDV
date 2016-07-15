namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fornecedor : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Fornecedor", new[] { "dadosBancarios_DadosBancariosID" });
            RenameColumn(table: "dbo.Fornecedor", name: "dadosBancarios_DadosBancariosID", newName: "DadosBancariosID");
            AddColumn("dbo.Fornecedor", "DtCadastro", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Fornecedor", "DadosBancariosID", c => c.Int(nullable: false));
            CreateIndex("dbo.Fornecedor", "DadosBancariosID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Fornecedor", new[] { "DadosBancariosID" });
            AlterColumn("dbo.Fornecedor", "DadosBancariosID", c => c.Int());
            DropColumn("dbo.Fornecedor", "DtCadastro");
            RenameColumn(table: "dbo.Fornecedor", name: "DadosBancariosID", newName: "dadosBancarios_DadosBancariosID");
            CreateIndex("dbo.Fornecedor", "dadosBancarios_DadosBancariosID");
        }
    }
}
