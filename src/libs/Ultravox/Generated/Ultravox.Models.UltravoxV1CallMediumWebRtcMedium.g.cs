
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a WebRTC call.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumWebRtcMedium
    {
        /// <summary>
        /// Controls which data messages are enabled for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataMessages")]
        public global::Ultravox.UltravoxV1EnabledDataMessages? DataMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebRtcMedium" /> class.
        /// </summary>
        /// <param name="dataMessages">
        /// Controls which data messages are enabled for the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumWebRtcMedium(
            global::Ultravox.UltravoxV1EnabledDataMessages? dataMessages)
        {
            this.DataMessages = dataMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebRtcMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumWebRtcMedium()
        {
        }

    }
}