namespace ERP.Domain.Exceptions
{
    internal class NomeCategoriaInvalidoException : DomainException
    {
        public NomeCategoriaInvalidoException() : base("Nome da categoria inválido.")
        {
        }
    }
}
