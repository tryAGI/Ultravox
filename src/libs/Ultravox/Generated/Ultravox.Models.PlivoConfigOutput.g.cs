
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlivoConfigOutput
    {
        /// <summary>
        /// Your Plivo Auth ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthId { get; set; }

        /// <summary>
        /// The prefix of your Plivo Auth Token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authTokenPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.KeyPrefix AuthTokenPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfigOutput" /> class.
        /// </summary>
        /// <param name="authId">
        /// Your Plivo Auth ID.
        /// </param>
        /// <param name="authTokenPrefix">
        /// The prefix of your Plivo Auth Token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlivoConfigOutput(
            string authId,
            global::Ultravox.KeyPrefix authTokenPrefix)
        {
            this.AuthId = authId ?? throw new global::System.ArgumentNullException(nameof(authId));
            this.AuthTokenPrefix = authTokenPrefix ?? throw new global::System.ArgumentNullException(nameof(authTokenPrefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfigOutput" /> class.
        /// </summary>
        public PlivoConfigOutput()
        {
        }
    }
}