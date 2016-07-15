namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        EstoqueID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.EstoqueID);
            
            AddColumn("dbo.Produto", "EstoqueID", c => c.Int(nullable: false));
            AddColumn("dbo.Produto", "DataCadastro", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Produto", "EstoqueID");
            AddForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque", "EstoqueID", cascadeDelete: true);
            DropColumn("dbo.Produto", "unSaida");
            DropColumn("dbo.Produto", "TipoSaida");
            DropColumn("dbo.Produto", "Origem");
            DropColumn("dbo.Produto", "dataInicio");
            DropColumn("dbo.Produto", "dataFinal");
            DropColumn("dbo.Produto", "Entrada");
            DropColumn("dbo.Produto", "Saida");
            DropColumn("dbo.Produto", "Emprestimo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Emprestimo", c => c.String());
            AddColumn("dbo.Produto", "Saida", c => c.String());
            AddColumn("dbo.Produto", "Entrada", c => c.String());
            AddColumn("dbo.Produto", "dataFinal", c => c.DateTime(nullable: false));
            AddColumn("dbo.Produto", "dataInicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Produto", "Origem", c => c.String());
            AddColumn("dbo.Produto", "TipoSaida", c => c.Int(nullable: false));
            AddColumn("dbo.Produto", "unSaida", c => c.String());
            DropForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque");
            DropIndex("dbo.Produto", new[] { "EstoqueID" });
            DropColumn("dbo.Produto", "DataCadastro");
            DropColumn("dbo.Produto", "EstoqueID");
            DropTable("dbo.Estoque");
        }
    }
}
