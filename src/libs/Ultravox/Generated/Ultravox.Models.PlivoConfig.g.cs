
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlivoConfig
    {
        /// <summary>
        /// Your Plivo Auth ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthId { get; set; }

        /// <summary>
        /// Your Plivo Auth Token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfig" /> class.
        /// </summary>
        /// <param name="authId">
        /// Your Plivo Auth ID.
        /// </param>
        /// <param name="authToken">
        /// Your Plivo Auth Token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlivoConfig(
            string authId,
            string authToken)
        {
            this.AuthId = authId ?? throw new global::System.ArgumentNullException(nameof(authId));
            this.AuthToken = authToken ?? throw new global::System.ArgumentNullException(nameof(authToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfig" /> class.
        /// </summary>
        public PlivoConfig()
        {
        }
    }
}