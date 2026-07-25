using Ardalis.SmartEnum;
using ERP.Domain.Converters;
using System.Text.Json.Serialization;

namespace ERP.Domain.Enums
{
    [JsonConverter(typeof(CfopInterestadualJsonConverter))]
    public class CfopInterestadual : SmartEnum<CfopInterestadual, string>
    {
        // Principais CFOPs Interestaduais de Saída (Para outro Estado)
        public static readonly CfopInterestadual CfopInterestadual6101 = new("Venda de produção do estabelecimento", "CFOPs Interestaduais de Saída (Para outro Estado)", "6101");
        public static readonly CfopInterestadual CfopInterestadual6102 = new("Venda de mercadoria adquirida de terceiros", "CFOPs Interestaduais de Saída (Para outro Estado)", "6102");
        public static readonly CfopInterestadual CfopInterestadual6103 = new("Venda de produção efetuada fora do estabelecimento", "CFOPs Interestaduais de Saída (Para outro Estado)", "6103");
        public static readonly CfopInterestadual CfopInterestadual6401 = new("Venda de produção com substituição tributária (ST)", "CFOPs Interestaduais de Saída (Para outro Estado)", "6401");
        public static readonly CfopInterestadual CfopInterestadual6403 = new("Venda de mercadoria adquirida de terceiros com ST", "CFOPs Interestaduais de Saída (Para outro Estado)", "6403");
        public static readonly CfopInterestadual CfopInterestadual6404 = new("Venda de mercadoria adquirida de terceiros com ST (substituído)", "CFOPs Interestaduais de Saída (Para outro Estado)", "6404");
        public static readonly CfopInterestadual CfopInterestadual6910 = new("Remessa em bonificação, doação ou brinde", "CFOPs Interestaduais de Saída (Para outro Estado)", "6910");
        public static readonly CfopInterestadual CfopInterestadual6915 = new("Remessa para conserto ou reparo", "CFOPs Interestaduais de Saída (Para outro Estado)", "6915");
        public static readonly CfopInterestadual CfopInterestadual6949 = new("Outra saída de mercadoria ou prestação de serviço não especificada", "CFOPs Interestaduais de Saída (Para outro Estado)", "6949");

        // Principais CFOPs Interestaduais de Entrada (De outro Estado)
        public static readonly CfopInterestadual CfopInterestadual2101 = new("Compra para industrialização", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2101");
        public static readonly CfopInterestadual CfopInterestadual2102 = new("Compra para comercialização", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2102");
        public static readonly CfopInterestadual CfopInterestadual2401 = new("Compra para industrialização de mercadoria sujeita a ST", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2401");
        public static readonly CfopInterestadual CfopInterestadual2403 = new("Compra para comercialização de mercadoria sujeita a ST", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2403");
        public static readonly CfopInterestadual CfopInterestadual2556 = new("Compra de material para uso ou consumo", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2556");
        public static readonly CfopInterestadual CfopInterestadual2904 = new("Retorno de remessa para venda fora do estabelecimento", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2904");
        public static readonly CfopInterestadual CfopInterestadual2949 = new("Outra entrada de mercadoria ou prestação de serviço não especificada ;", "Principais CFOPs Interestaduais de Entrada (De outro Estado)", "2949");

        public string Descricao { get; } = string.Empty;
        public string Grupo { get; } = string.Empty;
        public string Codigo { get; } = string.Empty;

        private CfopInterestadual(string descricao, string grupo, string codigo) : base(descricao, codigo)
        {
            Grupo = grupo;
        }
    }
}
