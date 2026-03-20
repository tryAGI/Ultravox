#nullable enable

namespace Ultravox.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaybackClearBufferPayloadTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.Realtime.PlaybackClearBufferPayloadType?>
    {
        /// <inheritdoc />
        public override global::Ultravox.Realtime.PlaybackClearBufferPayloadType? Read(
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
                        return global::Ultravox.Realtime.PlaybackClearBufferPayloadTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.Realtime.PlaybackClearBufferPayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.Realtime.PlaybackClearBufferPayloadType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.Realtime.PlaybackClearBufferPayloadType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.Realtime.PlaybackClearBufferPayloadTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
