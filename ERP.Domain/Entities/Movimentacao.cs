using ERP.Domain.Enums;

namespace ERP.Domain.Entities
{
    public class Movimentacao
    {
        public Guid Id { get; private set; }

        public Estoque EstoqueEntrada { get; } = null!;
        public Estoque EstoqueSaida { get; } = null!;
        public Usuario Usuario { get; } = null!;
        public TipoMovimentacao TipoMovimentacao { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime DataDaMovimentacao { get; }
        public string? Descricao { get; private set; }

    }
}
