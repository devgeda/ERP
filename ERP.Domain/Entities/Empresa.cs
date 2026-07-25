using ERP.Domain.Enums;

namespace ERP.Domain.Entities
{
    public class Empresa
    {
        public Guid Id;

        public string Nome;
        public string TipoDeEmpresa;

        public RegimeTributario Crt;
        public Estado Estado;
        public string Cnae;
        public string InscricaoEstadual;
        public bool IsentoInscricaoEstadual;

        public Empresa()
        {
        }

    }
}
