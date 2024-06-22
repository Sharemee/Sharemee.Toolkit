#if NET6_0_OR_GREATER

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sharemee.Toolkit;

/// <summary>
/// 
/// </summary>
public class DatetimeJsonConverter : JsonConverter<DateTime>
{
    /// <inheritdoc/>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            if (DateTime.TryParse(reader.GetString(), out DateTime dateTime)) return dateTime;
        }
        return reader.GetDateTime();
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}

#endif
