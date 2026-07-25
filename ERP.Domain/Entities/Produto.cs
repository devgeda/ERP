 using ERP.Domain.Enums;

namespace ERP.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; } = string.Empty;
        public string Codigo { get; private set; } = string.Empty;
        public string? CodigoAdicional { get; private set; }

        public decimal Valor { get; private set; }
        public decimal ValorPromocional { get; private set; }
        public bool Ativo { get; private set; } = true;

        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; } = null!;
        public string? Ncm { get; private set; }
        public string? Cest { get; private set; }
        public string? OrigemDoProduto { get; private set; }
        public CstIcms CstIcms { get; private set; } = null!;
        public Csosn Csosn { get; private set; } = null!;
        public CstPis CstPis { get; private set; } = null!;
        public CstCofins CstCofins { get; private set; } = null!;
        public decimal? AliquotaIcms { get; private set; }
        public decimal? AliquotaPis { get; private set; }
        public decimal? AliquotaCofins { get; private set; }
        public decimal? AliquotaIpi { get; private set; }
        public decimal? AliquotaFcp { get; private set; }
        public decimal? IvaSt { get; private set; }
        public CfopInterno CfopInterno { get; private set; } = null!;
        public CfopInterestadual CfopInterestadual { get; private set; } = null!;

        public Produto(string nome, string codigo, string? codigoAdicional, decimal valor, decimal valorPromocional, Guid categoriaId)
        {
            Id = Guid.NewGuid();

        }


    }
}