#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1DataConnectionAudioConfigChannelModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode?>
    {
        /// <inheritdoc />
        public override global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Read(
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
                        return global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
