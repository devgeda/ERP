namespace ERP.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }


        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Senha { get; private set; } = string.Empty;
        public bool Ativo { get; private set; } = true;
        public DateTime DataCriacao { get; }
        public DateTime DataAlteracao { get; }

        public List<Role> Roles { get; private set; } = null!;
    }
}
