using ERP.Domain.Enums;
using ERP.Domain.Exceptions;

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
        public string? Cest { get; set; }
        public string? OrigemDoProduto { get; set; }
        public CstIcms CstIcms { get; private set; } = null!;
        public Csosn Csosn { get; set; } = null!;
        public CstPis CstPis { get; set; } = null!;
        public CstCofins CstCofins { get; set; } = null!;
        public decimal? AliquotaIcms { get; set; }
        public decimal? AliquotaPis { get; set; }
        public decimal? AliquotaCofins { get; set; }
        public decimal? AliquotaIpi { get; set; }
        public decimal? AliquotaFcp { get; set; }
        public decimal? IvaSt { get; set; }
        public CfopInterno CfopInterno { get; set; } = null!;
        public CfopInterestadual CfopInterestadual { get; set; } = null!;

        public Produto(string nome, string codigo, string? codigoAdicional, decimal valor, decimal valorPromocional, Guid categoriaId)
        {
            Id = Guid.NewGuid();
            AlterarNome(nome);
            AlterarCodigo(codigo);
            AlterarCodigoAdicional(codigoAdicional);
            AlterarValor(valor);
            AlterarValorPromocional(valorPromocional);
            AlterarCategoriaId(categoriaId);

        }

        private static void ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new NomeProdutoInvalidoException();
        }

        public void AlterarNome(string nome)
        {
            ValidarNome(nome);
            Nome = nome;
        }

        private static void ValidarCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) throw new CodigoProdutoInvalidoException();

        }

        public void AlterarCodigo(string codigo)
        {
            ValidarCodigo(codigo);
            Codigo = codigo;
        }

        private static void ValidarCodigoAdicional(string? codigoAdicional)
        {
            if (string.IsNullOrWhiteSpace(codigoAdicional))
            {
                throw new CodigoAdicionalInvalidoException();
            }
        }

        public void AlterarCodigoAdicional(string? codigoAdicional)
        {
            ValidarCodigoAdicional(codigoAdicional);
            CodigoAdicional = codigoAdicional;
        }

        private static void ValidarValor(decimal valor)
        {
            if (valor < 0) throw new ValorProdutoInvalidoException();
        }

        public void AlterarValor(decimal valor)
        {
            ValidarValor(valor);
            Valor = valor;
        }

        public static void ValidarValorPromocional(decimal valorPromocional)
        {
            if (valorPromocional < 0) throw new ValorProdutoInvalidoException();
        }

        public void AlterarValorPromocional(decimal valorPromocional)
        {
            ValidarValorPromocional(valorPromocional);
            ValorPromocional = valorPromocional;
        }

        public void Ativar(bool ativo)
        {
            if (Ativo) throw new ProdutoJaAtivoException();

            Ativo = ativo;
        }

        public void Desativar(bool ativo)
        {
            if (!Ativo) throw new ProdutoJaInativoException();

            Ativo = ativo;
        }

        private static void ValidarCategoriaId(Guid categoriaId)
        {
            if (categoriaId == Guid.Empty) throw new CategoriaIdProdutoInvalidaException();
        }

        public void AlterarCategoriaId(Guid categoriaId)
        {
            ValidarCategoriaId(categoriaId);
            CategoriaId = categoriaId;
        }


    }
}