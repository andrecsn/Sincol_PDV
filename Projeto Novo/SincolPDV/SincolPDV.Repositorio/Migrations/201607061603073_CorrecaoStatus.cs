namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fornecedor", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Estoque", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Fabricante", "StatusId", "dbo.Status");
            DropForeignKey("dbo.FuncaoUsuario", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Cliente", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque");
            DropForeignKey("dbo.Produto", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Marca", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Usuario", "FuncaoUsuarioID", "dbo.FuncaoUsuario");
            DropForeignKey("dbo.Usuario", "PerfilAcessoID", "dbo.PerfilAcesso");
            DropForeignKey("dbo.Usuario", "StatusId", "dbo.Status");
            DropIndex("dbo.Fornecedor", new[] { "StatusId" });
            DropIndex("dbo.Estoque", new[] { "StatusId" });
            DropIndex("dbo.Fabricante", new[] { "StatusId" });
            DropIndex("dbo.Marca", new[] { "StatusId" });
            DropIndex("dbo.FuncaoUsuario", new[] { "StatusId" });
            RenameColumn(table: "dbo.Marca", name: "StatusId", newName: "Status_StatusId");
            AlterColumn("dbo.Marca", "Status_StatusId", c => c.Int());
            CreateIndex("dbo.Marca", "Status_StatusId");
            AddForeignKey("dbo.Cliente", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque", "EstoqueID");
            AddForeignKey("dbo.Produto", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Marca", "Status_StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Usuario", "FuncaoUsuarioID", "dbo.FuncaoUsuario", "FuncaoUsuarioID");
            AddForeignKey("dbo.Usuario", "PerfilAcessoID", "dbo.PerfilAcesso", "PerfilAcessoID");
            AddForeignKey("dbo.Usuario", "StatusId", "dbo.Status", "StatusId");
            DropColumn("dbo.Fornecedor", "StatusId");
            DropColumn("dbo.Fabricante", "StatusId");
            DropColumn("dbo.FuncaoUsuario", "StatusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FuncaoUsuario", "StatusId", c => c.Int(nullable: false));
            AddColumn("dbo.Fabricante", "StatusId", c => c.Int(nullable: false));
            AddColumn("dbo.Fornecedor", "StatusId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Usuario", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Usuario", "PerfilAcessoID", "dbo.PerfilAcesso");
            DropForeignKey("dbo.Usuario", "FuncaoUsuarioID", "dbo.FuncaoUsuario");
            DropForeignKey("dbo.Marca", "Status_StatusId", "dbo.Status");
            DropForeignKey("dbo.Produto", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque");
            DropForeignKey("dbo.Cliente", "StatusId", "dbo.Status");
            DropIndex("dbo.Marca", new[] { "Status_StatusId" });
            AlterColumn("dbo.Marca", "Status_StatusId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Marca", name: "Status_StatusId", newName: "StatusId");
            CreateIndex("dbo.FuncaoUsuario", "StatusId");
            CreateIndex("dbo.Marca", "StatusId");
            CreateIndex("dbo.Fabricante", "StatusId");
            CreateIndex("dbo.Estoque", "StatusId");
            CreateIndex("dbo.Fornecedor", "StatusId");
            AddForeignKey("dbo.Usuario", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Usuario", "PerfilAcessoID", "dbo.PerfilAcesso", "PerfilAcessoID", cascadeDelete: true);
            AddForeignKey("dbo.Usuario", "FuncaoUsuarioID", "dbo.FuncaoUsuario", "FuncaoUsuarioID", cascadeDelete: true);
            AddForeignKey("dbo.Marca", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Produto", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Produto", "EstoqueID", "dbo.Estoque", "EstoqueID", cascadeDelete: true);
            AddForeignKey("dbo.Cliente", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.FuncaoUsuario", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Fabricante", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Estoque", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
            AddForeignKey("dbo.Fornecedor", "StatusId", "dbo.Status", "StatusId", cascadeDelete: true);
        }
    }
}
