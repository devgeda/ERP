namespace ERP.Domain.Entities
{
    public class Estoque
    {
        public Guid Id { get; private set; }

        public Produto Produto { get; private set; } = null!;
        public Localizacao Localizacao { get; private set; } = null!;
        public int Quantidade { get; private set; }
        public bool Ativo { get; private set; } = true;
    }
}
