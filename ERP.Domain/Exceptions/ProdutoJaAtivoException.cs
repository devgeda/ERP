using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    public sealed class ProdutoJaAtivoException : DomainException
    {
        public ProdutoJaAtivoException() : base("O produto já está ativo.")
        {

        }
    }
}