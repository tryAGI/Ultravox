#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallsEventsListMinimumSeverityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.CallsEventsListMinimumSeverity?>
    {
        /// <inheritdoc />
        public override global::Ultravox.CallsEventsListMinimumSeverity? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Ultravox.CallsEventsListMinimumSeverityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.CallsEventsListMinimumSeverity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.CallsEventsListMinimumSeverity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.CallsEventsListMinimumSeverity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.CallsEventsListMinimumSeverityExtensions.ToValueString(value.Value));
            }
        }
    }
}
