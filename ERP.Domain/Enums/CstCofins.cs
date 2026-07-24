using Ardalis.SmartEnum;
using ERP.Domain.Converters;
using System.Text.Json.Serialization;

namespace ERP.Domain.Enums
{
    [JsonConverter(typeof(CstCofinsJsonConverter))]
    public sealed class CstCofins : SmartEnum<CstCofins, string>
    {
        public static readonly CstCofins Cst01 = new("Operação Tributável com Alíquota Básica", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "01");
        public static readonly CstCofins Cst02 = new("Operação Tributável com Alíquota Diferenciada", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "02");
        public static readonly CstCofins Cst03 = new("Operação Tributável com Alíquota por Unidade de Medida de Produto", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "03");
        public static readonly CstCofins Cst04 = new("Operação Tributável Monofásica (Alíquota Zero)", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "04");
        public static readonly CstCofins Cst05 = new("Operação Tributável por Substituição Tributária", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "05");
        public static readonly CstCofins Cst06 = new("Operação Tributável com Alíquota Zero", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "06");
        public static readonly CstCofins Cst07 = new("Operação Isenta da Contribuição", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "07");
        public static readonly CstCofins Cst08 = new("Operação Sem Incidência da Contribuição", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "08");
        public static readonly CstCofins Cst09 = new("Operação com Suspensão da Contribuição", "Operações de Saída (Contribuição Cumulativa e Não Cumulativa)", "09");

        // Operações de Crédito (Entrada)
        public static readonly CstCofins Cst50 = new("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno", "Operações de Crédito (Entrada)", "50");
        public static readonly CstCofins Cst51 = new("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno", "Operações de Crédito (Entrada)", "51");
        public static readonly CstCofins Cst52 = new("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação", "Operações de Crédito (Entrada)", "52");
        public static readonly CstCofins Cst53 = new("Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não Tributadas no Mercado Interno", "Operações de Crédito (Entrada)", "53");
        public static readonly CstCofins Cst54 = new("Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação", "Operações de Crédito (Entrada)", "54");
        public static readonly CstCofins Cst55 = new("Operação com Direito a Crédito - Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação", "Operações de Crédito (Entrada)", "55");
        public static readonly CstCofins Cst56 = new("Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não Tributadas no Mercado Interno, e de Exportação", "Operações de Crédito (Entrada)", "56");
        public static readonly CstCofins Cst60 = new("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno", "Operações de Crédito (Entrada)", "60");
        public static readonly CstCofins Cst61 = new("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno", "Operações de Crédito (Entrada)", "61");
        public static readonly CstCofins Cst62 = new("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação", "Operações de Crédito (Entrada)", "62");
        public static readonly CstCofins Cst63 = new("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não Tributadas no Mercado Interno", "Operações de Crédito (Entrada)", "63");
        public static readonly CstCofins Cst64 = new("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação", "Operações de Crédito (Entrada)", "64");
        public static readonly CstCofins Cst65 = new("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação", "Operações de Crédito (Entrada)", "65");
        public static readonly CstCofins Cst66 = new("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não Tributadas no Mercado Interno, e de Exportação", "Operações de Crédito (Entrada)", "66");
        public static readonly CstCofins Cst67 = new("Crédito Presumido - Outras Operações", "Operações de Crédito (Entrada)", "67");

        // Outras Operações
        public static readonly CstCofins Cst49 = new("Outras Operações de Saída", "Outras Operações", "49");
        public static readonly CstCofins Cst70 = new("Operação de Aquisição sem Direito a Crédito", "Outras Operações", "70");
        public static readonly CstCofins Cst71 = new("Operação de Aquisição com Isenção", "Outras Operações", "71");
        public static readonly CstCofins Cst72 = new("Operação de Aquisição com Suspensão", "Outras Operações", "72");
        public static readonly CstCofins Cst73 = new("Operação de Aquisição a Alíquota Zero", "Outras Operações", "73");
        public static readonly CstCofins Cst74 = new("Operação de Aquisição sem Incidência da Contribuição", "Outras Operações", "74");
        public static readonly CstCofins Cst75 = new("Operação de Aquisição por Substituição Tributária", "Outras Operações", "75");
        public static readonly CstCofins Cst98 = new("Outras Operações de Entrada", "Outras Operações", "98");
        public static readonly CstCofins Cst99 = new("Outras Operações", "Outras Operações", "99");

        public string Descricao { get; } = string.Empty;
        public string Grupo { get; } = string.Empty;
        public string Codigo { get; } = string.Empty;

        private CstCofins(string descricao, string grupo, string codigo) : base(descricao, codigo)
        {
            Grupo = grupo;
        }
    }
}
