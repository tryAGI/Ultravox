
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioConfigOutput
    {
        /// <summary>
        /// Your Twilio Account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// The prefix of your Twilio Auth Token.
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
        /// Initializes a new instance of the <see cref="TwilioConfigOutput" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Your Twilio Account SID.
        /// </param>
        /// <param name="authTokenPrefix">
        /// The prefix of your Twilio Auth Token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioConfigOutput(
            string accountSid,
            global::Ultravox.KeyPrefix authTokenPrefix)
        {
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.AuthTokenPrefix = authTokenPrefix ?? throw new global::System.ArgumentNullException(nameof(authTokenPrefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioConfigOutput" /> class.
        /// </summary>
        public TwilioConfigOutput()
        {
        }
    }
}