using Ardalis.SmartEnum;

namespace ERP.Domain.Enums
{
    public sealed class Csosn : SmartEnum<Csosn, string>
    {
        public static readonly Csosn Csosn101 = new("Tributada pelo Simples Nacional com permissão de crédito", "101");
        public static readonly Csosn Csosn102 = new("Tributada pelo Simples Nacional sem permissão de crédito", "102");
        public static readonly Csosn Csosn103 = new("Isenção do ICMS no Simples Nacional para faixa de receita bruta", "103");
        public static readonly Csosn Csosn201 = new("Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por substituição tributária", "201");
        public static readonly Csosn Csosn202 = new("Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por substituição tributária", "202");
        public static readonly Csosn Csosn203 = new("Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do ICMS por substituição tributária", "203");
        public static readonly Csosn Csosn300 = new("Imune", "300");
        public static readonly Csosn Csosn400 = new("Não tributada pelo Simples Nacional", "400");
        public static readonly Csosn Csosn500 = new("ICMS cobrado anteriormente por substituição tributária(substituído)ou por antecipação", "500");
        public static readonly Csosn Csosn900 = new("Outros", "900");

        public string Codigo { get; } = string.Empty;
        public string Descricao { get; } = string.Empty;

        private Csosn(string descricao, string codigo) : base(descricao, codigo)
        {
        }
    }
}
