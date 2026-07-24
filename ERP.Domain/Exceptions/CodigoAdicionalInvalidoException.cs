using ERP.Domain.Exceptions;

namespace ERP.Domain.Exceptions
{
    internal class CodigoAdicionalInvalidoException : DomainException
    {
        public CodigoAdicionalInvalidoException() : base("Código adicional inválido.")
        {

        }
    }
}
