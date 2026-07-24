using Ardalis.SmartEnum;
using ERP.Domain.Converters;
using System.Text.Json.Serialization;

namespace ERP.Domain.Enums
{
    [JsonConverter(typeof(CfopInternoJsonConverter))]
    public class CfopInterno : SmartEnum<CfopInterno, string>
    {
        // Principais CFOPs Internos de Saída (Dentro do Estado)
        public static readonly CfopInterno Cfop5101 = new("Venda de produção do estabelecimento", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5101");
        public static readonly CfopInterno Cfop5102 = new("Venda de mercadoria adquirida de terceiros", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5102");
        public static readonly CfopInterno Cfop5103 = new("Venda de produção efetuada fora do estabelecimento", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5103");
        public static readonly CfopInterno Cfop5401 = new("Venda de produção com substituição tributária (ST)", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5401");
        public static readonly CfopInterno Cfop5403 = new("Venda de mercadoria adquirida de terceiros com ST", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5403");
        public static readonly CfopInterno Cfop5405 = new("Venda de mercadoria adquirida de terceiros com ST (substituído)", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5405");
        public static readonly CfopInterno Cfop5910 = new("Remessa em bonificação, doação ou brinde", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5910");
        public static readonly CfopInterno Cfop5915 = new("Remessa para conserto ou reparo", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5915");
        public static readonly CfopInterno Cfop5949 = new("Outra saída de mercadoria ou prestação de serviço não especificada", "Principais CFOPs Internos de Saída (Dentro do Estado)", "5949");

        // Principais CFOPs Internos de Entrada (Dentro do Estado)
        public static readonly CfopInterno Cfop1101 = new("Compra para industrialização", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1101");
        public static readonly CfopInterno Cfop1102 = new("Compra para comercialização", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1102");
        public static readonly CfopInterno Cfop1401 = new("Compra para industrialização de mercadoria sujeita a ST", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1401");
        public static readonly CfopInterno Cfop1403 = new("Compra para comercialização de mercadoria sujeita a ST", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1403");
        public static readonly CfopInterno Cfop1556 = new("Compra de material para uso ou consumo", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1556");
        public static readonly CfopInterno Cfop1904 = new("Retorno de remessa para venda fora do estabelecimento", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1904");
        public static readonly CfopInterno Cfop1949 = new("Outra entrada de mercadoria ou prestação de serviço não especificada", "Principais CFOPs Internos de Entrada (Dentro do Estado)", "1949");

        public string Descricao { get; private set; } = string.Empty;
        public string Grupo { get; private set; } = string.Empty;
        public string Codigo { get; private set; } = string.Empty;

        private CfopInterno(string descricao, string grupo, string codigo) : base(descricao, codigo)
        {
            Grupo = grupo;
        }
    }
}
