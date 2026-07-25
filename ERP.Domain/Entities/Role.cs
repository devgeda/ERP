using ERP.Domain.Enums;

namespace ERP.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; private set; }

        public Roles UsuarioRole { get; private set; }
    }
}
