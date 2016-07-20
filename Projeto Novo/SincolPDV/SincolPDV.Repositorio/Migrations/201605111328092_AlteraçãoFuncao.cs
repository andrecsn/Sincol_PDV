namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraçãoFuncao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FuncaoUsuario", "Descricao", c => c.String());
            DropColumn("dbo.FuncaoUsuario", "Funcao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FuncaoUsuario", "Funcao", c => c.String());
            DropColumn("dbo.FuncaoUsuario", "Descricao");
        }
    }
}
