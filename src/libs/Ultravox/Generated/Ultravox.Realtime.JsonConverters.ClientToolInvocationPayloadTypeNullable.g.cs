#nullable enable

namespace Ultravox.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientToolInvocationPayloadTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.Realtime.ClientToolInvocationPayloadType?>
    {
        /// <inheritdoc />
        public override global::Ultravox.Realtime.ClientToolInvocationPayloadType? Read(
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
                        return global::Ultravox.Realtime.ClientToolInvocationPayloadTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.Realtime.ClientToolInvocationPayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.Realtime.ClientToolInvocationPayloadType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.Realtime.ClientToolInvocationPayloadType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.Realtime.ClientToolInvocationPayloadTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
