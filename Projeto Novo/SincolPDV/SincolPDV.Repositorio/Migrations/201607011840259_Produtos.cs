namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produto", "Fabricante_FabricanteID", "dbo.Fabricante");
            DropIndex("dbo.Produto", new[] { "Fabricante_FabricanteID" });
            RenameColumn(table: "dbo.Produto", name: "Fabricante_FabricanteID", newName: "FabricanteID");
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.MarcaID);
            
            AddColumn("dbo.Produto", "FornecedorID", c => c.Int(nullable: false));
            AddColumn("dbo.Produto", "MarcaID", c => c.Int(nullable: false));
            AlterColumn("dbo.Produto", "FabricanteID", c => c.Int(nullable: false));
            CreateIndex("dbo.Produto", "FabricanteID");
            CreateIndex("dbo.Produto", "FornecedorID");
            CreateIndex("dbo.Produto", "MarcaID");
            AddForeignKey("dbo.Produto", "FornecedorID", "dbo.Fornecedor", "FornecedorID", cascadeDelete: true);
            AddForeignKey("dbo.Produto", "MarcaID", "dbo.Marca", "MarcaID", cascadeDelete: true);
            AddForeignKey("dbo.Produto", "FabricanteID", "dbo.Fabricante", "FabricanteID", cascadeDelete: true);
            DropColumn("dbo.Produto", "Marca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Marca", c => c.String());
            DropForeignKey("dbo.Produto", "FabricanteID", "dbo.Fabricante");
            DropForeignKey("dbo.Produto", "MarcaID", "dbo.Marca");
            DropForeignKey("dbo.Produto", "FornecedorID", "dbo.Fornecedor");
            DropIndex("dbo.Produto", new[] { "MarcaID" });
            DropIndex("dbo.Produto", new[] { "FornecedorID" });
            DropIndex("dbo.Produto", new[] { "FabricanteID" });
            AlterColumn("dbo.Produto", "FabricanteID", c => c.Int());
            DropColumn("dbo.Produto", "MarcaID");
            DropColumn("dbo.Produto", "FornecedorID");
            DropTable("dbo.Marca");
            RenameColumn(table: "dbo.Produto", name: "FabricanteID", newName: "Fabricante_FabricanteID");
            CreateIndex("dbo.Produto", "Fabricante_FabricanteID");
            AddForeignKey("dbo.Produto", "Fabricante_FabricanteID", "dbo.Fabricante", "FabricanteID");
        }
    }
}
