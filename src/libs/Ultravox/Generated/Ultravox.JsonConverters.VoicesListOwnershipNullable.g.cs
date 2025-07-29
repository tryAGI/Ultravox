#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoicesListOwnershipNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.VoicesListOwnership?>
    {
        /// <inheritdoc />
        public override global::Ultravox.VoicesListOwnership? Read(
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
                        return global::Ultravox.VoicesListOwnershipExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.VoicesListOwnership)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.VoicesListOwnership?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.VoicesListOwnership? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.VoicesListOwnershipExtensions.ToValueString(value.Value));
            }
        }
    }
}
