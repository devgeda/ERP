using ERP.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ERP.Domain.Converters
{
    public class CstCofinsJsonConverter : JsonConverter<CstCofins>
    {
        public override void Write(Utf8JsonWriter writer, CstCofins value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("codigo", value.Codigo);
            writer.WriteString("descricao", value.Descricao);
            writer.WriteString("grupo", value.Grupo);

            writer.WriteEndObject();
        }

        public override CstCofins Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? valor = reader.GetString();

            if (string.IsNullOrWhiteSpace(valor)) throw new JsonException("O valor do CstCofins não pode ser nulo ou vazio.");

            if (CstCofins.TryFromValue(valor, out var cstCofinsResultado))
            {
                return cstCofinsResultado;
            }

            throw new JsonException($"O código '{valor}' não é um CST COFINS válido cadastrado no sistema.");
        }
    }
}
