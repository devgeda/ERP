using ERP.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ERP.Domain.Converters
{
    internal class CfopInterestadualJsonConverter : JsonConverter<CfopInterestadual>
    {
        public override void Write(Utf8JsonWriter writer, CfopInterestadual value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("codigo", value.Codigo);
            writer.WriteString("descricao", value.Descricao);
            writer.WriteString("grupo", value.Grupo);

            writer.WriteEndObject();
        }

        public override CfopInterestadual Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? valor = reader.GetString();

            if (string.IsNullOrWhiteSpace(valor)) throw new JsonException("O valor do CfopInterestadual não pode ser nulo ou vazio.");

            if (CfopInterestadual.TryFromValue(valor, out var cfopInterestadualResultado))
            {
                return cfopInterestadualResultado;
            }

            throw new JsonException($"O código '{valor}' não é um CFOP Interestadual válido cadastrado no sistema.");
        }
    }
}
