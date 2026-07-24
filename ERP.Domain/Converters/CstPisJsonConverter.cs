using ERP.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ERP.Domain.Converters
{
    public class CstPisJsonConverter : JsonConverter<CstPis>
    {
        public override void Write(Utf8JsonWriter writer, CstPis value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("codigo", value.Codigo);
            writer.WriteString("descricao", value.Descricao);
            writer.WriteString("grupo", value.Grupo);

            writer.WriteEndObject();
        }

        public override CstPis Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? valor = reader.GetString();

            if (string.IsNullOrWhiteSpace(valor)) throw new JsonException("O valor do CstPis não pode ser nulo ou vazio.");

            if (CstPis.TryFromValue(valor, out var cstPisResultado))
            {
                return cstPisResultado;
            }

            throw new JsonException($"O código '{valor}' não é um CST PIS válido cadastrado no sistema.");
        }
    }
}
