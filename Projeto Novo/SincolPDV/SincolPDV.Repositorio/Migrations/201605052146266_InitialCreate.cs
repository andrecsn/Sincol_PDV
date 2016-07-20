namespace SincolPDV.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        tp_pessoa = c.String(),
                        StatusId = c.Int(nullable: false),
                        CPF = c.String(),
                        CNPJ = c.String(),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        Sexo = c.String(),
                        DtNascimento = c.DateTime(nullable: false),
                        Email = c.String(),
                        DtCadastro = c.DateTime(nullable: false),
                        DtAtualizacao = c.DateTime(nullable: false),
                        LimiteCredito = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LimiteDias = c.Int(nullable: false),
                        Observacao = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.CRM",
                c => new
                    {
                        CrmID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Assunto = c.String(),
                        Texto = c.String(),
                        Resolvido = c.Boolean(nullable: false),
                        DtSolucao = c.DateTime(nullable: false),
                        Solucao = c.String(),
                        Cliente_ClienteID = c.Int(),
                        Fornecedor_FornecedorID = c.Int(),
                    })
                .PrimaryKey(t => t.CrmID)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteID)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_FornecedorID)
                .Index(t => t.Cliente_ClienteID)
                .Index(t => t.Fornecedor_FornecedorID);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        FornecedorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Status = c.Int(nullable: false),
                        Pessoa = c.String(),
                        CPF = c.String(),
                        CNPJ = c.String(),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        Email = c.String(),
                        Observacao = c.String(),
                        dadosBancarios_DadosBancariosID = c.Int(),
                    })
                .PrimaryKey(t => t.FornecedorID)
                .ForeignKey("dbo.DadosBancarios", t => t.dadosBancarios_DadosBancariosID)
                .Index(t => t.dadosBancarios_DadosBancariosID);
            
            CreateTable(
                "dbo.DadosBancarios",
                c => new
                    {
                        DadosBancariosID = c.Int(nullable: false, identity: true),
                        Banco = c.String(),
                        Agencia = c.Int(nullable: false),
                        Conta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DadosBancariosID);
            
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
                .PrimaryKey(t => t.EntradaID)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_FornecedorID)
                .Index(t => t.Fornecedor_FornecedorID);
            
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
                .PrimaryKey(t => t.EntradaProdutoID)
                .ForeignKey("dbo.Entrada", t => t.Entrada_EntradaID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .Index(t => t.Entrada_EntradaID)
                .Index(t => t.Produto_ProdutoID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Referencia = c.String(),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Status = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Imagem = c.String(),
                        unEntrada = c.String(),
                        Fator = c.Int(nullable: false),
                        unSaida = c.String(),
                        precoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstoqueMinimo = c.Int(nullable: false),
                        EstoqueMaximo = c.Int(nullable: false),
                        ValorTabela = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacao = c.String(),
                        TipoSaida = c.Int(nullable: false),
                        Origem = c.String(),
                        Peso = c.String(),
                        dataInicio = c.DateTime(nullable: false),
                        dataFinal = c.DateTime(nullable: false),
                        Entrada = c.String(),
                        Saida = c.String(),
                        Emprestimo = c.String(),
                        Fabricante_FabricanteID = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Fabricante", t => t.Fabricante_FabricanteID)
                .Index(t => t.Fabricante_FabricanteID);
            
            CreateTable(
                "dbo.Fabricante",
                c => new
                    {
                        FabricanteID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.FabricanteID);
            
            CreateTable(
                "dbo.FuncaoUsuario",
                c => new
                    {
                        FuncaoUsuarioID = c.Int(nullable: false, identity: true),
                        Funcao = c.String(),
                    })
                .PrimaryKey(t => t.FuncaoUsuarioID);
            
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        InventarioID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.InventarioID);
            
            CreateTable(
                "dbo.InventarioProduto",
                c => new
                    {
                        InventarioProdutoID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Produto_ProdutoID = c.Int(),
                        Inventario_InventarioID = c.Int(),
                    })
                .PrimaryKey(t => t.InventarioProdutoID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .ForeignKey("dbo.Inventario", t => t.Inventario_InventarioID)
                .Index(t => t.Produto_ProdutoID)
                .Index(t => t.Inventario_InventarioID);
            
            CreateTable(
                "dbo.PerfilAcesso",
                c => new
                    {
                        PerfilAcessoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        PerfilTransacao_PerfilTransacaoID = c.Int(),
                    })
                .PrimaryKey(t => t.PerfilAcessoID)
                .ForeignKey("dbo.PerfilTransacao", t => t.PerfilTransacao_PerfilTransacaoID)
                .Index(t => t.PerfilTransacao_PerfilTransacaoID);
            
            CreateTable(
                "dbo.PerfilTransacao",
                c => new
                    {
                        PerfilTransacaoID = c.Int(nullable: false, identity: true),
                        Consultar = c.Boolean(nullable: false),
                        Visualizar = c.Boolean(nullable: false),
                        Excluir = c.Boolean(nullable: false),
                        Alterar = c.Boolean(nullable: false),
                        Incluir = c.Boolean(nullable: false),
                        Imprimir = c.Boolean(nullable: false),
                        Processar = c.Boolean(nullable: false),
                        Liberar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PerfilTransacaoID);
            
            CreateTable(
                "dbo.Saida",
                c => new
                    {
                        SaidaID = c.Int(nullable: false, identity: true),
                        Tabela = c.String(),
                        ModoPagamento = c.String(),
                        Vencimento = c.String(),
                        GtdParcelas = c.String(),
                        valor2 = c.String(),
                        ParcelasFaltantes = c.String(),
                    })
                .PrimaryKey(t => t.SaidaID);
            
            CreateTable(
                "dbo.Transacao",
                c => new
                    {
                        TransacaoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TransacaoID);
            
            CreateTable(
                "dbo.Transferencia",
                c => new
                    {
                        TransferenciaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Quantidade = c.Int(nullable: false),
                        LojaSaida = c.Int(nullable: false),
                        LojaEntrada = c.Int(nullable: false),
                        DtTransferencia = c.DateTime(nullable: false),
                        Produto_ProdutoID = c.Int(),
                    })
                .PrimaryKey(t => t.TransferenciaID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .Index(t => t.Produto_ProdutoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        StatusId = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Funcao_FuncaoUsuarioID = c.Int(),
                        PerfilAcesso_PerfilAcessoID = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .ForeignKey("dbo.FuncaoUsuario", t => t.Funcao_FuncaoUsuarioID)
                .ForeignKey("dbo.PerfilAcesso", t => t.PerfilAcesso_PerfilAcessoID)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId)
                .Index(t => t.Funcao_FuncaoUsuarioID)
                .Index(t => t.PerfilAcesso_PerfilAcessoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Usuario", "PerfilAcesso_PerfilAcessoID", "dbo.PerfilAcesso");
            DropForeignKey("dbo.Usuario", "Funcao_FuncaoUsuarioID", "dbo.FuncaoUsuario");
            DropForeignKey("dbo.Transferencia", "Produto_ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.PerfilAcesso", "PerfilTransacao_PerfilTransacaoID", "dbo.PerfilTransacao");
            DropForeignKey("dbo.InventarioProduto", "Inventario_InventarioID", "dbo.Inventario");
            DropForeignKey("dbo.InventarioProduto", "Produto_ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.EntradaProduto", "Produto_ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Produto", "Fabricante_FabricanteID", "dbo.Fabricante");
            DropForeignKey("dbo.EntradaProduto", "Entrada_EntradaID", "dbo.Entrada");
            DropForeignKey("dbo.Entrada", "Fornecedor_FornecedorID", "dbo.Fornecedor");
            DropForeignKey("dbo.CRM", "Fornecedor_FornecedorID", "dbo.Fornecedor");
            DropForeignKey("dbo.Fornecedor", "dadosBancarios_DadosBancariosID", "dbo.DadosBancarios");
            DropForeignKey("dbo.CRM", "Cliente_ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Cliente", "StatusId", "dbo.Status");
            DropIndex("dbo.Usuario", new[] { "PerfilAcesso_PerfilAcessoID" });
            DropIndex("dbo.Usuario", new[] { "Funcao_FuncaoUsuarioID" });
            DropIndex("dbo.Usuario", new[] { "StatusId" });
            DropIndex("dbo.Transferencia", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.PerfilAcesso", new[] { "PerfilTransacao_PerfilTransacaoID" });
            DropIndex("dbo.InventarioProduto", new[] { "Inventario_InventarioID" });
            DropIndex("dbo.InventarioProduto", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.Produto", new[] { "Fabricante_FabricanteID" });
            DropIndex("dbo.EntradaProduto", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.EntradaProduto", new[] { "Entrada_EntradaID" });
            DropIndex("dbo.Entrada", new[] { "Fornecedor_FornecedorID" });
            DropIndex("dbo.Fornecedor", new[] { "dadosBancarios_DadosBancariosID" });
            DropIndex("dbo.CRM", new[] { "Fornecedor_FornecedorID" });
            DropIndex("dbo.CRM", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Cliente", new[] { "StatusId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Transferencia");
            DropTable("dbo.Transacao");
            DropTable("dbo.Saida");
            DropTable("dbo.PerfilTransacao");
            DropTable("dbo.PerfilAcesso");
            DropTable("dbo.InventarioProduto");
            DropTable("dbo.Inventario");
            DropTable("dbo.FuncaoUsuario");
            DropTable("dbo.Fabricante");
            DropTable("dbo.Produto");
            DropTable("dbo.EntradaProduto");
            DropTable("dbo.Entrada");
            DropTable("dbo.DadosBancarios");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.CRM");
            DropTable("dbo.Status");
            DropTable("dbo.Cliente");
        }
    }
}
