
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TextQualid2.Core.Data;
using TextQualid2.Core.Models;
using TextQualid2.Core.Services;
using Xunit;

namespace TextQualid2.Tests.XUnit
{
    public class SolicitacaoServiceTests : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly TextQualid2Context _context;
        private readonly SolicitacaoService _service;

        public SolicitacaoServiceTests()
        {
            _connection = new SqliteConnection("Data Source=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<TextQualid2Context>()
                .UseSqlite(_connection)
                .Options;

            _context = new TextQualid2Context(options);
            _context.Database.EnsureCreated();

            _service = new SolicitacaoService(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
            _connection.Dispose();
        }

        [Fact]
        public void Criar_DeveCadastrarSolicitacaoComStatusAberta()
        {
            var solicitacao = new Solicitacao
            {
                Nome = "Maria Silva",
                Matricula = "12345",
                Email = "maria@email.com",
                Categoria = "Acadêmico",
                Assunto = "Problema com matrícula",
                Descricao = "Não consigo acessar minha matrícula."
            };

            var resultado = _service.Criar(solicitacao);

            Assert.Equal(1, resultado.Id);
            Assert.NotEmpty(resultado.Protocolo);
            Assert.Equal("Aberta", resultado.Status);
        }

        [Fact]
        public void BuscarPorId_DeveRetornarSolicitacaoCadastrada()
        {
            var solicitacao = new Solicitacao
            {
                Nome = "João Santos",
                Categoria = "Financeiro",
                Assunto = "Boleto",
                Descricao = "Dúvida sobre pagamento."
            };

            _service.Criar(solicitacao);

            var resultado = _service.BuscarPorId(1);

            Assert.NotNull(resultado);
            Assert.Equal("João Santos", resultado.Nome);
        }

        [Fact]
        public void AtualizarStatus_DeveAlterarStatusDaSolicitacao()
        {
            var solicitacao = new Solicitacao
            {
                Nome = "Ana Souza",
                Categoria = "Acadêmico",
                Assunto = "Documentação",
                Descricao = "Solicitação de documento."
            };

            _service.Criar(solicitacao);

            var resultado = _service.AtualizarStatus(
                1,
                "Em andamento",
                "Solicitação em análise."
            );

            Assert.True(resultado);
            Assert.Equal("Em andamento", solicitacao.Status);
            Assert.Equal(
                "Solicitação em análise.",
                solicitacao.Observacoes
            );
        }
    }
}
