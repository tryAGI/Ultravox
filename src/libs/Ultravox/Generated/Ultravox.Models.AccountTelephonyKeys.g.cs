
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountTelephonyKeys
    {
        /// <summary>
        /// The Telnyx API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public global::Ultravox.KeyPrefix? Telnyx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTelephonyKeys" /> class.
        /// </summary>
        /// <param name="telnyx">
        /// The Telnyx API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountTelephonyKeys(
            global::Ultravox.KeyPrefix? telnyx)
        {
            this.Telnyx = telnyx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTelephonyKeys" /> class.
        /// </summary>
        public AccountTelephonyKeys()
        {
        }
    }
}