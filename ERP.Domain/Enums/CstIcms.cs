using Ardalis.SmartEnum;

namespace ERP.Domain.Enums
{
    public sealed class CstIcms : SmartEnum<CstIcms, string>
    {
        public static readonly CstIcms Cst00 = new("Tributada integralmente", "00");
        public static readonly CstIcms Cst10 = new("Tributada e com cobrança do ICMS por substituição tributária", "10");
        public static readonly CstIcms Cst20 = new("Com redução de base de cálculo", "20");
        public static readonly CstIcms Cst30 = new("Isenta ou não tributada e com cobrança do ICMS por substituição tributária", "30");
        public static readonly CstIcms Cst40 = new("Isenta", "40"); 
        public static readonly CstIcms Cst41 = new("Não tributada", "41");
        public static readonly CstIcms Cst50 = new("Suspensão", "50");
        public static readonly CstIcms Cst51 = new("Diferimento", "51");
        public static readonly CstIcms Cst60 = new("ICMS cobrado anteriormente por substituição tributária", "60");
        public static readonly CstIcms Cst70 = new("Com redução de base de cálculo e cobrança do ICMS por substituição tributária", "70");
        public static readonly CstIcms Cst90 = new("Outras", "90");

        public string Codigo { get; } = string.Empty;
        public string Descricao { get; } = string.Empty;

        private CstIcms(string descricao, string codigo) : base(descricao, codigo)
        { 
        }

    }
}
