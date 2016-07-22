namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntradaProduto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrada", "Fornecedor_FornecedorID", "dbo.Fornecedor");
            DropForeignKey("dbo.EntradaProduto", "Entrada_EntradaID", "dbo.Entrada");
            DropForeignKey("dbo.EntradaProduto", "Produto_ProdutoID", "dbo.Produto");
            DropIndex("dbo.Entrada", new[] { "Fornecedor_FornecedorID" });
            DropIndex("dbo.EntradaProduto", new[] { "Entrada_EntradaID" });
            DropIndex("dbo.EntradaProduto", new[] { "Produto_ProdutoID" });
            CreateTable(
                "dbo.EntradaProdutos",
                c => new
                    {
                        EntradaID = c.Int(nullable: false, identity: true),
                        CodigoBarras = c.Int(nullable: false),
                        ProdutoID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                        DtEntrada = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntradaID)
                .ForeignKey("dbo.Produto", t => t.ProdutoID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID)
                .Index(t => t.ProdutoID)
                .Index(t => t.UsuarioID);

            DropTable("Entrada");
            DropTable("EntradaProduto");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EntradaProduto",
                c => new
                    {
                        EntradaProdutoID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Entrada_EntradaID = c.Int(),
                        Produto_ProdutoID = c.Int(),
                    })
                .PrimaryKey(t => t.EntradaProdutoID);
            
            CreateTable(
                "dbo.Entrada",
                c => new
                    {
                        EntradaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        FormaPagamento = c.Int(nullable: false),
                        Vencimento = c.DateTime(nullable: false),
                        ValorParcela = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DtEntrada = c.DateTime(nullable: false),
                        Fornecedor_FornecedorID = c.Int(),
                    })
                .PrimaryKey(t => t.EntradaID);
            
            DropForeignKey("dbo.EntradaProdutos", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.EntradaProdutos", "ProdutoID", "dbo.Produto");
            DropIndex("dbo.EntradaProdutos", new[] { "UsuarioID" });
            DropIndex("dbo.EntradaProdutos", new[] { "ProdutoID" });
            DropTable("dbo.EntradaProdutos");
            CreateIndex("dbo.EntradaProduto", "Produto_ProdutoID");
            CreateIndex("dbo.EntradaProduto", "Entrada_EntradaID");
            CreateIndex("dbo.Entrada", "Fornecedor_FornecedorID");
            AddForeignKey("dbo.EntradaProduto", "Produto_ProdutoID", "dbo.Produto", "ProdutoID");
            AddForeignKey("dbo.EntradaProduto", "Entrada_EntradaID", "dbo.Entrada", "EntradaID");
            AddForeignKey("dbo.Entrada", "Fornecedor_FornecedorID", "dbo.Fornecedor", "FornecedorID");
        }
    }
}
