
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TextQualid2.Core.Data;
using TextQualid2.Core.Models;
using TextQualid2.Core.Services;

namespace TextQualid2.Tests.NUnit
{
    public class SolicitacaoServiceTests
    {
        private SqliteConnection _connection = null!;
        private TextQualid2Context _context = null!;
        private SolicitacaoService _service = null!;

        [SetUp]
        public void SetUp()
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

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
            _connection.Dispose();
        }

        [Test]
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

            Assert.That(resultado.Id, Is.EqualTo(1));
            Assert.That(resultado.Protocolo, Is.Not.Empty);
            Assert.That(resultado.Status, Is.EqualTo("Aberta"));
        }

        [Test]
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

            Assert.That(resultado, Is.Not.Null);
            Assert.That(resultado!.Nome, Is.EqualTo("João Santos"));
        }

        [Test]
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

            Assert.That(resultado, Is.True);
            Assert.That(solicitacao.Status, Is.EqualTo("Em andamento"));
            Assert.That(
                solicitacao.Observacoes,
                Is.EqualTo("Solicitação em análise.")
            );
        }
    }
}
