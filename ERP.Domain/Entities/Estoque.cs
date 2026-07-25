using System.Xml.Linq;

namespace ERP.Domain.Entities
{
    internal class Estoque
    {
        public Guid Id { get; private set; }

        private Produto produto;
        private Localizacao localizacao;
        private int quantidade = 0;
        public bool ativo = true;
    }
}
