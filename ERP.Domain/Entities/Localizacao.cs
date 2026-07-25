namespace ERP.Domain.Entities
{
    public class Localizacao
    {
        public Guid Id { get; private set; }

        public string Codigo { get; private set; } = string.Empty;

        public string Prateleira { get; private set; } = string.Empty;
        public string Fileira { get; private set; } = string.Empty;
        public string Coluna { get; private set; } = string.Empty;
        public string? Caixa { get; private set; } = string.Empty;
        public bool Ativo { get; private set; }
    }
}
