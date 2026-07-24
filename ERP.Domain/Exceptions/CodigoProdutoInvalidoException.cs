using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    public sealed class CodigoProdutoInvalidoException : DomainException
    {
        public CodigoProdutoInvalidoException() : base("O código do produto é inválido.")
        { }
    }
}
