using ERP.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ERP.Domain.Converters
{
    public class CfopInternoJsonConverter : JsonConverter<CfopInterno>
    {
        public override void Write(Utf8JsonWriter writer, CfopInterno value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("codigo", value.Codigo);
            writer.WriteString("descricao", value.Descricao);
            writer.WriteString("grupo", value.Grupo);

            writer.WriteEndObject();
        }

        public override CfopInterno Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? valor = reader.GetString();

            if (string.IsNullOrWhiteSpace(valor)) throw new JsonException("O valor do CfopInterno não pode ser nulo ou vazio.");

            if (CfopInterno.TryFromValue(valor, out var cfopInternoResultado))
            {
                return cfopInternoResultado;
            }

            throw new JsonException($"O código '{valor}' não é um CFOP Interno válido cadastrado no sistema.");
        }
    }
}
