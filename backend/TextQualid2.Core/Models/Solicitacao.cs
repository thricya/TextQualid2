namespace TextQualid2.Core.Models
{
    public class Solicitacao
    {
        public int Id { get; set; }

        public string Protocolo { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public string Matricula { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public string Status { get; set; } = "Aberta";

        public string Observacoes { get; set; } = string.Empty;
    }
}