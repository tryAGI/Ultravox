#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallMediumRestrictionAllowedMediumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.CallMediumRestrictionAllowedMedium?>
    {
        /// <inheritdoc />
        public override global::Ultravox.CallMediumRestrictionAllowedMedium? Read(
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
                        return global::Ultravox.CallMediumRestrictionAllowedMediumExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.CallMediumRestrictionAllowedMedium)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.CallMediumRestrictionAllowedMedium?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.CallMediumRestrictionAllowedMedium? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.CallMediumRestrictionAllowedMediumExtensions.ToValueString(value.Value));
            }
        }
    }
}
