using System.Text.Json.Serialization;

namespace ERP.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RegimeTributario
    {
        SIMPLES_NACIONAL,
        LUCRO_PRESUMIDO,
        LUCRO_REAL
    }
}
