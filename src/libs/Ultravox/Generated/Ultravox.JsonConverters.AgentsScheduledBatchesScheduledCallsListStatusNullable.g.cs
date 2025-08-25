#nullable enable

namespace Ultravox.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsScheduledBatchesScheduledCallsListStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus?>
    {
        /// <inheritdoc />
        public override global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Read(
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
                        return global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
