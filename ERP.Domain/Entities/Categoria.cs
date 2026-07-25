using ERP.Domain.Exceptions;

namespace ERP.Domain.Entities
{
    public class Categoria
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; } = string.Empty;
        public bool Ativo { get; private set; } = true;

        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            AlterarNome(nome);
        }

        private static void ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new NomeCategoriaInvalidoException();
        }

        public void AlterarNome(string nome)
        {
            ValidarNome(nome);
            Nome = nome;
        }

        public void Ativar(bool ativo)
        {
            if (Ativo) throw new CategoriaJaAtivoException();

            Ativo = ativo;
        }

        public void Desativar(bool ativo)
        {
            if (!Ativo) throw new CategoriaJaInativoException();

            Ativo = ativo;
        }
    }

}