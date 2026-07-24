using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    public sealed class NomeProdutoInvalidoException : DomainException
    {
        public NomeProdutoInvalidoException() : base("O nome do produto é inválido.")
        {

        }
    }
}
