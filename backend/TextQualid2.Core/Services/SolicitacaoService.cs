
using Microsoft.EntityFrameworkCore;
using TextQualid2.Core.Data;
using TextQualid2.Core.Models;

namespace TextQualid2.Core.Services
{
    public class SolicitacaoService
    {
        private readonly TextQualid2Context _context;

        public SolicitacaoService(TextQualid2Context context)
        {
            _context = context;
        }

        public Solicitacao Criar(Solicitacao solicitacao)
        {
            solicitacao.Id = 0;
            solicitacao.Protocolo = $"TQ{DateTime.Now:yyyyMMddHHmmss}";
            solicitacao.Status = "Aberta";

            _context.Solicitacoes.Add(solicitacao);
            _context.SaveChanges();

            solicitacao.Protocolo += solicitacao.Id;

            _context.SaveChanges();

            return solicitacao;
        }

        public List<Solicitacao> ListarTodas()
        {
            return _context.Solicitacoes.ToList();
        }

        public Solicitacao? BuscarPorId(int id)
        {
            return _context.Solicitacoes
                .FirstOrDefault(s => s.Id == id);
        }

        public Solicitacao? BuscarPorProtocolo(string protocolo)
        {
            return _context.Solicitacoes
                .FirstOrDefault(s => s.Protocolo == protocolo);
        }

        public bool AtualizarStatus(int id, string status, string observacoes)
        {
            var solicitacao = BuscarPorId(id);

            if (solicitacao == null)
            {
                return false;
            }

            solicitacao.Status = status;
            solicitacao.Observacoes = observacoes;

            _context.SaveChanges();

            return true;
        }
    }
}
