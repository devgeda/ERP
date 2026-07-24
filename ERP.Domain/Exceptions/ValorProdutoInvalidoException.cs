using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    public sealed class ValorProdutoInvalidoException : DomainException
    {
        public ValorProdutoInvalidoException() : base("O valor do produto é inválido.")
        { }
    }
}
