using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    internal class ProdutoJaInativoException : DomainException
    {
        public ProdutoJaInativoException() : base("Produto já está inativo.")
        {

        }
    }
}
