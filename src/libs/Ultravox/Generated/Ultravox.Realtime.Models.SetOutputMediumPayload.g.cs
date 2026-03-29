
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Configure server output format.
    /// </summary>
    public sealed partial class SetOutputMediumPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.SetOutputMediumPayloadType Type { get; set; }

        /// <summary>
        /// Output medium: voice or text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadMediumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.Realtime.SetOutputMediumPayloadMedium Medium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetOutputMediumPayload" /> class.
        /// </summary>
        /// <param name="medium">
        /// Output medium: voice or text.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetOutputMediumPayload(
            global::Ultravox.Realtime.SetOutputMediumPayloadMedium medium,
            global::Ultravox.Realtime.SetOutputMediumPayloadType type)
        {
            this.Type = type;
            this.Medium = medium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetOutputMediumPayload" /> class.
        /// </summary>
        public SetOutputMediumPayload()
        {
        }
    }
}