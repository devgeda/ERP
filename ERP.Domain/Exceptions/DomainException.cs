namespace ERP.Domain.Exceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string mensagem) : base(mensagem)
        {

        }
    }
}
