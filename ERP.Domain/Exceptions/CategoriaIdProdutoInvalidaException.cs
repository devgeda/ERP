using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    public sealed class CategoriaIdProdutoInvalidaException : DomainException
    {
        public CategoriaIdProdutoInvalidaException() : base("Categoria do produto inválida.")
        {

        }
    }
}
