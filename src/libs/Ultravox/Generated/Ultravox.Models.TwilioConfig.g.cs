
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioConfig
    {
        /// <summary>
        /// Your Twilio Account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// Your Twilio Auth Token.
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
        /// Initializes a new instance of the <see cref="TwilioConfig" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Your Twilio Account SID.
        /// </param>
        /// <param name="authToken">
        /// Your Twilio Auth Token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioConfig(
            string accountSid,
            string authToken)
        {
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.AuthToken = authToken ?? throw new global::System.ArgumentNullException(nameof(authToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioConfig" /> class.
        /// </summary>
        public TwilioConfig()
        {
        }
    }
}