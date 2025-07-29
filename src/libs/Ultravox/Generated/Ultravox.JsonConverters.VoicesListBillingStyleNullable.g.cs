#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoicesListBillingStyleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.VoicesListBillingStyle?>
    {
        /// <inheritdoc />
        public override global::Ultravox.VoicesListBillingStyle? Read(
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
                        return global::Ultravox.VoicesListBillingStyleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.VoicesListBillingStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.VoicesListBillingStyle?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.VoicesListBillingStyle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.VoicesListBillingStyleExtensions.ToValueString(value.Value));
            }
        }
    }
}
