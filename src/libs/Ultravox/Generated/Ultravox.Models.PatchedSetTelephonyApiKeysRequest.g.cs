
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedSetTelephonyApiKeysRequest
    {
        /// <summary>
        /// Your Telnyx API key.<br/>
        /// https://portal.telnyx.com/#/api-keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public string? Telnyx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSetTelephonyApiKeysRequest" /> class.
        /// </summary>
        /// <param name="telnyx">
        /// Your Telnyx API key.<br/>
        /// https://portal.telnyx.com/#/api-keys
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedSetTelephonyApiKeysRequest(
            string? telnyx)
        {
            this.Telnyx = telnyx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSetTelephonyApiKeysRequest" /> class.
        /// </summary>
        public PatchedSetTelephonyApiKeysRequest()
        {
        }
    }
}