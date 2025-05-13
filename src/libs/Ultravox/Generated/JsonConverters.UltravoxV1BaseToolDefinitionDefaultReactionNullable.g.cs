#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1BaseToolDefinitionDefaultReactionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction?>
    {
        /// <inheritdoc />
        public override global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Read(
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
                        return global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReactionExtensions.ToValueString(value.Value));
            }
        }
    }
}
