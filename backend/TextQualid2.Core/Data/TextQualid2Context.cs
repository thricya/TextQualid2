
using Microsoft.EntityFrameworkCore;
using TextQualid2.Core.Models;

namespace TextQualid2.Core.Data
{
    public class TextQualid2Context : DbContext
    {
        public TextQualid2Context(DbContextOptions<TextQualid2Context> options)
            : base(options)
        {
        }

        public DbSet<Solicitacao> Solicitacoes { get; set; }
    }
}
