#nullable enable

namespace Ultravox.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class SetOutputMediumPayloadTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.Realtime.SetOutputMediumPayloadType>
    {
        /// <inheritdoc />
        public override global::Ultravox.Realtime.SetOutputMediumPayloadType Read(
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
                        return global::Ultravox.Realtime.SetOutputMediumPayloadTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.Realtime.SetOutputMediumPayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.Realtime.SetOutputMediumPayloadType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.Realtime.SetOutputMediumPayloadType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Ultravox.Realtime.SetOutputMediumPayloadTypeExtensions.ToValueString(value));
        }
    }
}
